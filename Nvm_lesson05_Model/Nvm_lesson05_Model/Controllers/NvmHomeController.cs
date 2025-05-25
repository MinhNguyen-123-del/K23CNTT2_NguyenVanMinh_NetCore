using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nvm_lesson05_Model.Models;

namespace Nvm_lesson05_Model.Controllers
{
    public class NvmHomeController : Controller
    {
        private readonly ILogger<NvmHomeController> _logger;

        public NvmHomeController(ILogger<NvmHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NvmIndex()
        {
            return View();
        }

        public IActionResult NvmAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
