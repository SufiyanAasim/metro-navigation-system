using System;
using System.Collections.Generic;
using System.Linq;

namespace Metro_App.Backend
{
    public sealed class RouteResult
    {
        public RouteResult(IReadOnlyList<string> stations, int distance)
        {
            Stations = stations;
            Distance = distance;
        }

        public IReadOnlyList<string> Stations { get; }
        public int Distance { get; }
        public string DisplayPath => string.Join(" -> ", Stations);
    }

    public static class MetroNetwork
    {
        private static readonly int[,] Graph =
        {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
            { 0, 0, 0, 2, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 6, 4, 0, 0, 0, 0, 3 },
            { 0, 2, 6, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 4, 0, 0, 2, 1, 2, 0, 0 },
            { 0, 0, 0, 1, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 1, 0, 0, 3 },
            { 2, 0, 3, 0, 0, 0, 0, 0, 3, 0 }
        };

        public static readonly string[] Stations =
        {
            "Millennium Mall",
            "Numaish",
            "FTC",
            "Frere Hall",
            "KPT Interchange",
            "Defence Morr",
            "Indus Hospital",
            "Shaan Chowrangi",
            "Singer Chowrangi",
            "Drigh Road"
        };

        public static RouteResult FindShortestRoute(int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex >= Stations.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < 0 || endIndex >= Stations.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            int stationCount = Stations.Length;
            int[] distances = Enumerable.Repeat(int.MaxValue, stationCount).ToArray();
            int[] previous = Enumerable.Repeat(-1, stationCount).ToArray();
            bool[] visited = new bool[stationCount];

            distances[startIndex] = 0;

            for (int count = 0; count < stationCount - 1; count++)
            {
                int current = GetNearestUnvisitedStation(distances, visited);
                if (current == -1)
                {
                    break;
                }

                visited[current] = true;

                for (int next = 0; next < stationCount; next++)
                {
                    int distance = Graph[current, next];
                    if (visited[next] || distance == 0 || distances[current] == int.MaxValue)
                    {
                        continue;
                    }

                    int candidate = distances[current] + distance;
                    if (candidate < distances[next])
                    {
                        distances[next] = candidate;
                        previous[next] = current;
                    }
                }
            }

            if (distances[endIndex] == int.MaxValue)
            {
                return null;
            }

            return new RouteResult(BuildPath(previous, startIndex, endIndex), distances[endIndex]);
        }

        private static int GetNearestUnvisitedStation(int[] distances, bool[] visited)
        {
            int minDistance = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < distances.Length; i++)
            {
                if (!visited[i] && distances[i] <= minDistance)
                {
                    minDistance = distances[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        private static IReadOnlyList<string> BuildPath(int[] previous, int startIndex, int endIndex)
        {
            var path = new List<string>();
            for (int current = endIndex; current != -1; current = previous[current])
            {
                path.Insert(0, Stations[current]);
                if (current == startIndex)
                {
                    break;
                }
            }

            return path;
        }
    }
}
