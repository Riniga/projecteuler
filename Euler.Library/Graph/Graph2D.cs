using System.Drawing;

namespace Euler.Library.Graph
{
    public class Graph2D : Graph
    {
        public Graph2D() { }
        public Graph2D(int count, int width, int height)
        {
            CreateVertices(count, width, height);
            CreateEdgesBetweenAllVertecis();
        }
        public override string ToString()
        {
            var result = string.Empty;
            var drawn = new List<Edge>();
            foreach(var vertex in Vertices)
            {
                foreach (Edge2D edge in vertex.Edges)
                    if (edge.Vertices.Item1 == vertex)
                    {
                        if (!drawn.Contains(edge))
                        {
                            var vertex1 = (Vertex2D)edge.Vertices.Item1;
                            var vertex2 = (Vertex2D)edge.Vertices.Item2;
                            result += ($"{vertex1.ToString()} - {vertex2.ToString() } = {edge.Length()} \r\n");
                            drawn.Add(edge);
                        }
                    }
            }
            return result;
        }

        private List<Edge2D> GetEdges()
        {
            var currentVertex = Vertices.First();
            var result = new List<Edge2D> { (Edge2D)currentVertex.Edges.First() };
            var lastEdge = result.Last();

            while (lastEdge!=null)
            {
                currentVertex = lastEdge.GetOtherVertex(currentVertex);
                lastEdge = null;
                foreach (Edge2D edge in currentVertex.Edges)
                {
                    if (result.Contains(edge)) continue;
                    lastEdge = edge;
                    result.Add(lastEdge);
                }
            }
            return result;
        }
        public int Length()
        {
            int length = 0;
            var edges = GetEdges();
            foreach (var edge in edges)
            {
                length += edge.Length();
            }
            
            return length;
        }
        private void CreateVertices(int count, int width, int height)
        {
            for (int i = 0; i < count; i++)
                Vertices.Add(new Vertex2D(new Point(Helpers.Randomizer.Next(width), Helpers.Randomizer.Next(height))));
        }
        private void CreateEdgesBetweenAllVertecis()
        {
            foreach (var vertex1 in Vertices)
            {
                foreach (var vertex2 in Vertices)
                {
                    if (vertex1 != vertex2)
                    {
                        if (!ContainsEdgeBetween(vertex1, vertex2))
                            new Edge2D(new Tuple<Vertex, Vertex>(vertex1, vertex2));
                    }
                }
            }
        }
    }
    public class Vertex2D : Vertex
    {
        public Point Coordinates { get; set; }
        public override string ToString() => $"{Coordinates.X}x{Coordinates.Y}";
        public Vertex2D(Point coordinates ) { Coordinates = coordinates;  }
    }
    public class Edge2D : Edge
    {
        public Edge2D(Tuple<Vertex, Vertex> vertices) : base(vertices){}
        public int Length()
        {
            int ΔX = ((Vertex2D)Vertices.Item1).Coordinates.X - ((Vertex2D)Vertices.Item2).Coordinates.X;
            int ΔY = ((Vertex2D)Vertices.Item1).Coordinates.Y - ((Vertex2D)Vertices.Item2).Coordinates.Y;
            return (int)Math.Sqrt(ΔX * ΔX + ΔY * ΔY);
        }
    }
}