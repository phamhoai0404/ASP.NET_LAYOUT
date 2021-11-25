using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutNhom8.Areas.Admin.Controllers
{
    public class TaikhoanController : Controller
    {
        // GET: Admin/Taikhoan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ThongtinDangnhap()
        {
            return View();
        }
    }
}