using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.CustomerValidation
{
    public class EmailClassValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string _value = Convert.ToString(value);
            if (_value.Contains("@") && _value.EndsWith(".com"))
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
