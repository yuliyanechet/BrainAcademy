using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Vector
    {
        public int CoordinateX;
        public int CoordinateY;

        public Vector()
        {
        }

        public Vector(int x, int y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }

        public static Vector operator +(Vector first, Vector second)
        {
            Vector result = new Vector();
            result.CoordinateX = first.CoordinateX + second.CoordinateX;
            result.CoordinateY = first.CoordinateY + second.CoordinateY;
            return result;
        }

        public static Vector operator -(Vector first, Vector second)
        {
            Vector result = new Vector();
            result.CoordinateX = first.CoordinateX - second.CoordinateX;
            result.CoordinateY = first.CoordinateY - second.CoordinateY;
            return result;
        }


        public static int operator *(Vector first, Vector second)

        {
            int result = first.CoordinateX * second.CoordinateX + first.CoordinateY * second.CoordinateY;
            return result;
        }

        public static int operator *(Vector first, int number)
        {
            int result = first.CoordinateX * number + first.CoordinateY * number;
            return result;
        }


    }
}



