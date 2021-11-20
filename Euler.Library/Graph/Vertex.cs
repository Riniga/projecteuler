namespace Euler.Library.Graph
{
    public class Vertex
    {
        public static int LastId=0;
        public int Id = ++LastId;
        public List<Edge> Edges = new List<Edge>();
        internal void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }
        public Edge GetEdgeTo(Vertex vertex)
        {
            foreach (var edge in Edges)
            {
                if (edge.Vertices.Item1 == vertex || edge.Vertices.Item2 == vertex) return edge;
            }
            return null;
        }
    }
}