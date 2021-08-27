using System;
using System.Linq;

namespace ConsoleApp1
{
    public class DefaultPasswordValidator : IPasswordValidator
    {
        public bool Validate(string password)
        {
            if (password.Length < 8) return false;
            if (!password.Any(c => char.IsUpper(c))) return false ;

            return true;
        }
    }
}
