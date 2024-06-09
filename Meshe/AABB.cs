using System.Numerics;

namespace raMeshe;

public class AABB
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