using GraysSportAlmanac.Data;
using GraysSportAlmanac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Services
{
    public class CommentService
    {
        private readonly Guid _userId;

        public CommentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new Comment()
                {
                    AuthorId = _userId,
                    ContentComment = model.ContentComment,
                    ProfileId = model.ProfileId,
                    PostId = model.PostId,
                    GroupPostId = model.GroupPostId,
                    FaqId = model?.FaqId,
   
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }



        public IEnumerable<CommentListItem> GetComment()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Comments
                    .Where(e => e.AuthorId == _userId)
                    .Select(
                        e =>
                        new CommentListItem
                        {
                            ProfileId = e.ProfileId,
                            UserName = e.Profile.UserName,
                            PostId = e.PostId,
                            FaqId = e.FaqId,
                            GroupPostId = e.GroupPostId,
                            CommentId = e.CommentId,
                            ContentComment = e.ContentComment,
                            
                        }
                        );
                
                return query.ToArray();
            }
        }

        public CommentDetail GetCommentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.CommentId == id && e.AuthorId == _userId);
                return
                    new CommentDetail
                    {
                        CommentId = entity.CommentId,
                        ContentComment = entity.ContentComment,
                        PostId = entity.PostId,
                        FaqId = entity.FaqId,
                        GroupPostId = entity.GroupPostId,
                        AuthorId = entity.AuthorId,
                        
                    };
            }
        }

        public bool UpdateComment(CommentEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.CommentId ==
                    model.CommentId && e.AuthorId == _userId);

                entity.CommentId = model.CommentId;
                entity.ContentComment = model.ContentComment;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteComment(int commentsId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.CommentId == commentsId && e.AuthorId == _userId);

                ctx.Comments.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
