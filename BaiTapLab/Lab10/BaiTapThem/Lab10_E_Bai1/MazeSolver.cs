using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai1
{
    public class MazeSolver
    {
        private int[,] grid;
        private bool[,] visited;
        private int M, N;

        public MazeSolver(int[,] grid)
        {
            this.grid = grid;
            M = grid.GetLength(0);
            N = grid.GetLength(1);
            visited = new bool[M, N];
        }

        // Kiểm tra xem có thể đi tới vị trí (x, y) hay không
        private bool IsValid(int x, int y)
        {
            return x >= 0 && x < M && y >= 0 && y < N && grid[x, y] == 1 && !visited[x, y];
        }

        // Tìm tất cả đường đi bằng Backtracking
        public void FindAllPaths(int startX, int startY, int endX, int endY, List<(int, int)> path)
        {
            if (startX == endX && startY == endY)
            {
                foreach (var p in path)
                {
                    Console.Write($"({p.Item1}, {p.Item2}) ");
                }
                Console.WriteLine();
                return;
            }

            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };
            visited[startX, startY] = true;
            path.Add((startX, startY));

            for (int direction = 0; direction < 4; direction++)
            {
                int nx = startX + dx[direction];
                int ny = startY + dy[direction];
                if (IsValid(nx, ny))
                {
                    FindAllPaths(nx, ny, endX, endY, path);
                }
            }

            path.RemoveAt(path.Count - 1);
            visited[startX, startY] = false;
        }

        // Tìm đường đi ngắn nhất bằng BFS
        public List<(int, int)> FindShortestPath(int startX, int startY, int endX, int endY)
        {
            var queue = new Queue<(int, int, List<(int, int)>)>();
            queue.Enqueue((startX, startY, new List<(int, int)>() { (startX, startY) }));
            visited[startX, startY] = true;

            while (queue.Count > 0)
            {
                var (x, y, path) = queue.Dequeue();
                if (x == endX && y == endY)
                    return path;

                int[] dx = { -1, 1, 0, 0 };
                int[] dy = { 0, 0, -1, 1 };

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];
                    if (IsValid(nx, ny))
                    {
                        visited[nx, ny] = true;
                        var newPath = new List<(int, int)>(path);
                        newPath.Add((nx, ny));
                        queue.Enqueue((nx, ny, newPath));
                    }
                }
            }

            return null;  // Không tìm thấy đường đi
        }
    }
}
