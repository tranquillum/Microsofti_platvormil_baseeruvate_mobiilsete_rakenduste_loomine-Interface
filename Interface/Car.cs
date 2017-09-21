using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Car : IMover
    {
        public void Move()
        {
            Console.WriteLine("Driving car");
        }

        public void MoveToCity(string cityName)
        {
            SitInCar();
        }

        private void SitInCar()
        {
            throw new NotImplementedException();
        }
    }
}
