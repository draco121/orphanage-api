using orphanage_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace orphanage_api.Controllers
{
   
    public class OrphanageController : ApiController
    {
      [Route("api/orphanage/register")]
       public IHttpActionResult Postregister([FromBody] orphanageRegistration1 op )
        {
            using (var x = new ActionLearningEntities())
            {
                try
                {
                    /*if(x.orphanageRegistration1.Where(o => o.oId == op.oId) == null)
                    {*/
                        x.orphanageRegistration1.Add(op);
                        x.SaveChanges();
                        return Ok();
                    //}
                    /*else
                    {
                        return BadRequest("user exists");
                    }*/
                    
                }
                catch(Exception e)
                {
                    return BadRequest(e.ToString());
                }
            }

        }
        [Route("api/orphanage/login")]
        public IHttpActionResult PostLogin(orphanageRegistration1 obj)
        {
            orphanageRegistration1 result = new orphanageRegistration1();
            using (var x = new ActionLearningEntities())
            {
                // x.Configuration.ProxyCreationEnabled = false;
                result = x.orphanageRegistration1.Where(a => a.oRegistrationNum.Equals(obj.oRegistrationNum) && a.password.Equals(obj.password) ).FirstOrDefault();
                //return Ok(result);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [Route("api/orphanage/allorphanage")]
        public IHttpActionResult Getallorphanage()
        {
            List<orphanageRegistration1> result = new List<orphanageRegistration1>();
            using (var x = new ActionLearningEntities())
            {
                x.Configuration.ProxyCreationEnabled = false;
                result = x.orphanageRegistration1.ToList();
                return Ok(result);
            }
        }

        [Route("api/orphanage/orphanagebyid")]
        public IHttpActionResult Getorphanagebyid(int id)
        {
            orphanageRegistration1 result = new orphanageRegistration1();

            using(var x = new ActionLearningEntities())
            {
                result = x.orphanageRegistration1.Where(op => op.oId == id).FirstOrDefault();
                return Ok(result);
            }
        }

        [Route("api/orphanage/children")]
        public IHttpActionResult GetChildren(int id)
        {
            List<childRegisteration> res = new List<childRegisteration>();
            using (var x = new ActionLearningEntities())
            {
                res = x.childRegisterations.Where(c => c.oId == id).ToList();
                return Ok(res);
            }
        }

        [Route("api/orphanage/childrenbyid")]
        public IHttpActionResult GetChildrenbyid(int id)
        {
            childRegisteration res = new childRegisteration();
            using (var x = new ActionLearningEntities())
            {
                try
                {
                    res = x.childRegisterations.Where(c => c.CId == id).FirstOrDefault();
                    if(res !=null)
                    return Ok(res);

                    return NotFound();
                }catch (Exception e)
                {
                    return BadRequest(e.ToString());
                }
                
            }
        }

        [Route("api/orphanage/add/child")]
        public IHttpActionResult PostChildren(childRegisteration obj)
        {
           using (var x = new ActionLearningEntities())
            {
                try
                {
                    x.childRegisterations.Add(obj);
                    x.SaveChanges();
                    return Ok();
                }catch (Exception e)
                {
                    return InternalServerError(e);
                }
            }
        }

    }
}
