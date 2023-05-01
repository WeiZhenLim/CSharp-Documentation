using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Box
    {
        // member variable
        private int length = 3;
        private int height;
        public int volume;

        public int Width { get; set; }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                height = value;
            }
        }

        public void SetLengt(int length)
        {
            this.length = length;
        }

        public int GetLength() 
        { 
            return this.length; 
        }

        public int GetVolume()
        {
            return this.length*this.Width*this.height;
        }

        public void DisplayInfo()
        {
            volume = length * height * Width;
            Console.WriteLine($"Length is {length} and height is {height} and width is {Width} so" +
                $" the volume is {volume}");
        }


    }
}
