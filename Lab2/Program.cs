using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car(1993,"Japan" ,"honda", true, 1700);
            Car c2 = new Car(1994, "Canada" ,"Ford", false, 1800);
            Car c3 = new Car(1995, "USA" ,"GMC", true, 1900);
            Car c4 = new Car(1996, "Germany" ,"Jetta", false, 2700);
            Car c5 = new Car(1997, "Italy" ,"Porche", true, 3700);

            Console.WriteLine( c1.TellAboutSelf());
            Console.WriteLine(c2.TellAboutSelf());
            Console.WriteLine(c3.TellAboutSelf());
            Console.WriteLine(c4.TellAboutSelf());
            Console.WriteLine(c5.TellAboutSelf());

        }
    }
}
