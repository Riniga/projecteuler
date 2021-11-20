namespace Euler.Library.Graph
{
    public class Edge
    {
        public int Value;
        public Tuple<Vertex, Vertex> Vertices;
        public Edge(Tuple<Vertex, Vertex> vertices)
        {
            Vertices = vertices;
            vertices.Item1.AddEdge(this);
            vertices.Item2.AddEdge(this);
        }
        public Vertex GetOtherVertex(Vertex vertex1)
        {
            return (Vertices.Item1 != vertex1) ? Vertices.Item1 : Vertices.Item2;

        }
    }
}