using System;
using TurboCollections;

namespace GameStateHistory
{
    class Program
    {
        static void Main(string[] args)
        {
            GameState gameState = new GameState();
            gameState.RunGame();
        }
    }

    public class GameState
    {
        private TurboLinkedStack<int> stateHistory = new TurboLinkedStack<int>();

        public static int positiveValue = 1;

        public void RunGame()
        {
            PushMainMenu();
        }

        private void PushMainMenu()
        {
            Console.Clear();
            Console.WriteLine("This is Main Menu");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("(0): Go to Level " + (positiveValue));
            Console.WriteLine("(1): Go to Settings");
            Console.WriteLine("(b): Quit");

            string input = Console.ReadLine();
            if (input == "0")
            {
                stateHistory.Push(1); 
                LevelState();
            }
            else if (input == "1")
            {
                Console.Clear();
                Console.WriteLine("Settings are empty.."); 
                Thread.Sleep(300000);
                Environment.Exit(0);
            }
            else if (input.ToLower() == "b")
            {
                Console.Clear();
                Console.WriteLine("Console closing..");
                Environment.Exit(0);
            }
        }
        private void LevelState()
        {
            
                Console.Clear();
                Console.WriteLine("You are at level: " + stateHistory.Count);
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("(0): Go to Level " + (stateHistory.Count +1));
                Console.WriteLine("(1): Go to Main Menu");
                if (stateHistory.Count > 1)
                {
                    Console.WriteLine("(b): Go back to level " + stateHistory.Count);
                }
                else
                {
                    Console.WriteLine("(b): Go back to Main Menu");
                }
                
                string input = Console.ReadLine(); 
                if (input == "0") 
                { 
                    stateHistory.Push( 1); 
                    LevelState(); 
                }
                else if (input == "1") 
                { 
                    stateHistory.Clear(); 
                    PushMainMenu(); 
                }
                else if (input.ToLower() == "b") 
                { 
                    if (stateHistory.Count > 1) 
                    { 
                        stateHistory.Pop(); 
                        LevelState(); 
                    }
                    else 
                    { 
                        PushMainMenu(); 
                    } 
                }
        }
    }
}
