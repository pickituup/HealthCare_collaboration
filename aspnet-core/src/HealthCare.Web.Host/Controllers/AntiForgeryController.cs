using Microsoft.AspNetCore.Antiforgery;
using HealthCare.Controllers;

namespace HealthCare.Web.Host.Controllers
{
    public class AntiForgeryController : HealthCareControllerBase
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
