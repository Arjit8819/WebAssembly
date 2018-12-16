using game2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace game2.Server.Controllers
{
    public class GameController : Controller
    {
        static Game game = new Game();
        static Dictionary<String, Game> gameDetails = new Dictionary<String, Game>();


        [HttpPost]
        [Route("api/[controller]/Signup")]
        public Boolean Signup([FromBody] String u)
        {

            String[] str = u.Split(":");
            if (!gameDetails.ContainsKey(str[0]))
            {
                Game g = new Game();
                gameDetails.Add(str[0], g);

                return true;

            }
            else {
                return false;
            }
        }
        [HttpPost]
        [Route("api/[controller]/putclue")]
        public Boolean putclue([FromBody] String u)
        {

            String[] str = u.Split(":");

            if (gameDetails.ContainsKey(str[0]))
            {
                if (gameDetails[str[0]].clue1 == null)
                {
                    gameDetails[str[0]].clue1 = str[1];
                    return true;
                }
                else if (gameDetails[str[0]].clue2 == null)
                {

                    gameDetails[str[0]].clue2 = str[1];
                    return true;
                }
                else if (gameDetails[str[0]].clue3 == null)
                {

                    gameDetails[str[0]].clue3 = str[1];
                    return true;
                }
                else {
                    return true;
                }

            }
            else {
                return false;
            }
        }

        [HttpPost]
        [Route("api/[controller]/getclue")]
        public Game getclue([FromBody] String u)
        {

            if (gameDetails.ContainsKey(u))
            {
                return gameDetails[u];
             }
            else {

                return null;
            }
        }
        [HttpPost]
        [Route("api/[controller]/deleteclue")]
        public void deleteclue([FromBody] String u)
        {
            String[] str = u.Split(":");
            if (gameDetails.ContainsKey(str[0]))
            {
                if (str[1] == "1")
                {
                    gameDetails[str[0]].clue1 = null;
                }
                else if (str[1] == "2")
                {
                    gameDetails[str[0]].clue2 = null;
                }
                else if (str[1] == "3")
                {
                    gameDetails[str[0]].clue3 = null;
                }
            }
        }
            [HttpPost]
        [Route("api/[controller]/changestatus")]
        public void changestatus([FromBody] String u)
        {
            String[] str = u.Split(":");
            if (gameDetails.ContainsKey(str[0]))
            {
                if (str[1] == "1")
                {
                    gameDetails[str[0]].status1 = true;
                }
                else if (str[1] == "2")
                {
                    gameDetails[str[0]].status2 = true;
                }
                else if (str[1] == "3")
                {
                    gameDetails[str[0]].status3 = true;
                }
            }

        }
    }
}