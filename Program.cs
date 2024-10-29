using MarsRover.InputParsing;

namespace MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var input = new List<string>() { "55", "12N", "LMLMLMLMM", "33E", "MMRMMRMRRM" };

           var plateau=  PlateauInputParser.Parse(input[0]);



            Mission mission = new Mission(new PlateauSize(plateau[0], plateau[1]));
            
            var startingPosition1= StartingPositionParser.Parse(input[1]);
            var instructions = InstructionParser.Parse(input[2]);
            var startingPosition2 = StartingPositionParser.Parse(input[3]);
            var instructions2  = InstructionParser.Parse(input[4]);
            Rover rover = new Rover(startingPosition1);
            Rover rover2 = new Rover(startingPosition2 );

            mission.AddRover( rover );
            mission.AddRover( rover2 );

           rover.UseMoveOrRotate(instructions);
            rover2.UseMoveOrRotate(instructions2);

            Console.WriteLine(rover.Position.X);
            Console.WriteLine(rover.Position.Y);
            Console.WriteLine(rover.Position.Facing);
        }
    }
}
