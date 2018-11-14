using Dark_Souls.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dark_Souls.NET.Controllers
{
    public class HomeController : Controller
    {
        private DbFighter db = new DbFighter();
        private DbMonster db2 = new DbMonster();
        //List<Character> fists = new List<Character>();

        public ActionResult Index()
        {
            //Making Selections
            ViewBag.fighters = db.Fighters;
            ViewBag.monsters = db2.Monsters;
            return View();
        }

        //public ActionResult About()
        //{
            
        //    ViewBag.Message = "You chose poorly.";

        //    return View();
        //}

        //Fight page
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult About(int Fid, int Mid)
        {
            //if (ModelState.IsValid)
            //{


            //    ViewBag.fighter = db.Fighters.Add(fighter);
            //    //ViewBag.monster = db2.Monsters.Add(monster);
            //    //fists.Add(fighter);
            //    //fists.Add(monster);
            //    db.SaveChanges();
            //    db2.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //int ID = Fid;
            Fighter f = db.Fighters.Find(Fid);
            //ID = Mid;
            Monster m = db2.Monsters.Find(Mid);
            ViewBag.mon = m;
            ViewBag.fig = f;
            return View(f);
            //return View(fists);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}