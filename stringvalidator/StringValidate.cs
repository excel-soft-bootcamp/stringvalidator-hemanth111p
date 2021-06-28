using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringvalidator
{
    public class StringValidate
    {
        Ivalidate _validate;
        public StringValidate(Ivalidate validate)
        {
            this._validate = validate;
        }
        public void IsValidString(string data)
        {
            _validate.IsValidString(data);
        }

    }
}
