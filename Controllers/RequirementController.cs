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
        //[Route("api/orphanage/addRequirement")]
        public IHttpActionResult PostRequirements(reqTable obj)
        {
            using (var x = new ActionLearningEntities())
            {
                try
                {
                    x.reqTables.Add(obj);
                    x.SaveChanges();
                    return Ok();
                }
                catch (Exception e)
                {
                    return InternalServerError(e);
                }
            }
        }
    }
}
