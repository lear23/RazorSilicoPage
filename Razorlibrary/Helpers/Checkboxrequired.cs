

using System.ComponentModel.DataAnnotations;

namespace Razorlibrary.Helpers
{
    public class Checkboxrequired : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return value is bool b && b;
        }
    }
}
