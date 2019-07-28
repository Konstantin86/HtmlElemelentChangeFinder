using System;

namespace HtmlElemelentChangeFinder.Core.Model
{
    public class ChangedHtmlElementResult
    {
        public string OuterHtml { get; set; }

        public string XPath { get; set; }

        public override string ToString()
        {
            return $"Potential changed element: {Environment.NewLine} {OuterHtml} {Environment.NewLine} Path: {XPath}";
        }
    }
}
