using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace customhelper.Customcodehelper
{
    public static class CodeExtensionhelper
    {
        public static IHtmlString LabelCustomext(this HtmlHelper helper ,string abc)
        {
            string value = string.Format("{0}", abc);


            return new HtmlString(value);
        }

    }
}