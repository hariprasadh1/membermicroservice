using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Models
{
    public class Memberdetails
    {
        public int Memberid { get; set; }
        public string Membername { get; set; }
        public string Phonenumber { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
    }
}
