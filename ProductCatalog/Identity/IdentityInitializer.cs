using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ProductCatalog.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductCatalog.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {

            //Create roles
            if(!context.Roles.Any(i=> i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin role" };
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user role" };
                manager.Create(role);
            }
            if (!context.Users.Any(i => i.Name == "ozgedemirtas"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() 
                { 
                    Name = "Ozge", 
                    Surname = "Demirtas", 
                    UserName ="ozgedemirtas", 
                    Email="ozgedmrts55@gmail.com"
                    
                };
                manager.Create(user,"1234567");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.Name == "aysekurucu"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() 
                { 
                    Name = "Ayşe", 
                    Surname = "Kurucu", 
                    UserName = "aysekurucu", 
                    Email = "aysekurucu@gmail.com" 
                };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }


            //Create users



            base.Seed(context);
        }
    }
}