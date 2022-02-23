using GraysSportAlmanac.Data;
using GraysSportAlmanac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Services
{
    public class AnswerService
    {
        private readonly Guid _answerId;
        public AnswerService(Guid answerId)
        {
            _answerId = answerId;
        }

        public bool CreateAnswer(AnswerCreate model)
        {
            var entity =
                new Answer()
                {
                    AuthorId = _answerId,
                    FAQId = model.FAQId,
                    ProfileId = model.ProfileId,
                    UserName = model.UserName,
                    AnswerContent = model.AnswerContent,

                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Answers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<AnswerListItem> GetAnswer()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Answers
                    .Where(e => e.AuthorId == _answerId)
                    .Select(
                        e =>
                        new AnswerListItem
                        {
                            ProfileId = e.Profile.ProfileId,
                            FAQId = e.FAQ.FaqId,
                            UserName = e.Profile.UserName,
                            AnswerContent = e.AnswerContent
                        });
                return query.ToArray();
            }
        }

        public AnswerDetail GetAnswerByID(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Answers
                    .Single(e => e.AnswerId == id && e.AuthorId == _answerId);
                return
                    new AnswerDetail
                    {
                        AnswerContent = entity.AnswerContent
                    };
            }
        }

        public bool UpdateAnswer (AnswerEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Answers
                    .Single(e => e.AnswerId == model.AnswerId);
                entity.AnswerContent = model.AnswerContent;
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteAnswer (int answersId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Answers
                    .Single(e => e.AnswerId == answersId && e.AuthorId == _answerId);
                ctx.Answers.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
