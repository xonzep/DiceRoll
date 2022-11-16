using System;
using System.Collections.Generic;

/*
 * Breakdown of issue before writing code.
 * Create a function that takes in the number of dice we're rolling and how many faces they have. 
 * First we need a list to store our dice rolls.
 * Then we need a random number between 1 and the number of faces our dice have.
 * We can then call that for each dice and store that in our list.
 * We can then sum those numbers.
*/
static void DiceRoll(int dCount, int dFaces)
{
    List<int> diceResults = new();

    for (int i = 1; i < dCount; i++)
    {
        int randomNumber = new Random().Next(1, dFaces);
        diceResults.Add(randomNumber);
    }

    diceResults.ForEach(Console.WriteLine);
    var total = diceResults.Sum();
    Console.WriteLine("The total amount is: " + total);
}

Console.WriteLine("How many dice do you need?");
int userDiceNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many faces are on these dice?");
int userDiceFace = Convert.ToInt32(Console.ReadLine());

DiceRoll(userDiceNum, userDiceFace);