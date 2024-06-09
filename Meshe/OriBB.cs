using System.Numerics;

namespace raMeshe;

public struct OriBB
{
    public Vector3 Center;
    public Vector3 Size;
    public Quaternion Rotation;
}

public class OriBBNode : ISubSpace
{
    OriBB space_;

    public static OriBB CreateFrom(IList<Vector3> vertices)
    {
        // Implementation to define OBB
        throw new NotImplementedException();
    }

    
    ISubSpace? left_;
    ISubSpace? right_;

    public ISubSpace? Left => left_;

    public ISubSpace? Right => right_;

    public void SplitSpace()
    {
        // Implementation of splitting the OriBB geometric space
        throw new NotImplementedException();
    }

    public OriBBNode()
    {
        left_ = right_ = null;
    }

    // Methods for intersection tests
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
