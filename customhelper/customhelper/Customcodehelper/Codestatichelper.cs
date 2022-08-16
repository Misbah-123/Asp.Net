using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace customhelper.Customcodehelper
{
    public class Codestatichelper
    {
        public static IHtmlString LabelCustom(string abc)
        {
            string value = string.Format("{0}", abc);


            return new HtmlString(value);
        }


    }
}