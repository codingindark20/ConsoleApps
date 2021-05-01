using System;

namespace calculator
    /// <summary>
    /// Program to add steps in the week from stepsapp
    /// </summary>
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           ///Declaration of variable
            int NoOfEntry;
            Console.WriteLine("How many data do you want to enter?\n Enter number : ");
            NoOfEntry = Convert.ToInt32(Console.ReadLine());
            int i;
            int Steps;
            int Day1Step = 0;
            int Day2Step = 0;
            int Day3Step = 0;
            int Day4Step = 0;
            int Day5Step = 0;
            int Day6Step = 0;
            int Day7Step = 0;
            int totalSteps;

            if (NoOfEntry <= 7)
            {
                for (i = 1; i <= NoOfEntry; i++)
                {
                    Console.WriteLine("Enter steps of day " + i);
                    Steps = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Day1Step = Steps;
                            break;
                        case 2:
                            Day2Step = Steps;
                            break;
                        case 3:
                            Day3Step = Steps;
                            break;
                        case 4:
                            Day4Step = Steps;
                            break;
                        case 5:
                            Day5Step = Steps;
                            break;
                        case 6:
                            Day6Step = Steps;
                            break;
                        default:
                            Day7Step = Steps;
                            break;
                    }
                }
                totalSteps = Day1Step + Day2Step + Day3Step + Day4Step + Day5Step + Day6Step + Day7Step;
                Console.WriteLine("Total Steps = " + totalSteps);
            }
            else
            {
                Console.WriteLine("This system is only valid for 7 days data...");
            }

        }
    }
}
