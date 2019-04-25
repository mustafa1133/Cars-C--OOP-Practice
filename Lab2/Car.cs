using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Car
    {
        public int Year { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public bool IsDrivable { get; set; }

        public double Price { get; set; }



        public Car(int iyear, string iman, string imodel, bool idriveable, double iprice)
        {
            Year = iyear;
            Manufacturer = iman;
            Model = imodel;
            IsDrivable = idriveable;
            Price = iprice;
        }

        public string TellAboutSelf()
        {
        
          return $"Year: {Year}\n Manufacturer: {Manufacturer}\n Model: {Model}\n Price: {Price}\n Price: {Price}\n";


        }






    }
}
