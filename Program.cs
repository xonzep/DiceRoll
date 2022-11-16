using System;
using System.Collections.Generic;

void DiceRoll(int dCount, int dFaces)
{
    List<int> diceResults = new();

    for(int i = 1; i < dCount; i++)
    {
        int randomNumber =  new Random().Next(1, dFaces);
        diceResults.Add(randomNumber);
    }

    diceResults.ForEach(Console.WriteLine);
    var Total = diceResults.Sum();
}

DiceRoll(8, 6);
