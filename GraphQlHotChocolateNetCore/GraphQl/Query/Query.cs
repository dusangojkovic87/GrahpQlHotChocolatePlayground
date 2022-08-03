using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQlHotChocolateNetCore.DataContext;
using GraphQlHotChocolateNetCore.Models;

namespace GraphQlHotChocolateNetCore.GraphQl.Query
{
    public class Query
    {
        [UseProjection]
        [UseSorting]
        [UseFiltering]

        public IQueryable<User> GetUsers([Service] AplicationDbContext context)
        {
            return context.User;
        }
        [UseProjection]
        [UseSorting]
        [UseFiltering]

        public User GetUserById([Service] AplicationDbContext context, int userId)
        {
            return context.User.FirstOrDefault(userFromDb => userFromDb.Id == userId);

        }



    }
}