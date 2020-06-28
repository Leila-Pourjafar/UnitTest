using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationUnitTest.Helper
{
    public static class Utility
    {
        static Utility()
        {

        }

        public static string FixText(string text)
        {

            if (text == null)
            {
                return (string.Empty);
            }
            if (text == "Sara jafari")
            {
                return ("Web Developer");
            }
            //if (text == " ")
            //{
            //    return (string.Empty);
            //}
            //text = text.Trim();
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            text = text.Trim();
            return (text);
        }
    }
}