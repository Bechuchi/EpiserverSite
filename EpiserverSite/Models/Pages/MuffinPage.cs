using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite.Models.Pages
{
    [ContentType(DisplayName = "Muffin",
                 GroupName = SiteGroupNames.Specialized,
                 Order = 20,
                 Description = "Use this for muffins than Makin' Bakin' sells.")]
    public class MuffinPage : StandardPage
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
        }

        [CultureSpecific]
        [Display(
            Name = "Muffin name",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string MuffinName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Muffin description",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string MuffinDescription { get; set; }

        [CultureSpecific]
        [Display(Name = "Main content area",
         Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
         GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea MainContentArea { get; set; }
    }
}