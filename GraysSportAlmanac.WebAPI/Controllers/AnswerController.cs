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
    [RoutePrefix("api/answer")]
    public class AnswerController : ApiController
    {
        public IHttpActionResult Get()
        {
            AnswerService answserService = CreateAnswerService();
            var answers = answserService.GetAnswer();
            return Ok(answers);
        }

        [Authorize]
        public IHttpActionResult Post(AnswerCreate answer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateAnswerService();

            if (!service.CreateAnswer(answer))
                return InternalServerError();

            return Ok();
        }

        private AnswerService CreateAnswerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var answerService = new AnswerService(userId);
            return answerService;
        }

        public IHttpActionResult Get(int id)
        {
            AnswerService answerService = CreateAnswerService();
            var answer = answerService.GetAnswerByID(id);
            return Ok(answer);
        }

        [Authorize]
        public IHttpActionResult Put(AnswerEdit answer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateAnswerService();

            if (!service.UpdateAnswer(answer))
                return InternalServerError();

            return Ok();
        }

        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateAnswerService();

            if (!service.DeleteAnswer(id))
                return InternalServerError();

            return Ok();
        }
    }
}
