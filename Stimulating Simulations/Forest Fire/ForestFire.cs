// ADAPTED FROM: STIMULATING SIMULATIONS SECOND EDTION BY C.W. ENGEL (C) 1979
// ADAPTED BY: KYLE GIVLER

using System;
class ForestFire
{
    static int[,] woods = new int[9,9]; // Row/Colum map of forest
                                        // Burnt woods: 0 Fire: 1-9 woods: 10, temporary variable 11

    public static void Main()
    {
        Random rand = new Random();

        for(int r = 0; r < 9; r++)
            for(int c = 0; c < 9; c++)
                woods[r,c] = 10; // 10 means woods, enum would be better here....

        for(int i = 1; i <= 3; i++)
            woods[rand.Next(9), rand.Next(9)] = 9; // 1-9 means fire
        
        while(true)
        {
            PrintGrid();
            InputRoutine();
        }
    }

    static void PrintGrid()
    {
        // REM PRINT GRID
        Console.WriteLine("   1 2 3 4 5 6 7 8 9");
        for(int r = 0; r < 9; r++)
        {
            Console.Write($"{r + 1}  ");
            for(int c = 0; c < 9; c++)
            {
                if(woods[r,c] == 10)
                    Console.Write(". ");
                else if (woods[r,c] > 0 && woods[r,c] < 10)
                    Console.Write("* ");
                else
                    Console.Write("B ");
            }
            Console.WriteLine();
        }
    }

    static void InputRoutine()
    {
        string input;
        int row,column;

        do {
            Console.Write("ROW? ");
            input = Console.ReadLine();
        } while(!Int32.TryParse(input, out row) || row < 0 || row > 9);
        if(row == 0)
        {
            BackFire();
            return;
        }
        row--;

        do {
            Console.Write("COLUMN? ");
            input = Console.ReadLine();
        } while(!Int32.TryParse(input, out column) || row < 0 || row > 9);
        column--;

        // Drop the chemicals!!
        Random rand = new Random();
        for(int i = -1; i <= 1; i++)
            for(int j = -1; j <= 1; j++)
            {
                int adjacentRow = row + i;
                int adjacentColumn = column + j;
                if (adjacentRow < 0 || adjacentRow > 8 || adjacentColumn < 0 || adjacentColumn > 8)
                    continue;
                if(woods[adjacentRow,adjacentColumn] < 1 || woods[adjacentRow,adjacentColumn] == 10)
                    continue;
                if(rand.NextDouble() > .5)
                    continue;
                //Console.WriteLine($"DEBUG: Applied Chemicals: {adjacentRow + 1},{adjacentColumn + 1}");
                woods[adjacentRow, adjacentColumn] -= 3;
            }
        SpreadFire();
    }

    static void BackFire()
    {
        string input;
        int row;
        int column;
        do {
            Console.Write("BACKFIRE ROW ");
            input = Console.ReadLine();
        } while(!Int32.TryParse(input, out row) || row < 0 || row > 9);

        do {
            Console.Write("BACKFIRE COLUMN ");
            input = Console.ReadLine();
        } while(!Int32.TryParse(input, out column) || row < 0 || row > 9);

        if(woods[row - 1,column - 1] == 10)
            woods[row - 1,column - 1] = 2;
        
        SpreadFire();
    }

    static void SpreadFire()
    {
        Random rand = new Random();
        // REM SPREAD FIRE
        for(int r = 0; r < 9; r++)
            for(int c = 0; c < 9; c++)
            {
                if(woods[r,c] < 1 || woods[r,c] > 9)
                    continue;
                if(woods[r,c] < 3)
                    continue;
                int i = (int)(3*rand.NextDouble()) -1;
                int j = (int)(3*rand.NextDouble()) -1;
                int adjacentRow = r + i;
                int adjacentColumn = c + j;
                if (adjacentRow < 0 || adjacentRow > 8 || adjacentColumn < 0 || adjacentColumn > 8)
                    continue;
                if(woods[adjacentRow,adjacentColumn] != 10)
                    continue;
                if(rand.NextDouble() < .3)
                    continue;
                woods[adjacentRow,adjacentColumn] = 11;
            }
        BurnFireAndCount();
    }

    static void BurnFireAndCount()
    {
        //REM BURN FIRE AND COUNT
        int count = 0;
        for(int r = 0; r < 9; r++)
            for(int c = 0; c < 9; c++)
            {
                int temp = woods[r,c];
                if (temp == 11)
                    temp = 9;
                if(temp > 0 && temp < 10)
                {
                    temp--;
                    count++;
                }
                woods[r,c] = temp;
            }
        if(count < 1)
            CountWoodsRating();
    }

    static void CountWoodsRating()
    {
        int count = 0;
        for(int r = 0; r < 9; r++)
            for(int c = 0; c < 9; c++)
                if (woods[r,c] == 10)
                    count++;
        int rating = count + 30;
        if (rating > 100)
            rating = 100;
        Console.WriteLine($"YOUR RATING IS {rating}.");
        Console.Write("PLAY AGAIN? ");
        string input = Console.ReadLine();
        if(Char.ToUpper(input[0]) == 'Y')
            Main();
        System.Environment.Exit(0);
    }
}