using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringvalidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "abcde";
            StringValidate validateLength = new StringValidate(new LengthCheckingClass());
            validateLength.IsValidString(data);
            StringValidate validateStartsWith = new StringValidate(new DataStartwithCheckingClass());
            validateStartsWith.IsValidString(data);
            StringValidate validateNullChecking = new StringValidate(new nullCheckingClass());
            validateNullChecking.IsValidString(data);




        }
    }
}
