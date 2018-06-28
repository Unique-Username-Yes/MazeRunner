using System;
using System.Collections.Generic;
using System.Text;

namespace MazeAStar
{
    class Map
    {
        bool[][] maze = MapBuilder.BuildMazePattern();

        public Map()
        {
            MapRenderer.UpdateMap(this);
        }



        public bool[][] Maze { get => maze; private set => maze = value; }
    }
}
