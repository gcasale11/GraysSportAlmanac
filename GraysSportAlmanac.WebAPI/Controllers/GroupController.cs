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
{/*
   
    [RoutePrefix("api/Group")]
    public class GroupController : ApiController
    {
        public IHttpActionResult Get()
        {
            GroupService groupService = CreateGroupService();
            var groups = groupService.GetGroup();
            return Ok(groups);
        }

        [Authorize]
        public IHttpActionResult Post(GroupCreate group)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGroupService();

            if (!service.CreateGroup(group))
                return InternalServerError();

            return Ok();
        }

        [Authorize]
        private GroupService CreateGroupService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var groupService = new GroupService(userId);
            return groupService;
        }

        public IHttpActionResult Get(Guid id)
        {
            GroupService groupService = CreateGroupService();
            var group = groupService.GetGroupByID(id);
            return Ok(group);
        }

        [Authorize]
        public IHttpActionResult Put(GroupEdit group)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGroupService();

            if (!service.UpdateGroup(group))
                return InternalServerError();

            return Ok();
        }

        [Authorize]
        public IHttpActionResult Delete(Guid id)
        {
            var service = CreateGroupService();
            if (!service.DeleteGroup(id))
                return InternalServerError();

            return Ok();
        }


    }
*/}
