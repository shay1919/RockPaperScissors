using System.Transactions;

string[] computerChoices = ["ROCK", "PAPER", "SCISSORS"];
string computerChoice;
string userChoice;
bool playAgain = true;
Random random = new Random();

void PlayAgain()
{
    Console.WriteLine("Would you like to play again? Enter (Y/N)");
    string input = Console.ReadLine().ToUpper();

    while (input != "Y" || input != "N")

        if (input == "Y")
        {
            playAgain = true;
            break;
        }
        else if (input == "N")
        {
            playAgain = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
            Console.WriteLine("Would you like to play again? Enter (Y/N)");
            input = Console.ReadLine().ToUpper();
        }
}

Console.WriteLine("Welcome to Rock Paper Scissors!");

while (playAgain == true)
{
    Console.WriteLine("Enter Rock, Paper or Scissors: ");

    userChoice = Console.ReadLine().ToUpper();
    computerChoice = computerChoices[random.Next(computerChoices.Length)];

    if (userChoice != "ROCK" ^ userChoice != "PAPER" ^ userChoice != "SCISSORS")
    {
        Console.WriteLine("Invalid input.");
        continue;
    }

    switch (userChoice)
    {
        case "ROCK":
            if (computerChoice == "ROCK")
            {
                Console.WriteLine($"Computer chooses:  {computerChoice}");
                Console.WriteLine("It's a draw!");
                break;
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine($"Computer chooses:  {computerChoice}");
                Console.WriteLine("You lose!");
                break;
            }
            else if (computerChoice == "SCISSORS")
            {
                Console.WriteLine($"Computer chooses:  {computerChoice}");
                Console.WriteLine("You win!");
                break;
            }
            break;

        case "PAPER":
            if (computerChoice == "ROCK")
            {
                Console.WriteLine($"Computer chooses:  {computerChoice}");
                Console.WriteLine("You win!");
                break;
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine($"Computer chooses:  {computerChoice}");
                Console.WriteLine("It's a draw!");
                break;
            }
            else if (computerChoice == "SCISSORS")
            {
                Console.WriteLine($"Computer chooses:  {computerChoice}");
                Console.WriteLine("You lose!");
                break;
            }
            break;

        case "SCISSORS":
            if (computerChoice == "ROCK")
            {
                Console.WriteLine($"Computer chooses:  {computerChoice}");
                Console.WriteLine("You lose!");
                break;
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine($"Computer chooses:  {computerChoice}");
                Console.WriteLine("You win!");
                break;
            }
            else if (computerChoice == "SCISSORS")
            {
                Console.WriteLine($"Computer chooses:  {computerChoice}");
                Console.WriteLine("It's a draw!");
                break;
            }
            break;
    }
    PlayAgain();
}
Console.WriteLine("Thanks for playing!");