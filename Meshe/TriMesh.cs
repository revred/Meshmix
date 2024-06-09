

namespace raMeshe;

// Managed TriMesh Implementation
internal class TriMesh : ITriMesh
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public IShapeBVH Rebuild()
    {
        return bvh_ = new ShapeBVH(this, IShapeBVH.SplitStrategy.asSAH);
    }

    public Stream Serialize(object? options = null)
    {
        throw new NotImplementedException();
    }
    public bool Intersect(Ray3d ray, out HitList? hits)
    {
        if (bvh_ is null) Rebuild();
        // Implementation of intersection test with a ray
        throw new NotImplementedException();
    }

    IShapeBVH? bvh_;

    public bool Intersect(Ray3d ray, out HitFirst? hit)
    {
        if (bvh_ is null) Rebuild();
        // Implementation of intersection test with a ray
        throw new NotImplementedException();
    }
}
