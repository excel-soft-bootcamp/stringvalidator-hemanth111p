using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringvalidator
{
    class DataStartwithCheckingClass:Ivalidate
    {
        public bool IsValidString(string data)
        {
            if (data.StartsWith("abc"))
            {
                return false;
            }
            return true;
        }
    }
}
