 Random random = new Random();
        bool playAgain; // Create a bool so whole game repeats

do
{
    // Difficulty selection
    Console.WriteLine("Choose difficulty level:");
    Console.WriteLine("1. Easy (1–10)"); // Print out Easy difficulty with the numbers you have to guess around
    Console.WriteLine("2. Medium (1–50)"); // Print out Medium difficulty with the numbers you have to guess around
    Console.WriteLine("3. Hard (1–100)"); // Print out Hard difficulty with the numbers you have to guess around
    Console.Write("Enter choice (1–3): ");
    string difficultyChoice = Console.ReadLine();

    int maxNumber; // Create a new int for us to put the int = "max number depending on diffculty"

    switch (difficultyChoice) //Switch statment for what thing they pick
    {
        case "1":
            maxNumber = 10; // Set max number to 10
            Console.WriteLine("You selected Easy mode!"); // Print out saying they picked easy
            break;
        case "2":
            maxNumber = 50; // Set max number to 50
            Console.WriteLine("You selected Medium mode!"); // Print out they picked medium
            break;
        case "3":
            maxNumber = 100; // Set max number to 100
            Console.WriteLine("You selected Hard mode!"); // Print out they picked hard
            break;
        default:
            maxNumber = 10; // Default if they chose nothing to 10 max number
            Console.WriteLine("Invalid choice! Defaulting to Easy mode (1–10)."); // Print out that they chose nothing and its going easy
            break;
    }

    // Generate a random secret number between 1 and maxNumber
    int secretNumber = random.Next(1, maxNumber + 1);
    int guess;
    int attempts = 0;

     // Tell the player the range of possible numbers
    Console.WriteLine($"\nI have chosen a number between 1 and {maxNumber}. Try to guess it!");

     // Start guessing loop
    do
    {
         // Ask player for their guess
        Console.Write("Enter your guess: ");
        guess = Convert.ToInt32(Console.ReadLine());
        attempts++;

         // Check if the guess is too low
        if (guess < secretNumber)
        {
            Console.WriteLine("Too low, try again.");
        }
        // Check if the guess is too high
        else if (guess > secretNumber)
        {
            Console.WriteLine("Too high, try again.");
        }
        // If not too high or too low, the player guessed correctly
        else
        {
            Console.WriteLine($"🎉 Correct! You guessed the number in {attempts} attempts!");
        }

    } while (guess != secretNumber); // Keep looping until player guesses correctly

    // Play again?
    Console.Write("\nWould you like to play again? (Y/N): ");
    string response = Console.ReadLine().ToUpper();
    // Set playAgain to true if response is "Y", otherwise false
    playAgain = (response == "Y");

    Console.WriteLine(); // Add a blank line for spacing
 
} while (playAgain); // Repeat entire game if player wants to play again
       
        // End of program message
        Console.WriteLine("Thanks for playing! Goodbye 👋");