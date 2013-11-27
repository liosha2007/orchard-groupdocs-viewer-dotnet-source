using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using GroupDocsViewerDotNet.Models;

namespace GroupDocsViewerDotNet {
    public class Migrations : DataMigrationImpl {

        public int Create() {
            // Creating table GroupDocsViewerDotNetRecord
            SchemaBuilder.CreateTable(typeof(GroupDocsViewerDotNetRecord).Name, table => table
                .ContentPartRecord()
                .Column<string>("Url", column => column.WithLength(256))
                .Column<string>("Width", column => column.WithLength(10))
                .Column<string>("Height", column => column.WithLength(10))
                .Column<string>("DefaultFileName", column => column.WithLength(256))
                .Column<bool>("UseHttpHandlers", column => column.WithDefault(true))
            );

            ContentDefinitionManager.AlterPartDefinition(
                typeof(GroupDocsViewerDotNetPart).Name, cfg => cfg.Attachable());

            return 1;
        }
    }
}