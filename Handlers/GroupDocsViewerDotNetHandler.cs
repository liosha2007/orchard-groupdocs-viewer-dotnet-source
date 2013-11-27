using GroupDocsViewerDotNet.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocsViewerDotNet.Handlers
{
    public class GroupDocsViewerDotNetHandler : ContentHandler
    {
        public GroupDocsViewerDotNetHandler(IRepository<GroupDocsViewerDotNetRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}