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
            this.Player = new Player(100);
            this.Enemy = new Enemy("Zombie Horde", 200);
        }

        //STEP 3. METHODS AND FUNCTIONS
        public void Title()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

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
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
        public void Zombie()
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(@"













"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













(/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













 (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













  (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













   (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













    (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













     (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();

            Console.WriteLine(@"













°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













[¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













 [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













  [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













   [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













    [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













     [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













      [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













       [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













        [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













         [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













          [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













           [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













            [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













             [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













              [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













               [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                 [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                  [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                   [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                    [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                     [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                      [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                       [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                        [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                         [¬°-°]¬      (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                           [¬°-°]¬     (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                             [¬°-°]¬    (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                               [¬°-°]¬   (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                                  [¬°-°]¬ (/°o°)/"); System.Threading.Thread.Sleep(100); Console.Clear();
            Console.WriteLine(@"













                                   [¬°-°]¬(/°o°)/"); System.Threading.Thread.Sleep(500); Console.Clear();

            Console.WriteLine(@"













                                                              Level      One");
            Console.WriteLine(@"







                                         




");
            System.Threading.Thread.Sleep(4800); Console.Clear();
        }

        public void DisplayCombatInfo()
        {
            Console.Write("    "); Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            //player stats bar
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"______________________________________________________________________________________________________________________________________________

  Player 1 Health     " + this.Player.HP + "/100                                                                                      Horde Health     " + this.Enemy.HP + @"/200
______________________________________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("    Make your move. Throw a grenade (press 1), Fire your shotgun (press 2), Take the adrenaline (press 3)");
            Console.WriteLine();
        }
        public void PlayGame()
        {
            //Set console window width to max
            Console.WindowWidth = 142;
            Console.WindowHeight = 54;
            Console.Title = "...";
            
            this.Player = new Player(100);
            this.Enemy = new Enemy("Zombie Horde", 200);

            Title();
            Console.WindowHeight = 30;
            Zombie();
            Console.WriteLine(@"


    What is your name?");
            Console.Write("    "); string playerName = Console.ReadLine();
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
            Console.WriteLine("    Press any key when ready.");

            while (this.Player.IsAlive && this.Enemy.IsAlive)
            {
                DisplayCombatInfo();
                this.Player.DoAttack(Enemy);
                if (Enemy.HP > 0)
                {
                    this.Enemy.DoAttack(Player);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            if (this.Player.IsAlive) { Console.WriteLine("    You decimated the zombie horde... this time."); }
            else { Console.WriteLine("    You've been devoured by the zombie horde, and since you're immune to the virus, you're really dead."); }

            //if player lost, display high score list without asking for name
            if (!this.Player.IsAlive)
            {
                System.Threading.Thread.Sleep(3500);
                //DisplayHighScores();
            }
            //if player won, ask for name for high score list
            else
            {
                System.Threading.Thread.Sleep(3500);}
        //        AddHighScore(Player.HP);
        //        DisplayHighScores();
        //    }
        //}
        //static void AddHighScore(int playerScore)
        //{
        //    //get the player name for high scores
        //    Console.Write("    Enter your name: ");
        //    string playerName = Console.ReadLine();

        //    //create a gateway to the database
        //    spAnthonyEntities db = new spAnthonyEntities();

        //    //create a new highscore object
        //    HighScore newHighScore = new HighScore();
        //    newHighScore.DateCreated = DateTime.Now;
        //    newHighScore.Game = "The Waking Dead";
        //    newHighScore.Name = playerName;
        //    newHighScore.Score = playerScore;

        //    //add to the database
        //    db.HighScores.Add(newHighScore);

        //    //save our changes
        //    db.SaveChanges();
        //}
        //static void DisplayHighScores()
        //{
        //    Console.SetWindowSize(40, 30);
        //    //clear the console
        //    Console.Clear();
        //    //Write the High Score Text
        //    Console.WriteLine();
        //    Console.WriteLine("     The Waking Dead High Scores");
        //    Console.WriteLine("    *****************************");

        //    //create a new connection to the db
        //    spAnthonyEntities db = new spAnthonyEntities();
        //    //get the high score list
        //    List<HighScore> highScoreList = db.HighScores.Where(x => x.Game == "The Waking Dead").OrderByDescending(x => x.Score).Take(10).ToList();

        //    foreach (HighScore highScore in highScoreList)
        //    {
        //        Console.WriteLine("    {0}. {1} - {2} on {3}", highScoreList.IndexOf(highScore) + 1, highScore.Name, highScore.Score, highScore.DateCreated.Value.ToShortDateString());
        //    }
        //    Console.ReadKey();
        }
    }
}