using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverSite.Models.Blocks
{
    [ContentType(DisplayName = "Listing",
                 GUID = "3729d596-42e7-47e9-9dd7-89fb999fe93d",
                 Description = "Choose a page in the tree, and its children will be listed, with a heading.")]
    public class ListingBlock : BlockData
    {
        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }

        [Display(Name = "Show children of this page", Order = 20)]
        public virtual PageReference ShowChildrenOfThisPage { get; set; }
    }
}