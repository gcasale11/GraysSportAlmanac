using System.Data.Entity.ModelConfiguration;
using Microsoft.AspNet.Identity.EntityFramework;



namespace GraysSportAlmanac.Data
{

    public class IdentityUserRoleConfiguration : EntityTypeConfiguration<IdentityUserRole>
    {
        public IdentityUserRoleConfiguration()
        {
            HasKey(iur => iur.UserId);
        }
    }
}