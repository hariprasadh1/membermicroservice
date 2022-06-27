﻿using membermicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Repository
{
    public class memberpolicyrepo
    {
        public static List<memberpolicy> m = new List<memberpolicy>()
        {
            new memberpolicy()
            {
              policyid=1,
              memberid=1,
              membername="Hariprasadh",
              subscriptiondate="XXX",
              locationid=1,
              locationname="Madurai",
              hospitalid=2,
              hospitalname="Velammal",
              topupfrequency=2
            },
            new memberpolicy()
            {
              policyid=1,
              memberid=2,
              membername="Charulatha",
              subscriptiondate="XXX",
              locationid=1,
              locationname="Chennai",
              hospitalid=3,
              hospitalname="GH",
              topupfrequency=1
            },
            new memberpolicy()
            {
              policyid=2,
              memberid=3,
              membername="Anjali",
              subscriptiondate="XXX",
              locationid=2,
              locationname="Kolkata",
              hospitalid=3,
              hospitalname="NRS",
              topupfrequency=0
            },
            new memberpolicy()
            {
              policyid=1,
              memberid=4,
              membername="Aishwarya",
              subscriptiondate="XXX",
              locationid=3,
              locationname="Coimbatore",
              hospitalid=1,
              hospitalname="CGH",
              topupfrequency=2
            }
        };
    }
}
