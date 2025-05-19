using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLesson03.Models;

namespace NetCoreMVCLesson03.Controllers
{
    public class NvmBookController : Controller
    {
        private List<NvmBook> NvmBooks = new List<NvmBook>
        {
            new NvmBook
            {
                NvmId = 1,
                NvmTitle = "Lập Trình C# Cơ Bản",
                NvmDescription = "Cuốn sách dành cho người mới bắt đầu học lập trình C#.",
                NvmImages = "images/book-1.jpg",
                NvmPrice = 129000f,
                NvmPage = 250
            },
            new NvmBook
            {
                NvmId = 2,
                NvmTitle = "Học SQL Trong 7 Ngày",
                NvmDescription = "Hướng dẫn sử dụng SQL để truy vấn và quản lý cơ sở dữ liệu.",
                NvmImages = "images/book-2.jpg",
                NvmPrice = 99000f,
                NvmPage = 200
            },
            new NvmBook
            {
                NvmId = 3,
                NvmTitle = "Clean Code - Code Sạch",
                NvmDescription = "Nguyên tắc và phương pháp viết code sạch và dễ bảo trì.",
                NvmImages = "images/book-3.jpg",
                NvmPrice = 159000f,
                NvmPage = 300
            },
            new NvmBook
            {
                NvmId = 4,
                NvmTitle = "Thuật Toán Và Cấu Trúc Dữ Liệu",
                NvmDescription = "Kiến thức cơ bản và nâng cao về thuật toán và cấu trúc dữ liệu.",
                NvmImages = "images/book-4.jpg",
                NvmPrice = 175000f,
                NvmPage = 350
            },
            new NvmBook
            {
                NvmId = 5,
                NvmTitle = "Phát Triển Web Với ASP.NET Core",
                NvmDescription = "Hướng dẫn xây dựng website với công nghệ ASP.NET Core.",
                NvmImages = "images/book-5.jpg",
                NvmPrice = 189000f,
                NvmPage = 400
            }
        };

        // GET: NvmBook/NvmIndex
        public IActionResult NvmIndex()
        {
            //ĐƯa dữ liệu lên view

            return View(NvmBooks); // Truyền danh sách sang View
        }
        // GET: NvmBook/NvmCreate
        public IActionResult NvmCreate()
        {
            NvmBook nvmBook = new NvmBook();

            return View(nvmBook); 
        }
        // Post: NvmBook/NvmCreate
        public IActionResult NvmCreateSubmit()
        {

            return RedirectToAction("NvmIndex");
        }
        // GET: NvmBook/NvmEdit
        public IActionResult NvmEdit(string id)
        {

            return View();
        }
        // GET: NvmBook/NvmEditSubmit
        public IActionResult NvmEditSubmit()
        {

            return RedirectToAction("NvmIndex");
        }
    }
}
