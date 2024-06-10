

namespace raMeshe;

using System.Numerics;
using RealTwo = double;


// a spherical shape used as a bounding volume, other volumes are AABB and OriBB
public struct Sphere
{
    public RealTwo Radius;
    public Point3d Centre;
}

public struct OriBB
{
    public Point3d Center;
    public Vector3 Size;
    public Quaternion Rotation;
}

// Axis aligned bounding box
public struct AABB
{
    public Vector3 Min { get; set; }
    public Vector3 Max { get; set; }

    public AABB(Vector3 min, Vector3 max)
    {
        Min = min;
        Max = max;
    }

    public AABB()
    {
        Max = Min = new Vector3();
    }

    public Point3d Centre 
        => new ((Min.X + Max.X)*0.5d, (Min.Y + Max.Y) * 0.5, (Min.Z + Max.Z)*0.5d);

    public bool Intersects(AABB other)
    {
        return (Min.X <= other.Max.X && Max.X >= other.Min.X) &&
               (Min.Y <= other.Max.Y && Max.Y >= other.Min.Y) &&
               (Min.Z <= other.Max.Z && Max.Z >= other.Min.Z);
    }

    public bool Contains(Vector3 point)
    {
        return (point.X >= Min.X && point.X <= Max.X) &&
               (point.Y >= Min.Y && point.Y <= Max.Y) &&
               (point.Z >= Min.Z && point.Z <= Max.Z);
    }
}
