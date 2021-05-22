using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MicroFinance.Validations
{
    public class NameValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string Word =(string)value;
            //if(string.IsNullOrEmpty(Word))
            //{
            //    return new ValidationResult(false, "Name Cannot Be Empty");
            //}
            for(int i=0;i<Word.Length;i++)
            {
                if(char.IsLetter(Word[i])==false)
                {
                    return new ValidationResult(false, "Name is Invalid,It allows a-z and A-Z");
                }
            }
            return ValidationResult.ValidResult;
        }
    }
}
