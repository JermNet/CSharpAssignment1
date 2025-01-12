using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class SuperDog : Animal
    {
        public SuperDog()
        {
            Voice = "I'm Krypto!";
            X = 10;
            Y = 10;
            DX = 10;
            DY = 10;
        }

        public override string Move(string direction)
        {
            if (direction.Equals("up"))
            {
                X += DX;
                Y += DY;
            }
            else if (direction.Equals("down"))
            {
                X -= DX;
                Y -= DY;
            }

            return "X is: " + X + ". And " + Y + " is.";
        }

        public void setDX(int dx)
        {
            DX += dx;
        }

        public void setDY(int dy)
        {
            DX += dy;
        }

        public override string GetVoice()
        {
            return Voice;
        }
    }
}
