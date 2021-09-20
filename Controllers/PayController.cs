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
                    op.date = DateTime.Now;
                    x.TransactionTables.Add(op);
                    x.SaveChanges();
                    reqTable t = x.reqTables.Where(r => r.Id == op.rId).FirstOrDefault();
                    if(t.Deposited == null)
                    {
                        t.Deposited = op.Amount;
                        if (t.Deposited >= t.amount)
                        {
                            t.status = "completed";

                        }
                        x.SaveChanges();
                        return Ok();
                    }
                    else
                    {
                        t.Deposited += op.Amount;
                        if (t.Deposited > t.amount)
                        {
                            t.status = "completed";
                        }
                        x.SaveChanges();
                        return Ok();
                    }
                    
                }catch (Exception e)
                {
                    return InternalServerError(e);
                }
                    
             
            }
        }
    }
}

