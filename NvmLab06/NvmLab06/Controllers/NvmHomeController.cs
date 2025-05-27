using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NvmLab06.Models;

namespace NvmLab06.Controllers
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

        public IActionResult NVmAbout()
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
