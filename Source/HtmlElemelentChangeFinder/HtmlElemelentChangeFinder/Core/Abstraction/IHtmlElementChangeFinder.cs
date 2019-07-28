using HtmlElemelentChangeFinder.Core.Model;

namespace HtmlElemelentChangeFinder.Core.Abstraction
{
    public interface IHtmlElementChangeFinder
    {
        ChangedHtmlElementResult GetChangedElement(string originalHtmlPath, string diffHtmlPath, string elementId);
    }
}
