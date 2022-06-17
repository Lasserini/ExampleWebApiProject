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
        /// <summary>
        /// Retrieves a list of companies
        /// </summary>
        public IEnumerable<string> Get()
        {
            return new string[] { "Get", "Company", "List" };
        }

        // GET: api/Companies/2
        /// <summary>
        /// Gets a specific company based on ID number
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A specific company</returns>
        /// <response code="204">Company ID doesn't exist in the Database, enter a valid ID</response>
        public string Get(int id)
        {
            return "Get specific company";
        }

        // POST: api/Companies
        /// <summary>
        /// Creates a new company
        /// </summary>
        /// <param name="value"></param>
        /// <response code="201">Company created</response>
        /// <response code="400">Company already exists in the database</response>public int Create(Account account)
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Companies/2
        /// <summary>
        /// Updates a specific company's data, based on the company's ID number
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <response code="204">Company ID doesn't exist in the Database, enter a valid ID</response>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Companies/2
        /// <summary>
        /// Removes a specific company from the database, based on the company's ID number
        /// </summary>
        /// <param name="id"></param>
        /// <response code="204">Company ID doesn't exist in the Database, enter a valid ID</response>
        public void Delete(int id)
        {
        }
    }
}
