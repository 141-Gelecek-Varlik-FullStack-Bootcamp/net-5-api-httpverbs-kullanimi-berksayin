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
        //Static users are generated when project started
        private static List<User> users = new List<User>() {
            new User{
                Id = 1,
                UserEmail = "example1@mail.com",
                UserPassword = "12345678",
                UserName = "John Doe"
            },
            new User{
                Id = 2,
                UserEmail = "example2@mail.com",
                UserPassword = "a1b2c3d4",
                UserName = "Jane Doe"
            },
            new User{
                Id = 3,
                UserEmail = "example3@mail.com",
                UserPassword = "pass1234",
                UserName = "Max William"
            },
            new User{
                Id = 4,
                UserEmail = "example4@mail.com",
                UserPassword = "987654321",
                UserName = "Edgar Allan"
            },
            new User{
                Id = 5,
                UserEmail = "example5@mail.com",
                UserPassword = "charles1234",
                UserName = "Charles Dickens"
            }
        };


        //Listing all users
        [HttpGet("GetUsers")]
        public List<User> GetUsers() {
            return users;
        }


        //Listing single user
        [HttpGet("GetUserById")]
        public User GetUser(int Id)
        {
            return users.Where(x => x.Id == Id).FirstOrDefault();
        }


        //Adding a new user
        [HttpPost("InsertUser")]
        public IActionResult InsertUser([FromBody]User user)
        {
            var usertemp = users.SingleOrDefault(x => x.Id == user.Id);
            if (usertemp == null) 
            {
                return BadRequest();
            }
            users.Add(user);
            return Ok();
        }


        //Updating a user
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser(int id, [FromBody]User user)
        {
            var usertemp = users.FirstOrDefault(x => x.Id == user.Id);
            if (usertemp == null)
            {
                return BadRequest();
            }
            usertemp.UserEmail = user.UserEmail;
            usertemp.UserPassword = user.UserPassword;
            usertemp.UserName = user.UserName;
            return Ok();
        }


        //Deleting a user
        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int id) 
        {
            var usertemp = users.FirstOrDefault(x => x.Id == id);
            if (usertemp == null)
            {
                return BadRequest();
            }
            users.Remove(usertemp);
            return Ok();
        }

    }
}
