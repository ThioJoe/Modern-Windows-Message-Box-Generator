using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Task_Dialog_Generator
{
    public class TaskDialogPreset
    {
        public required string Title { get; set; }
        public required string Heading { get; set; }
        public required string Message { get; set; }
        public required string Footer { get; set; }
        public required string ExpandedInfo { get; set; }
        public required bool ShowVerification { get; set; }
        public required string VerificationMessage { get; set; }
        public required MessageBoxButtons Buttons { get; set; }
        public required string CustomIconDLLPath { get; set; }
        public required string CustomMainIconPath { get; set; }
        public required string CustomTitleIconPath { get; set; }
        public required int CustomMainIconID { get; set; }
        public required int CustomTitleIconID { get; set; }
    }
}
