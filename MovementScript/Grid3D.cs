using System;
using System.Collections.Generic;
using System.Text;

namespace MovementScript
{
    class Grid3D
    {
        double minY = 0;
        double minX = 0;
        double minZ = 0;

        double maxY => minY + 1000;
        double maxX => minX + 1000;
        double maxZ => minZ + 1000;

        //If we had game objects this is where they'd go
        public List<GameComponent> Components { get; set; }

        public Player Player { get; set; }

        public Grid3D()
        {
            Components = new List<GameComponent>();
            Player = new Player(500, 500, 0);
        }

        public bool Update()
        {
            bool exit = false;
            char key = Console.ReadKey().KeyChar;
            Player.Move(key);

            if(key == (char)ConsoleKey.Escape)
            {
                exit = true;
            }

            return exit;
        }
    }
}
