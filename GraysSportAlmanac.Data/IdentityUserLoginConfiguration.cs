﻿using System.Data.Entity.ModelConfiguration;
using Microsoft.AspNet.Identity.EntityFramework;



namespace GraysSportAlmanac.Data
{
    public class IdentityUserLoginConfiguration : EntityTypeConfiguration<IdentityUserLogin>
    {
        public IdentityUserLoginConfiguration()
        {
            HasKey(iul => iul.UserId);
        }
    }
}