using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interface
{
    public interface IServiceFlight
    {
        public List<DateTime> getFlightDates(string destination);
        public void getFlights(string filterType, string filterValue);
        public void ShowFlightDetails(Plane plane);

        public int programmedFlightNumber(DateTime startDate);

        public double DurationAverage(string destination);

        public IEnumerable<Flight> OrderedDurationFlights();

        public IEnumerable<Traveller> SeniorTravellers(Flight flight);

        public IEnumerable<IGrouping<string,Flight>> DestinationGroupedFlights();
    }
}
