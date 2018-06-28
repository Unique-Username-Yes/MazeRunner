using System;
using System.Collections.Generic;
using System.Text;

namespace MazeAStar
{
    class MapBuilder
    {

        public MapBuilder()
        {
            
        }

        private bool[][] mazePattern()
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
    }
}
