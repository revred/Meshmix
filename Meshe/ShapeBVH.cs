

namespace raMeshe;

internal class ShapeBVH : IShapeBVH
{
    public IShapeBVH.SplitStrategy Strategy => strategy_;
    
    public Stream Serialize(MakerSpec? options = null)
    {
        throw new NotImplementedException();
    }

    ITriMesh shape_;
    IShapeBVH.SplitStrategy strategy_;

    public ShapeBVH(ITriMesh mesh, IShapeBVH.SplitStrategy ss)
    {
        shape_ = mesh;
        strategy_ = IShapeBVH.SplitStrategy.atAverage;
    }

    public Task RebuildAsync()
    {
        // Implement the BVH construction considering the changes in shape_
        throw new NotImplementedException ();
    }

    public Task TraverseAsync(Ray3d hitter)
    {
        // Implementation of the intersection test with hitter on shape_
        throw new NotImplementedException();
    }

}
