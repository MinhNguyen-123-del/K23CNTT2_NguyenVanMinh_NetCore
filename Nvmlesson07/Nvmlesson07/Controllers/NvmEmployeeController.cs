using Microsoft.AspNetCore.Mvc;
using Nvmlesson07.Models;
using System;
using System.Collections.Generic;

namespace Nvmlesson07.Controllers
{
    public class NvmEmployeeController : Controller
    {
        // Danh sách mẫu 5 nhân viên
        private static List<NvmEmployee> nvmListEmployee = new List<NvmEmployee>()
        {
            new NvmEmployee
            {
                NvmId = "2310900068",
                NvmName = "Nguyễn Văn Minh",
                NvmBirthday = new DateTime(2005, 7, 3),
                NvmEmail = "vanminhham0896742531@gmail.com",
                NvmPhone = "0387853601",
                NvmSalary = 15000000,
                NvmStatus = true
            },
            new NvmEmployee
            {
                NvmId = "NV002",
                NvmName = "Trần Thị Lan",
                NvmBirthday = new DateTime(1998, 3, 12),
                NvmEmail = "lan.tran@example.com",
                NvmPhone = "0923456789",
                NvmSalary = 16000000,
                NvmStatus = true
            },
            new NvmEmployee
            {
                NvmId = "NV003",
                NvmName = "Lê Văn An",
                NvmBirthday = new DateTime(1995, 11, 5),
                NvmEmail = "an.le@example.com",
                NvmPhone = "0934567890",
                NvmSalary = 14500000,
                NvmStatus = false
            },
            new NvmEmployee
            {
                NvmId = "NV004",
                NvmName = "Phạm Thị Hương",
                NvmBirthday = new DateTime(1990, 6, 21),
                NvmEmail = "huong.pham@example.com",
                NvmPhone = "0945678901",
                NvmSalary = 17500000,
                NvmStatus = true
            },
            new NvmEmployee
            {
                NvmId = "NV005",
                NvmName = "Đỗ Minh Tuấn",
                NvmBirthday = new DateTime(2005, 1, 17),
                NvmEmail = "tuan.do@example.com",
                NvmPhone = "0956789012",
                NvmSalary = 18000000,
                NvmStatus = false
            }
        };

        // GET: Hiển thị danh sách nhân viên
        public IActionResult NvmIndex()
        {
            return View(nvmListEmployee);
        }
        public IActionResult NvmDetails(string id)
        {
            var nvmEmployee = nvmListEmployee.FirstOrDefault(x => x.NvmId == id);
            return View(nvmEmployee);
        }
        // GET: Form tạo mới nhân viên
        public IActionResult NvmCreate()
        {
            return View();
        }

        // POST: Thêm mới nhân viên vào danh sách
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NvmCreate(NvmEmployee nvmModel)
        {
            try
            {
                nvmModel.NvmId=nvmListEmployee.Max(x=>x.NvmId)+1;
                nvmListEmployee.Add(nvmModel); // thêm vào danh sách
                return RedirectToAction(nameof(NvmIndex)); // trở về trang danh sách
            }
            catch
            {
                return View();
            }
        }
        // GET: NvmEmployeeController/NvmEdit/5
        public ActionResult NvmEdit(string id)
        {
            var nvmEmployee = nvmListEmployee.FirstOrDefault(x => x.NvmId == id);
            return View(nvmEmployee);
        }

        // POST: NvmEmployeeController/NvmEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvmEdit(string id, NvmEmployee nvmModel)
        {
            try
            {
                for (int i = 0; i < nvmListEmployee.Count(); i++)
                    {
                    if (nvmListEmployee[i].NvmId==id)
                    {
                        nvmListEmployee[i] = nvmModel;
                        break;
                    }    
                }
                return RedirectToAction(nameof(NvmIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NvmEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NvmEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, NvmEmployee nvmModel)
        {
            try
            {

                return RedirectToAction(nameof(NvmIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}

