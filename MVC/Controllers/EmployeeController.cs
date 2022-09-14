using Microsoft.AspNetCore.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
         
         public IActionResult nhanvient()
         {
       List<Employee> ptList = new List<Employee>()
       
            {
                new Employee{ nhanvien="Đức Hùng", gioitinh="Nam" , tuoi=22},
               
               


            };
          ViewData["Employee"]= ptList;
    
            return View();
    }    
    


     

        [HttpGet]
        public IActionResult nhanvien()
        {
            return View();
        }
        [HttpPost]
        public IActionResult nhanvien(Employee std)
        {
            ViewBag.nhanvien ="Họ và tên:"+ std.nhanvien;
            ViewBag.d="Giới tính:"+ std.gioitinh;
            ViewBag.c="tuổi:"+ std.tuoi;
            return View();
        }
    }
}