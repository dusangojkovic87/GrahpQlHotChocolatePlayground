using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQlHotChocolateNetCore.DataContext;
using GraphQlHotChocolateNetCore.Dtos;
using GraphQlHotChocolateNetCore.Models;

namespace GraphQlHotChocolateNetCore.GraphQl.Mutation
{
    public class Mutation
    {
        public bool addUser([Service] AplicationDbContext context, UserDto request)
        {
            var user = new User
            {
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                Password = request.Password,
                Address = request.Address

            };


            context.User.Add(user);
            return context.SaveChanges() > 0;



        }

    }
}