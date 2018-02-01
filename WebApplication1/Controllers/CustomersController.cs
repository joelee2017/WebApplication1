using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomersController : Controller
    {
        NorthwindEntities dc = new NorthwindEntities();
        //網頁無狀態所以，放外層較不影響之後結果

        // GET: Customers
        public ActionResult Index()
        {
                      return View(dc.Customers);
        }

        public ActionResult Details(string CustomerID)
        {
            Customers c = dc.Customers.Find(CustomerID);
            if (c == null)
            {
                return HttpNotFound(); //錯誤時404
            }
            return View(c);
        }
    }
}