using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Models
{
    public class Memberpremium
    {
        public int Memberid { get; set; }
        public int Policyid { get; set; }
        public int Topup { get; set; }
        public int Premium { get; set; }
        public string Paiddate { get; set; }
    }
}
