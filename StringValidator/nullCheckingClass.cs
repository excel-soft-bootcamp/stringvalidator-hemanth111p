using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringvalidator
{
  public  class nullCheckingClass:Ivalidate
    {
        public bool IsValidString(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            
            return true;
        }
    }
}
