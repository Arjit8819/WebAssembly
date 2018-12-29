//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using FinalProject.Shared;
//using System.Net.Http;

//namespace FinalProject.Client.Pages.Services
//{
//    public class projectService
//    {
//        public async Task changeapp(String myvalue,String appname)
//        {
//            Boolean a;
//            string body = (myvalue + ":" + appname);

//            a = await Http.SendJsonAsync<Boolean>(HttpMethod.Post, "/api/Login/appname", body);

//            return a;
//        }
//    }
//}
