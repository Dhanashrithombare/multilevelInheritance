using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevelInheritance
{
    public class AA
    {
        public AA() 
        {
            Console.WriteLine("Its Default Consructor AA");
        }
        public AA(int a)
        {
            Console.WriteLine("This is Paramaterize Constructer AA"+a);
        }
    }
    public class BB:AA
    {
        public BB() 
        {
            Console.WriteLine("This is Parametrize constructor BB");
        }
        public BB(int a):base(a)
        {
            Console.WriteLine("This is Parameterize constructor BB"+a);
        }
    }
    public class CC:BB 
    {
        public CC()
        {
            Console.WriteLine("This is Parametrize constructor CC");
        }
        public CC(int a):base(a)
        {
            Console.WriteLine("This is Parameterize constructor CC"+a);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //    AA a= new AA();
            //    BB b= new BB(100);
            //    CC c = new CC();
            //  CC c1= new CC(100);
            Truck tr1 = new Truck(100,"TATA",1234,80,5,30);
            tr1.display();
            int fn = tr1.fuel_needed(100);
            Console.WriteLine("fuel need for 100 km"+fn);
            int TotalDist = tr1.Distance_Covered(5);
            Console.WriteLine("Distance covered in 5 Hr"+TotalDist);
            Console.WriteLine("-----------------------------------------------");
            bus b = new bus(10, "Thar", 1123, 12, 34, 56);
            b.display();

            Console.ReadKey();
        }
        
    }
}
