using System;
using System.Collections.Generic;
using System.Text;

namespace ср.data_structures
{
   
        public class Graph
    {
        // Список суміжності: ключ - вершина, значення - список сусідів
        private Dictionary<int, List<int>> adjList;

        public Graph()
        {
            adjList = new Dictionary<int, List<int>>();
        }

        // Додати вершину
        public void AddVertex(int vertex)
        {
            if (!adjList.ContainsKey(vertex))
            {
                adjList[vertex] = new List<int>();
            }
        }

        // Додати ребро (для неорієнтованого графа)
        public void AddEdge(int source, int destination)
        {
            if (!adjList.ContainsKey(source)) AddVertex(source);
            if (!adjList.ContainsKey(destination)) AddVertex(destination);

            adjList[source].Add(destination);
            adjList[destination].Add(source);
        }

        // Отримати список сусідів вершини
        public List<int> GetNeighbors(int vertex)
        {
            return adjList.ContainsKey(vertex) ? adjList[vertex] : new List<int>();
        }

        // Обхід у ширину (BFS) - повертає список вершин у порядку відвідування
        public List<int> BFS(int startVertex)
        {
            var visited = new HashSet<int>();
            var queue = new Queue<int>();
            var result = new List<int>();

            if (!adjList.ContainsKey(startVertex)) return result;

            visited.Add(startVertex);
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                result.Add(vertex);

                foreach (int neighbor in adjList[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return result;
        }
    }  
}
