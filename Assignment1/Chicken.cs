using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Chicken : Animal
    {
        public Chicken()
        {
            Voice = "Buk Buk!";
            X = 1;
            Y = 1;
            DX = 1;
            DY = 1;
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
            if (!(DX + dx > 3))
            {
                DX += dx;
            }
        }

        public void setDY(int dy)
        {
            if (!(DY + dy > 3))
            {
                DY += dy;
            }
        }

        public override string GetVoice()
        {
            return Voice;
        }
    }
}
