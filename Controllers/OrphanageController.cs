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
       public IHttpActionResult Postregister(orphanageRegistration1 op )
        {
            using (var x = new ActionLearningEntities())
            {
                try
                {
                        x.orphanageRegistration1.Add(op);
                        x.SaveChanges();
                        return Ok();
                }
                catch(Exception e)
                {
                    return InternalServerError(e);
                }
            }

        }
        [Route("api/orphanage/login")]
        public IHttpActionResult PostLogin(LoginModel obj)
        {
            orphanageRegistration1 result = new orphanageRegistration1();
            using (var x = new ActionLearningEntities())
            {
                try
                {
                    result = x.orphanageRegistration1.Where(a => a.oRegistrationNum.Equals(obj.oRegistrationNum) && a.password.Equals(obj.Password)).FirstOrDefault();

                    if (result != null)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception e)
                {
                    return InternalServerError(e);
                }
            }  
        }

        [Route("api/orphanage/allorphanage")]
        public IHttpActionResult Getallorphanage()
        {
            List<orphanageRegistration1> result = new List<orphanageRegistration1>();
            using (var x = new ActionLearningEntities())
            {
                try
                {
                    result = x.orphanageRegistration1.ToList();
                    if (result.Count > 0)
                    {
                        return Ok(result);
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

        [Route("api/orphanage/orphanagebyid/{id}")]
        public IHttpActionResult Getorphanagebyid(int id)
        {
            orphanageRegistration1 result = new orphanageRegistration1();

            using(var x = new ActionLearningEntities())
            {
                try
                {
                    result = x.orphanageRegistration1.Where(op => op.oId == id).FirstOrDefault();
                    if(result != null)
                    {
                        result.password = "";
                        return Ok(result);
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

        [Route("api/orphanage/children/{id}")]
        public IHttpActionResult GetChildren(int id)
        {
            List<childRegisteration> res = new List<childRegisteration>();
            using (var x = new ActionLearningEntities())
            {
                try
                {
                    res = x.childRegisterations.Where(c => c.oId == id).ToList();
                    if (res.Count > 0)
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

        [Route("api/orphanage/childrenbyid/{id}")]
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
                    else
                    return NotFound();
                }catch (Exception e)
                {
                    return InternalServerError(e);
                }
                
            }
        }

        [Route("api/orphanage/add/addchild")]
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
