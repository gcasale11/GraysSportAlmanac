using GraysSportAlmanac.Data;
using GraysSportAlmanac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Services
{
    public class GroupPostService
    {
        private readonly Guid _groupPostId;

        public GroupPostService(Guid groupPostId)
        {
            _groupPostId = groupPostId;
        }

        public bool CreateGroupPost(GroupPostCreate model)
        {
            var entity =
                new GroupPost()
                {
                    AuthorId = _groupPostId,
                    GroupId = model.GroupId,
                    ProfileId = model.ProfileId,
                    BetDate = model.BetDate,
                    Risked = model.Risked,
                    Odds = model.Odds,
                    Result = model.Result,
                    Payout = model.Payout,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.GroupPosts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GroupPostListItem> GetGroupPost()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .GroupPosts
                    .Where(e => e.AuthorId == _groupPostId)
                    .Select(
                        e =>
                        new GroupPostListItem
                        {
                            UserName = e.Profile.UserName,
                            BetDate = e.BetDate,
                            Risked = e.Risked,
                            Odds = e.Odds,
                            Result = e.Result,
                            Payout = e.Payout,
                        }
                        );
                return query.ToArray();
            }
        }

        public GroupPostDetail GetGroupPostByID(Guid id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .GroupPosts
                    .Single(e => e.AuthorId == id && e.AuthorId == _groupPostId);
                return
                    new GroupPostDetail
                    {
                        GroupPostId = entity.GroupPostId,
                    };
            }
        }

        public bool UpdateGroupPost(GroupPostEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .GroupPosts
                    .Single(e => e.GroupPostId == model.GroupPostId);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteGroupPost(Guid groupPostId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .GroupPosts
                    .Single(e => e.AuthorId == groupPostId);
                ctx.GroupPosts.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }


    }
}
