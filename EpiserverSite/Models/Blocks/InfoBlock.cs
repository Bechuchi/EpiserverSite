using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverSite.Models.Blocks
{
    [ContentType(DisplayName = "InfoBlock", GUID = "019d8aa6-059f-40b9-88d2-873becf8b31e", Description = "")]
    public class InfoBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Info block",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string InfoText { get; set; }



    }
}