using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Mindscape.Raygun4Net;

namespace AppHarborBuild.Controllers
{
    public class EmailsController : ApiController
    {
        // GET api/emails
        public IEnumerable<Email> Get()
        {
            return new Email[]
                {
                    new Email
                        {
                            From = "gerrit.puddig@conjin.de",
                            To = "paul.paulsen@conjin.de",
                            Subject = "Hallo 1"
                        },
                    new Email
                        {
                            From = "gerrit.puddig@conjin.de",
                            To = "paul.paulsen@conjin.de",
                            Subject = "Hallo 2"
                        }
                };
        }

        // GET api/emails/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/emails
        public HttpResponseMessage Post(Email email)
        {
            if (ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            new RaygunClient("6Zq4x7UB+5mdlq8eigy0Ow==").Send(new ArgumentException("Email was invalid", "email"));
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        // PUT api/emails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/emails/5
        public void Delete(int id)
        {
        }
    }

    public class Email
    {
        [EmailAddress]
        public string From { get; set; }
         [EmailAddress]
        public string To { get; set; }
        public string Subject { get; set; }
    }
}
