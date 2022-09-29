using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Models.Process;

namespace MVC.Controllers
{
    public class ptController : Controller    
    {
        //khai bao class theo huong doi tuong
      //  GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
      
      public IActionResult Index ()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult Index(string heSoA, string heSoB)
      {
        // ep kieu du lieu cua tham so
        double a = Convert.ToDouble(heSoA);
        double b = Convert.ToDouble(heSoB);
        string thongBao =new GiaiPhuongTrinh().GiaiPhuongTrinhBacNhat(a, b);
        ViewBag.mess= thongBao ; 
        return View();
      }
       public IActionResult Create ()
      {
            return View();
      }
      [HttpPost]
      public IActionResult Create(string a, string b, string c)
      {
        double f = Convert.ToDouble(a);
        double d = Convert.ToDouble(b);
        double e = Convert.ToDouble(c);
        string thongBao =new GiaiPhuongTrinh().GiaiPhuongTrinhBacHai( f,d,e );
        ViewBag.thongBao=thongBao;
        return View();
        }
      }
    }