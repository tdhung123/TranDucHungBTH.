using Microsoft.AspNetCore.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class PersonController : Controller
    {
         public IActionResult nguoit()
         {
       List<Person> psList = new List<Person>()
       
            {
                new Person{ ten="Đức Hùng", tuoi=22, ngaysinh= 2001},
                new Person{ ten="Đức Hùng", tuoi=22, ngaysinh= 2001},
               


            };
          ViewData["Person"]= psList;
    
            return View();
    }    


     

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