using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosMVC.WebApp.HTML
{
    public static class HTMLUtil
    {
        public static string GetHTMLContent(string formName)
        {
            string fullPath = $"HTML/{formName}.html";
            using (var file = File.OpenText(fullPath))
            {
                return file.ReadToEnd();
            }
        }
    }
}
