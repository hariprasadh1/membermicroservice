using membermicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Repository
{
    public class Memberpremiumrepo : IMemberpremiumrepo
    {
        public List<Memberpremium> m = new List<Memberpremium>()
        {
         new Memberpremium()
         {
             Memberid=1,
             Policyid=1,
             Topup=1000,
             Premium=2000,
             Paiddate=new DateTime(2022,06,20).ToString("dd/MM/yyyy")
         },
         new Memberpremium()
         {
             Memberid=1,
             Policyid=1,
             Topup=1000,
             Premium=2000,
             Paiddate=new DateTime(2022,06,22).ToString("dd/MM/yyyy")
         },
         new Memberpremium()
         {
             Memberid=2,
             Policyid=1,
             Topup=1000,
             Premium=2000,
             Paiddate=new DateTime(2022,06,21).ToString("dd/MM/yyyy")
         },
         new Memberpremium()
         {
             Memberid=4,
             Policyid=1,
             Topup=1500,
             Premium=2000,
             Paiddate=new DateTime(2022,06,23).ToString("dd/MM/yyyy")
         },
          new Memberpremium()
         {
             Memberid=4,
             Policyid=1,
             Topup=4000,
             Premium=5000,
             Paiddate=new DateTime(2022,06,24).ToString("dd/MM/yyyy")
         }
};
    
            public  List<Memberpremium> GetViewBills(int mid, int pid)
            {
            List<Memberpremium> memberp = new List<Memberpremium>();
           foreach(var item in m)
            {
                if(item.Memberid == mid && item.Policyid==pid)
                {
                    memberp.Add(item);
                }
            }
            return memberp;
        }
    }
}
