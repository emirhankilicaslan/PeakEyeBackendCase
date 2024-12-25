using Microsoft.AspNetCore.Mvc;

namespace PeakEyeBackendCase.Controllers;

public class LoginController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}