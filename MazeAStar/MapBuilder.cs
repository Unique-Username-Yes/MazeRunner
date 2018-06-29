using System;
using System.Collections.Generic;
using System.Text;

namespace MazeAStar
{
    class MapBuilder
    {
        public static bool[][] BuildMazePattern()
        {
            
            return new[]
            {
                new[]{true,true,true,false,false},
                new[]{false,false,true,false,false},
                new[]{false,false,true,false,false},
                new[]{false,true,true,false,false},
                new[]{false,true,false,false,false}
            };
        }

        public static int[] SpawnPoint()
        {
            return new int[] { 0, 0 };
        }
    }
}
