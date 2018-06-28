using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MazeAStar
{
    class MapRenderer
    {
        public static void UpdateMap(Map map)
        {
            var maze = map.Maze; 
            for(int y=0; y<maze.Length; y++)
            {
                for(int x = 0; x < maze[y].Length; x++)
                {
                    if (maze[y][x])// Red if stepped on
                    {
                        Console.ForegroundColor = ()
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
