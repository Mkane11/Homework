// written by Mamoutou Kane
// date: 02/16/2025
using System;

class ChestLockingMechanism
{
    enum ChestState
    {
        Open,
        Closed,
        Locked
    }

    static void Main()
    {
        ChestState currentState = ChestState.Locked;

        while (true)
        {
            Console.WriteLine($"The chest is {currentState.ToString().ToLower()}. What do you want to do?");
            string command = Console.ReadLine().ToLower();

            switch (currentState)
            {
                case ChestState.Open:
                    if (command == "close")
                        currentState = ChestState.Closed;
                    break;
                case ChestState.Closed:
                    if (command == "open")
                        currentState = ChestState.Open;
                    else if (command == "lock")
                        currentState = ChestState.Locked;
                    break;
                case ChestState.Locked:
                    if (command == "unlock")
                        currentState = ChestState.Closed;
                    break;
            }
        }
    }
}

