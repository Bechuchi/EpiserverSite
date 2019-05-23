using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EpiserverSite.Models.ViewModels;

namespace EpiserverSite.Models.Pages
{
    [ContentType(DisplayName = "Start",
                 GUID = "bc4cc5c5-5885-4205-8e4c-1596abae66dd",
                 Description = "The home page for a website with an area for blocks and partial pages.",
                 GroupName = SiteGroupNames.Specialized,
                 Order = 10)]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Heading",
                 Description = "If the Heading is not set, the page falls back to showing the Name.",
                 GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer address",
                 Description = "The footer text will be shown at the bottom of every page.",
                 GroupName = SiteTabNames.SiteSettings,
                 Order = 10)]
        public virtual string FooterAddress { get; set; }
        [CultureSpecific]
        [Display(Name = "Footer opening hours",
                 Description = "The footer text will be shown at the bottom of every page.",
                 GroupName = SiteTabNames.SiteSettings,
                 Order = 10)]
        public virtual string FooterOpeningHours { get; set; }

        [CultureSpecific]
        [Display(Name = "Main content area",
                 Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
                 GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea MainContentArea { get; set; }
    }
}