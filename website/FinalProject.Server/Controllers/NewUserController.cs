using FinalProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Server.Controllers
{
    public class NewUserController : Controller
    {
        static Dictionary<String, Viewer> userDetails = new Dictionary<String, Viewer>();
        static Viewer u = new Viewer();


        [HttpPost]
        [Route("api/[controller]/Signup")]
        public void Signup([FromBody] String u)
        {
            String[] str = u.Split(":");
            Viewer us = new Viewer();

            String username = str[0];
            String password = str[1];
            if (!userDetails.ContainsKey(username))
            {
                Viewer user = new Viewer();
                user.Name = username;
                user.password = password;
                user.email = str[2];
            
                userDetails.Add(username, user);

            }


        }

        [HttpPost]
        [Route("api/[controller]/Signin")]
        public Viewer Signin([FromBody] string u)
        {
            String[] str = u.Split(":");
            if (userDetails.ContainsKey(str[0]) && userDetails[str[0]].password.Equals(str[1]))
            {
                var user = userDetails[str[0]];
      
                return user;
            }
            else
            {
                Viewer use = new Viewer();
                use.Name = "";
                use.password = "";
                return use;
            }
        }

        [HttpPost]
        [Route("api/[controller]/getspeuser")]
        public Viewer getspeuser([FromBody] String u)
        {
            if (userDetails.ContainsKey(u))
            {
                return userDetails[u];
            }
            else
            {

                return null;
            }

        }
    }
}