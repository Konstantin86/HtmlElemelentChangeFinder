using HtmlElemelentChangeFinder.Core;
using HtmlElemelentChangeFinder.Core.Abstraction;
using System;

namespace HtmlElemelentChangeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                throw new Exception("Required arguments aren't provided");
            }

            string inputHtml = args[0];
            string diffHtml = args[1];
            string inputElementId = args[2];

            IHtmlElementChangeFinder finder = new HtmlElementChangeFinder();

            var result = finder.GetChangedElement(inputHtml, diffHtml, inputElementId);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
