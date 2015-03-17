using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.StudentsEnrolledIn2014
{
    static class Extension
    {
        public static Boolean Enrolled(this int num)
        {
            string str = num.ToString();
            if (str[4]=='1' && str[5]=='4')
            {
                return true;
            }
            return false;
        }
    }
}
