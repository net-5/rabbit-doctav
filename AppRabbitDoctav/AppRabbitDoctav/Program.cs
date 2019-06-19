using System;

namespace AppRabbitDoctav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play with the rabbits!");
            Rabbit myFirstRabbit = new Rabbit(EYES.Blue, FUR.White, GENDER.Male, new DateTime(2017, 3, 1));
            myFirstRabbit.Move(10);
            myFirstRabbit.Eat(3);
            myFirstRabbit.Sleep(5);
            
            //get info about the rabbit
            Console.WriteLine(myFirstRabbit.DetailedInfo);
            Console.WriteLine(myFirstRabbit.GetAgeOfTheRabbit);
                        
            //change the eyes of the rabbit  :)
            myFirstRabbit.Eyes = EYES.Red;
            //move and sleep again
            myFirstRabbit.Move(2);
            myFirstRabbit.Sleep(4);
            //get the new info about the rabbit
            Console.WriteLine();
            Console.WriteLine($"The new info is: {myFirstRabbit.DetailedInfo}. {myFirstRabbit.GetAgeOfTheRabbit}");

        }
    }
}
