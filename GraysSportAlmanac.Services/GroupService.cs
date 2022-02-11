﻿using GraysSportAlmanac.Data;
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
            groupId = _groupId;
        }

        public bool CreateGroup(GroupCreate model)
        {
            var entity =
                new Group()
                {
                    GroupId = _groupId,
                    //ProfileId = model.ProfileId,
                    GroupName = model.GroupName,
                    RankingWL = model.RankingWL,
                    RankingTA = model.RankingTA,
                    GroupPost = model.GroupPost
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
                    .Where(e => e.GroupId == _groupId)
                    .Select(
                        e =>
                        new GroupListItem
                        {
                            GroupID = e.GroupId
                        }
                        );
                return query.ToArray();
            }
        }

        public GroupDetail GetGroupByID (Guid id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Groups
                    .Single(e => e.GroupId == id && e.GroupId == _groupId);
                return
                    new GroupDetail
                    {
                        GroupId = entity.GroupId,
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

        public bool DeleteGroup(Guid groupId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Groups
                    .Single(e => e.GroupId == groupId);
                ctx.Groups.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
