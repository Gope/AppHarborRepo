using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Geckonet.Core.Models;

namespace AppHarborBuild.Controllers
{
    public class GeckoController : ApiController
    {
        // GET api/gecko
        public HttpResponseMessage Get()
        {
            try
            {
               var retVal = new GeckoItems();
                var items = new List<DataItem>() { 
                    new DataItem(){ Text = "Text 1", Type = DataItemType.None },
                    new DataItem(){ Text = "Text 1", Type = DataItemType.Info },
                    new DataItem(){ Text = "Text 1", Type = DataItemType.Alert }
                };
                retVal.DataItems = items.ToArray();

                return this.Request.CreateResponse<GeckoItems>(HttpStatusCode.OK, retVal);
            }
            catch (Exception ex)
            {
                return this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        // GET api/gecko/5
        public string Get(int id)
        {
            return "This will be delivered to Gecko";
        }

        // POST api/gecko
        public void Post([FromBody]string value)
        {
        }

        // PUT api/gecko/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/gecko/5
        public void Delete(int id)
        {
        }
    }
}
