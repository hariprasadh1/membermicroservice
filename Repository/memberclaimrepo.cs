using membermicroservice.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace membermicroservice.Repository
{
    public class Memberclaimrepo : IMemberclaimrepo
    {
        private readonly Uri baseAddress; 
        private readonly HttpClient client;
        IConfiguration _config;
        public Memberclaimrepo(IConfiguration config)
        {
             _config = config;
            baseAddress = new Uri(_config["Links:CLAIM"]);
            client = new HttpClient();
            client.BaseAddress = baseAddress;

        }
        public string submitClaim(Memberclaim obj)
        {
            try
            {
                string data = JsonConvert.SerializeObject(obj);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(client.BaseAddress, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    return "success";

                }
                return "failed";
            }
            catch (Exception e)
            {
                return "Exception Occured"+e.Message;
            }
        }

        public Memberclaim viewClaimStatus(int id, Memberclaim obj)
        {
            try
            {
                Memberclaim ob = new Memberclaim();

                string data = JsonConvert.SerializeObject(obj);

                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/" + id, content).Result;

                if (response.IsSuccessStatusCode)
                {

                    string data1 = response.Content.ReadAsStringAsync().Result;
                    ob = JsonConvert.DeserializeObject<Memberclaim>(data);

                }

                return ob;//for claimstatus.cshtml
            }
            catch(Exception)
            {
                return null;
            }


        }



        public List<Memberclaim> getmyclaim(int id)
        {
            List<Memberclaim> ls = new List<Memberclaim>();


            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;//calls getall method in claim controller

            if (response.IsSuccessStatusCode)
            {

                string data = response.Content.ReadAsStringAsync().Result;

                ls = JsonConvert.DeserializeObject<List<Memberclaim>>(data);

            }
            //filtering process

            List<Memberclaim> ml = new List<Memberclaim>();

            foreach (Memberclaim item in ls)
            {
                if (item.Memberid == id)
                {
                    ml.Add(item);
                }
            }
            return ml;
        }










    }
}
    

