using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlElemelentChangeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                throw new Exception("Required arguments aren't provided");
            }

            string inputHtml = args[0];
            string diffHtml = args[1];

            
        }
    }
}
