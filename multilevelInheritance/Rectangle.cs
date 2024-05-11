using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace multilevelInheritance
{
    public class Rectangle
    {
        private int length;
        private int breath;
        public Rectangle()
        {
            length = 0;
            breath = 0;
            
        }

        public Rectangle(int l,int b)
        {
            length = l;
            breath = b;
        }
       
     }
    public class Area:Rectangle
    {
     public Area(int le,int br):base(le,br)
        {
            int area = le * br;
            Console.WriteLine("Area is --> "+area);

        }
    }
 

}
