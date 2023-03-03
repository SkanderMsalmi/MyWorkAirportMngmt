using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {

        public DateTime employementDate { get; set; }
        public string function { get; set; }
        public double salary { get; set; }

        public override string? ToString()
        {
            return "Staff : \n" + base.ToString() + "\n Employement Date :  " + employementDate + "\n Function : " + function + "\n Salary : " + salary;
        }

        public override void passengerType()
        {
            Console.WriteLine( "I'm a staff member");
        }

    }
}
