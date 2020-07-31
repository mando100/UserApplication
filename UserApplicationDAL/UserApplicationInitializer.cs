using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UserApplicationDAL.Entities;

namespace UserApplicationDAL
{
    public static class UserApplicationInitializer
    {
        public static void Initialize(UserApplicationDBContext dbContext)
        {
            dbContext.Database.Migrate();

            if (!dbContext.User.Any())
            {
                InitializeUsers(dbContext);
            }
        }

        private static void InitializeUsers(UserApplicationDBContext dbContext)
        {
            var users = new User[]
            {
                new User { UserName = "UserName1", Name = "Name1", Email = "name1email@email.com", Phone = "12312451342"},
                new User { UserName = "UserName2", Name = "Name2", Email = "name2email@email.com", },
                new User { UserName = "UserName3", Name = "Name3", Email = "name3email@email.com", Phone = "4353654456764"},
                new User { UserName = "UserName4", Name = "Name4", Email = "name4email@email.com", },
                new User { UserName = "UserName5", Name = "Name5", Email = "name5email@email.com", Phone = "565642314789798"}
            };

            foreach (var user in users)
            {
                dbContext.User.Add(user);
                dbContext.SaveChanges();
            }
        }
    }
}
