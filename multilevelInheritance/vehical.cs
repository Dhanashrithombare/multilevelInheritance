using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevelInheritance
{

    public class vehical
    {
        private string vehical_model;
        private int Reg_no;
        private int vehicle_speed;
        private int fuel_con;
        private int fuel_capacity;

        public string getVehical_model()
        { return vehical_model; }
        public void setVehicla_model(string vm)
        {
            vehical_model = vm;
        }
        public int getReg_no()
        { return Reg_no; }
        public void setReg_no(int rn)
        {
            Reg_no = rn;
        }
        public int getVehicla_speed()
        { return vehicle_speed; }
        public void setVehicle_speed(int vs)
        {
            vehicle_speed = vs;
        }
        // 2 set get for consum& capaciy
        public vehical()
        {

        }
        public vehical(string vm, int reg_no, int vs, int fcons,int fcap)
        {
            vehical_model = vm;
            Reg_no = reg_no;
            vehicle_speed = vs;
            fuel_con = fcons;
            fuel_capacity = fcap; // vehicle avg

        }
        public void setfuel_con(int fc)
        {
            fuel_con = fc;
        }
        public int getfuel_con()
        {
            return fuel_con;
        }
        public void setfuel_capacity(int fcap)
        {
            fuel_capacity = fcap;
        }
        public int getfuel_capacity()
        {
            return fuel_capacity;
        }


        public int fuel_needed(int distance)
        {
            int fn = 0;
            fn = distance / fuel_con;
            return fn;

        }
        public int Distance_Covered(int time)
        {
            int distance = 0;
            distance = vehicle_speed * time;
            return distance;
        }
       virtual public void display()
        {
            Console.WriteLine("Vehical model -> "+vehical_model);
            Console.WriteLine("reg no -> "+Reg_no);
            Console.WriteLine("vehicle speed -> "+vehicle_speed);
            Console.WriteLine("fuel consumption -> "+fuel_con);
            Console.WriteLine("Fuel Capacity -> "+fuel_capacity);

        }
    }


    public class bus : vehical
        {
        private int no_of_passenger;
        public void setno_of_passenger(int nop)
        {
            no_of_passenger = nop;
        }
        public int getno_of_passenger()
        {
            return no_of_passenger;
         }

        public bus(int nop, string vm, int reg_no, int vs, int fcons, int fcap):base(vm, reg_no, vs, fcons, fcap)
        {
                no_of_passenger=nop;
            
        }

        override public void display()
        {
            base.display();
            Console.WriteLine("Cargo wait limit -> :" +no_of_passenger );
        }

    }

        public class Truck : vehical
        {
        private int Cargo_wt_limit;
             public void setCargo_wt_limit(int cwl)
                {
                    Cargo_wt_limit = cwl;
                }
               public int getCargo_wt_limit()
               {
                  return Cargo_wt_limit;
                }
        public Truck(int cWlimit,string vm, int reg_no, int vs, int fcons, int fcap):base(vm,reg_no,vs,fcons,fcap)
        {
            Cargo_wt_limit = cWlimit;
        }
        override public void display()
        {
            base.display();
            Console.WriteLine("Cargo wait limit -> "+Cargo_wt_limit);
        }

    }
       
    
}
