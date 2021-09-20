using orphanage_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace orphanage_api.Controllers
{
    public class DashboardController : ApiController
    {
        [Route("api/metrics/totaldonations")]
        public IHttpActionResult Gettotaldonations()
        {
            decimal result = 0;

            using (var x = new ActionLearningEntities())
            {
                try
                {
                    List<TransactionTable> res = x.TransactionTables.ToList();
                    res.ForEach(t => result += t.Amount);
                    return Ok(result);
                }catch (Exception e)
                {
                    return InternalServerError(e);
                }
                
            }
        }

        [Route("api/metrics/totaldonationsbyid/{id}")]
        public IHttpActionResult Gettotaldonationsbyid(int id)
        {
            List<TransactionTable> res = null;
            using(var x = new ActionLearningEntities())
            {
                try
                {
                    res = x.TransactionTables.Where(t => t.oId == id).ToList();
                    if (res != null)
                    {
                        return Ok(res);
                    }
                    else
                    {
                        return NotFound();
                    }
                }catch (Exception e)
                {
                    return InternalServerError(e);
                }
                
                
            }
        }

        [Route("api/metrics/scheduledvisits/{id}")]
        public IHttpActionResult Getscheduledvisits(int id)
        {
            List<OrphanageVisit> res = null;
            using(var x = new ActionLearningEntities())
            {
                try
                {
                    res = x.OrphanageVisits.Where(p => (p.oId == id)).ToList();
                    if (res != null)
                    {
                        return Ok(res);
                    }
                    else
                    {
                        return NotFound();
                    }
                }catch(Exception e)
                {
                    return InternalServerError(e);
                }    
            }
        }

        [Route("api/metrics/frontpageinfo")]
        public IHttpActionResult Getfrontpageinfo()
        {
            using (var x = new ActionLearningEntities())
            {
                try
                {
                    List<TransactionTable> transactions = x.TransactionTables.ToList();
                    int donations = transactions.Count();
                    decimal totaldonation = 0;
                    for(int i = 0; i < donations;i++)
                    {
                        totaldonation += transactions[i].Amount;
                    }
                    int count = x.orphanageRegistration1.ToList().Count();
                    frontpageres p = new frontpageres();
                    p.donation = donations;
                    p.count = count;
                    p.totaldonation = totaldonation;

                    return Ok(p);

                }
                catch (Exception e)
                {
                    return InternalServerError(e);
                }
            }
        }
    }
}
