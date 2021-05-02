using System;

namespace Trigonometry_Console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ///Declaration of variables
            float angle = 60;

            ///Sine of angle
            float sine = (float)Math.Sin(angle * (float)Math.PI / 180);

            ///Cosine of angle
            float cosine = (float)Math.Cos(angle * (float)Math.PI / 180);

            ///Output
            Console.WriteLine("Sine of " +angle + "is : " +sine);
            Console.WriteLine("Cosine of " +angle + "is : " +cosine);
        }
    }
}
