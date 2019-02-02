using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class ProductController : ApiController
    {

        public IHttpActionResult TEST(Product data)
        {
           //AYKUTTA BURADA!!!!
            if (ModelState.IsValid)
            {
                return Ok(data);
            }
            return BadRequest(ModelState);
        }


        public IHttpActionResult PostProduct(Product data)
        {
            //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            if (ModelState.IsValid)
            {
                return Ok(data);
            }
            return BadRequest(ModelState);
        }
    }
}
