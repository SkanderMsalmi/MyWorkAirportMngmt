using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
   public static class TestData
    {
       public static Plane BoingPlane = new Plane { planeType = PlanType.Boing, capacity = 150, manufactureDate = new DateTime(2015, 02, 03) };
        public static Plane Airbusplane = new Plane { planeType = PlanType.Airbus, capacity = 250, manufactureDate = new DateTime(2020, 11, 11) };
        // Staffs
        public static Staff captain = new Staff { passeportNumber=1, firstName = "captain", lastName = "captain", emailAdress = "captain.captain@gmail.com", birthDate = new DateTime(1965, 01, 01), employementDate =   new DateTime(1999, 01, 01), salary = 99999 };
        public static Staff hostess1 = new Staff { passeportNumber = 2, firstName = "hostess1", lastName = "hostess1", emailAdress = "hostess1.hostess1@gmail.com", birthDate = new DateTime(1995, 01, 01), employementDate =   new DateTime(2020, 01, 01), salary = 999 };
        public static Staff hostess2 = new Staff { passeportNumber = 3, firstName = "hostess2", lastName = "hostess2", emailAdress = "hostess2.hostess2@gmail.com", birthDate = new DateTime(1996, 01, 01), employementDate =   new DateTime(2020, 01, 01), salary = 999 };
        // Travellers
        public static Traveller traveller1 = new Traveller { passeportNumber = 4, firstName = "traveller1", lastName = "traveller1", emailAdress = "traveller1.traveller1@gmail.com", birthDate = new DateTime(1980, 01, 01), healthInformation = "no troubles", nationality = "American" };
        public static Traveller traveller2 = new Traveller { passeportNumber = 5, firstName = "traveller2", lastName = "traveller2", emailAdress = "traveller2.traveller2@gmail.com", birthDate = new DateTime(1981, 01, 01), healthInformation = "Some troubles", nationality = "French" };
        public static Traveller traveller3 = new Traveller { passeportNumber = 6, firstName = "traveller3", lastName = "traveller3", emailAdress = "traveller3.traveller3@gmail.com", birthDate = new DateTime(1982, 01, 01), healthInformation = "no troubles", nationality = "Tunisian" };
        public static Traveller traveller4 = new Traveller { passeportNumber = 7, firstName = "traveller4", lastName = "traveller4", emailAdress = "traveller4.traveller4@gmail.com", birthDate = new DateTime(1983, 01, 01), healthInformation = "Some troubles", nationality = "American" };
        public static Traveller traveller5 = new Traveller { passeportNumber = 8, firstName = "traveller5", lastName = "traveller5", emailAdress = "traveller5.traveller5@gmail.com", birthDate = new DateTime(1984, 01, 01), healthInformation = "Some troubles", nationality = "Spanish" };
        // Flights
        // Affect all passengers to flight1
        public static Flight flight1 = new Flight { flightDate = new DateTime(2022, 01, 01, 15, 10, 10), destination = "Paris", effectiveArrival = new DateTime(2022, 01, 01, 17, 10, 10), estimatedDuration = 110, plane = Airbusplane };
    
      
        public static Flight flight2 = new Flight { flightDate = new DateTime(2022, 02, 01,21,10,10), destination = "Paris", effectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10), estimatedDuration =105 , plane = BoingPlane };
        public static Flight flight3 = new Flight { flightDate = new DateTime(2022, 03, 01, 5, 10, 10), destination = "Paris", effectiveArrival = new DateTime(2022, 03, 01, 6, 40, 10), estimatedDuration = 100, plane = BoingPlane };
        public static Flight flight4 = new Flight { flightDate = new DateTime(2022, 04, 01, 6, 10, 10), destination = "Madrid", effectiveArrival = new DateTime(2022, 04, 01, 8, 10, 10), estimatedDuration =130 , plane = BoingPlane };
        public static Flight flight5 = new Flight { flightDate = new DateTime(2022, 05, 01, 17, 10, 10), destination = "Madrid", effectiveArrival = new DateTime(2022, 05, 01, 18, 50, 10), estimatedDuration =105 , plane = BoingPlane };
        public static Flight flight6 = new Flight { flightDate = new DateTime(2022, 06, 01, 20, 10, 10), destination = "Lisbonne", effectiveArrival = new DateTime(2022, 06, 01, 22, 30, 10), estimatedDuration =200 , plane = Airbusplane };

        //test list
        public static List<Flight> listFlights = new List<Flight> { flight1, flight2, flight3, flight4, flight5, flight6 };

        public static List<Passenger> listPassengers = new List<Passenger> { captain, hostess1, hostess2, traveller1, traveller2, traveller3, traveller4, traveller5 };

   
    }
}
