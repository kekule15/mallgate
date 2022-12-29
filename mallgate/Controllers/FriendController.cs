using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mallgate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        [HttpGet]
        public List<Friend> GetFriends()
        {
            List<Friend> friends = new List<Friend>();

            friends.Add(new Friend("Emeka", "Onye", "Lagos"));
            friends.Add(new Friend("Wilson", "Anderson", "Aba"));
            friends.Add(new Friend("Stella", "Eze", "Lagos"));

            //for (int i = 0; i < 5; i++)
            //{
            //    friends.Add(new Friend("Emeka", "Onye", "Lagos"));
            //}

            return (friends);
        }
        [HttpGet("GetOne{name}")]
        public Friend GetSIngle(string name)
        {
            List<Friend> friends = new List<Friend>();

            friends.Add(new Friend("Emeka", "Onye", "Lagos"));
            friends.Add(new Friend("Wilson", "Anderson", "Aba"));
            friends.Add(new Friend("Stella", "Eze", "Lagos"));



#pragma warning disable CS8603 // Possible null reference return.
            return friends.FirstOrDefault(c => c.firstName == name);
        }
    }
}
