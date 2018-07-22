using SayLove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SayLove.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var domain = GetDoMain();
            var p = GetTargetPerson(domain);

            //加载数据
            ViewBag.TargetName = p.Name;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(p);


            return View();
        }

        private Person GetTargetPerson(string domain)
        {
            //后面这里可以改成去数据库读取
            Person p = new Person();
            p.Name = "路人东";
            p.Msg1 = "你是我的眼,嫁给我好不好";
            p.Msg2 = "为了配得上你,我走了很多你不知道的路";
            return p;
        }

        private string GetDoMain()
        {
            return "lurendong";
        }
    }
}