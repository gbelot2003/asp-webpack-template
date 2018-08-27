namespace MusicStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MusicStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MusicStore.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MusicStore.Models.ApplicationDbContext context)
        {
            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Admin" },
                new IdentityRole { Name = "Senior" },
                new IdentityRole { Name = "Moderator" },
                new IdentityRole { Name = "Member" },
                new IdentityRole { Name = "Junior" },
                new IdentityRole { Name = "Candidate" }
                );


            if (!context.Users.Any(u => u.UserName == "admin"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "admin", Email = "gbelot@test.com" };

                manager.Create(user, "ChangeItAsap!");
                manager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(u => u.UserName == "senior"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user2 = new ApplicationUser { UserName = "sinior", Email = "gbelot@test.com" };

                manager.Create(user2, "ChangeItAsap!");
                manager.AddToRole(user2.Id, "Senior");
            }
        }
    }
}
