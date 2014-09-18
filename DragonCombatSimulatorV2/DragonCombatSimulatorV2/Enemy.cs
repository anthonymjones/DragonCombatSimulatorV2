using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorV2
{
    class Enemy
    {
        //STEP 1. DECLARE PROPERTIES
        public string Name { get; set; }
        public int HP { get; set; }
        public bool IsAlive
        {
            get
            {
                return HP > 0;
            }
        }
        //STEP 2. CONSTRUCTORS
        public Enemy(string name, int hp)
        {
            this.Name = name;
            this.HP = hp;
        }
        //STEP 3. METHODS AND/OR FUNCTIONS

        //takes no args, contains all the logic for determining a hit. Combat text for the attack also happens here
        //It returns an int in the amount of damage dealt for use with the TakeDamage().
        public int DoAttack(Player Player)
        {
            //Create random number generator
            Random rng = new Random();
            //Calculate the horde chance of hitting (80%)
            int hordeHitChance = rng.Next(1, 101);
            int damage = 0;
            //Horde hit
            if (hordeHitChance < 80)
            {
                //Calculate the amount of damage(5 - 15 HP) to the player, display to the player, subtract amount from player HP
                damage = rng.Next(5, 16);
                Player.HP -= damage;
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("    The zombies grab you and take a bite for " + damage + " damage!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("    Press any key to make your next move.");
            }
            //Horde missed
            else
            {
                //tell the player the horde missed.
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("    The zombies slash at you, but miss!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("    Press any key to make your next move.");
            }

            return damage;
        }


    }
}
