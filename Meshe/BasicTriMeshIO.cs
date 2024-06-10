using System.Numerics;

namespace raMeshe;
public class STLReader
{
    public TrisLayout tris_ = new TrisLayout();

    public void LoadSTL(string filePath)
    {
        using (var reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            reader.BaseStream.Seek(80, SeekOrigin.Begin); // Skip header
            uint triangleCount = reader.ReadUInt32();

            var vertexDict = new Dictionary<Vector3, int>(new Vector3Comparer());

            for (uint i = 0; i < triangleCount; i++)
            {
                reader.BaseStream.Seek(12, SeekOrigin.Current); // Skip normal
                Intrix itx = new Intrix();
                for (int j = 0; j < 3; j++)
                {
                    var vertex = new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
                    if (!vertexDict.TryGetValue(vertex, out int index))
                    {
                        index = tris_.Vertices;
                        tris_.VB.Add(vertex);
                        vertexDict[vertex] = index;
                    }
                    itx[j] = (uint)index;
                }
                tris_.IB.Add(itx);
                reader.BaseStream.Seek(2, SeekOrigin.Current); // Skip attribute byte count
            }
        }
    }

    private class Vector3Comparer : IEqualityComparer<Vector3>
    {
        public bool Equals(Vector3 v1, Vector3 v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
        }

        public int GetHashCode(Vector3 v)
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + v.X.GetHashCode();
                hash = hash * 23 + v.Y.GetHashCode();
                hash = hash * 23 + v.Z.GetHashCode();
                return hash;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        STLReader converter = new STLReader();
        converter.LoadSTL("path_to_your_stl_file.stl");

        Console.WriteLine("Vertices:");
        foreach (var vertex in converter.tris_.VB)
        {
            Console.WriteLine($"{vertex.X}, {vertex.Y}, {vertex.Z}");
        }

        Console.WriteLine("Indices:");
        foreach (var itx in converter.tris_.IB)
        {
            Console.WriteLine($"{itx.a}, {itx.b}, {itx.c}");
        }
    }
}
