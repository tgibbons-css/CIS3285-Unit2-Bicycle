using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRefactored
{
    public class Bicycle
    {

        // the Bicycle class has three fields
        private int cadence;
        public int Cadence
        {
            get {return this.cadence;}
            set{cadence = value;}
        }
        private int gear;
        public int Gear
        {
            get { return this.gear; }
            set { gear = value; }
        }
        private int speed;
        public int Speed
        {
            get { return this.speed; }
            set { speed = value; }
        }

        // the Bicycle class has one constructor
        public Bicycle(int startCadence, int startSpeed, int startGear)
        {
            gear = startGear;
            cadence = startCadence;
            speed = startSpeed;
        }

        // the Bicycle class has four methods
       

        public void applyBrake(int decrement)
        {
            speed -= decrement;
        }

        public void speedUp(int increment)
        {
            speed += increment;
        }

        public String toString()
        {
            String bike = "My Bike: " + this.Speed + ", " + this.Cadence + ", " + this.Gear;
            return bike;
        }





    }
}
