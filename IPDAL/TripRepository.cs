using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPDAL
{
    public class TripRepository
    {
        public List<Trip> GetTrips()
        {
            TripItineraryPlannerEntities ipe = new TripItineraryPlannerEntities();
            return ipe.Trips.ToList();
        }
    }
}
