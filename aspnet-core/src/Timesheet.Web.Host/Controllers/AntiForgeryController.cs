using Microsoft.AspNetCore.Antiforgery;
using Timesheet.Controllers;

namespace Timesheet.Web.Host.Controllers
{
    public class AntiForgeryController : TimesheetControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
