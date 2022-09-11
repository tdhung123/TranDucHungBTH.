using Microsoft.AspNetCore.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class PersonController : Controller
    {
    


     

        [HttpGet]
        public IActionResult nguoi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult nguoi(Person std)
        {
            ViewBag.nguoi ="Họ và tên:"+ std.ten+"-"+"Giới tính:"+ std.tuoi+"tuổi:"+ std.ngaysinh;
            return View();
        }
    }
}