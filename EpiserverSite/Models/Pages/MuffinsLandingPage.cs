using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EpiserverSite.Models.Blocks;

namespace EpiserverSite.Models.Pages
{
    [ContentType(DisplayName = "Muffins landing",
                 GUID = "2169c083-7c5a-420d-a7da-26dd8f679545",
                 Description = "Use this as a page for a list of news muffins")]
    public class MuffinsLandingPage : StandardPage
    {
        [Display(Name = "News listing", Order = 315)]
        public virtual ListingBlock MuffinsListing { get; set; }
    }
}