using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using log4net.DateFormatter;
using membermicroservice.Models;
using membermicroservice.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace membermicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MemberController : ControllerBase
    {
        private readonly IMemberclaimrepo repo;
        private readonly log4net.ILog _log4net;
        public MemberController(IMemberclaimrepo _rep)
        {
            _log4net = log4net.LogManager.GetLogger(typeof(MemberController));
            repo = _rep;

        }
        /// <summary>
        /// It is used to fetch all the memberclaims from the claim microservice and then filter those claims by the memberid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            _log4net.Info("MemberController Get View Claim Action Method is called!");
            List<Memberclaim> ls = new List<Memberclaim>();
            ls = repo.getmyclaim(id);
            if (ls != null)
                return Ok(ls);
            else
                return BadRequest(ls);
        }

     /// <summary>
     /// It is used to send the memberclaim object received from the memberportal to the claim microservice and stores it in the memberclaim static list in claim microservice
     /// </summary>
     /// <param name="obj"></param>
     /// <returns></returns>
  
       
        [HttpPost]
        public IActionResult Post([FromBody] Memberclaim obj)//for submitting claims
        {
            _log4net.Info("MemberController Submit Claim Action Method is called!");
           
            if (string.Equals(repo.submitClaim(obj) , "success"))
                return Ok("success");
            return BadRequest("failure");
        }
      
     /// <summary>
     /// This function returns the claim status for a particular claim by invoking the claim microservice and updates the status in memberclaim static list in claim microservice
     /// </summary>
     /// <param name="id"></param>
     /// <param name="obj"></param>
     /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Memberclaim obj)//for viewing claim status
        {
            _log4net.Info("MemberController View Claim Status Action Method is called!");
            Memberclaim ob = repo.viewClaimStatus(id, obj);
            if (ob == null)
                return BadRequest(ob);
            else
                return Ok(ob);
        }

    }
}
