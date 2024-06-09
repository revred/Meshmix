

namespace raMeshe;

internal class ShapeBVH : IShapeBVH
{
    public IShapeBVH.SplitStrategy Strategy => strategy_;
    IShapeBVH.SplitStrategy strategy_;
    public Stream Serialize(MakerSpec? options = null)
    {
        throw new NotImplementedException();
    }
}
