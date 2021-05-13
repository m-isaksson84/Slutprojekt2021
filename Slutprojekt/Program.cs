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


               static string GetDamage(string classChosen)
                {   
                    // input = det som användaren skriver.
                    //string input = Console.ReadLine();

                    string test = "melee AAAasbyuefg8yeuf";
                    string test2 = "archer AAAasbyuefg8yeuf";
                    string test3 = "mage AAAasbyuefg8yeuf";
                    string test4 = "How the hell??!";

                    // jämför inputLength med det bestämda intervallet.
                    if (classChosen == "1") {
                        return test;
                    }

                    if (classChosen == "2") {
                        return test2;
                    }

                    if (classChosen == "3") {
                        return test3;
                    }

                    else {
                        return test4;
                    }
                }

                

                if (classSelect == "1") {

                    bool inMeleeInfo = true;
                    Console.Beep(294,10);

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
                            Console.Beep(294,10);
                            inMeleeInfo = false;
                            inMenu = true;
                        }

                        if (select == "1") {
                            Console.Clear();
                            Console.Beep(294,10);
                            // stänger ned / öppnar de "flikar" som ska / inte ska synas
                            inMeleeInfo = false;
                            gameStarted = true;
                            // här deklareras den "klass" som spelaren valt att spela som
                            classChosen = "1";
                        }
                    }
                }

                if (classSelect == "2") {

                    bool inArcherInfo = true;
                    Console.Beep(294,10);

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
                            Console.Beep(294,10);
                            inArcherInfo = false;
                            inMenu = true;
                        }

                        if (select == "1") {
                            Console.Clear();
                            Console.Beep(294,10);
                            // stänger ned / öppnar de "flikar" som ska / inte ska synas
                            inArcherInfo = false;
                            gameStarted = true;
                            // här deklareras den "klass" som spelaren valt att spela som
                            classChosen = "2";
                        }
                    }
                }

                if (classSelect == "3") {

                    bool inMageInfo = true;
                    Console.Beep(294,10);

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
                            Console.Beep(294,10);
                            inMageInfo = false;
                            inMenu = true;
                        }

                        if (select == "1") {
                            Console.Clear();
                            Console.Beep(294,10);
                            // stänger ned / öppnar de "flikar" som ska / inte ska synas
                            inMageInfo = false;
                            gameStarted = true;
                            // här deklareras den "klass" som spelaren valt att spela som
                            classChosen = "3";
                        }
                    }
                }
                
                while (gameStarted) {

                    Random randomUpdating = new Random();
                    
                    string botClassInfo = "";

                    if (botClass.ToString() == "1") {
                        botClassInfo = "Melee";
                        Console.WriteLine("Your opponent chose " + botClassInfo);
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Enemy stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥♥ (30)");
                        Console.WriteLine("      Damage: 5-10");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                    }

                    if (botClass.ToString() == "2") {
                        botClassInfo = "Archer";
                        Console.WriteLine("Your opponent chose " + botClassInfo);
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Enemy stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥ (20)");
                        Console.WriteLine("      Damage: 1-20");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                    }

                    if (botClass.ToString() == "3") {
                        botClassInfo = "Magic";
                        Console.WriteLine("Your opponent chose " + botClassInfo);
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Enemy stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥♥ (30)");
                        Console.WriteLine("      Damage: 5-10");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                    }

                    if (classChosen == "1") {
                        string damage = GetDamage(classChosen);

                        Console.WriteLine(damage);
                        Console.WriteLine(classChosen);
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Your stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥♥ (30)");
                        Console.WriteLine("      Damage: 5-10");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        int meleeDamage = generator.Next(5, 11);
                        Console.ReadLine();
                        Console.Clear();
                    }

                    if (classChosen == "2") {
                        string damage = GetDamage(classChosen);

                        Console.WriteLine(damage);
                        Console.WriteLine(classChosen);
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Your stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥ (20)");
                        Console.WriteLine("      Damage: 1-20");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        int rangedDamage = generator.Next(1, 21);
                        Console.ReadLine();
                        Console.Clear();
                    }

                    if (classChosen == "3") {
                        string damage = GetDamage(classChosen);

                        Console.WriteLine(damage);
                        Console.WriteLine(classChosen);
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Your stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥ (20)");
                        Console.WriteLine("      Damage: 5-15");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        int magicDamage = generator.Next(5, 16);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }


                Console.ReadLine();
                Console.Clear();
                }
            }
        }
    }








// skriv metod för health och för attacker