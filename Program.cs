using System;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate each vehicle
            Zero myZero = new Zero();
            Cessna myCessna = new Cessna();
            Tesla myTesla = new Tesla();
            Ram myRam = new Ram();


            myCessna.MainColor = "silver";
            Console.Write($"The {myCessna.MainColor} Cessna screams, ");
            myCessna.Drive();
            Console.WriteLine("");

            myTesla.MainColor = "black";
            Console.Write($"The {myTesla.MainColor} Tesla just ");
            myTesla.Drive();
            Console.WriteLine(" on by.");
            Console.WriteLine("");

            myRam.MainColor = "red";
            Console.Write($"The {myRam.MainColor} Ram speeds on the interstate with an exagerated, ");
            myRam.Drive();
            Console.WriteLine("");

            myZero.MainColor = "smoke";
            Console.Write($"The {myZero.MainColor} Zero zips by with a subdued, ");
            myZero.Drive();
            Console.WriteLine("");

        }
    }
}
