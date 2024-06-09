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

public interface ITriBuffer
{
    ulong Triangles => 0;
    ulong Vertices => 0;
}

public interface ITypeBuffer<T, I> : ITriBuffer
{
    T[] VB { get; }
    I[] IB { get; }
}

public struct BufferLogical : ITypeBuffer<R1Vec3, Intrix>
{
    public R1Vec3[] VB { get; }
    public Intrix[] IB { get; }
}
public struct BufferLayout : ITypeBuffer<RealOne, Indexer>
{
    public RealOne[] VB { get; }
    public Indexer[] IB { get; }
}

