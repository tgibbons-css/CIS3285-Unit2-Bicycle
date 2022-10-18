using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRefactored
{
    public class MountainBike : Bicycle
    {

    // the MountainBike subclass adds one field
        public int seatHeight;
        public int SeatHeight
        {
            get { return this.seatHeight; }
            set { seatHeight = value; }
        }


    // the MountainBike subclass has one constructor
    public MountainBike(int startHeight,
                        int startCadence,
                        int startSpeed,
                        int startGear) : base(startCadence, startSpeed, startGear)
    {
        //super(startCadence, startSpeed, startGear);
        seatHeight = startHeight;
    }

    // the MountainBike subclass adds one method
 
    public String toString()
    {
        String bike = "My MountainBike: " + this.Speed + ", " + this.Cadence + ", " + this.Gear + ", " + this.SeatHeight;
        return bike;
    }
}

}

