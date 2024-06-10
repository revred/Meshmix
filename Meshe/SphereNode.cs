

namespace raMeshe;


class SphereNode : ISubSpace
{
    Sphere space_;

    ISubSpace? left_;
    ISubSpace? right_;

    public ISubSpace? Left => left_;
    public ISubSpace? Right => right_;

    public Point3d Centre => space_.Centre;

    public SphereNode()
    {
        space_ = new Sphere();
        left_ = right_ = null;
    }

    public bool Intersect(Ray3d ray, out HitList? hits)
    {
        throw new NotImplementedException();
    }

    public bool Intersect(Ray3d ray, out HitFirst? hit)
    {
        throw new NotImplementedException();
    }
}
