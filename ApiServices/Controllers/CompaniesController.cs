using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiServices.Controllers
{
    public class CompaniesController : ApiController
    {
        // GET: api/Companies
        public IEnumerable<string> Get()
        {
            return new string[] { "Get", "Company", "List" };
        }

        // GET: api/Companies/2
        public string Get(int id)
        {
            return "Get specific company";
        }

        // POST: api/Companies
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Companies/2
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Companies/2
        public void Delete(int id)
        {
        }
    }
}
