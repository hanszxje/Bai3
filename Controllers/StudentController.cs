using Microsoft.AspNetCore.Mvc;

namespace buoi3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ShowKQ(string MSSV, string HoTen, float DiemTB, string ChuyenNganh)
        {
            danhSachSV.Add(new Student { MSSV = MSSV, HoTen = HoTen, DiemTB = DiemTB, ChuyenNganh = ChuyenNganh });
            int soLuong = danhSachSV.Count(s => s.ChuyenNganh == ChuyenNganh);
            ViewBag.MSSV = MSSV;
            ViewBag.HoTen = HoTen;
            ViewBag.DiemTB = DiemTB;
            ViewBag.ChuyenNganh = ChuyenNganh;
            ViewBag.SoLuong = soLuong;

            return View();
        }
        private static List<Student> danhSachSV = new List<Student>();

        public class Student
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public float DiemTB { get; set; }
            public string ChuyenNganh { get; set; }
        }
    }
}
