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
                    AuthorId = _postId,
                    ProfileId = model.ProfileId,
                    UserName = model.UserName,
                    BetDate = model.BetDate,
                    Bet = model.Bet,
                    Risked = model.Risked,
                    Odds = model.Odds,
                    Result = model.Result,
                    Payout = model.Payout

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
                    .Where(e => e.AuthorId == _postId)
                    .Select(
                        e =>
                        new PostListItem
                        {
                            PostId = e.PostId,
                            ProfileId = e.ProfileId,
                            UserName = e.Profile.UserName,
                            BetDate = e.BetDate,
                            Bet = e.Bet,
                            Risked = e.Risked,
                            Odds = e.Odds,
                            Result = e.Result,
                            Payout = e.Payout
                        }
                        );
                return query.ToArray();
            }
        }

        public PostDetail GetPostByID (int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.PostId == id && e.AuthorId == _postId);
                return
                    new PostDetail
                    {
                        Result = entity.Result,
                        Payout = entity.Payout

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
                entity.Result = model.Result;
                entity.Payout = model.Payout;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePost(int postId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.PostId == postId && e.AuthorId == _postId);

                ctx.Posts.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }


    }
}
