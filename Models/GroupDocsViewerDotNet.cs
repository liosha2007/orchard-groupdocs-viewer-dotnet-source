using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupDocsViewerDotNet.Models
{
    public class GroupDocsViewerDotNetRecord : ContentPartRecord
    {
        public virtual String Url { get; set; }
        public virtual String Width { get; set; }
        public virtual String Height { get; set; }
        public virtual String DefaultFileName { get; set; }
        public virtual bool UseHttpHandlers { get; set; }
    }

    public class GroupDocsViewerDotNetPart : ContentPart<GroupDocsViewerDotNetRecord>
    {

        [Required]
        [DisplayName("Viewer Url")]
        public String Url
        {
            get { return Record.Url; }
            set { Record.Url = value; }
        }

        [Required]
        [DisplayName("Viewer Width")]
        public String Width
        {
            get { return Record.Width; }
            set { Record.Width = value; }
        }

        [Required]
        [DisplayName("Viewer Height")]
        public String Height
        {
            get { return Record.Height; }
            set { Record.Height = value; }
        }

        [DisplayName("Default file name")]
        public String DefaultFileName
        {
            get { return Record.DefaultFileName; }
            set { Record.DefaultFileName = value; }
        }

        [Required]
        [DisplayName("Use Http Handlers")]
        public bool UseHttpHandlers
        {
            get { return Record.UseHttpHandlers; }
            set { Record.UseHttpHandlers = value; }
        }
    }
}