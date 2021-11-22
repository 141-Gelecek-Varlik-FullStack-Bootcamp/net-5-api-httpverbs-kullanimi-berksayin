using HAFTA_1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HAFTA_1.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>() {
            new User{
                Id = 1,
                UserEmail = "example1@mail.com",
                UserName = "John Doe"
            },
            new User{
                Id = 2,
                UserEmail = "example2@mail.com",
                UserName = "Jane Doe"
            },
            new User{
                Id = 3,
                UserEmail = "example3@mail.com",
                UserName = "Max William"
            },
            new User{
                Id = 4,
                UserEmail = "example4@mail.com",
                UserName = "Edgar Allan"
            },
            new User{
                Id = 5,
                UserEmail = "example5@mail.com",
                UserName = "Charles Dickens"
            }
        };

        [HttpGet("GetUsers")]
        public List<User> GetUsers() {
            return users;
        }

        [HttpGet("GetUserById")]
        public User GetUser(int Id)
        {
            return users.Where(x => x.Id == Id).FirstOrDefault();
        }

        [HttpPost("InsertUser")]
        public bool InsertUser([FromBody]User user)
        {
            users.Add(user);
            return users.Exists(x => x.Id == user.Id);
        }
    }
}
