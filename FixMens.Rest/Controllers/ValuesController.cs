using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using FixMens.BLL;

namespace FixMens.Rest.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        MediaTypeFormatter formatter = null;
        // GET api/values


        // GET api/<controller>
        public HttpResponseMessage Get(string nombre, int orden, string admin)
        {

            try
            {
                Orden bllOrden = new Orden();
                return Request.CreateResponse(HttpStatusCode.OK, bllOrden.ConsultarOrden(nombre, orden, admin)
                    , formatter);
            }
            catch (System.Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message, formatter);
            }

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
