namespace Euler.Library.Graph
{
    public class Graph
    {
        public List<Vertex> Vertices = new List<Vertex>();
        
        public bool Contains(Vertex vertexToFind)
        {
            foreach (var vertext in Vertices)
            {
                if (vertext == vertexToFind) return true;
            }
            return false;
        }
        public bool Contains(Edge edgeToFind)
        {
            var currentVertext = Vertices.FirstOrDefault();
            foreach (var vertex in Vertices)
            {
                foreach (var edge in vertex.Edges)
                    if (edge == edgeToFind) return true;
            }
            return false;
        }
        protected bool ContainsEdgeBetween(Vertex vertex1, Vertex vertex2)
        {
            foreach (var edge in vertex1.Edges)
            {
                if (edge.GetOtherVertex(vertex1) == vertex2) return true;
            }
            return false;
        }
    }
}