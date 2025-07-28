//using System;
//using System.Collections.Generic;

//public class Dijkstra
//{
//    public static (int, List<string>) GetShortestPath(MetroGraph graph, string start, string end)
//    {
//        var distances = new Dictionary<string, int>();
//        var previous = new Dictionary<string, string>();
//        var priorityQueue = new SortedSet<(int distance, string station)>();

//        foreach (var node in graph.AdjacencyList.Keys)
//        {
//            distances[node] = int.MaxValue;
//            previous[node] = null;
//        }

//        distances[start] = 0;
//        priorityQueue.Add((0, start));

//        while (priorityQueue.Count > 0)
//        {
//            var (currentDistance, currentStation) = priorityQueue.Min;
//            priorityQueue.Remove(priorityQueue.Min);

//            if (currentStation == end)
//            {
//                var path = new List<string>();
//                for (var at = end; at != null; at = previous[at])
//                    path.Add(at);
//                path.Reverse();
//                return (currentDistance, path);
//            }

//            foreach (var (neighbor, weight) in graph.AdjacencyList[currentStation])
//            {
//                int newDistance = currentDistance + weight;
//                if (newDistance < distances[neighbor])
//                {
//                    priorityQueue.Remove((distances[neighbor], neighbor));
//                    distances[neighbor] = newDistance;
//                    previous[neighbor] = currentStation;
//                    priorityQueue.Add((newDistance, neighbor));
//                }
//            }
//        }

//        return (int.MaxValue, null); // No path found
//    }
//}
