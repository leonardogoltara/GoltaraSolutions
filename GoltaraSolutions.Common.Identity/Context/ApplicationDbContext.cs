using GoltaraSolutions.Common.Identity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace GoltaraSolutions.Common.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>, IDisposable
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("Identity");
            base.OnModelCreating(modelBuilder);
        }

    }
}
