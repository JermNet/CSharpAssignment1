using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Animal
    {
        private int x;
        private int y;
        private int dx;
        private int dy;
        private string voice;

        public int X
        {
            get
            {
                return x;
            }

            set 
            { 
                x = value;
            }
        }

        public int Y
        {
            get
            { 
                return y;
            }

            set
            { 
                y = value;
            }
        }

        public int DX
        {
            get
            {
                return dx;
            }

            set
            { 
                dx = value;
            }
        }

        public int DY
        {
            get
            {
                return dy;
            }

            set
            {
                dy = value;
            }
        }

        public string Voice
        {
            get
            {
                return voice;
            }

            set
            {
                voice = value;
            }
        }

        abstract public string Move(string direction);
        abstract public string GetVoice();
    }
}
