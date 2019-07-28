using HtmlElemelentChangeFinder.Core;
using HtmlElemelentChangeFinder.Core.Abstraction;
using System;
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

            var resultForSample1 = finder.GetChangedElement(testInputHtmlPath, testDiffHtml1Path, "make-everything-ok-button");
            Assert.AreEqual("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/a[2]", resultForSample1.XPath);

            var resultForSample2 = finder.GetChangedElement(testInputHtmlPath, testDiffHtml2Path, "make-everything-ok-button");
            Assert.AreEqual("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/a[1]", resultForSample2.XPath);

            var resultForSample3 = finder.GetChangedElement(testInputHtmlPath, testDiffHtml3Path, "make-everything-ok-button");
            Assert.AreEqual("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[3]/a[1]", resultForSample3.XPath);

            var resultForSample4 = finder.GetChangedElement(testInputHtmlPath, testDiffHtml4Path, "make-everything-ok-button");
            Assert.AreEqual("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[3]/a[1]", resultForSample4.XPath);
        }
    }
}
