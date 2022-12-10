using System;

public class Program
{

    public static void Main()
    {

        Console.WriteLine("Welcome to our Mac & Cheese Buffet. All you can eat for $9.99! " +
            "We only charge extra for coffee & smoothies. How many people are in your group? " +
            "Please, groups of 6 or fewer.");
        int Num = int.Parse(Console.ReadLine());

        if (Num < 7)
        {
            Console.WriteLine("A table for " + Num + "! Please follow me and take a seat. " +
                "Let's get everyone started with some drinks. A water fountain and glasses are next to the plates;" +
                " if you want water you can grab that. We have flavor of the day smoothie or coffee.");
            Console.WriteLine(" ");

            int coffeeCount = 0;
            int smoothieCount = 0;

            Double BuffetCost = 9.99;
            Double SmoothieCost = 3.99;
            Double CoffeeCost = 1.99;

            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine("Go ahead, person number " + i + " , smoothie or coffee?");
                String answer = (Console.ReadLine());

                if (answer == "coffee")
                {
                    Console.WriteLine("Coffee, Great!");
                    coffeeCount = coffeeCount + 1;
                }

                else if (answer == "smoothie")
                {
                    Console.WriteLine("Smoothie, Great!");
                    smoothieCount = smoothieCount + 1;
                }

                else
                { Console.WriteLine("We don't have that option. You can get water from the fountain by the plates."); }
            }


            Console.WriteLine("Okay, so that's " + coffeeCount + " coffees and " + smoothieCount + " smoothies. I'll be right back. Feel free to grab your food!");

            Double coffeeTotal = coffeeCount * CoffeeCost;
            Double smoothieTotal = smoothieCount * SmoothieCost;
            Double buffetTotal = BuffetCost * Num;
            Double BillTotal = buffetTotal + coffeeTotal + smoothieTotal;

            Console.WriteLine("Here's you bill! Total price: $" + BillTotal);

        }

        else
        { Console.WriteLine("Sorry, we can only seat groups up to 6 right now. Have a nice day."); }
    }

}
