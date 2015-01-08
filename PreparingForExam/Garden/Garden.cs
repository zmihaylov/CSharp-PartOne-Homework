using System;

class Garden
{
    static void Main()
    {
        decimal tomateSeed = decimal.Parse(Console.ReadLine());
        decimal tomateArea = decimal.Parse(Console.ReadLine());
        
        decimal cucumberSeed = decimal.Parse(Console.ReadLine());
        decimal cucumberArea = decimal.Parse(Console.ReadLine());
        
        decimal potatoSeed = decimal.Parse(Console.ReadLine());
        decimal potatoArea = decimal.Parse(Console.ReadLine());
        
        decimal carrotSeed = decimal.Parse(Console.ReadLine());
        decimal carrotArea = decimal.Parse(Console.ReadLine());
        
        decimal cabbageSeed = decimal.Parse(Console.ReadLine());
        decimal cabbageArea = decimal.Parse(Console.ReadLine());
        
        decimal beanSeed = decimal.Parse(Console.ReadLine());

        decimal tomatoCoast = tomateSeed * 0.5M;
        decimal cucumberCoast = cucumberSeed * 0.4M;
        decimal potatoCoast = potatoSeed * 0.25M;
        decimal carrotCoast = carrotSeed * 0.6M;
        decimal cabbageCoast = cabbageSeed * 0.3M;
        decimal beanCoast = beanSeed * 0.4M;

        decimal totalCoast = tomatoCoast + cucumberCoast + potatoCoast +
                        carrotCoast + cabbageCoast + beanCoast;

        Console.WriteLine("Total costs: " + totalCoast);

        decimal beanArea = 250 - (tomateArea + cucumberArea
            + potatoArea + carrotArea + cabbageArea);

        if (beanArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (beanArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Beans area: " + beanArea);
        }

    }
}