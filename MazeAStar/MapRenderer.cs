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
                    if (x == map.RobotPos[0] && y == map.RobotPos[1])
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("+ ");
                    }
                    // TODO: Implement visual representation of stepped on tiles
                    else if (maze[y][x])
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Green;
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
