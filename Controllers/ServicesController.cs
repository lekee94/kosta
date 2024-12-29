using Microsoft.AspNetCore.Mvc;

namespace Kostic.Controllers;

public class ServicesController : Controller
{
    [Route("services")]
    public IActionResult Index()
    {
        return View("Services");
    }
}

public class WebDevelopmentController : Controller
{
    [Route("web-development")]
    public IActionResult Index()
    {
        return View("WebDevelopment");
    }
}