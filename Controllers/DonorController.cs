using orphanage_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace orphanage_api.Controllers
{
    public class DonorController : ApiController
    {
        [Route("api/helpinghand/Requirement")]
        [HttpGet]
        public IHttpActionResult GetRequirement(int id)
        {
            try
            {
                List<reqTable> res = new List<reqTable>();
                using (var x = new ActionLearningEntities())
                {
                    res = x.reqTables.Where(c => c.oId == id).ToList();
                    return Ok(res);
                }
            }
            catch(Exception e)
            {
                return Ok(e.ToString());
            }
            
        }
    }
}
