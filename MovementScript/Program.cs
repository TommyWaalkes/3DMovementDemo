using System;

namespace MovementScript
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid3D Game = new Grid3D();

            bool exit = false;
            while (exit != true)
            {
                exit = Game.Update();
            }
        }
    }
}
