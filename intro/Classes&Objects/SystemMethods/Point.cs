using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMethods
{
    //This class inherits from systemMethods. 
    class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //method to covert to string
        public override string ToString()//inherited from system.object. 
        {
            return $"({x}, {y})";
        }

        //method to compare object types: inherited from object class. 
        public override bool Equals(object obj)
        {
            return x == ((Point)obj).x && y ==((Point)obj).y;
            
        }


        //Method to make a copy
        public Point Copy()
        {
            return (Point)this.MemberwiseClone();
        }
    }
}
