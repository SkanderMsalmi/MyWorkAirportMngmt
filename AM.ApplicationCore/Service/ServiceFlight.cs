using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> flights { get; set; }

        public IEnumerable<IGrouping<string,Flight>> DestinationGroupedFlights()
        {
            var req = from f in flights
                      group f by f.destination;
            foreach(var g in req)
            {
                Console.WriteLine("Destination : "+g.Key);
                foreach(var flight in g)
                {
                    Console.WriteLine("Décollage : " + flight.flightDate);
                }
            }
            return req;
        }

        public double DurationAverage(string destination)
        {
            return flights.Where(f => f.destination == destination).Select(f=> f.estimatedDuration).Average();
        }

        public List<DateTime> getFlightDates(string destination)
        {
            List<DateTime> ls = new List<DateTime>();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].destination.Equals(destination))
                {
                    ls.Add(flights[i].flightDate);
                }
            }
            return ls;

            var flightsQuery = from flight in flights
                               where (flight.destination == destination)
                               select flight.flightDate;

            var flightsQueryLamba = flights.Where(f => f.destination == (destination)).Select(f => f.flightDate);
            return flightsQuery.ToList();

            /*foreach(Flight flight in flights)
            {
                if(flight.destination.Equals(destination))
                {
                    ls.Add(flight.flightDate);
                }
            }
            return ls;*/
        }

        public void getFlights(string filterType,string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in flights)
                    {
                        if (flight.destination.Equals(filterValue))
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }
                   
                    break;
                case "FlightDate":
                    foreach (var flight in flights)
                    {
                        if (flight.flightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }
                    break;
                case "EffectiveArrival":
                    foreach (var flight in flights)
                    {
                        if (flight.effectiveArrival == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }
                    break;
            }
            

        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            return flights.OrderByDescending(f => f.estimatedDuration);
/*            var req = from f in flights orderby f.estimatedDuration descending select f;
            return req.ToList();*/

            
        }

        public int programmedFlightNumber(DateTime startDate)
        {
            var req = from f in flights
                      where DateTime.Compare(f.flightDate, startDate) > 0
                      && (f.flightDate - startDate).TotalDays < 7
                      select f;
            return req.Count();

           /* return flights.Where(f => startDate.CompareTo(f.flightDate) > 0).Where(f => (f.flightDate - startDate).TotalDays <= 7).Count();*/
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            return flights.Select(f=> f.peseengers).OfType<Traveller>().OrderBy(f => f.birthDate).Take(3);

          /*  var req = from f in flights.Select(f => f.peseengers).OfType<Traveller>() orderby f.birthDate select f;
            return req.Take(3);*/
        }

        public void ShowFlightDetails(Plane plane)
        {
            var flightDetailsQuery = flights.Where(f => f.plane == plane).Select(f => new
            {
                f.flightDate,
                f.destination
            });

            foreach(var flight in flightDetailsQuery)
            {
                Console.WriteLine("Destination : "+flight.destination+"\n FlightDate " + flight.flightDate.ToString() );
            }
        }
    }
}
