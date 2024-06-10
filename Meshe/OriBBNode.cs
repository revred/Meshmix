using System.Numerics;

namespace raMeshe;



public class OriBBNode : ISubSpace
{
    OriBB space_;

    public static OriBBNode CreateFrom(IList<Vector3> vertices)
    {
        // Implementation to define OBB
        throw new NotImplementedException();
    }

    public Point3d Centre => space_.Center;
    
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
        space_ = new OriBB();
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
