using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Models
{
    public class Claim
    {
        public int Claimid { get; set; }
        public int Billedamount { get; set; }
        public int Claimedamount { get; set; }
        public string Claimstatus { get; set; }
    }
}
