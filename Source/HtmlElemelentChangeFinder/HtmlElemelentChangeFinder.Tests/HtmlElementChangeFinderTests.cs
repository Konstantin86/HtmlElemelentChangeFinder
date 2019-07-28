using HtmlElemelentChangeFinder.Core;
using HtmlElemelentChangeFinder.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlElemelentChangeFinder.Tests
{
    [TestClass]
    public class HtmlElementChangeFinderTests
    {
        [TestMethod]
        public void FindSearchesAndReturnsChangedElementPath()
        {
            var testInputHtmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData\\sample-0-origin.html");
            var testDiffHtml1Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData\\sample-1-evil-gemini.html");
            var testDiffHtml2Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData\\sample-2-container-and-clone.html");
            var testDiffHtml3Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData\\sample-3-the-escape.html");
            var testDiffHtml4Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData\\sample-4-the-mash.html");

            IHtmlElementChangeFinder finder = new HtmlElementChangeFinder();
            var result1 = finder.GetChangedElementPath(testInputHtmlPath, testDiffHtml1Path, "make-everything-ok-button");
        }
    }
}
