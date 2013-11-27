using GroupDocsViewerDotNet.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocsViewerDotNet.Drivers
{
    public class GroupDocsViewerDotNetDriver : ContentPartDriver<GroupDocsViewerDotNetPart>
    {
        protected override DriverResult Display(
            GroupDocsViewerDotNetPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_GroupDocsViewerDotNet",
                () => shapeHelper.Parts_GroupDocsViewerDotNet(
                    Url: part.Url,
                    Width: part.Width == null || part.Width.Length == 0 ? "100%" : part.Width,
                    Height: part.Height == null || part.Height.Length == 0 ? "600px" : part.Height,
                    DefaultFileName: part.DefaultFileName,
                    UseHttpHandlers: part.UseHttpHandlers == null ? true : part.UseHttpHandlers
                    ));
        }

        //GET
        protected override DriverResult Editor(GroupDocsViewerDotNetPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_GroupDocsViewerDotNet_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/GroupDocsViewerDotNet",
                    Model: part,
                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(
            GroupDocsViewerDotNetPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}