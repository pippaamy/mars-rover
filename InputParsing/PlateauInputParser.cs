using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.InputParsing
{
   public class PlateauInputParser
    {


        public static List<int> Parse(string input)
        {
            //no longer than 2, no characters that dont convert to int

            if (input.Length != 2)
            {
               //throw
            }
            string num = input[0].ToString();
            int num1 = Convert.ToInt32(num);

            string num2 = input[1].ToString();
            int num3 = Convert.ToInt32(num);


            var plateau = new List<int>() { num1 +1, num3 +1};
          
            return plateau;
        }

    }
}
