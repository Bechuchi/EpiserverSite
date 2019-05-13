using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverSite.Models.Media
{
    [ContentType(DisplayName = "Any File",
                 GUID = "9ab46fcb-c114-49d0-86f6-882512e5ccfa",
                 Description = "Use this to upload any type of file.")]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class AnyFile : MediaData
    {
        
    }
}