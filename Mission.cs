using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   public class Mission
    {
        public List <Rover> ListOfRovers = new List<Rover>();

        public PlateauSize PlateauSize { get; set; }


        public Mission(PlateauSize plateauSize)
        {
            PlateauSize = plateauSize;
        }

        public Rover? GetRover(Rover rover) {
           if (ListOfRovers.Contains(rover)) return rover;

            return null;
        }


        public void AddRover(Rover rover) {
            if (IsPositionFree(rover)) {  ListOfRovers.Add(rover);}

           
        }

        public void RemoveRover(Rover rover) {
            if (ListOfRovers.Contains(rover)) ListOfRovers.Remove(rover);

        }

        public bool IsPositionFree(Rover rover)
        {
            foreach (Rover r in ListOfRovers)
            {
                //has to be.X and .Y can use override !!!
                if(r.Position.X == rover.Position.X && r.Position.Y == rover.Position.Y) return false;
                
            }
            return true;
        }
    }
}
