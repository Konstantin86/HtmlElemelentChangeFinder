using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace Core.Model
{
    public class HtmlElementComparedAttributes
    {
        public HtmlElementComparedAttributes(HtmlNode originalElement)
        {
            AttributeValues = new Dictionary<string, string>();

            foreach (var attr in originalElement.Attributes)
            {
                AttributeValues.Add(attr.Name, attr.Value);
            }

            ClearedInnerHtml = Regex.Replace(ParseTextAndDigits(originalElement.InnerHtml).Trim(), @"\s+", " ");
        }

        public Dictionary<string, string> AttributeValues { get; set; }

        public string ClearedInnerHtml { get; }

        public string Title { get; }

        private string ParseTextAndDigits(string originalString)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char character in originalString)
            {
                if ((character >= '0' && character <= '9')
                    || (character >= 'A' && character <= 'Z')
                    || (character >= 'a' && character <= 'z')
                    || character == '.' || character == '_' || character == ' ')
                {
                    stringBuilder.Append(character);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
