using dethi1920.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dethi1920.Controllers
{
    public class DiemCachLyController : Controller
    {
        
        public IActionResult ThemCachLy()
        {
            return View();
        }

        [HttpPost]
        public string AddCL(DiemCachLyModel d)
        {
            int count;
            DataContext context = HttpContext.RequestServices.GetService(typeof(dethi1920.Models.DataContext)) as DataContext;
            count = context.Create(d);
            if (count == 1)
            {
                return "Thêm Thành Công!";
            }
            return "Thêm thất bại";
        }
        public IActionResult ListDiemCachLy()
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(dethi1920.Models.DataContext)) as DataContext;
            return View(context.getDiemCachLy());
        }

            [HttpPost]
        public IActionResult LietKe(string madiemcachly)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(dethi1920.Models.DataContext)) as DataContext;
            return View(context.getCNCL(madiemcachly));
        }
        public IActionResult Delete(string macongnhan, CongNhanModel c)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(dethi1920.Models.DataContext)) as DataContext;
            if (context.DeleteCN(macongnhan, c) != 0)
            {
                return Redirect("/DiemCachly/ListDiemCachLy");
            }
            return Redirect("/DiemCachly/ListDiemCachLy");
        }
        public IActionResult View(string macongnhan)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(dethi1920.Models.DataContext)) as DataContext;
           
            return View(context.getCN(macongnhan));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult View(CongNhanModel sp, string macongnhan)
        {
            int count = 0;
            DataContext context = HttpContext.RequestServices.GetService(typeof(dethi1920.Models.DataContext)) as DataContext;
            count = context.DetailCN( sp, macongnhan);
            if (count != 0)
            {
                return Redirect("/DiemCachly/ListDiemCachLy");
            }
            return Redirect("/DiemCachly/ListDiemCachLy");
        }

    }
}

