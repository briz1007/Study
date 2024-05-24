using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //double celcius = 37;
            //double Fahrenheit = 98.6;
            //Console.WriteLine("Value of {0} celcius to Fahrenheit is {1}", celcius, Converter.ToFahrenheit(celcius));
            //Console.WriteLine("Value of {0} Fahrenheit to celcius is {1}", Fahrenheit, Converter.ToCelcius(Fahrenheit));
            //Console.ReadLine();
            //int a = 0;
            //a = 1/a;
            //Console.WriteLine("Enter a Value");
            //Console.ReadLine();
            ABC obj = new ABC();
            obj.Xyz();
            //obj.EFG();
            //Base:Constructor
            //ABC:Constructor
            //Print Drived: ABC:Xyz


            Base obj1 = new ABC();
            obj1.Xyz();
            //Base:Constructor
            //ABC:Constructor
            //Print Drived: ABC:Xyz

            Base obj2 = new Base();
            obj2.Xyz();
            //Base:Constructor
            //Print Base: Xyz
            


            Console.ReadLine();

        }
    }

    public class Base {
        //private int Privatea;

        //public string Publicb;
        //protected int Protectedc;
        public virtual void Xyz()
        {
            Console.WriteLine("Print Base: Xyz");
        }
        public void EFG()
        {
            Console.WriteLine("Print Base: EFG");
        }

        public Base()
        {
            Console.WriteLine("Base:Constructor");
        }
        
        
    }

    public class ABC : Base { 
        
        public override void Xyz()
        {
            Console.WriteLine("Print Drived: ABC:Xyz");
        }
        public ABC()
        {
            //call base constructor explicity
            //if base class constructor is parameterized
            Console.WriteLine("ABC:Constructor");
        }
    }
}
