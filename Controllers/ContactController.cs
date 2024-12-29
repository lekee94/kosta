using Microsoft.AspNetCore.Mvc;

namespace Kostic.Controllers;

public class ContactController : Controller
{
    [Route("contact")]
    public IActionResult Index()
    {
        return View("Contact");
    }
}