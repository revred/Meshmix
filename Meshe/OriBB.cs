using System.Numerics;

namespace raMeshe;

public class OriBB : ISubSpace
{
    public Vector3 Center;
    public Vector3 Size;
    public Quaternion Rotation;

    public static OriBB CreateFrom(IList<Vector3> vertices)
    {
        // Implementation to define OBB
        throw new NotImplementedException();
    }

    public bool Intersect(Ray3d ray)
    {
        // Implementation of intersection test with a ray
        throw new NotImplementedException();
    }

    // Methods for intersection tests
}
