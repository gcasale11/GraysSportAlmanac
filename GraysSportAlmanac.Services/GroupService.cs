using GraysSportAlmanac.Data;
using GraysSportAlmanac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Services
{
    public class GroupService
    {
        private readonly Guid _groupId;

        public GroupService(Guid groupId)
        {
            _groupId = groupId;
        }

        public bool CreateGroup(GroupCreate model)
        {
            var entity =
                new Group()
                {
                    AuthorId = _groupId,
                    GroupName = model.GroupName,
                    RankingWL = model.RankingWL,
                    RankingTA = model.RankingTA,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Groups.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GroupListItem> GetGroup()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Groups
                    .Where(e => e.AuthorId == _groupId)
                    .Select(
                        e =>
                        new GroupListItem
                        {
                            GroupID = e.GroupId,
                            GroupName = e.GroupName,
                            RankingWL = e.RankingWL,
                            RankingTA = e.RankingTA,
                        }
                        );
                return query.ToArray();
            }
        }

        public GroupDetail GetGroupByID (int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Groups
                    .Single(e => e.GroupId == id && e.AuthorId == _groupId);
                return
                    new GroupDetail
                    {
                        GroupId = entity.GroupId,
                        GroupName = entity.GroupName,
                        RankingWL = entity.RankingWL,
                        RankingTA = entity.RankingTA,
                        
                    };
            }
        }

        public bool UpdateGroup (GroupEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Groups
                    .Single(e => e.GroupId == model.GroupId);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteGroup(int groupId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Groups
                    .Single(e => e.GroupId == groupId && e.AuthorId == _groupId);
                ctx.Groups.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
