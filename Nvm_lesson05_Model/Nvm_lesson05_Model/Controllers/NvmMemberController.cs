using Microsoft.AspNetCore.Mvc;
using Nvm_lesson05_Model.Models.DataModels;

namespace Nvm_lesson05_Model.Controllers
{
    public class NvmMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NvmGetMember()
        {
            var nvmMember = new NvmMember();
            nvmMember.NvmMemberID=Guid.NewGuid().ToString();
            nvmMember.NvmUserName = "Minh Xinh";
            nvmMember.NvmFullName = "Văn Minh";
            nvmMember.NvmPassWord = "0001sdasd";
            nvmMember.NvmEmail = "vanminhham0896745231@gmail.com";

            ViewBag.nvmMember=nvmMember;
            return View();
        }
    }
}
