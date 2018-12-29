using FinalProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Server.Controllers
{
    public class LoginController : Controller
    {
       
        static Dictionary<String, User> userDetails = new Dictionary<String, User>();
        static Dictionary<String, List<User>> emailDetails = new Dictionary<String, List<User>>();
        static User u = new User();


        [HttpGet]
        [Route("api/[controller]/getuse")]
        public IEnumerable<User> getUse()
        {
            Dictionary<String, User>.ValueCollection values = userDetails.Values;
            return values;
        }

        [HttpGet]
        [Route("api/[controller]/getsurveyuser")]
        public IEnumerable<User> getsurveyuser([FromBody] String s)
        {
            if (emailDetails.ContainsKey(s))
            {

                return emailDetails[s];
            }
            else {

                return null;
            }
            
        }

        [HttpPost]
        [Route("api/[controller]/getspeuser")]
        public User getspeuser([FromBody] String u)
        {
            if (userDetails.ContainsKey(u))
            {
                return userDetails[u];
            }
            else {

                return null;
            }    

        }

        [HttpPost]
        [Route("api/[controller]/sendmoney")]
        public Boolean sendmoney([FromBody] String s) {

            String[] str = s.Split(":");
            if (userDetails.ContainsKey(str[0]))
            {
                userDetails[str[0]].money += Convert.ToDouble(str[1]);
                userDetails[str[0]].money = userDetails[str[0]].money;
                return true;

            }
            else {

                return false;
            }

        }

        [HttpPost]
        [Route("api/[controller]/resolvesurvey")]
        public void resolvesurvey([FromBody] String s)
        {

            
            if (userDetails.ContainsKey(s))
            {
                userDetails[s].Survey = true;
                

            }
           

        }

        [HttpPost]
        [Route("api/[controller]/sendsurvey")]
        public Boolean sendsurvey([FromBody] String s)
        {

            String[] str = s.Split(":");
            //String[] emails = str[2].Split(",");
           
            //foreach (var e in emails) {
            //    if (emailDetails.ContainsKey(e))
            //    {
            //        emailDetails[e].Add(userDetails[str[0]]);
            //    }
            //    else {
            //        emailDetails.Add(e, null);
            //       // emailDetails[e].Add(userDetails[str[0]]);
            //    }
                
            //}
            if (userDetails.ContainsKey(str[0]))
            {
               
                    userDetails[str[0]].Surveyitems = str[1];
                String arj = "";
                for (int i = 2; i < str.Length; i++)
                {
                    arj = (arj + ":" + str[i]);
                }
                 arj =arj.Substring(1);
                userDetails[str[0]].gamelink = (arj);
                return true;
            }
            else
            {

                return false;
            }
            
        }

        [HttpPost]
        [Route("api/[controller]/getsurveylist")]
        public IEnumerable<String> getsurveylist([FromBody] String s)
        {
           
            
            if (userDetails.ContainsKey(s))
            {

                String[] str = userDetails[s].Surveyitems.Split(",");
                return str;
            }
            else
            {

                return null;
            }

        }

        [HttpPost]
        [Route("api/[controller]/appname")]
        public Boolean appname([FromBody] String s)
        {

            String[] str = s.Split(":");
            if (userDetails.ContainsKey(str[0]))
            {
                userDetails[str[0]].Appname = str[1];
                userDetails[str[0]].Appname = userDetails[str[0]].Appname;
                return true;

            }
            else
            {

                return false;
            }

        }

        [HttpPost]
        [Route("api/[controller]/decreasemoney")]
        public Boolean decreasemoney([FromBody] String s)
        {

            String[] str = s.Split(":");
            if (userDetails.ContainsKey(str[0]))
            {
                userDetails[str[0]].money = userDetails[str[0]].money - Convert.ToDouble(str[1]);
                
                return true;

            }
            else
            {

                return false;
            }

        }

        [HttpPost]
        [Route("api/[controller]/updateinfo")]
        public Boolean updateinfo([FromBody] String s)
        {

            String[] str = s.Split(":");
            if (userDetails.ContainsKey(str[0]))
            {
                userDetails[str[0]].image = (str[1]+ ":" + str[2]);
                userDetails[str[0]].yourname = str[3];
                userDetails[str[0]].email = str[4];
                userDetails[str[0]].password = str[5];
                return true;

            }
            else
            {

                return false;
            }

        }

        [HttpPost]
        [Route("api/[controller]/Signup")]
        public void Signup([FromBody] String u)
        {
            String[] str = u.Split(":");
            User us = new User();

            String username = str[0];
            String password = str[1];
            if (!userDetails.ContainsKey(username))
            {
                User user = new User();
                user.username = username;
                user.yourname = username;
                user.password = password;
                user.image = "http://icons.iconarchive.com/icons/papirus-team/papirus-status/256/avatar-default-icon.png";
                user.Appname = "Game Name";
                user.money = 20;
                user.Survey = false;
                user.Surveyitems = "No Survey";
                userDetails.Add(username, user);

            }


        }

        [HttpPost]
        [Route("api/[controller]/Signin")]
        public User Signin([FromBody] string u)
        {
            String[] str = u.Split(":");
            str[0]=str[0];
            str[1] = str[1];

            if (userDetails.ContainsKey(str[0]) && userDetails[str[0]].password.Equals(str[1]))
            {
                var user = userDetails[str[0]];
              
                user.Survey = false;
                return user;
            }
            else
            {
                User use = new User();
                use.username = "";
                use.password = "";
                return use;
            }
        }


    }
}