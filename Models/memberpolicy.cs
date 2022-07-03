using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Models
{
    public class Memberpolicy
    {
        public int Memberid { get; set; }
        public string Membername { get; set; }
        public int Policyid { get; set; } 
        //one member is assigned to only one policy
        public string Subscriptiondate { get; set; }
        //it will not contain premium amount
        //hence it will not contain cap amount
        public int Locationid { get; set; }
        public string Locationname { get; set; }
        public int Hospitalid { get; set; }
        public string Hospitalname { get; set; }
        public int Topupfrequency { get; set; }
        //topup is essential to check first validation

    }
}
