﻿using GraysSportAlmanac.Data;
using GraysSportAlmanac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Services
{
    public class FaqService
    {
        private readonly Guid _userId;

        public FaqService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateFAQ(FAQCreate model)
        {
            var entity =
                new FAQ()
                {
                    Question = model.Question,
                    ProfileId = model.ProfileId,
                    AuthorId = _userId

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.FAQs.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<FAQListItem> GetFAQGet()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .FAQs
                    .Where(e => e.AuthorId == _userId)
                    .Select(
                        e =>
                        new FAQListItem
                        {
                            FaqId = e.FaqId,
                            Question = e.Question,
                            UserName = e.Profile.UserName,
                            ProfileId = e.ProfileId,
                            
                        }
                     );

                return query.ToArray();
            }
        }

        public FAQDetail GetFAQById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .FAQs
                    .Single(e => e.FaqId == id && e.AuthorId == _userId);
                return
                    new FAQDetail
                    {
                        FaqId = entity.FaqId,
                        AuthorId = entity.AuthorId,
                        Question = entity.Question,
                        UserName = entity.Profile.UserName,
                        ProfileId = entity.ProfileId,
                    };
            }
        }

        public bool UpdateFAQ(FAQEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .FAQs
                    .Single(e => e.FaqId == model.FaqId && e.AuthorId == _userId);

                entity.FaqId = model.FaqId;
                entity.Question = model.Question;
               
             
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteFAQ(int faqsId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .FAQs
                    .Single(e => e.FaqId == faqsId && e.AuthorId == _userId);

                ctx.FAQs.Remove(entity);

                return ctx.SaveChanges() == 1;
            }

        }

    }
}
