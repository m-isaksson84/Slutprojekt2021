using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random generator = new Random();
            bool inMenu = true;
            bool gameStarted = false;
            string classChosen = "";
            int botClass = generator.Next(1, 4);


            while (inMenu) {

                Console.WriteLine("Choose your class:");
                Console.WriteLine("");
                Console.WriteLine("(1) Melee");
                Console.WriteLine("(2) Archer");
                Console.WriteLine("(3) Magic");
                Console.WriteLine("");
                
                string classSelect = Console.ReadLine();

               

                if (classSelect == "1") {

                    bool inMeleeInfo = true;

                    while (inMeleeInfo) {
                        Console.Clear();
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Melee stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥♥ (30)");
                        Console.WriteLine("      Damage: 5-10");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("  Press '1' to start game.");
                        Console.WriteLine("   Press '2' to go back.");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        inMenu = false;

                        string select = Console.ReadLine();

                        if (select == "2") {
                            Console.Clear();
                            inMeleeInfo = false;
                            inMenu = true;
                        }

                        if (select == "1") {
                            Console.Clear();
                            inMeleeInfo = false;
                            gameStarted = true;
                            classChosen = "1";
                        }
                    }
                }

                if (classSelect == "2") {

                    bool inArcherInfo = true;

                    while (inArcherInfo) {
                        Console.Clear();
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Archer stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥ (20)");
                        Console.WriteLine("      Damage: 1-20");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("  Press '1' to start game.");
                        Console.WriteLine("   Press '2' to go back.");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        inMenu = false;

                        string select = Console.ReadLine();

                        if (select == "2") {
                            Console.Clear();
                            inArcherInfo = false;
                            inMenu = true;
                        }

                        if (select == "1") {
                            Console.Clear();
                            inArcherInfo = false;
                            gameStarted = true;
                            classChosen = "2";
                        }
                    }
                }

                if (classSelect == "3") {

                    bool inMageInfo = true;

                    while (inMageInfo) {
                        Console.Clear();
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Mage stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥ (20)");
                        Console.WriteLine("      Damage: 5-15");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("  Press '1' to start game.");
                        Console.WriteLine("   Press '2' to go back.");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        inMenu = false;

                        string select = Console.ReadLine();

                        if (select == "2") {
                            Console.Clear();
                            inMageInfo = false;
                            inMenu = true;
                        }

                        if (select == "1") {
                            Console.Clear();
                            inMageInfo = false;
                            gameStarted = true;
                            classChosen = "2";
                        }
                    }
                }
                
                while (gameStarted) {
                    
                    string botClassInfo = "";

                    if (botClass.ToString() == "1") {
                        botClassInfo = "Melee";
                        Console.WriteLine("Your opponent chose " + botClassInfo);
                    }

                    if (botClass.ToString() == "2") {
                        botClassInfo = "Archer";
                        Console.WriteLine("Your opponent chose " + botClassInfo);
                    }

                    if (botClass.ToString() == "3") {
                        botClassInfo = "Magic";
                        Console.WriteLine("Your opponent chose " + botClassInfo);
                    }

                    if (classChosen == "1") {
                        
                        Console.WriteLine("you are stuck here melee man :D");
                        int meleeDamage = generator.Next(5, 11);
                        Console.ReadLine();
                    }

                    if (classChosen == "2") {
                        Console.WriteLine("you are stuck here archer man :D");
                        int rangedDamage = generator.Next(1, 21);
                        Console.ReadLine();
                    }

                    if (classChosen == "3") {
                        Console.WriteLine("you are stuck here wizard man :D");
                        int magicDamage = generator.Next(5, 16);
                        Console.ReadLine();
                    }

                }


                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}



// skriv metod för health och för attacker