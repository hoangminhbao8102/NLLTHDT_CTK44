using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = {
                { 1, 0, 1, 1 },
                { 1, 1, 0, 1 },
                { 0, 1, 1, 1 },
                { 1, 1, 1, 0 }
            };
            var solver = new MazeSolver(grid);
            var allPaths = new List<(int, int)>();
            solver.FindAllPaths(0, 0, 2, 2, allPaths);

            var shortestPath = solver.FindShortestPath(0, 0, 2, 2);
            Console.WriteLine("Shortest path:");
            if (shortestPath != null)
            {
                foreach (var p in shortestPath)
                {
                    Console.Write($"({p.Item1}, {p.Item2}) ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
