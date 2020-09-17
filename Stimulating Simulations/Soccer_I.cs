// Note this is unfinished.

// Adapted from: Stimulating Simulations by C.W. Engel (c) 1977
// Adapted by: Kyle Givler
//
// This was was a struggle.. Trying to find BASIC doumenation for various flavors of BASIC
// PRINT@ was something I was not familair with and had to work around. 
// It looks like what I was planning won't even work. Will have to come back to this one...

using System;
using System.Drawing;

class Soccer_I
{
    public static void Main()
    {
        Point[] p1Loc = new Point[5];
        Point[] p2Loc = new Point[5];
        Point oldLoc;

        ConsoleKeyInfo cki;
        ConsoleKey key;
        char asciiCharacter;
        ConsoleKey direction;

        // REM SET
        Console.Clear();
        Console.SetWindowSize(63,20);
        int player = 1; // P - Player

        // REM PRINT
        for(int i = 0; i < 5; i++)
        {
            p1Loc[i] = new Point(1, i);
            Console.SetCursorPosition(1,i); // column,row
            Console.WriteLine((char) (65+i));
        }
        for(int i = 0; i< 5; i++)
        {
            p2Loc[i] = new Point(1, i);
            Console.SetCursorPosition(57,i);
            Console.WriteLine((char) (49+i));
        }

        // REM INPUT
        cki = Console.ReadKey(true);
        key = cki.Key;
        asciiCharacter = cki.KeyChar;
        if (player ==1)
            asciiCharacter -= (char)65;
        else
            asciiCharacter -= (char)44;
        oldLoc = p1Loc[asciiCharacter];

        cki = Console.ReadKey(true);
        key = cki.Key;
        direction = cki.Key;

        // REM START MOVE
        for(int i = 1; i <= 10; i++)
            ;

        // REM CHECKS
    }
}