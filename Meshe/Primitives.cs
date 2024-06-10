using RealOne = float;
using RealTwo = double;
using Indexer = uint;
using R1Vec3 = System.Numerics.Vector3;

using System.Runtime.InteropServices;

namespace raMeshe;

[StructLayout(LayoutKind.Sequential)]
public struct R2Vec3
{
    public RealTwo x;
    public RealTwo y;
    public RealTwo z;
}

[StructLayout(LayoutKind.Sequential)]
public struct Intrix
{
    public Indexer a;
    public Indexer b;
    public Indexer c;
}

[StructLayout(LayoutKind.Sequential)]
public struct Vector3d
{
    public RealTwo i;
    public RealTwo j;
    public RealTwo k;
}

[StructLayout(LayoutKind.Sequential)]
public struct Point3d
{
    public RealTwo x;
    public RealTwo y;
    public RealTwo z;

    public Point3d()
    {
        x = y = z = 0.0d;
    }

    public Point3d(double xx, double yy, double zz)
    {
        x = xx;
        y = yy;
        z = zz;
    }

    public Point3d(R1Vec3 r3)
    {
        x = r3.X;
        y = r3.Y;
        z = r3.Z;
    }
}

[StructLayout(LayoutKind.Sequential)]
public struct Vector3f
{
    public RealOne i;
    public RealOne j;
    public RealOne k;
}

[StructLayout(LayoutKind.Sequential)]
public struct Point3f
{
    public RealOne x;
    public RealOne y;
    public RealOne z;
}

[StructLayout(LayoutKind.Sequential)]
public struct Ray3d
{
    public Point3d Origin;
    public Vector3d Direction;
}

[StructLayout(LayoutKind.Sequential)]
public struct Ray3f
{
    public Point3f Origin;
    public Vector3f Direction;
}
// represents the interface that
// represents tiangle count and vertex count
public interface ITriBuffer
{
    ulong Triangles => 0;
    ulong Vertices => 0;
}

// The raw Vertex Buffer VB[] and Index Buffer are 
// provided through the TriType 
public interface ITrisType<T, I> : ITriBuffer
{
    T[] VB { get; }
    I[] IB { get; }
}
// Triangles as Buffer Layour as Points and Triangles 
public struct TrisLayout : ITrisType<R1Vec3, Intrix>
{
    public R1Vec3[] VB { get; }
    public Intrix[] IB { get; }
}

// Triangles as Buffer Layour as floats and integers
public struct TrisBuffer : ITrisType<RealOne, Indexer>
{
    public RealOne[] VB { get; }
    public Indexer[] IB { get; }
}

// sequence of hits as a result of ray striking a shape
public struct HitList
{
    Point3d first_;
    List<RealTwo> offsets_ = [];

    public HitList()
    {
        first_ = new Point3d();        
    }
}

// first single hit as a result of ray striking a shape
public struct HitFirst
{
    Point3d first_;
    RealTwo offset_;

    public HitFirst()
    {
        first_ = new Point3d();
        offset_ = 0.0d;
    }

    public RealTwo Offset => offset_;
    public Point3d Hit => first_;
}

public interface ISubSpace
{
    Point3d Centre { get; }
    ISubSpace? Left { get; }
    ISubSpace? Right { get; }

    bool Intersect(Ray3d ray, out HitList? hits);
    bool Intersect(Ray3d ray, out HitFirst? hit);
}