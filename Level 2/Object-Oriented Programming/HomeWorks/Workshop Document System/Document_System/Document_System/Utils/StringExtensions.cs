﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Document_System.Utils
{
   public static class StringExtensions
    {
      public static string HtmlEncode(this string str)
       {
           return HttpUtility.HtmlEncode(str);
       }
    }
}
