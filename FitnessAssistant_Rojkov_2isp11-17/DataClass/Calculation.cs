using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant_Rojkov_2isp11_17.DataClass
{
    class Calculation
    {

        public static double BMI(double weight, double height)
        {
            double res = weight / Math.Pow(height / 100, 2);
            return res;
        }


        public static double BMR(string gender, double weight, double height, int age)
        {

            double res = 0;
            if (gender == "мужской")
            {
                res = 66 + (13.7 * weight) + (5 * height) - (6.8 * age);

            }

            if (gender == "женский")
            {
                res = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
            }
            return res;

        }
    }
}
