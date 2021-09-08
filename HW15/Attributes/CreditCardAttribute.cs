using HW15.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HW15.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    class CreditCardAttribute : Attribute
    {
        public bool IsValid(string number)
        {
            if (string.IsNullOrEmpty(number))
                return false;

            Regex reg = new Regex(@"\d{4}([\s-]\d{4}){3}");
            Regex regex = new Regex(@"\d{16}");
            if (reg.Match(number).Success|| regex.Match(number).Success)
            {
                return true;
            }
            else
            {
                return false;
            }                
        }
    }
}
