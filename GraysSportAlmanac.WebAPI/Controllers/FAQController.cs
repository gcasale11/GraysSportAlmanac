using GraysSportAlmanac.Model;
using GraysSportAlmanac.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GraysSportAlmanac.WebAPI.Controllers
{
        [Authorize]
        [RoutePrefix("api/faq")]
    public class FAQController : ApiController
    {
        
            public IHttpActionResult Get()
            {
                FaqService faqService = CreateFaqService();
                var catments = faqService.GetFAQGet();
                return Ok(catments);
            }
            public IHttpActionResult Post(FAQCreate faq)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var service = CreateFaqService();

                if (!service.CreateFAQ(faq))
                    return InternalServerError();

                return Ok();
            }

            private FaqService CreateFaqService()
            {
                var userId = Guid.Parse(User.Identity.GetUserId());
                var catmentService = new FaqService(userId);
                return catmentService;
            }

            public IHttpActionResult Get(int id)
            {
                FaqService catmentService = CreateFaqService();
                var faq = catmentService.GetFAQById(id);
                return Ok(faq);
            }

            public IHttpActionResult Put(FAQEdit faq)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var service = CreateFaqService();

                if (!service.UpdateFAQ(faq))
                    return InternalServerError();

                return Ok();
            }

            public IHttpActionResult Delete(int id)
            {
                var service = CreateFaqService();

                if (!service.DeleteFAQ(id))
                    return InternalServerError();

                return Ok();
            }

        }
    }
