using Microsoft.AspNetCore.Mvc;

namespace Kostic.Controllers;

public class AboutController : Controller
{
    [Route("about")]
    public IActionResult Index()
    {
        return View("About");
    }
}