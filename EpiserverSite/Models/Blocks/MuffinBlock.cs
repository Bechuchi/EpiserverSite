using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverSite.Models.Blocks
{
    [ContentType(DisplayName = "MuffinBlock", GUID = "a79505a1-35ce-44bb-9a5e-3dcc70d34637", Description = "")]
    public class MuffinBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Name { get; set; }
    }
}