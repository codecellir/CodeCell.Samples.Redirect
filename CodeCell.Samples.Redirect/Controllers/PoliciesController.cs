using Microsoft.AspNetCore.Mvc;

namespace CodeCell.Samples.Redirect.Controllers
{
    public class PoliciesController : Controller
    {
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}
