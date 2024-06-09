

namespace raMeshe;

internal class ShapeBVH : IShapeBVH
{
    public IShapeBVH.SplitStrategy Strategy => strategy_;

    ISubSpace? left_;
    ISubSpace? right_;
    public ISubSpace? Left => left_;

    public ISubSpace? Right => right_;

    public Stream Serialize(MakerSpec? options = null)
    {
        throw new NotImplementedException();
    }

    ITriMesh shape_;
    IShapeBVH.SplitStrategy strategy_;

    public ShapeBVH(ITriMesh mesh, IShapeBVH.SplitStrategy ss)
    {
        left_ = right_ = null;
        shape_ = mesh;
        strategy_ = IShapeBVH.SplitStrategy.atAverage;
    }

    public Task RebuildAsync()
    {
        // Implement the BVH construction considering the changes in shape_
        throw new NotImplementedException ();
    }

    public bool Intersect(Ray3d hitter, out HitList? hits)
    {
        // Implementation of the intersection test with hitter on shape_
        throw new NotImplementedException();
    }

    public bool Intersect(Ray3d ray, out HitFirst? hit)
    {
        throw new NotImplementedException();
    }
}
