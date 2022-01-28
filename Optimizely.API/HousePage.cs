using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Optimizely.API
{
    [ContentType(GroupName = "Basic pages", Order = 1, DisplayName = "HousePage",
        GUID = "739479f3-9c5a-4261-8ab0-dd56aee7a8c9")]
    public class HousePage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Body",
            Description = "The main body for inserting for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(Order = 2, GroupName = SystemTabNames.Content)]
        public virtual House HouseBlock { get; set; }
    }
}