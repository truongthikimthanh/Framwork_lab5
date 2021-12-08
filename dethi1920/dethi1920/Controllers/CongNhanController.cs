using dethi1920.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dethi1920.Controllers
{
    public class CongNhanController : Controller
    {
        
        public IActionResult LieTKeCongNhanTheoSoLan()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ListByTime(int solan)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(dethi1920.Models.DataContext)) as DataContext;
            return View(context.getCongNhan(solan));
        }

       
    }
}
