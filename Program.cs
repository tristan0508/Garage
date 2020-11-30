using System;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate each vehicle
            Zero myZero = new Zero()
            {
                MainColor = "smoke"
            };
            Cessna myCessna = new Cessna()
            {
                MainColor = "silver"
            };
            Tesla myTesla = new Tesla()
            {
                MainColor = "black"
            };
            Ram myRam = new Ram()
            {
                MainColor = "red"
            };

            myCessna.Drive();
            myCessna.Turn("right");
            myCessna.Stop();

            myTesla.Drive();
            myTesla.Turn("left");
            myTesla.Stop();

            myRam.Drive();
            myRam.Turn("right");
            myRam.Stop();

            myZero.Drive();
            myZero.Turn("left");
            myZero.Stop();




        }
    }
}
