// ADAPTED FROM: STIMULATING SIMULATIONS SECOND EDTION BY C.W. ENGEL (C) 1979
// ADAPTED BY: KYLE GIVLER

// This code sucks almost as bad as the orginal :( 

using System;
class BusinessManagement
{
    static int[] rawMaterials = new int[3];
    static int[] materialCost = new int[3];
    static int[] finishedProduct = new int[3];
    static int[] productPrice = new int[3];
    static decimal cash;
    static int startingCash = 500;
    static int manufacturingCost = 2;
    static Random rand = new Random();
    
    public static void Main()
    {
        // REM SET PRICES
        cash = startingCash;
        for(int i = 0; i < 3; i++)
        {
            rawMaterials[i] = 0;
            finishedProduct[i] = 0;
            materialCost[i] = (int)(3*rand.NextDouble()+15);
            productPrice[i] = (int)(10*rand.NextDouble()+70);
        }
        for(int t = 0; t <= 12; t++)
        {
            OutputData();
            Console.WriteLine($"\nMONTH {t + 1} YOU HAVE ${cash}");
            Console.WriteLine($"MANUFACTURING COSTS ARE ${manufacturingCost}");
            Console.Write("TRANSACTION O,B,M,S ");
            char what = getChar();

            switch (what)
            {
                case 'B':
                    BuyMaterials();
                    break;
                case 'M':
                    Manufacture();
                    break;
                case 'S':
                    Sell();
                    break;
                default:
                    break;
            }
            ChangePrices();
        }

        // REM SUMMARY
        Console.WriteLine("END OF YEAR");
        for(int i = 0; i < 3; i++)
        {
            cash += rawMaterials[i] * materialCost[i];
            cash += finishedProduct[i] * productPrice[i];
        }
        cash -= startingCash;
        Console.WriteLine($"YOUR PROFIT IS {cash}.");
        Console.Write("PLAY AGAIN ");
        if(getChar() == 'Y')
            Main();
        System.Environment.Exit(System.Environment.ExitCode);  
    }
    public static void OutputData()
    {
        // REM OUTPUT DATA
        Console.WriteLine("\nITEM     MATERIALS     PRODUCT");
        for(int i = 0; i < 3; i++)
            Console.WriteLine($"{i + 1}        {rawMaterials[i]}  ${materialCost[i]}        {finishedProduct[i]} ${productPrice[i]}");
    }

    public static void BuyMaterials()
    {
        int amount = 0;
        int item = 0;
        string input;
        // REM BUY MATERIALS (and some ugly repeated code)
        do {
            Console.Write("AMOUNT OF MATERIALS ");
            input = Console.ReadLine();
        } while (!Int32.TryParse(input, out amount));

        do {
            Console.Write("ITEM# ");
            input = Console.ReadLine();
        } while (!Int32.TryParse(input, out item) || item < 1 || item > 3);

        cash -= amount * materialCost[item -1];
        if(cash < 0)
        {
            cash += amount * materialCost[item - 1];
            Console.WriteLine("INSUFFICIENT FUNDS");
            return;
        }
        rawMaterials[item -1] += amount;
    }

    public static void Manufacture()
    {
        // REM MANUFACTURE
        string input;
        int amount;
        int item;
        do {
            Console.Write("MANUFACTURE AMOUNT ");
            input = Console.ReadLine();
        } while (!Int32.TryParse(input, out amount));

        do {
            Console.Write("ITEM# ");
            input = Console.ReadLine();
        } while (!Int32.TryParse(input, out item) || item < 1 || item > 3);

        cash -= amount * manufacturingCost;
        if(cash < 0)
        {
            cash += amount * manufacturingCost;
            Console.WriteLine("INSUFFICIENT FUNDS");
            return;
        }
        
        // Pretty sure this will eat materials in certain cases
        // It's true to the BAISC though will fix it later
        for(int i = 0; i < 3; i++)
        {
            if(i == item - 1)
                continue;

            rawMaterials[i] -= amount;
            if(rawMaterials[i] < 0)
            {
                Console.WriteLine("MATERIALS GONE");
                rawMaterials[i] += amount;
                cash += amount * manufacturingCost;
                return;
            }
        }
        finishedProduct[item - 1] += amount;
    }

    public static void Sell()
    {
        // REM SELL
        string input;
        int amount;
        int item;

        do {
            Console.Write("AMOUNT TO SELL ");
            input = Console.ReadLine();
        } while(!Int32.TryParse(input, out amount));

        do {
            Console.Write("ITEM# ");
            input = Console.ReadLine();
        } while(!Int32.TryParse(input, out item) || item < 1 || item > 3);

        finishedProduct[item -1 ] -= amount;
        if(finishedProduct[item -1] < 0)
        {
            finishedProduct[item -1] += amount;
            Console.WriteLine("PRODUCTS GONE");
            return;
        }

        cash += amount * productPrice[item - 1];
    }

    public static void ChangePrices()
    {
        // REM CHANGE PRICE SUBROUTINE
        int variance = 0;
        for(int i = 0; i < 3; i++)
        {
            do {
                variance = (int)(5 * rand.NextDouble()) - 2;
                variance = materialCost[i] + variance;
            } while(variance < 10 || variance > 20);
            materialCost[i] = variance;

            do {
                variance = (int)(11 * rand.NextDouble()) - 5;
                variance = productPrice[i] + variance;
            }while(variance < 50 || variance > 90);
            productPrice[i] = variance;
        }

         do {
            variance = (int)(5 * rand.NextDouble()) - 2;
            variance = manufacturingCost + variance;
        }while(variance < 1 || variance > 9);
        manufacturingCost = variance;
    }

    public static char getChar()
    {
        string input = Console.ReadLine();
        return Char.ToUpper(input[0]);
    }
}