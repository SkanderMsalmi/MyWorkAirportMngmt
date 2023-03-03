using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int id { get; set; }
        public DateTime birthDate { get; set; }
        public int passeportNumber { get; set; }
        public string emailAdress { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int telNumber { get; set; }

        public virtual ICollection<Flight> flights { get; set; }

        public override string? ToString()
        {
            return "Passenger : \n BirthDate : " + birthDate + "\n Passeport Number : " + passeportNumber + "\n Email : " + emailAdress + "\n First Name : " + firstName + "\n LastName" + lastName + "\n Phone : " + telNumber;
        }

        public bool checkProfile(string firstName, string lastName)
        {
            return this.firstName.Equals(firstName) && this.lastName.Equals(lastName);

        }
        public bool checkProfile(string firstName, string lastName, string email)
        {
            return this.firstName.Equals(firstName) && this.lastName.Equals(lastName) && this.emailAdress.Equals(email) ;

        }

        public virtual void passengerType()
        {
            Console.WriteLine("I'm a Passenger");
        }
    }
}
