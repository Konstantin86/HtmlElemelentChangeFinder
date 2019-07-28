# HtmlElemelentChangeFinder

The Utility to find a specific element in the target html after changes that may occur in a set of attributes.

How to Run:
HtmlElemelentChangeFinder.exe <inputHtml> <targetHtml> <originalElementId>

Examples:
1. HtmlElemelentChangeFinder.exe "D:\Git\HtmlElemelentChangeFinder\Source\HtmlElemelentChangeFinder\HtmlElemelentChangeFinder.Tests\TestData\sample-0-origin.html" "D:\Git\HtmlElemelentChangeFinder\Source\HtmlElemelentChangeFinder\HtmlElemelentChangeFinder.Tests\TestData\sample-1-evil-gemini.html" "make-everything-ok-button"

Output:
Potential changed element:
 <a class="btn btn-success" href="#check-and-ok" title="Make-Button" rel="done" onclick="javascript:window.okDone(); return false;">
                              Make everything OK
                            </a>
 Path: /html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/a[2]

2. HtmlElemelentChangeFinder.exe "D:\Git\HtmlElemelentChangeFinder\Source\HtmlElemelentChangeFinder\HtmlElemelentChangeFinder.Tests\TestData\sample-0-origin.html" "D:\Git\HtmlElemelentChangeFinder\Source\HtmlElemelentChangeFinder\HtmlElemelentChangeFinder.Tests\TestData\sample-2-container-and-clone.html" "make-everything-ok-button"

Output:
Potential changed element:
 <a class="btn test-link-ok" href="#ok" title="Make-Button" rel="next" onclick="javascript:window.okComplete(); return false;">
                              Make everything OK
                            </a>
 Path: /html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/a[1]

3. HtmlElemelentChangeFinder.exe "D:\Git\HtmlElemelentChangeFinder\Source\HtmlElemelentChangeFinder\HtmlElemelentChangeFinder.Tests\TestData\sample-0-origin.html" "D:\Git\HtmlElemelentChangeFinder\Source\HtmlElemelentChangeFinder\HtmlElemelentChangeFinder.Tests\TestData\sample-3-the-escape.html" "make-everything-ok-button"

Output:
Potential changed element:
 <a class="btn btn-success" href="#ok" title="Do-Link" rel="next" onclick="javascript:window.okDone(); return false;">
                            Do anything perfect
                          </a>
 Path: /html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[3]/a[1]

4. HtmlElemelentChangeFinder.exe "D:\Git\HtmlElemelentChangeFinder\Source\HtmlElemelentChangeFinder\HtmlElemelentChangeFinder.Tests\TestData\sample-0-origin.html" "D:\Git\HtmlElemelentChangeFinder\Source\HtmlElemelentChangeFinder\HtmlElemelentChangeFinder.Tests\TestData\sample-4-the-mash.html" "make-everything-ok-button"

Output:
Potential changed element:
 <a class="btn btn-success" href="#ok" title="Make-Button" rel="next" onclick="javascript:window.okFinalize(); return false;">
                            Do all GREAT
                          </a>
 Path: /html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[3]/a[1]