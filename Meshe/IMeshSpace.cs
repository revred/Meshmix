

namespace raMeshe;

public record MakerSpec(string Options);

public interface IShapeBVH
{
    Stream Serialize(MakerSpec? options = null);
    // SplitStrategy.atSAH = Surface Area Hueristics
    enum SplitStrategy { atCentre = 0, atAverage = 1, asSAH = 2 };  
    SplitStrategy Strategy { get; }

    Task RebuildAsync();
    Task TraverseAsync(Ray3d hitter);
}

public interface ITriMesh : IDisposable
{
    Stream Serialize(object? options = null);
    IShapeBVH Rebuild(); 

}

public interface IMeshSpace : IDisposable
{
    private static IMeshSpace mspace_ = new MeshSpace();
    public static IMeshSpace Spacer => mspace_;

    ITriMesh Deserialize(string filePath, MakerSpec? options = null);
    ITriMesh DeserializeTris(Stream triStream, MakerSpec? options = null);
    IShapeBVH DeserializeBVHs(Stream triStream, MakerSpec? options = null);
    ITriMesh Create(ITriBuffer tb, MakerSpec? options = null);
}
