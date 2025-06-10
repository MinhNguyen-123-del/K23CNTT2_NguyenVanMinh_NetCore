using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NvmCoreMVCLab08.Models;

namespace NvmCoreMVCLab08.Controllers
{
    public class NvmAccountController : Controller
    {
        // ✅ GET: NvmAccountController
        public ActionResult NvmIndex()
        {
            var employees = new List<NvmEmployee>
            {
                new NvmEmployee
                {
                    Id = 1,
                    NvmFullName = "Nguyễn Văn Minh",
                    NvmEmail = "a@gmail.com",
                    NvmPhone = "0387853601",
                    NvmAddress = "Hà Nội",
                    NvmAvatar = "/images/avatar1.jpg",
                    NvmBirthday = new DateTime(2005, 7, 3),
                    NvmGender = "Nam",
                    NvmPassword = "pass123",
                    NvmFaceBook = "https://facebook.com/nguyenvana"
                },
                new NvmEmployee
                {
                    Id = 2,
                    NvmFullName = "Trần Thị B",
                    NvmEmail = "b@gmail.com",
                    NvmPhone = "0909234567",
                    NvmAddress = "TP HCM",
                    NvmAvatar = "/images/avatar2.jpg",
                    NvmBirthday = new DateTime(1997, 3, 15),
                    NvmGender = "Nữ",
                    NvmPassword = "123abc",
                    NvmFaceBook = "https://facebook.com/tranb"
                },
                new NvmEmployee
                {
                    Id = 3,
                    NvmFullName = "Lê Văn C",
                    NvmEmail = "c@gmail.com",
                    NvmPhone = "0909345678",
                    NvmAddress = "Đà Nẵng",
                    NvmAvatar = "/images/avatar3.jpg",
                    NvmBirthday = new DateTime(1990, 12, 1),
                    NvmGender = "Nam",
                    NvmPassword = "lepass",
                    NvmFaceBook = "https://facebook.com/levanc"
                },
                new NvmEmployee
                {
                    Id = 4,
                    NvmFullName = "Phạm Thị D",
                    NvmEmail = "d@gmail.com",
                    NvmPhone = "0911123456",
                    NvmAddress = "Huế",
                    NvmAvatar = "/images/avatar4.jpg",
                    NvmBirthday = new DateTime(1992, 8, 10),
                    NvmGender = "Nữ",
                    NvmPassword = "dpass456",
                    NvmFaceBook = "https://facebook.com/phamd"
                },
                new NvmEmployee
                {
                    Id = 5,
                    NvmFullName = "Đỗ Minh E",
                    NvmEmail = "e@gmail.com",
                    NvmPhone = "0922123456",
                    NvmAddress = "Cần Thơ",
                    NvmAvatar = "/images/avatar5.jpg",
                    NvmBirthday = new DateTime(1993, 1, 5),
                    NvmGender = "Nam",
                    NvmPassword = "emin123",
                    NvmFaceBook = "https://facebook.com/dominhe"
                }
            };

            return View(employees); // ✅ truyền danh sách vào View
        }

        // GET: NvmAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NvmAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NvmAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NvmAccountController/Edit/5
        public ActionResult NvmEdit(int id)
        {
            return View();
        }

        // POST: NvmAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NvmAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NvmAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
