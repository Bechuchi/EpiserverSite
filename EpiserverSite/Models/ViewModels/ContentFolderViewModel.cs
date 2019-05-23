using EPiServer.Core;

namespace EpiserverSite.Models.ViewModels
{
    public class ContentFolderViewModel
    {
        public ContentFolder CurrentFolder { get; set; }
        public int ItemsCount { get; set; }
    }
}