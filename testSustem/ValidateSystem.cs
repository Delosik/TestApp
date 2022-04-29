using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSustem
{
    class ValidateSystem
    {
        public static bool ValidatePassword(string password)
        {
            bool minLenght = false;
            bool containsNumbers = false;
            bool containsLowerChar = false;
            bool containsUpperChar = false;
            if (password.Length >= 6)
            {
                minLenght = true;
                char[] passwordChars = password.ToCharArray();
                for (int i = 0; i < passwordChars.Length; i++)
                {
                    if (Char.IsUpper(passwordChars[i]) && containsUpperChar == false) containsUpperChar = true;
                    if (Char.IsLower(passwordChars[i]) && containsLowerChar == false) containsLowerChar = true;
                    if (Char.IsNumber(passwordChars[i]) && containsNumbers == false) containsNumbers = true;
                    if (Char.IsLetter(passwordChars[i]))
                    {
                        if (passwordChars[i] <= 'я' && passwordChars[i] >= 'а' || passwordChars[i] >= 'А' && passwordChars[i] <= 'Я') return false;
                    }
                }
            }
            if (minLenght && containsNumbers && containsLowerChar && containsUpperChar) return true;
            else return false;
        }
        public static bool ValidateLogin(string login)
        {
            if (login.Length >= 6)
            {
                char[] loginChars = login.ToCharArray();
                string[] loginArray = login.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (char loginChar in loginChars) if (loginChar <= 'я' && loginChar >= 'а' || loginChar >= 'А' && loginChar <= 'Я') return false;
                if (loginArray.Length != 1) return false;
                return true;
            }
            else return false;
        }
        public static bool ValidateFullName(string fullname)
        {
            string[] fullNameArray = fullname.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (fullNameArray.Length != 3) return false;
            else return true;
        }
    }
}
