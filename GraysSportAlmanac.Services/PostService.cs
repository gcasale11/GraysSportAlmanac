using GraysSportAlmanac.Data;
using GraysSportAlmanac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Services
{
    public class PostService
    {
        private readonly Guid _postId;
        
        public PostService(Guid postId)
        {
            _postId = postId;
        }

        public bool CreatePost(PostCreate model)
        {
            var entity =
                new Post()
                {
                    PostId = _postId,
                    BetDate = model.BetDate,
                    Bet = model.Bet,
                    Risked = model.Risked,
                    Odds = model.Odds,
                    Result = model.Result,
                    Payout = model.Payout,

                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PostListItem> GetPost()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Posts
                    .Where(e => e.PostId == _postId)
                    .Select(
                        e =>
                        new PostListItem
                        {
                            PostId = e.PostId
                        }
                        );
                return query.ToArray();
            }
        }

        public PostDetail GetPostByID (Guid id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.PostId == id && e.PostId == _postId);
                return
                    new PostDetail
                    {
                        PostId = entity.PostId,

                    };
            }
        }

        public bool UpdatePost (PostEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.PostId == model.PostId);

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePost(Guid postId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.PostId == postId);

                ctx.Posts.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }


    }
}
