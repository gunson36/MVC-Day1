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
        //public ActionResult MoneyList()
        //{
        //    var lstMoney = new List<Money>();
        //    for (int i = 0; i < 5; i++) { 
        //        lstMoney.Add(new Money
        //        {
        //            seqno = 1 + i,
        //            category = "支出",
        //            amount = 100 * i,
        //            date = DateTime.Now.AddDays(1 * i),
        //            remark = "鉛筆"
        //        });
        //    }
        //    return View(lstMoney);
        //}
        public ActionResult MoneyList()
        {
            var modelView = new List<Money>();
            for (int i = 0; i < 5; i++)
            {
                modelView.Add(new Money
                {
                    seqno = 1 + i,
                    category = "支出",
                    amount = 100 * i + 2,
                    date = DateTime.Now.AddDays(1 * i),
                    remark = "鉛筆"
                });
            }
            return View(modelView);
        }

    }
}