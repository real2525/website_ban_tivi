using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanweb.Models;

namespace doanweb.Controllers
{
    public class Admin_QLLICHSUController : Controller
    {
        WebSiteBanTiviEntities db = new WebSiteBanTiviEntities();
        public ActionResult LichSuQuanLyNguoiDung()
        {
            var lstnd = db.tbl_Hmember.OrderByDescending(n=>n.Id).ToList();
            return View(lstnd);
        }

        public ActionResult LichSuQuanLyGioHang()
        {
            var lstgh = db.tbl_Hgiohang.OrderByDescending(n => n.Id).ToList();
            return View(lstgh);
        }

    }
}
