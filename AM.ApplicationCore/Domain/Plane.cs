using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int capacity { get; set; }
        public DateTime manufactureDate { get; set; }
        public int planeId { get; set; }
        public PlanType planeType { get; set; }

        public virtual ICollection<Flight> flights { get; set; }


        public override string? ToString()
        {
            return "Plane : \n Plane ID : " + planeId + "\n ManyfactureDate : " + manufactureDate + "\n Capacity : " + capacity + "\n Type of Plane : " + planeType;
        }

    }

    public enum PlanType
    {
        Boing, Airbus
    }
}

