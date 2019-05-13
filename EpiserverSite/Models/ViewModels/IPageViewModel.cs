using EpiserverSite.Models.Pages;
using System;
using System.Collections.Generic;
using EPiServer.Core;
using System.Collections.Generic;

namespace EpiserverSite.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        StartPage StartPage { get; }
        IEnumerable<SitePageData> MenuPages { get; }
        IContent Section { get; }

        //TODO: Jämför Haglunds (han har topPages exempel)
    }
}
