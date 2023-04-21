using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Parallelepiped
    { 
        public static int Volume(int width, int length)
        {
            return width * length;
        }

        public static int Volume(int width, int length, int height)
        {
            return Volume(width, length) * height;
        }
    }
}
