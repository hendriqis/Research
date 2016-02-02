using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PivotReporting.Model
{
    public class TemplateGroup
    {
        public string TemplateGroupCode { get; set; }
        public string TemplateGroupName { get; set; }
        public string Remarks { get; set; }
        public bool IsEnabled { get; set; }
    }

    public class Template
    {
        public string TemplateGroupCode { get; set; }
        public string TemplateCode { get; set; }
        public string TemplateName { get; set; }
        public string ControlName { get; set; }
        public string MethodName { get; set; }
        public bool IsEnabled { get; set; }
        public string TemplateRemarks { get; set; }
    }
}
