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

        //TODO: add image as property
    }
}