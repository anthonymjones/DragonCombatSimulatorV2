using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set console window width to max
            Console.WindowWidth = 160;
            Console.WindowHeight = 55;

            //Play game
            Game game = new Game();
            game.PlayGame();

            //Keep the console window open
            Console.ReadKey();
        }
        }
    }

