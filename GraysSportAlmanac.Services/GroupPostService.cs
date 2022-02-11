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
            groupPostId = _groupPostId;
        }

        public bool CreateGroupPost(GroupPostCreate model)
        {
            var entity =
                new GroupPost()
                {
                    GroupPostId = model.GroupPostId,
                    //ProfileId and GroupId I think need to go here
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
                    .Where(e => e.GroupPostId == _groupPostId)
                    .Select(
                        e =>
                        new GroupPostListItem
                        {
                            GroupPostId = e.GroupPostId
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
                    .Single(e => e.GroupPostId == id && e.GroupPostId == _groupPostId);
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
                    .Single(e => e.GroupPostId == groupPostId);
                ctx.GroupPosts.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }


    }
}
