using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        public Position Position { get; set; }
        public Rover(Position position) {
        Position = position;
        }


        public void Rotate(Instruction instruction)
        {
            Compass facing = Position.Facing;


            Compass newFacing;

       

            if (facing == Compass.S)
            {
                newFacing = (instruction == Instruction.L) ? Compass.W : Compass.E;
            }
            else if (facing == Compass.W)
            {
                newFacing = (instruction == Instruction.L) ? Compass.N : Compass.S;

            }
            else if (facing == Compass.N)
            {
                newFacing = (instruction == Instruction.L) ? Compass.E : Compass.W;

            }
            else {
                newFacing = (instruction == Instruction.L) ? Compass.S : Compass.N;
            }


            if (instruction == Instruction.M)
            {
                newFacing = facing;
            }
           


          Position = new Position(Position.X, Position.Y, newFacing);
        }



        public void Move(Instruction instruction)
        {

            //split into one movement
            int x = Position.X;
            int y = Position.Y;
                
                
            Compass facing = Position.Facing;

            if (facing == Compass.S)
            {
                Position =new Position(x, y -1, facing);
            }
            else if (facing == Compass.W)
            {
                Position = new Position(x - 1, y, facing);

            }
            else if (facing == Compass.N)
            {
                Position = new Position(x, y + 1, facing);

            }
            else 
            {
                Position = new Position(x + 1, y, facing);
            }

            if (instruction != Instruction.M) {
                Position = new Position(x, y, facing);
            }
            
         
        }

        public Position UseMoveOrRotate(List<Instruction> instructions)
        {
            int x = Position.X;
            int y = Position.Y;


            foreach (Instruction instruction in instructions)
            {

                if (instruction != Instruction.M)
                {
                    Rotate(instruction);
                }
                else
                {
                    Move(instruction);
                }
            }
           
            return Position;
        }
    }
}
