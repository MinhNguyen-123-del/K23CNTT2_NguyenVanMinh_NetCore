using Microsoft.AspNetCore.Mvc;
using NvmLab06.Models;
using System.Collections.Generic;

namespace NvmLab06.Controllers
{
    public class NvmEmployeeController : Controller
    {
        // Khởi tạo danh sách nhân viên mẫu
        private static List<NvmEmployee> nvmListEmployee = new List<NvmEmployee>
        {
            new NvmEmployee
            {
                NvmId = "2310900068",
                NvmName = "Nguyễn Văn Minh",
                NvmBirthday = new DateTime(2005, 7, 3),
                NvmEmail = "vana@example.com",
                NvmPhone = "0123456789",
                NvmSalary = 15000000,
                NvmStatus = true
            },
            new NvmEmployee
            {
                NvmId = "NV002",
                NvmName = "Trần Thị B",
                NvmBirthday = new DateTime(1992, 5, 10),
                NvmEmail = "thib@example.com",
                NvmPhone = "0987654321",
                NvmSalary = 17000000,
                NvmStatus = false
            }
        };

        public IActionResult NvmIndex()
        {
            // Truyền danh sách nhân viên sang View
            return View(nvmListEmployee);
        }
        // Hiển thị form tạo mới nhân viên (GET)
        [HttpGet]
        public IActionResult NvmCreate()
        {
            return View();
        }

        // Xử lý dữ liệu khi người dùng submit form (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NvmCreate(NvmEmployee employee)
        {
            if (ModelState.IsValid)
            {
                // Thêm nhân viên mới vào danh sách
                nvmListEmployee.Add(employee);

                // Chuyển hướng về trang danh sách
                return RedirectToAction("NvmIndex");
            }

            // Nếu dữ liệu không hợp lệ, trả lại form
            return View(employee);
        }


        public IActionResult NvmEdit(string id)
        {
            var emp = nvmListEmployee.FirstOrDefault(e => e.NvmId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        // POST: Xử lý cập nhật thông tin
        [HttpPost]
        public IActionResult NvmEdit(NvmEmployee updatedEmp)
        {
            var emp = nvmListEmployee.FirstOrDefault(e => e.NvmId == updatedEmp.NvmId);
            if (emp != null)
            {
                emp.NvmName = updatedEmp.NvmName;
                emp.NvmBirthday = updatedEmp.NvmBirthday;
                emp.NvmEmail = updatedEmp.NvmEmail;
                emp.NvmPhone = updatedEmp.NvmPhone;
                emp.NvmSalary = updatedEmp.NvmSalary;
                emp.NvmStatus = updatedEmp.NvmStatus;
                return RedirectToAction("NvmIndex");
            }
            return View(updatedEmp);
        }
       
        public IActionResult NvmDelete(string id)
        {
            var emp = nvmListEmployee.FirstOrDefault(e => e.NvmId == id);
            if (emp != null)
            {
                nvmListEmployee.Remove(emp);
            }
            return RedirectToAction("NvmIndex");
        }


    }
}
