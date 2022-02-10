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
    [RoutePrefix("api/GroupPost")]
    public class GroupPostController : ApiController
    {
        public IHttpActionResult Get()
        {
            GroupPostService groupPostService = CreateGroupPostService();
            var groupPosts = groupPostService.GetGroupPost();
            return Ok(groupPosts);
        }

        public IHttpActionResult Post(GroupPostCreate groupPost)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGroupPostService();

            if (!service.CreateGroupPost(groupPost))
                return InternalServerError();

            return Ok();
        }

        private GroupPostService CreateGroupPostService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var groupPostService = new GroupPostService(userId);
            return groupPostService;
        }

        public IHttpActionResult Get(Guid id)
        {
            GroupPostService groupPostService = CreateGroupPostService();
            var groupPost = groupPostService.GetGroupPostByID(id);
            return Ok(groupPost);
        }

        public IHttpActionResult Put(GroupPostEdit groupPost)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGroupPostService();

            if (!service.UpdateGroupPost(groupPost))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(Guid id)
        {
            var service = CreateGroupPostService();
            if (!service.DeleteGroupPost(id))
                return InternalServerError();

            return Ok();
        }
    }
}
