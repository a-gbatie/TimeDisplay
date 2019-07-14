using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay {

    public class HomeController: Controller {

        [HttpGet("")]
        public IActionResult Index() => View();
    }
}