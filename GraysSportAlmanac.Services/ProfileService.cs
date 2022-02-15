using GraysSportAlmanac.Data;
using GraysSportAlmanac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Services
{
    public class ProfileService
    {
        private readonly Guid _userId;
        public ProfileService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateProfile(ProfileCreate model)
        {
            var entity =
                new Profile()
                {
                    OwnerId = _userId,
                    UserName = model.UserName,
                    Bio = model.Bio
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Profiles.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<ProfileListItem> GetProfile()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Profiles
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new ProfileListItem
                        {
                            ProfileId = e.ProfileId,
                            UserName = e.UserName,
                            Bio = e.Bio
                        }
                        );
                return query.ToArray();
            }
        }

            public ProfileDetail GetProfileById(int id)
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var entity =
                        ctx
                        .Profiles
                        .Single(e => e.ProfileId == id && e.OwnerId == _userId);
                    return
                        new ProfileDetail
                        {
                            ProfileId = entity.ProfileId,
                            OwnerId = entity.OwnerId,
                            UserName = entity.UserName,
                            Bio = entity.Bio,
                            Record = entity.Record,
                            TotalRisked = entity.TotalRisked,
                            TotalAccount = entity.TotalAccount,
                            UnitSize = entity.UnitSize,
                            Units = entity.Units
                        };
                }
            }

            public bool UpdateProfile(ProfileEdit model)
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var entity =
                        ctx
                        .Profiles
                        .Single(e => e.ProfileId == model.ProfileId && e.OwnerId == _userId);

                        entity.Bio = model.Bio;
                        

                    return ctx.SaveChanges() == 1;
                }
            }

            public bool DeleteProfile(int profileId)

            {
                using (var ctx = new ApplicationDbContext())
                {
                    var entity =
                        ctx
                        .Profiles
                        .Single(e => e.ProfileId == profileId && e.OwnerId == _userId);

                    ctx.Profiles.Remove(entity);

                    return ctx.SaveChanges() == 1;
                }
            }
        }
    }


