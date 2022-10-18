/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace BicycleRefactored
{

    /**
     * This is the main routine that tests out the Bicycle and MountainBike objects
     * 
     * @author 
     */
    public class CIS2087Bicycle
    {

        /**
         * @param args the command line arguments
         */
        static void Main(string[] args)
        {
            Bicycle myBike = new Bicycle(1, 2, 3);
            MountainBike myMtnBike = new MountainBike(33, 1, 2, 3);

            Console.WriteLine("My Bike speed: " + myBike.Speed);
            Console.WriteLine("My Mountain Bike speed: " + myMtnBike.Speed);

            myBike.speedUp(5);
            myMtnBike.speedUp(3);

            Console.WriteLine("My Bike speed: " + myBike.Speed);
            Console.WriteLine("My Mountain Bike speed: " + myMtnBike.Speed);

            myBike.Cadence=7;
            Console.WriteLine("My Bike cadence: " + myBike.Cadence);

            myMtnBike.Cadence=5;
            Console.WriteLine("My Bike cadence: " + myMtnBike.Cadence);

            //This code fails, setHeight & getHeight are in MountainBike
            //myBike.setHeight(33);
            //System.out.println("My Bike cadence: " + myBike.getHeight());

            myMtnBike.SeatHeight=35;
            Console.WriteLine("My Bike cadence: " + myMtnBike.SeatHeight);

            //Testing toString()
            Console.WriteLine(myBike.toString());
            Console.WriteLine(myMtnBike.toString());


        }

    }
}
