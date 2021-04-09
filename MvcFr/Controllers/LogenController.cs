using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFr.Models;
using MvcFr.ViewModels;

namespace MvcFr.Controllers
{
    public class LogenController : Controller
    {
        // GET: Logen
        public ActionResult Index()
        {
                    return View();
           
        }
        public ActionResult Login()
        {

            string user = Request["user"].Trim().ToString();
            string pwd = Request["pwd"].Trim().ToString();
            using (Student3 db = new Student3())
            {
                #region 导航关系实现lambda
                logen list = db.logen.SingleOrDefault(s => s.loge == user);
                if (list != null)
                {
                    if (list.pwd == pwd)
                    {
                        return Redirect("~/student/index");
                    }
                    else
                    {
                        ViewBag.Error = "密码错误";
                        return View("Index");
                    }
                }
                else
                {
                    ViewBag.Error = "用户不存在";
                    return View("Index");
                }

                #endregion
            }

        }
    }
}