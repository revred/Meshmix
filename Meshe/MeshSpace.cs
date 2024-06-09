

namespace raMeshe;

// Implementation of the Factory class to create ITriMesh and IShapeBVH from stream or file path
// has default options for the creation in case options are not passed
// Based on options, a managed or unmanaged mesh is created for consumption
// the ITriMesh is derived from IDisposable mainly to deallocate unmanaged resources
internal class MeshSpace : IMeshSpace
{

    public ITriMesh Deserialize(string filePath, MakerSpec? options = null)
    {
        throw new NotImplementedException();
    }

    public ITriMesh Create(ITriBuffer tb, MakerSpec? options = null)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public ITriMesh DeserializeTris(Stream triStream, MakerSpec? options = null)
    {
        throw new NotImplementedException();
    }

    public IShapeBVH DeserializeBVHs(Stream triStream, MakerSpec? options = null)
    {
        throw new NotImplementedException();
    }

    enum DefaultSpec { desTris = 0, desBVHs = 1, create = 2, desTrisFile = 3}
    static MakerSpec?[] specs_ = [null, null, null, null];
}