using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlElemelentChangeFinder.Core.Abstraction
{
    public interface IHtmlElementChangeFinder
    {
        string GetChangedElementPath(string originalHtmlPath, string diffHtmlPath, string elementId);
    }
}
