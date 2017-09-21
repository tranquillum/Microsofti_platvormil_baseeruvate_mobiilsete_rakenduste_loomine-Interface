using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Bicycle : IMover
    {
        public void Move()
        {
           Console.WriteLine("Driving bicycle");
        }

        void IMover.Move()
        {
            throw new NotImplementedException();
        }

        void IMover.MoveToCity(string cityName)
        {
            throw new NotImplementedException();
        }
    }
}
