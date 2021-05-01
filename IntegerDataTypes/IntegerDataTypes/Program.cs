using System;

namespace IntegerDataTypes
/// <summary>
///  Learning of C# data types
/// </summary>
{
    class MainClass

        ///<summary>
        /// Program to exchange unit of time
        /// </summary>
    {
        public static void Main(string[] args)
        {
            ///Declaration of variable
            Console.WriteLine("Enter time in seconds : ");

            int timeSecond = Convert.ToInt32(Console.ReadLine());
            int timeMinute;

            ///calculations
            timeMinute = timeSecond / 60;

            ///display result
            Console.WriteLine(timeSecond + " seconds is equal to " + timeMinute +" minutes.");

        }
    }
}
