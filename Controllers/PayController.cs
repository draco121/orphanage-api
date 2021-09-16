using orphanage_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace orphanage_api.Controllers
{
    public class PayController : ApiController
    {
        public IHttpActionResult Postregister(TransactionTable op)
        {
            using (var x = new ActionLearningEntities())
            {
                try
                {
                    /*if(x.orphanageRegistration1.Where(o => o.oId == op.oId) == null)
                    {*/
                    x.TransactionTables.Add(op);
                    x.SaveChanges();
                    return Ok();
                    //}
                    /*else
                    {
                        return BadRequest("user exists");
                    }*/

                }
                catch (Exception e)
                {
                    return BadRequest(e.ToString());
                }
            }
        }
    }
}

