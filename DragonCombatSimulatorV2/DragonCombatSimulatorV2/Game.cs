using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorV2
{
    class Game
    {
        //STEP 1. DECLARE PROPERTIES
        public Player Player { get; set; }
        public Enemy Enemy { get; set; }
        //STEP 2. CONSTRUCTORS
        public Game()
        {
            this.Player = Player;
            this.Enemy = Enemy;
        }

        //STEP 3. METHODS AND FUNCTIONS
        public void Title()
        {
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine(@"                                    TTTTTTTTTTTTTTTTTTTTTTTHHHHHHHHH     HHHHHHHHHEEEEEEEEEEEEEEEEEEEEEE"); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                    T:::::::::::::::::::::TH:::::::H     H:::::::HE::::::::::::::::::::E"); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                    T:::::::::::::::::::::TH:::::::H     H:::::::HE::::::::::::::::::::E"); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                    T:::::TT:::::::TT:::::THH::::::H     H::::::HHEE::::::EEEEEEEEE::::E"); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                    TTTTTT  T:::::T  TTTTTT  H:::::H     H:::::H    E:::::E       EEEEEE"); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                            T:::::T          H:::::H     H:::::H    E:::::E             "); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                            T:::::T          H::::::HHHHH::::::H    E::::::EEEEEEEEEE   "); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                            T:::::T          H:::::::::::::::::H    E:::::::::::::::E   "); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                            T:::::T          H:::::::::::::::::H    E:::::::::::::::E   "); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                            T:::::T          H::::::HHHHH::::::H    E::::::EEEEEEEEEE   "); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                            T:::::T          H:::::H     H:::::H    E:::::E             "); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                            T:::::T          H:::::H     H:::::H    E:::::E       EEEEEE"); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                          TT:::::::TT      HH::::::H     H::::::HHEE::::::EEEEEEEE:::::E"); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                          T:::::::::T      H:::::::H     H:::::::HE::::::::::::::::::::E"); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                          T:::::::::T      H:::::::H     H:::::::HE::::::::::::::::::::E"); System.Threading.Thread.Sleep(50);
            Console.WriteLine(@"                                          TTTTTTTTTTT      HHHHHHHHH     HHHHHHHHHEEEEEEEEEEEEEEEEEEEEEE"); System.Threading.Thread.Sleep(50);
            Console.WriteLine(); System.Threading.Thread.Sleep(500);
            Console.WriteLine(@" WWWWWWWW                           WWWWWWWW   AAA               KKKKKKKKK    KKKKKKKIIIIIIIIIINNNNNNNN        NNNNNNNN        GGGGGGGGGGGGG"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@" W::::::W                           W::::::W  A:::A              K:::::::K    K:::::KI::::::::IN:::::::N       N::::::N     GGG::::::::::::G"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@" W::::::W                           W::::::W A:::::A             K:::::::K    K:::::KI::::::::IN::::::::N      N::::::N   GG:::::::::::::::G"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@" W::::::W                           W::::::WA:::::::A            K:::::::K   K::::::KII::::::IIN:::::::::N     N::::::N  G:::::GGGGGGGG::::G"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@" W:::::W           WWWWW           W:::::WA:::::::::A            K::::::K  K:::::KKK  I::::I  N::::::::::N    N::::::N G:::::G       GGGGGG"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"  W:::::W         W:::::W         W:::::WA:::::A:::::A            K:::::K K:::::K     I::::I  N:::::::::::N   N::::::NG:::::G              "); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"   W:::::W       W:::::::W       W:::::WA:::::A A:::::A           K::::::K:::::K      I::::I  N:::::::N::::N  N::::::NG:::::G              "); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"    W:::::W     W:::::::::W     W:::::WA:::::A   A:::::A          K:::::::::::K       I::::I  N::::::N N::::N N::::::NG:::::G    GGGGGGGGGG"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"     W:::::W   W:::::W:::::W   W:::::WA:::::A     A:::::A         K:::::::::::K       I::::I  N::::::N  N::::N:::::::NG:::::G    G::::::::G"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"      W:::::W W:::::W W:::::W W:::::WA:::::AAAAAAAAA:::::A        K::::::K:::::K      I::::I  N::::::N   N:::::::::::NG:::::G    GGGGG::::G"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"       W:::::W:::::W   W:::::W:::::WA:::::::::::::::::::::A       K:::::K K:::::K     I::::I  N::::::N    N::::::::::NG:::::G        G::::G"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"        W:::::::::W     W:::::::::WA:::::AAAAAAAAAAAAA:::::A     K::::::K  K:::::KKK  I::::I  N::::::N     N:::::::::N G:::::G       G::::G"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"          W:::::::W       W:::::::WA:::::A             A:::::A   K:::::::K   K::::::KII::::::IIN::::::N      N::::::::N  G:::::GGGGGGGG::::G"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"           W:::::W         W:::::WA:::::A               A:::::A  K:::::::K    K:::::KI::::::::IN::::::N       N:::::::N   GG:::::::::::::::G"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"            W:::W           W:::WA:::::A                 A:::::A K:::::::K    K:::::KI::::::::IN::::::N        N::::::N     GGG::::::GGG:::G"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(@"             WWW             WWWAAAAAAA                   AAAAAAAKKKKKKKKK    KKKKKKKIIIIIIIIIINNNNNNNN         NNNNNNN        GGGGGG   GGGG"); System.Threading.Thread.Sleep(100);
            Console.WriteLine(); System.Threading.Thread.Sleep(700);
            Console.WriteLine(@"                          DDDDDDDDDDDDD      EEEEEEEEEEEEEEEEEEEEEE               AAA               DDDDDDDDDDDDD        ");
            Console.WriteLine(@"                          D::::::::::::DDD   E::::::::::::::::::::E              A:::A              D::::::::::::DDD     ");
            Console.WriteLine(@"                          D:::::::::::::::DD E::::::::::::::::::::E             A:::::A             D:::::::::::::::DD   ");
            Console.WriteLine(@"                          DDD:::::DDDDD:::::DEE::::::EEEEEEEEE::::E            A:::::::A            DDD:::::DDDDD:::::D  ");
            Console.WriteLine(@"                            D:::::D    D:::::D E:::::E       EEEEEE           A:::::::::A             D:::::D    D:::::D ");
            Console.WriteLine(@"                            D:::::D     D:::::DE:::::E                       A:::::A:::::A            D:::::D     D:::::D");
            Console.WriteLine(@"                            D:::::D     D:::::DE::::::EEEEEEEEEE            A:::::A A:::::A           D:::::D     D:::::D");
            Console.WriteLine(@"                            D:::::D     D:::::DE:::::::::::::::E           A:::::A   A:::::A          D:::::D     D:::::D");
            Console.WriteLine(@"                            D:::::D     D:::::DE:::::::::::::::E          A:::::A     A:::::A         D:::::D     D:::::D");
            Console.WriteLine(@"                            D:::::D     D:::::DE::::::EEEEEEEEEE         A:::::AAAAAAAAA:::::A        D:::::D     D:::::D");
            Console.WriteLine(@"                            D:::::D     D:::::DE:::::E                  A:::::::::::::::::::::A       D:::::D     D:::::D");
            Console.WriteLine(@"                            D:::::D    D:::::D E:::::E       EEEEEE    A:::::AAAAAAAAAAAAA:::::A      D:::::D    D:::::D ");
            Console.WriteLine(@"                          DDD:::::DDDDD:::::DEE::::::EEEEEEEE:::::E   A:::::A             A:::::A   DDD:::::DDDDD:::::D  ");
            Console.WriteLine(@"                          D:::::::::::::::DD E::::::::::::::::::::E  A:::::A               A:::::A  D:::::::::::::::DD   ");
            Console.WriteLine(@"                          D::::::::::::DDD   E::::::::::::::::::::E A:::::A                 A:::::A D::::::::::::DDD     ");
            Console.WriteLine(@"                          DDDDDDDDDDDDD      EEEEEEEEEEEEEEEEEEEEEEAAAAAAA                   AAAAAAADDDDDDDDDDDDD        ");
            System.Threading.Thread.Sleep(500);
            System.Threading.Thread.Sleep(200);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.Clear();
        }
        public void DisplayCombatInfo()
        {
            Console.Clear();
            Console.WriteLine();
            //player stats bar
            Console.WriteLine(@"_________________________________________________________________________________________________________________________________________________________

  Player Health     " + this.Player.HP + "/100                                                                                                 Horde Health     " + this.Enemy.HP + @"/200
_________________________________________________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Make your move. Throw a grenade (press 1), Fire your shotgun (press 2), Take the adrenaline (press 3)");
            Console.WriteLine();
        }
        public void PlayGame()
        {
            this.Player = new Player(100);
            this.Enemy = new Enemy("Zombie Horde", 200);

            Title();
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            //enter instructions here
            Console.Clear();
            Console.WriteLine
                (@"
Doctor: 'Well " + playerName + @", I have some good news and some bad news. 
The good news is you're immune to the virus. The bad news is the zombies can still kill you, 
and there's a horde about to break through that door behind you. Take this bag full of supplies, hopefully they'll help.'

You open the bag. There are grenades, a shotgun, and a few syringes marked 'adrenaline'.
The grenades are powerful, causing between 20 - 30 damage to the horde,  but there's only a 70% chance they work.
The shotgun works every time, but it's not as powerful, causing 10 - 15 damage to the horde.
The adrenaline will boost your health by 10 - 20 points.

Doctor: 'This horde is strong. If I were to rate their health on a scale of 1 - 200, I'd give them a 200.
That's about twice as much as you. I'll try to block the door so you can get a head start.'

The doctor tries to baracade the door, but it's too late. The zombies grab him and start to eat.

Doctor: 'RUN " + playerName.ToUpper() + @"!! RUN!!!

You start running down the hall towards the hospital cafeteria, but the zombies are gaining on you. It's business time.

");
            Console.WriteLine();
            Console.WriteLine("Press any key when ready.");
            Console.ReadKey();

            while (this.Player.IsAlive && this.Enemy.IsAlive)
            {
                DisplayCombatInfo();
                this.Player.DoAttack(Enemy);
                this.Enemy.DoAttack(Player);

            }
            if (this.Player.IsAlive) { Console.WriteLine("You Won!"); }
            else { Console.WriteLine("You Lost!"); }
        }
    }
}