using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant_Rojkov_2isp11_17.DataClass
{
    public class ValidationClass
    {
        public static bool ValidationPassword(string password)
        {

            if (password.Length < 8 || password.Length > 20)
            {
                return false;

            }
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            if (!password.Any(Char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            if (!password.Any(char.IsPunctuation))
            {
                return false;
            }
            if (password == "")
            {
                return false;
            }
            if (password.Any(char.IsWhiteSpace))
            {
                return false;
            }
            return true;
        }

        public static bool ValidationFIO(string nameSurname)
        {
            if (String.IsNullOrWhiteSpace(nameSurname))
            {
                return false;
            }
            if (nameSurname.Any(char.IsDigit))
            {
                return false;
            }
            if (nameSurname.Intersect("-").Count() >= 2)
            {
                return false;
            }
            if (((!nameSurname[0].ToString().Any(char.IsUpper))))
            {
                return false;
            }


            return true;
        }

        public static bool ValidationHeightWeight(string heightWeight)
        {
            if (!heightWeight.All(char.IsDigit))
            {
                return false;
            }
            if (heightWeight.Any(char.IsWhiteSpace))
            {
                return false;
            }
            if (heightWeight == "")
            {
                return false;
            }
            if (Convert.ToInt32(heightWeight) < 0)
            {
                return false;
            }
            if (Convert.ToInt32(heightWeight) > 300)
            {
                return false;
            }
            return true;
        }

    }
}
