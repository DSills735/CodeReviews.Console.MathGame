using System.Collections;
using System.Runtime.InteropServices;

Console.WriteLine("Welcome to my math game!");
List<string> history = new List<string>();
MainMenu();



void MainMenu()
{
    Console.WriteLine("Please choose a gamemode:");
    Console.WriteLine("1: Addition");
    Console.WriteLine("2: Subtraction");
    Console.WriteLine("3: Multiplication");
    Console.WriteLine("4: Division");
    //Console.WriteLine("5: Random"); //change the numbers below when this is updated. 
    Console.WriteLine("5: History");
    Console.WriteLine("6. Exit Game");

    int gameSelect = Convert.ToInt32(Console.ReadLine());


    if (gameSelect == 1)
    {
        Addition();
    }
    if(gameSelect == 2)
    {
        Subtraction();
    }
    if(gameSelect == 3)
    {
        Multiplication();
    }
    if(gameSelect == 4)
    {
        Division();
    }
    if(gameSelect == 5)
    {
        ViewHistory();
    }
}

//Methods for gameplay

void Addition()
{
    Console.WriteLine("You chose addition! Welcome to the game.");
    Console.WriteLine("We will ask you 5 math questions. Please input your answer when prompted.");
    int points = 0;
    Random rand = new Random();
    int a = rand.Next(0, 10);
    int b = rand.Next(0, 10);

    for (int i = 0; i < 5; ++i)
    {
        
        int solution = a + b;
        Console.WriteLine($"Please give the soltion to: {a} + {b} = ?");
        int userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput == solution)
        {
            Console.WriteLine("Correct!");

            points += 1;
        }
        else
        {
            Console.WriteLine("Incorrect");
        }

    }
    Console.WriteLine($"You have completed the math game with a score of {points} / 5");
    Console.WriteLine("Do you want to play again? Y/N");
    string playAgain = Console.ReadLine()!.Trim().ToLower();
    history.Add($"{points}pts");
    if (playAgain == "y")
    {
        Console.Clear();
        MainMenu();
    }
    else
    {
        Console.WriteLine("Thanks for playing. See you next time!");
        Environment.Exit(0);
    }

}

void Subtraction()
{
    Console.WriteLine("You chose subtraction! Welcome to the game.");
    Console.WriteLine("We will ask you 5 math questions. Please input your answer when prompted.");
    int points = 0;
    Random rand = new Random();
    int a = rand.Next(0, 10);
    int b = rand.Next(0, 10);

    for (int i = 0; i < 5; ++i)
    {
        
        int solution = a - b;
        Console.WriteLine($"Please give the soltion to: {a} - {b} = ?");
        int userInput = Convert.ToInt32(Console.ReadLine());
        history.Add($"{points}pts");
        if (userInput == solution)
        {
            Console.WriteLine("Correct!");

            points++;
        }
        else
        {
            Console.WriteLine("Incorrect");
        }

    }
    Console.WriteLine($"You have completed the math game with a score of {points} / 5");
    Console.WriteLine("Do you want to play again? Y/N");
    string playAgain = Console.ReadLine()!.Trim().ToLower();
    if (playAgain == "y")
    {
        Console.Clear();
        MainMenu();
    }
    else
    {
        Console.WriteLine("Thanks for playing. See you next time!");
        Environment.Exit(0);
    }
}
void Multiplication()
{
    Console.WriteLine("You chose multiplication! Welcome to the game.");
    Console.WriteLine("We will ask you 5 math questions. Please input your answer when prompted.");
    int points = 0;
    Random rand = new Random();
    int a = 0;
    int b = 0;

    for (int i = 0; i < 5; ++i)
    {
        a = rand.Next(0,10);
        b = rand.Next(0, 10);
        int solution = a * b;
        Console.WriteLine($"Please give the soltion to: {a} X {b} = ?");
        int userInput = Convert.ToInt32(Console.ReadLine());
        
        if (userInput == solution)
        {
            Console.WriteLine("Correct!");

            points++;
        }
        else
        {
            Console.WriteLine("Incorrect");
        }

    }
    Console.WriteLine($"You have completed the math game with a score of {points} / 5");
    Console.WriteLine("Do you want to play again? Y/N");
    history.Add($"{points}pts");
    string playAgain = Console.ReadLine()!.Trim().ToLower();
    if (playAgain == "y")
    {
        Console.Clear();
        MainMenu();
    }
    else
    {
        Console.WriteLine("Thanks for playing. See you next time!");
        Environment.Exit(0);
    }
}

void Division()
{
    Console.WriteLine("You chose division! Welcome to the game.");
    Console.WriteLine("We will ask you 5 math questions. Please input your answer when prompted. Please note the answer will always be a whole number.");
    int points = 0;
    Random rand = new Random();
    int a = rand.Next(0, 10);
    int b = rand.Next(0, 10);

    for (int i = 0; i < 5; ++i)
    {
        a = rand.Next(10,100);
        b = rand.Next(1, 10);
        
         while(a % b != 0)
        {
            a = rand.Next(5,100);
            b = rand.Next(2, 10);
        }
        
        int solution = a / b;
        Console.WriteLine($"Please give the soltion to: {a} / {b} = ?");
        int userInput = Convert.ToInt32(Console.ReadLine());
        
        if (userInput == solution)
        {
            Console.WriteLine("Correct!");

            points++;
        }
        else
        {
            Console.WriteLine("Incorrect");
        }

    }
    Console.WriteLine($"You have completed the math game with a score of {points} / 5");
    Console.WriteLine("Do you want to play again? Y/N");
    history.Add($"{points}pts");
    string playAgain = Console.ReadLine()!.Trim().ToLower();
    if (playAgain == "y")
    {
        Console.Clear();
        MainMenu();
    }
    else
    {
        Console.WriteLine("Thanks for playing. See you next time!");
        Environment.Exit(0);
    }
}

void ViewHistory()
{
    for(int i = 0; i < history.Count; i++)
    {
        Console.WriteLine(history[i]);
    }
}
