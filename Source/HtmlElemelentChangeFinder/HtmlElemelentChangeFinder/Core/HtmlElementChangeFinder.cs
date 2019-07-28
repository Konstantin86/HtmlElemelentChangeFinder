using HtmlAgilityPack;
using HtmlElemelentChangeFinder.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlElemelentChangeFinder.Core
{
    public class HtmlElementChangeFinder : IHtmlElementChangeFinder
    {
        public string GetChangedElementPath(string originalHtmlPath, string diffHtmlPath, string elementId)
        {
            var originalHtml = new HtmlDocument();
            originalHtml.Load(originalHtmlPath);

            var originalElement = originalHtml.GetElementbyId(elementId);

            string changedElementPath = string.Empty;

            return changedElementPath;
        }
    }
}
