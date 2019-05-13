using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSite.Models.Media
{
    [ContentType(DisplayName = "ImageFile",
                 GUID = "56357916-25e4-4635-9fdb-6001554b6e01",
                 Description = "Use this to upload image files")]
    [MediaDescriptor(ExtensionString = "png, gif, jpg, jpeg")]
    public class ImageFile : ImageData
    {
        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }

    }
}