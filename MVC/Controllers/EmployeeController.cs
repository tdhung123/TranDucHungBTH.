using Microsoft.AspNetCore.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
    


     

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