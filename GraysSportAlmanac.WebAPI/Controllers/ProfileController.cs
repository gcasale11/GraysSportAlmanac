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
    
    [RoutePrefix("api/profile")]
    public class ProfileController : ApiController
    {
        public IHttpActionResult Get()
        {
            ProfileService profileService = CreateProfileService();
            var profiles = profileService.GetProfile();
            return Ok(profiles);
        }

        [Authorize]
        public IHttpActionResult Post(ProfileCreate profile)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateProfileService();

            if (!service.CreateProfile(profile))
                return InternalServerError();

            return Ok();
        }

        [Authorize]
        private ProfileService CreateProfileService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var profileService = new ProfileService(userId);
            return profileService;
        }

        public IHttpActionResult Get(int id)
        {
            ProfileService profileService = CreateProfileService();
            var profile = profileService.GetProfileById(id);
            return Ok(profile);
        }

        [Authorize]
        public IHttpActionResult Put(ProfileEdit profile)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateProfileService();

            if (!service.UpdateProfile(profile))
                return InternalServerError();

            return Ok();
        }

        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateProfileService();

            if (!service.DeleteProfile(id))
                return InternalServerError();

            return Ok();
        }
    }
}
