using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Plane : IMover
    {
        public void MoveToCity(string cityName)
        {
            throw new NotImplementedException();
        }

        void IMover.Move()
        {
            Console.WriteLine("Driving plane");
        }
    }
}
