using System;

public class Program
{
    public static void Main(String[]args)
    {
        /* int temperature = 20;

         //here 25 is a magic no because it does not explained what is 25 how it came 

         if (temperature > 25)
         {
             Console.WriteLine("Temperature is too high!");
         }
         else
         {
             Console.WriteLine("Temperature is normal.");
         }*/

        //proof of concept
        // writing declarative constants so that whenever we want to change 25 with any number we need to change at one place only

        int temperature = 20;
        int temperatureThreshold = 25;  //constant declared

        if (temperature > temperatureThreshold)
        {
            Console.WriteLine("Temperature is too high!");
        }
        else
        {
            Console.WriteLine("Temperature is normal.");
        }

        Console.ReadLine();

    }
}

