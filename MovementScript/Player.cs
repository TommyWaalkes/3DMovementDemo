using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MovementScript
{
    public class Player : GameComponent
    {
        bool Jumping = false;
        int jumpTimer = 0;
        int jumpMax = 100;
        double jumpSpeed = 5; 
        public Player(double X, double Y, double Z) : base(X, Y, Z)
        {
        }

        public void Move(char key)
        {
            //I'm kinda going for tank style controls 
            //Left and right will rotate the character
            if (key == 'a')
            {
                XRot--; 
            }

            if(key == 'd')
            {
                XRot++;
            }

            if(key == 'w')
            {
                moveForward(XRot);
            }
                
            if(key == 's')
            {
                moveForward(XRot);
            }

            if(key == ' ' && Jumping == false)
            {
                Jumping = true;
            }

            if (Jumping)
            {
                Z += jumpSpeed;
                jumpTimer++;

                //check if it's time to start falling 
                if(jumpTimer >= jumpMax)
                {
                    Jumping = false;
                }
            }
            else if(Z > 0)
            {
                //Falling to the ground
                //Would also check for collisions here as well
                //But all there is right now is floor at Z = 0
                Z--;
            }
        }

        //These 2 methods move us along an angle
       public void moveForward(double angle)
        {
            X += Speed * Math.Sin(angle);
            Y += Speed * Math.Cos(angle);
        }

        public void moveBackward(double angle)
        {
            X -= Speed * Math.Sin(angle);
            Y -= Speed * Math.Cos(angle);
        }
    }
}
