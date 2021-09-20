using orphanage_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace orphanage_api.Controllers
{
    public class HelpingHandController : ApiController
    {
        
        //[Route("api/helpinghand/allOrphanage")]
        public IHttpActionResult Getallorphanage()
        {
            List<orphanageRegistration1> result = new List<orphanageRegistration1>();
            using (var x = new ActionLearningEntities())
            {
                try
                {   
                    result = x.orphanageRegistration1.ToList();
                    if(result.Count > 0)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound();
                    }
                    
                }catch( Exception e)
                {
                    return InternalServerError(e);
                }
                
            }
        }


        [Route("api/helpinghand/getRequirement/{id}")]
        public IHttpActionResult GetRequirement(int id)
        {
            List<reqTable> res = new List<reqTable>();
            using (var x = new ActionLearningEntities())
            {
                try
                {
                    res = x.reqTables.Where(c => c.oId == id).ToList();
                    if (res.Count > 0)
                    {
                        return Ok(res);
                    }
                    else
                    {
                        return NotFound();
                    }
                    
                } catch (Exception e)
                {
                    return InternalServerError(e);
                }
                
            }
        }
    }
}
