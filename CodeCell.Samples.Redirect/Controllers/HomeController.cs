using CodeCell.Samples.Redirect.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeCell.Samples.Redirect.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return Redirect("~/Policies/PrivacyPolicy");
            //return RedirectPermanent("~/Policies/PrivacyPolicy");
            //return RedirectPreserveMethod("~/Policies/PrivacyPolicy");
            //return RedirectPermanentPreserveMethod("~/Policies/PrivacyPolicy");

            //return RedirectToAction("PrivacyPolicy", "Policies");
            //return RedirectToActionPermanent("PrivacyPolicy", "Policies");
            //return RedirectToActionPreserveMethod("PrivacyPolicy", "Policies");
            //return RedirectToActionPermanentPreserveMethod("PrivacyPolicy", "Policies");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}