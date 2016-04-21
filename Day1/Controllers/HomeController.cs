using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1.Models;

namespace Day1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MoneyList()
        {
            var modelView = new List<Money>();

            using (var db = new SkillTreeHomeworkEntities())
            {
                modelView = (from a in db.AccountBook
                             where a.Remarkkk.Length < 10
                             orderby a.Dateee descending
                             select new Money
                             {
                                 id = a.Id.ToString(),
                                 amount =a.Amounttt,
                                 category = a.Categoryyy ,
                                 remark= a.Remarkkk
                             }                            
                    ).Take(5).ToList();
                //foreach (AccountBook a in ab)
                //{
                //    modelView.Add(new Money
                //    {
                //        id= a.Id.ToString(),
                //        category = a.Categoryyy == 0 ? "支出" : (a.Categoryyy == 1 ? "收入" : a.Categoryyy.ToString()),
                //        amount = a.Amounttt,
                //        date = a.Dateee,
                //        remark = a.Remarkkk
                //    });
                //}
            }
            return View(modelView);
        }

    }
}