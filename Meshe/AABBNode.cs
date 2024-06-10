using System.Numerics;

namespace raMeshe;

public class AABBNode : ISubSpace
{
    AABB space_;
    ISubSpace? left_;
    ISubSpace? right_;
    public ISubSpace? Left => left_;

    public ISubSpace? Right => right_;

    public Point3d Centre => space_.Centre;

    public AABBNode()
    {
        space_ = new AABB();
        left_ = right_ = null;
    }

    public bool Intersect(Ray3d ray, out HitList? hits)
    {
        // Implementation of intersection test with a ray
        throw new NotImplementedException();
    }

    public bool Intersect(Ray3d ray, out HitFirst? hit)
    {
        // Implementation of intersection test with a ray
        throw new NotImplementedException();
    }
}