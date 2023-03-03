using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller :Passenger
    {
        public string healthInformation { get; set; }
        public string nationality { get; set; }
        public override string? ToString()
        {
            return "Travalleur : \n " + base.ToString() + "\nHealth : " + healthInformation + "\nNationality : " + nationality;
        }
        public override void passengerType()
        {
            Console.WriteLine( "i'm a traveler");
        }
    }
}
