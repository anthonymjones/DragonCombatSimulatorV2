using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorV2
{
    public enum AttackType
    {
        Sword,
        Magic,
        Heal,
        Null
    }

    class Player
    {
        //STEP 1. DECLARE PROPERTIES
        public int HP { get; set; }
        public bool IsAlive
        {
            get
            {
                return HP > 0;
            }
        }
        //STEP 2. CONSTRUCTORS
        public Player(int hp)
        {
            this.HP = hp;
        }

        //STEP 3. METHODS AND FUNCTIONS
        public int DoAttack(Enemy Enemy)
        {
            AttackType chosenAttack = ChooseAttack();
            int damage = 0;
            //if their selection is 1 
            if (chosenAttack == AttackType.Sword)
            {
                //there are only 6 grenades in the bag
                int att1Count = 0;
                if (att1Count > 5)
                {
                    Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                    Console.WriteLine("  You can't find any more grenades. While you were looking through your bag, the zombies attack.");
                    Console.WriteLine("|________________________________________________________________________________________________________|");

                }
                else
                {
                    //calculate their chance of hitting (70%)
                    Random rng = new Random();
                    int playerHitChance = rng.Next(1, 101);
                    //Attack 1 hits
                    if (playerHitChance < 70)
                    {
                        //calculate the amount of damage(20 - 35 HP) to the dragon, display to player, subtract amount from dragon HP
                        damage = rng.Next(20, 36);
                        Enemy.HP -= damage;
                        Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                        Console.WriteLine("  The grenade hits the middle of the horde, and causes " + damage + " damage to the zombies!");
                        Console.WriteLine("|________________________________________________________________________________________________________|");

                    }
                    //didn't hit
                    else
                    {
                        //tell the player they missed.
                        Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                        Console.WriteLine("  The grenade fizzled out. It was a dud!");
                        Console.WriteLine("|________________________________________________________________________________________________________|");

                    }
                    att1Count++;
                }
            }
            //else if their selection is 2
            else if (chosenAttack == AttackType.Magic)
            {
                //calculate their chance of hitting (98%)
                Random rng = new Random();
                int playerShotChance = rng.Next(1, 101);
                if (playerShotChance < 98)
                {
                    int playerCriticalChance = rng.Next(1, 101);
                    int att2Count = 0;
                    if (playerCriticalChance < 15)
                    {
                        //critical hit, causes 65 damage
                        int att2critDam = 65;
                        Enemy.HP -= att2critDam;
                        Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                        Console.WriteLine("  You blasted the zombies with your shotgun, and it was a CRITICAL HIT! Causing 65 damage to the horde!");
                        Console.WriteLine("|________________________________________________________________________________________________________|");

                        att2Count++;
                    }
                    else
                    {
                        //they hit, calculate the amount of damage(10 - 15 HP) to the dragon, display to player, subtract the amount from dragon HP
                        damage = rng.Next(10, 16);
                        Enemy.HP -= damage;
                        Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                        Console.WriteLine("  You blasted the zombies with your shotgun, and caused " + damage + " damage to the horde!");
                        Console.WriteLine("|________________________________________________________________________________________________________|");
                        att2Count++;
                    }
                }
                //didn't hit
                else
                {
                    //tell the player they missed.
                    Console.WriteLine(@" ___________________________________________________________________________________________________
|                                                                                                   |");
                    Console.WriteLine("  The shotgun misfired!");
                    Console.WriteLine("|___________________________________________________________________________________________________|");
                }
            }
            //else if their selection is 3, 
            else if (chosenAttack == AttackType.Heal)
            {
                int healCount = 0;
                if (healCount > 4)
                {
                    Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                    Console.WriteLine("  You can't find any more syringes. While you were looking through your bag, the zombies attack.");
                    Console.WriteLine("|________________________________________________________________________________________________________|");
                }
                else
                {
                    //calculate the amount they've healed(10 - 20 HP), display to player, add the amount to player HP
                    Random rng = new Random();
                    damage = rng.Next(10, 21);
                    HP += damage;
                    Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                    Console.WriteLine("  You plunge a syringe into your heart, and heal " + damage + " points.");
                    Console.WriteLine("|________________________________________________________________________________________________________|");

                    healCount++;
                }
            }
            //                else if (9)
            //                {
            //                    HP = HP - 200;
            //                    Console.WriteLine(@" ___________________________________________________________________________________________________________________________________________
            //|                                                                                                                                           |");
            //                    Console.WriteLine("  You realize that you're Superman, and take out the entire zombie horde with your heat vision. Wait, why did you let that doctor die?");
            //                    Console.WriteLine("|___________________________________________________________________________________________________________________________________________|");

//                }
            else if (chosenAttack == AttackType.Null)
            {
                Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                Console.WriteLine("  You froze. The zombies attack");
                Console.WriteLine("|________________________________________________________________________________________________________|");
            }
            return damage;
        }
        private AttackType ChooseAttack()
        {
            string input = Console.ReadLine();

            if(input == "1")
            { 
                return AttackType.Sword; 
            }
            else if (input == "2") 
            {
                return AttackType.Magic;
            }
            else if (input == "3")
            {
                return AttackType.Heal;
            }
            else
            {
                return AttackType.Null;
            }
        }

    }
}

