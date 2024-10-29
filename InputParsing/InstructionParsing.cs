using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.InputParsing
{
    public class InstructionParser
    {
        public static List<Instruction> Parse(string input)
        {
            var instructions = new List<Instruction>();

           
                foreach (char s in input)
                {

                    instructions.Add((Instruction)Enum.Parse(typeof(Instruction), s.ToString()));


                }


            return instructions;
            }
    }
}
