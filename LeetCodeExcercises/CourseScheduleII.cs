namespace LeetCodeExcercises
{
    public static class CourseScheduleII
    {
        public static int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var adj = new bool[numCourses, numCourses];
            BuildGraph(adj, prerequisites);

            var visited = new int[numCourses];
            var result = new List<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (visited[i] == 0 && !DFS(adj, visited, i, numCourses, result)) return new int[] { };
            }

            result.Reverse();
            return result.ToArray();
        }

        private static bool DFS(bool[,] adj, int[] visited, int i, int numCourses, IList<int> result)
        {
            visited[i] = 1;
            for (int j = 0; j < numCourses; j++)
            {
                if (adj[i, j])
                {
                    if (visited[j] == 1) return false;
                    if (visited[j] == 0)
                        if (!DFS(adj, visited, j, numCourses, result)) return false;
                }
            }

            visited[i] = 2;
            result.Add(i);
            return true;
        }

        private static void BuildGraph(bool[,] adj, int[][] prerequisites)
        {
            foreach (var prerequisite in prerequisites)
            {
                adj[prerequisite[1], prerequisite[0]] = true;
            }
        }
    }
}
