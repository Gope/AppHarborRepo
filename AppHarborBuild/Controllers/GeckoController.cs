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
        public IEnumerable<DataItem> Get()
        {
            var items = new List<DataItem>() 
                { 
                    new DataItem(){ Text = "Textzeile 1", Type = DataItemType.None },
                    new DataItem(){ Text = "Textzeile 2", Type = DataItemType.Info },
                    new DataItem(){ Text = "Textzeile 3", Type = DataItemType.Alert }
                };

            return items;
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
