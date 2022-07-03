using membermicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Repository
{
    public interface IMemberpremiumrepo
    {
      //  public  List<memberpremium> fun();
        public List<Memberpremium> GetViewBills(int mid, int pid);


    }
}
