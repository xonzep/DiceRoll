using System;
using System.Collections.Generic;

/*
 * Create a function that takes in the number of dice we're rolling and how many faces they have. 
 * First we need a list to store our dice rolls.
 * Then we need a random number between 1 and the number of faces our dice have.
 * We can then call that for each dice and store that in our list.
 * We then sum those numbers.
*/
static void DiceRoll(int dCount, int dFaces)
{
    List<int> diceResults = new();

    for (int i = 1; i < dCount; i++)
    {
        int randomNumber =  new Random().Next(1, dFaces);
        diceResults.Add(randomNumber);
    }

    diceResults.ForEach(Console.WriteLine);
    var Total = diceResults.Sum();
}

DiceRoll(8, 6);
