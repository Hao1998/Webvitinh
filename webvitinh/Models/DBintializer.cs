using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webvitinh.Models
{
    public class DBintializer
    {
        public static async Task InitializeAsync(OnlineShop1Context context, IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "ADMIN", "MEMBER" };
            IdentityResult roleResult;
            foreach(var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if(!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}
