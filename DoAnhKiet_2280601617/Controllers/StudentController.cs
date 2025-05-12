using Microsoft.AspNetCore.Mvc;
using DoAnhKiet_2280601617.Models;
namespace DoAnhKiet_2280601617.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> studentlist = new List<Student>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowKQ(Student student)
        {
            studentlist.Add(student);

            int sameMajorCount = studentlist.Count(s => s.ChuyenNganh == student.ChuyenNganh);

            ViewBag.Id = student.Id;
            ViewBag.Name = student.Name;
            ViewBag.ChuyenNganh = student.ChuyenNganh;
            ViewBag.SoLuong = sameMajorCount;

            return View();
        }
    }
}
