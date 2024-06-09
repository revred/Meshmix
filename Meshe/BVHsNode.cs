namespace raMeshe;
using Triangle = raMeshe.Intrix;

public class SplitNode : ISubSpace
{
    public AABB Bounds => bounds_;

    AABB bounds_;

    public ISubSpace? Left => left_;
    ISubSpace? left_;
    public ISubSpace? Right => right_;
    ISubSpace? right_;

    public IList<Triangle>? Triangles => triangles_;
    IList<Triangle>? triangles_;

    public bool IsLeaf => Left == null && Right == null;

    public SplitNode()
    {
        bounds_ = new AABB();
        triangles_ = null;
        left_ = null;
        right_ = null;
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