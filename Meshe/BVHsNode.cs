namespace raMeshe;
using Triangle = raMeshe.Intrix;

public class BVHsNode : ISubSpace
{
    public AABB Bounds => bounds_;

    AABB bounds_;

    public BVHsNode? Left => left_;
    BVHsNode? left_;
    public BVHsNode? Right => right_;
    BVHsNode? right_;

    public IList<Triangle>? Triangles => triangles_;
    IList<Triangle>? triangles_;

    public bool IsLeaf => Left == null && Right == null;

    public BVHsNode()
    {
        bounds_ = new AABB();
        triangles_ = null;
        left_ = null;
        right_ = null;
    }

    public bool Intersect(Ray3d ray)
    {
        // Implementation of intersection test with a ray
        throw new NotImplementedException();
    }
}