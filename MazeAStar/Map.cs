using System;
using System.Collections.Generic;
using System.Text;

namespace MazeAStar
{
    class Map
    {
        public Map()
        {
            MapBuilder map = new MapBuilder();
            MapRenderer mapRend = new MapRenderer(this);
        }

        public bool [][] GetMazePattern()
        {

        }
    }
}
