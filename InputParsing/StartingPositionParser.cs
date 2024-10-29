using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.InputParsing
{
    public class StartingPositionParser
    {
      
       public static Position Parse(string input)
        {


            if (input.Length < 3)
            {
               // throw
            }
            // wht if double number - needs to be "3 10" etc. 
            string num1Char = input[0].ToString();
            int num1 = Convert.ToInt32(num1Char);

            string num2Char = input[1].ToString();
            int num2 = Convert.ToInt32(num2Char);

    
            Compass facing;

            try
            {
                facing = (Compass)Enum.Parse(typeof(Compass), input[2].ToString().ToUpper());
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Invalid facing direction.");
            }
            var pos = new Position(  num1, num2, facing);

            return pos; 
        }
    }
}
