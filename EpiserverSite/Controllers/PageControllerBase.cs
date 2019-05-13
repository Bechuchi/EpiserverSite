
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using EpiserverSite.Business.ExtensionMethods;
using EpiserverSite.Models.Pages;
using EpiserverSite.Models.ViewModels;
using EPiServer.Filters;
using System.Web.Security;


namespace EpiserverSite.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        protected readonly IContentLoader loader;

        public PageControllerBase(IContentLoader loader)
        {
            this.loader = loader;
        }

        //TODO: Kolla vad den gör
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index");
        }

        //TODO: Jämföra med Haglunds
        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(TPage currentPage) where TPage : SitePageData
        {
            var viewModel = PageViewModel.Create(currentPage);

            viewModel.StartPage = loader.Get<StartPage>(ContentReference.StartPage);
            //FilterForVisitorn tar bort opubliserade pages + sidor som användaren inte har access till
            viewModel.MenuPages = FilterForVisitor.Filter(loader.GetChildren<SitePageData>(ContentReference.StartPage))
                .Cast<SitePageData>()
                .Where(page => page.VisibleInMenu);

            viewModel.Section = currentPage.ContentLink.GetSection();

            return viewModel;
        }
    }
}