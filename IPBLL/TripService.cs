﻿using IPDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPBLL
{
    public class TripService
    {
        public List<Trip> GetTrips() 
        {
            TripRepository tr = new TripRepository();
            return tr.GetTrips();
        }
    }
}
