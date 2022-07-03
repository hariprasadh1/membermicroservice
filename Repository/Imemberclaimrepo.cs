using membermicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Repository
{
    public interface IMemberclaimrepo
    {
        public string submitClaim(Memberclaim obj);
        public Memberclaim viewClaimStatus(int id, Memberclaim obj);

        public List<Memberclaim> getmyclaim(int id);
    }
}
