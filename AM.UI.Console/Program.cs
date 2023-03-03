// See https://aka.ms/new-console-template for more information

using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Service;

ServiceFlight sF = new ServiceFlight();
sF.flights = TestData.listFlights;
/*for(int i = 0;i < sF.ShowFlightDetails(new Plane { planeType = PlanType.Boing, capacity = 150, manufactureDate = new DateTime(2015, 02, 03) }).Count; i++)
{

}*/
sF.ShowFlightDetails(new Plane { planeType = PlanType.Airbus, capacity = 250, manufactureDate = new DateTime(2020, 11, 11) });
DateTime localDate = DateTime.Now;
Console.WriteLine(sF.programmedFlightNumber(new DateTime(2022, 04, 28, 15, 10, 10)));
foreach (var flight in sF.SeniorTravellers(TestData.flight4))
{
    Console.WriteLine(flight);
}
