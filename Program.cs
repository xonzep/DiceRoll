
/*
 * Breakdown of issue before writing code.
 * Create a function that takes in the number of dice we're rolling and how many faces they have. 
 * First we need a list to store our dice rolls.
 * Then we need a random number between 1 and the number of faces our dice have.
 * We can then call that for each dice and store that in our list.
 * We can then sum those numbers.
*/


static List<int> DiceRoll(int dCount, int dFaces)
{
    List<int> diceResults = new();
    Random random = new Random();
    
    //For loop to get our numbers.
    for (int i = 0; i < dCount; i++)
    {
        int randomNumber = random.Next(1, dFaces);
        diceResults.Add(randomNumber);
    }

    return diceResults;

}

static void DisplayResult(List<int> diceResults)
{
    diceResults.ForEach(Console.WriteLine);
    int total = diceResults.Sum();
    Console.WriteLine("The total amount is: " + total);    
}


static int ParseIntInput(string prompt)
{
    Console.WriteLine(prompt);
    int userInput;
    while (!int.TryParse(Console.ReadLine(), out userInput))
    {
        Console.WriteLine("Invalid input. Please input a valid integer value.");
    }

    return userInput;
}

bool continueRolling = true;
while (continueRolling)
{
    int userDiceNum = ParseIntInput("How many dice do you need?");
    int userDiceFace = ParseIntInput("How many faces are on these dice?");

    Console.WriteLine(" ");

    var results = DiceRoll(userDiceNum, userDiceFace);
    DisplayResult(results);
    
    Console.WriteLine("Do you wish to roll again? (Y/N)");
    string? userAnswer = Console.ReadLine();
    continueRolling = (userAnswer?? "Y").ToUpper() == "Y";
}