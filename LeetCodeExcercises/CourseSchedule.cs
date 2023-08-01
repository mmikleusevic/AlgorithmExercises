namespace LeetCodeExcercises
{
    public static class CourseSchedule
    {
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var adj = new bool[numCourses, numCourses];
            BuildGraph(adj, prerequisites);

            var visited = new int[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                if (visited[i] == 0 && !DFS(adj, visited, i, numCourses)) return false;
            }
            return true;
        }

        private static bool DFS(bool[,] adj, int[] visited, int i, int numCourses)
        {
            visited[i] = 1;
            for (int j = 0; j < numCourses; j++)
            {
                if (adj[i, j])
                {
                    if (visited[j] == 1) return false;
                    if (visited[j] == 0)
                    {
                        if (!DFS(adj, visited, j, numCourses)) return false;
                    }
                }
            }

            visited[i] = 2;
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
