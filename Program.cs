
List<string> history = new List<string>();
int points = 0;
void MainMenu()
{
    Console.Clear();
    Console.WriteLine("Welcome to my math game. Please select a menu option.");
    Console.WriteLine("1: Addition");
    Console.WriteLine("2: Subtraction");
    Console.WriteLine("3: Multiplication");
    Console.WriteLine("4: Division");
    Console.WriteLine("5: History");
    Console.WriteLine("6. Exit Game");
    int gameSelect = Convert.ToInt32(Console.ReadLine());


    if (gameSelect <= 4)
    {
        Game(gameSelect);
    }
    else if (gameSelect == 5)
    {
        ViewHistory();
    }
    else if (gameSelect == 6)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid Input, please enter an option listed above. Thank you.");
    }

}

MainMenu();
void Game(int gameSelect)
{
    Console.Clear();
    string op = "";

    switch (gameSelect)
    {
        case 1:
            op = "+";
            break;
        case 2:
            op = "-";
            break;
        case 3:
            op = "*";
            break;
        case 4:
            op = "/";
            break;
    }


    for (int i = 0; i < 5; ++i)
    {
        (int x, int y) nums = (0, 0);

        if(gameSelect != 4)
        {
             nums = GetNumbers();
        }
        else
        {
            nums = GetNumbersDivision();
        }
        
        Console.WriteLine($"Question {i + 1}: {nums.x} {op} {nums.y}");
        int validator = 0;
        int response = Convert.ToInt32(Console.ReadLine());
        switch (op)
        {
            case "+":
                validator = nums.x + nums.y;
                break;
            case "-":
                validator = nums.x - nums.y;
                break;
            case "*":
                validator = nums.x * nums.y;
                break;
            case "/":
                validator = nums.x / nums.y;
                break;
        }
        if (validator == response)
        {
            Console.WriteLine("Correct!");
            points++;
        }
        else
        {
            Console.WriteLine($"Incorrect. The answer was {validator}");
        }
    }
    history.Add(points.ToString());
    points = 0;
    Console.WriteLine("Do you want to play again? Enter Y/N");
    string playAgain = Console.ReadLine()!.ToString().ToLower();

    if (playAgain == "y")
    {
        MainMenu();
    }
    else
    {
        Console.WriteLine("Thank you for playing");
        Environment.Exit(0);
    }

}
(int x, int y) GetNumbers()
{
    Random rand = new Random();
    int x = rand.Next(0, 10);
    int y = rand.Next(0, 10);
    return (x, y);
}
void ViewHistory()

{
    Console.WriteLine("Printing History!");
    Console.WriteLine("-------------------------------------------");
    for (int i = 0; i < history.Count; i++)
    {
        Console.WriteLine(history[i]);
    }
    Console.WriteLine(0);
    Console.WriteLine("Press 'q' to quit. Otherwise, press any key to return to the main menu.");

    string quit = Console.ReadLine()!.Trim().ToLower();

    if (quit == "q")
    {
        Environment.Exit(0);
    }
    else
    {
        MainMenu();
    }
}
(int x, int y) GetNumbersDivision()
{
    Random rand = new Random();
    int x = rand.Next(0, 100);
    int y = rand.Next(1, 10);

    while (x % y != 0)
    {
        x = rand.Next(0, 100);
        y = rand.Next(1, 10);
    }
    return (x, y);
}

