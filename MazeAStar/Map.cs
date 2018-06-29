using System;
using System.Collections.Generic;
using System.Text;

namespace MazeAStar
{
    class Map
    {
        bool[][] maze = MapBuilder.BuildMazePattern();
        int[] robotPos = MapBuilder.SpawnPoint();

        public Map()
        {
            MapRenderer.UpdateMap(this);
        }

        public int[] RobotPos { get => robotPos; private set => robotPos = value; }
        public bool[][] Maze { get => maze; private set => maze = value; }
    }
}
