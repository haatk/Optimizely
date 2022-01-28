using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.PlugIn;
using EPiServer.Shell.ObjectEditing;
using Newtonsoft.Json;

namespace Optimizely.API
{
    [ContentType(GroupName = "Basic pages", Order = 1, DisplayName = "MultiHousePage",
        GUID = "b16ba170-0dc2-4f0d-9c27-0874087a345a")]
    public class MultiHousePage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Body",
            Description = "The main body for inserting for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(Order = 2, GroupName = SystemTabNames.Content)]
        [EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<House>))]
        public virtual IList<House> Houses { get; set; }
    }
    
    [PropertyDefinitionTypePlugIn]
    public class HouseProperty : PropertyList<House> { }
}