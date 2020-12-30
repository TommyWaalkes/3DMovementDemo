using System;
using System.Collections.Generic;
using System.Text;

namespace MovementScript
{
    public class GameComponent
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        protected double Speed { get; set; } =0;
        protected double XRot = 0;
        protected double YRot = 0;
        //No Z rot since we'll assume our character is always flat footed


        public GameComponent(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
}
