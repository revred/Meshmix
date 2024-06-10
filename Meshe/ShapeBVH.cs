

namespace raMeshe;

internal class ShapeBVH : IShapeBVH
{
    public IShapeBVH.SplitStrategy Strategy => strategy_;
    AABB bounds_;
    ISubSpace? left_;
    ISubSpace? right_;
    public ISubSpace? Left => left_;

    public ISubSpace? Right => right_;

    public Point3d Centre => bounds_.Centre;

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
        bounds_ = new AABB();
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
