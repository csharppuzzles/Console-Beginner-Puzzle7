using System;
using System.Numerics;

static void ExampleA()
{
    Console.WriteLine("\nExample A");
    Console.WriteLine("~~~~~~~~~");

    int input = 0;
    int apples = 10;
    double i = 2;
    bool isActive = true;

    if (isActive)
    {
        // You can't divide by 0.
        // It will run but will fail, a "run time" error.
        int ans = 10 / input;
        Console.WriteLine($"10 / {input} is {ans}");

        // TESTING - Andy 29/Oct/24
        Console.WriteLine($"Test: apples is of type {apples.GetType()}");
        Console.WriteLine($"Test: i is of type {i.GetType()}");

        // You can't divide a double by an int, one must be converted!
        // This is a "compile time" error.
        // You can't build the program without fixing it, and will have red wavy lines.
        // int ans2 = apples / i;
        // Console.WriteLine($"{apples} / {i} is {ans2}");
    }

}


static void ExampleB()
{
    Console.WriteLine("\nExample B");
    Console.WriteLine("~~~~~~~~~");

    try
    {
        int input = 0;

        int i = 0;
        while (i < 5)
        {

            int ans = 10 / input;
            Console.WriteLine($"10 / {input} is {ans}");

            if(i == 3)
            {
                // This creates a new exception.
                // Read up on "throwing exceptions"
                throw new Exception("Test Exception");
            }

            i++;

        }

    }
    catch(DivideByZeroException ex)
    {
        // This will catch the DivideByZero error ONLY
        Console.WriteLine($"Sorry, you can't divide by zero! Error: {ex.Message}");
    }
    catch(Exception ex)
    {
        // This will catch every other error
        Console.WriteLine($"General Error: {ex.Message}");
    }

}


// Puzzle A - Get Past Gandalf
// Add a try-catch block to this code and debug it.
static void PuzzleA()
{
    Console.WriteLine("\nPuzzle A");
    Console.WriteLine("~~~~~~~~~");

    string challenge = null;

    Console.WriteLine("Gandalf: 'You shall not pass!'...");

    Console.WriteLine("Try and pass? y/n:");
    string input = Console.ReadLine();

    if(input.ToLower() == "y"){
        string uppercaseInput = challenge.ToUpper();
        Console.WriteLine($"{uppercaseInput} ");
    }
    else
    {
        Console.WriteLine("Gandalf: 'Phew, I thought you were going to try and pass! Slow down!'...");
    }
}



// Puzzle B - Format me not
// Add a try-catch block to this code and debug it.

static void PuzzleB()
{
    Console.WriteLine("\nPuzzle B");
    Console.WriteLine("~~~~~~~~~");

    double input = 0;

    Console.WriteLine("Enter a number with a floating point:");
    input = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(String.Format("Your number was {1}", input));
}



// Puzzle C - Microsoft Money
// Add a try-catch block to this code and debug it.
// If Bill has too much money for a decimal to store, can we find a value type that can handle it?
// Alternatively, lets just give him a second bank account? Put any new money in there.
// You can find the max value of a decimal using decimal.MaxValue
static void PuzzleC()
{
    Console.WriteLine("\nPuzzle C");
    Console.WriteLine("~~~~~~~~~");

        decimal billGatesBankBalance = 79228162514264337593543950332m;

        int i = 0;
        while (i < 5)
        {

            billGatesBankBalance = billGatesBankBalance + 1;
            
            Console.WriteLine("Yo, we got another dollar from selling Word :-) +$1");
            Console.WriteLine($"Bank balance 1 is now: ${billGatesBankBalance}");

            i++;
        }
}




// Run the puzzles

ExampleA();
ExampleB();

//PuzzleA();
//PuzzleB();
//PuzzleC();



Console.WriteLine("\n Press enter to exit the program...");
Console.ReadLine();                                         // Keeps the console app window open until you hit enter