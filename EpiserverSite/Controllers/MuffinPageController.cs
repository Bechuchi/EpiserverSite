using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EpiserverSite.Models.Pages;

namespace EpiserverSite.Controllers
{
    public class MuffinPageController : PageControllerBase<MuffinPage>
    {
        public MuffinPageController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(MuffinPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}