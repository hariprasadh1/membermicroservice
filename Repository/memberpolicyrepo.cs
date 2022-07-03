using membermicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Repository
{
    public class Memberpolicyrepo
    {
        public static List<Memberpolicy> m = new List<Memberpolicy>()
        {
            new Memberpolicy()
            {
              Policyid=1,
              Memberid=1,
              Membername="Hariprasadh",
              Subscriptiondate="XXX",
              Locationid=1,
              Locationname="Madurai",
              Hospitalid=2,
              Hospitalname="Velammal",
              Topupfrequency=2
            },
            new Memberpolicy()
            {
              Policyid=1,
              Memberid=2,
              Membername="Charulatha",
              Subscriptiondate="XXX",
              Locationid=1,
              Locationname="Chennai",
              Hospitalid=3,
              Hospitalname="GH",
              Topupfrequency=1
            },
            new Memberpolicy()
            {
              Policyid=2,
              Memberid=3,
              Membername="Anjali",
              Subscriptiondate="XXX",
              Locationid=2,
              Locationname="Kolkata",
              Hospitalid=3,
              Hospitalname="NRS",
              Topupfrequency=0
            },
            new Memberpolicy()
            {
              Policyid=1,
              Memberid=4,
              Membername="Aishwarya",
              Subscriptiondate="XXX",
              Locationid=3,
              Locationname="Coimbatore",
              Hospitalid=1,
              Hospitalname="CGH",
              Topupfrequency=2
            }
        };
    }
}
