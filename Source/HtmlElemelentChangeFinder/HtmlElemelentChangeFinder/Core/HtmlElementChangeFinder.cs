using HtmlAgilityPack;
using HtmlElemelentChangeFinder.Core.Abstraction;
using HtmlElemelentChangeFinder.Core.Model;
using Utilities;
using Core.Model;
using System.Linq;

namespace HtmlElemelentChangeFinder.Core
{
    public class HtmlElementChangeFinder : IHtmlElementChangeFinder
    {
        private const int MinNumberOfCommonAttributes = 4;      // This is solely based on test example which has 'class', 'ref', 'title', 'onclick' attributes which matter. It's not perfect solution.

        public ChangedHtmlElementResult GetChangedElement(string originalHtmlPath, string diffHtmlPath, string elementId)
        {
            var originalHtml = CreateHtmlDocument(originalHtmlPath);
            var diffHtml = CreateHtmlDocument(diffHtmlPath);

            var originalElement = originalHtml.GetElementbyId(elementId);
            var originalElementAttributes = new HtmlElementComparedAttributes(originalElement);

            // Current alg version assumes that changed element is still element of the same type. It's not perfect as "input" and "a" and "button" elements for example can represent the same element. 
            var allElementsWithOriginalElementTag = diffHtml.DocumentNode.Descendants(originalElement.Name);

            int? similarElementDifference = null;
            ChangedHtmlElementResult changedElementResult = null;

            foreach (var changedElement in allElementsWithOriginalElementTag)
            {
                var diffElementAttributes = new HtmlElementComparedAttributes(changedElement);

                var commonAttributes = originalElementAttributes.AttributeValues.Keys.Intersect(diffElementAttributes.AttributeValues.Keys).ToList();

                int overallDiff = 0;
                foreach (var attr in commonAttributes)
                {
                    overallDiff += LevenshteinDistance.Compute(originalElementAttributes.AttributeValues[attr], diffElementAttributes.AttributeValues[attr]);
                }

                int innerHtmlDifference = LevenshteinDistance.Compute(originalElementAttributes.ClearedInnerHtml, diffElementAttributes.ClearedInnerHtml);

                overallDiff += innerHtmlDifference;

                if (!similarElementDifference.HasValue || ((overallDiff < similarElementDifference) && commonAttributes.Count > 4))
                {
                    similarElementDifference = overallDiff;
                    changedElementResult = new ChangedHtmlElementResult { OuterHtml = changedElement.OuterHtml, XPath = changedElement.XPath };
                }
            }

            return changedElementResult;
        }

        private HtmlDocument CreateHtmlDocument(string htmlFilePath)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.Load(htmlFilePath);
            return htmlDoc;
        }
    }
}
