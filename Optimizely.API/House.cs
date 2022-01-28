using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Optimizely.API
{
    [ContentType(DisplayName = "House Block", Description = "Block for houses")]
    public class House : BlockData
    {
        [Display(
           Name = "House Name",
           Description = "",
           GroupName = SystemTabNames.Content,
           Order = 1)]
       public virtual string Name { get; set; }
 
 
       [Display(
           Name = "House year",
           Description = "",
           GroupName = SystemTabNames.Content,
           Order = 2)]
       public virtual int ImageDescription { get; set; }
    }
}