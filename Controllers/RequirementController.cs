using orphanage_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace orphanage_api.Controllers
{
    public class RequirementController : ApiController
    {
        [Route("api/orphanage/addRequirement")]
        public IHttpActionResult PostRequirement(reqTable obj)
        {
            using (var x = new ActionLearningEntities())
            {
                try
                {
                    obj.Id = Guid.NewGuid().ToString();
                    obj.date = DateTime.Now;
                    x.reqTables.Add(obj);
                    x.SaveChanges();
                    return Ok("requirement added");
                }
                catch (Exception e)
                {
                    return Ok(e.ToString());
                }
            }
        }
    }
}
