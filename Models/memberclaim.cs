using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Models
{
    public class Memberclaim
    {
        public int Memberid { get; set; }
        public int Claimid { get; set; }
        public int Billedamount { get; set; }
        public int Claimedamount { get; set; }
        public int Benefitid { get; set; }
        public string Claimstatus { get; set; }

    }
}
