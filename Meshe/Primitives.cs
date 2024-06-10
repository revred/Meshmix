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
    public Indexer this[int index]
    {
        get
        {
            index %= 3;
            return index == 0 ? a : index == 1 ? b : c;
        }
        set
        {
            index %= 3;
            if (index == 0) a = value;
            else if (index == 1) b = value;
            else c = value;
        }
    }
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
    int Triangles => 0;
    int Vertices => 0;
}

// The raw Vertex Buffer VB[] and Index Buffer are 
// provided through the TriType 
public interface ITrisType<T, I> : ITriBuffer
{
    IList<T> VB { get; }
    IList<I> IB { get; }
}
// Triangles as Buffer Layour as Points and Triangles 
public struct TrisLayout : ITrisType<R1Vec3, Intrix>
{
    public IList<R1Vec3> VB { get; }
    public IList<Intrix> IB { get; }

    public int Triangles => IB.Count;
    public int Vertices => VB.Count;
}

// Triangles as Buffer Layour as floats and integers
public struct TrisBuffer : ITrisType<RealOne, Indexer>
{
    public IList<RealOne> VB { get; }
    public IList<Indexer> IB { get; }
    public int Triangles => (IB.Count / 3);
    public int Vertices => (VB.Count / 3) ;
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