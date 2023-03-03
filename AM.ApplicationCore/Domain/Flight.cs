﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string destination { get; set; }
        public string departure { get; set; }
        public DateTime flightDate { get; set; }
        public int flightId { get; set; }
        public DateTime effectiveArrival { get; set; }
        public int estimatedDuration { get; set; }
        public string AirlineLogo { get; set; }
        public virtual ICollection<Passenger> peseengers { get; set; }

        public virtual Plane plane { get; set; }

        public override string? ToString()
        {
            return $"FlightId: {flightId}, Destination: {destination},Departure: {departure}, FlightDate: {flightDate}, EffectiveArrival: {effectiveArrival},EstimatedDuration: {estimatedDuration}";
        }
    }
}
