// My solution to the first problem form the exam. Points: 100

using System;
 
class Garden
{
    static void Main()
    {
        // input
        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
 
        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
 
        int potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
 
        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
 
        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
 
        int beansSeeds = int.Parse(Console.ReadLine());
 
        int totalArea = 250;
 
        // prices
        double tomatoPrice = 0.5;
        double cucumberPrice = 0.4;
        double potatoPrice = 0.25;
        double carrotPrice = 0.6;
        double cabbagePrice = 0.3;
        double beansPrice = 0.4;
 
        // answer
 
        // cost
        double totalCost = (tomatoSeeds * tomatoPrice) + (cucumberSeeds * cucumberPrice)
            + (potatoSeeds * potatoPrice) + (carrotSeeds * carrotPrice)
            + (cabbageSeeds * cabbagePrice) + (beansSeeds * beansPrice);
        Console.WriteLine("Total costs: {0:0.00}", totalCost);
 
        // beans area
        int beansArea = totalArea - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
 
        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }
    }
}
