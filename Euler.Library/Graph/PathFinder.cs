namespace Euler.Library.Graph
{
    public class PathFinder 
    {
        public static Graph2D ShortestPath(Graph2D graph)
        {
            var result = new Graph2D();
            var processed = new Graph2D();
            var vertex1 = (Vertex2D)graph.Vertices.First();
            var v1 = new Vertex2D(new System.Drawing.Point(vertex1.Coordinates.X, vertex1.Coordinates.Y));

            while (result.Vertices.Count < graph.Vertices.Count-1)
            {
                processed.Vertices.Add(vertex1);
                result.Vertices.Add(v1);

                var shortestEdge = GetShortesEdgeFrom(vertex1, processed);

                var vertex2 = (Vertex2D)shortestEdge.GetOtherVertex(vertex1);
                var v2 = new Vertex2D(new System.Drawing.Point(vertex2.Coordinates.X, vertex2.Coordinates.Y));
                new Edge2D(new Tuple<Vertex, Vertex>(v1, v2));

                vertex1 = vertex2;
                v1 =v2;
            }
            return result;
        }

        private static Edge2D GetShortesEdgeFrom(Vertex vertex, Graph2D exclude)
        {
            int shortestIndex = -1;
            for (int i = 0; i < vertex.Edges.Count; i++)
            {
                var vertex2 = vertex.Edges[i].GetOtherVertex(vertex);
                if (exclude.Contains(vertex2)) continue;
                if (shortestIndex == -1) shortestIndex = i;
                else if (((Edge2D)vertex.Edges[i]).Length() < ((Edge2D)vertex.Edges[shortestIndex]).Length()) shortestIndex = i;
            }
            return (Edge2D)vertex.Edges[shortestIndex];
        }

        public static void RandomSwap(int v, Graph2D roadmap)
        {
        }
    }
}