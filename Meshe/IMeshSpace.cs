

namespace raMeshe;

public record MakerSpec(string Options);

public interface IShapeBVH
{
    Stream Serialize(MakerSpec? options = null);
    enum SplitStrategy { atCentre = 0, atAverage = 1, atSAH = 2 };
    SplitStrategy Strategy { get; }
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
