using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Dog : Animal
    {
        public Dog() {
            Voice = "Bark!";
            X = 2;
            Y = 2;
            DX = 2;
            DY = 2;
        }

        public override string Move(string direction)
        {
            if (direction.Equals("up")) {
                X += DX;
                Y += DY;
            }
            else if (direction.Equals("down")) {
                X -= DX;
                Y -= DY;
            }

            return "X is: " + X + ". And " + Y + " is.";
        }

        public void setDX(int dx)
        {
            if (!(DX + dx > 4)) {
                DX += dx;
            }
        }

        public void setDY(int dy)
        {
            if (!(DY + dy > 4)) {
                DY += dy;
            }
        }

        public override string GetVoice()
        {
            return Voice;
        }
    }
}
