using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bll;
using Model;

namespace Week1.MVC.Controllers
{
    public class HuiyiController : Controller
    {
        HuiyiBll bll = new HuiyiBll();
        // GET: Huiyi
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public JsonResult Adds(Huiyi h)
        {
            return Json(bll.Add(h));
        }
        public JsonResult Didian()
        {
            return Json(bll.didians(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Canhuizhe()
        {
            return Json(bll.canhuizhes(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Show()
        {
            return View();
        }
        public JsonResult Shows()
        {
            return Json(bll.huiyis(), JsonRequestBehavior.AllowGet);
        }
    }
}