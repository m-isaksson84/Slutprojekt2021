﻿using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random generator = new Random();
            bool inMenu = true;
            bool inGameStartup = false;
            bool gameStarted = false;
            string classChosen = "";
            string botClassChosen = "";
            int botClass = generator.Next(1, 4);
            int playerHealth = 0;
            int botHealth = 0;

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
                    Console.Beep(294,10);

                    while (inMeleeInfo) {
                        Console.Clear();
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Melee stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥♥ (150)");
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
                            inGameStartup = true;
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
                        Console.WriteLine("     Health: ♥♥ (100)");
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
                            inGameStartup = true;
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
                        Console.WriteLine("     Health: ♥♥ (100)");
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
                            inGameStartup = true;
                            // här deklareras den "klass" som spelaren valt att spela som
                            classChosen = "3";
                        }
                    }
                }
                
                while (inGameStartup) {

                    //Random randomUpdating = new Random();
                    
                    string botClassInfo = "";

                    if (botClass.ToString() == "1") {
                        botClassChosen = "1";
                        botClassInfo = "Melee";
                        botHealth = 150;
                        Console.WriteLine("Your opponent chose " + botClassInfo);
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Enemy stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥♥ (150)");
                        Console.WriteLine("      Damage: 5-10");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                    }

                    if (botClass.ToString() == "2") {
                        botClassChosen = "2";
                        botClassInfo = "Archer";
                        botHealth = 100;
                        Console.WriteLine("Your opponent chose " + botClassInfo);
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Enemy stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥ (100)");
                        Console.WriteLine("      Damage: 1-20");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                    }

                    if (botClass.ToString() == "3") {
                        botClassChosen = "3";
                        botClassInfo = "Magic";
                        botHealth = 100;
                        Console.WriteLine("Your opponent chose " + botClassInfo);
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Enemy stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥ (100)");
                        Console.WriteLine("      Damage: 5-15");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                    }

                    if (classChosen == "1") {
                        playerHealth = 150;
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Your stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥♥ (150)");
                        Console.WriteLine("      Damage: 5-10");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("  Press '1' to start game.");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        //int meleeDamage = generator.Next(5, 11);
                    }

                    if (classChosen == "2") {
                        playerHealth = 100;
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Your stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥ (100)");
                        Console.WriteLine("      Damage: 1-20");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("  Press '1' to start game.");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        //int rangedDamage = generator.Next(1, 21);
                    }

                    if (classChosen == "3") {
                        playerHealth = 100;
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("      Your stats:");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("     Health: ♥♥ (100)");
                        Console.WriteLine("      Damage: 5-15");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("  Press '1' to start game.");
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        //int magicDamage = generator.Next(5, 16);
                    }

                        string select = Console.ReadLine();

                        if (select == "1") {
                            Console.Clear();
                            Console.Beep(294,10);
                            // stänger ned / öppnar de "flikar" som ska / inte ska synas
                            inGameStartup = false;
                            gameStarted = true;
                            // här deklareras den "klass" som spelaren valt att spela som
                            classChosen = "3";
                        }

                        else {
                            Console.Clear();
                            inGameStartup = true;
                        }
                }

                while (gameStarted) {

                    static int GetPlayerDamage(string classChosen)
                    {   
                
                        Random damageGenerator = new Random();
                        int botClass1 = damageGenerator.Next(5, 11);
                        int botClass2 = damageGenerator.Next(1, 21);
                        int botClass3 = damageGenerator.Next(5, 11);
                        int botClass4 = damageGenerator.Next(0, 999999);

                        if (classChosen == "1") {
                            return botClass1;
                        }

                        if (classChosen == "2") {
                            return botClass2;
                        }

                        if (classChosen == "3") {
                            return botClass3;
                        }

                        else {
                            return botClass4;
                        }
                    }

                    static int GetBotDamage(string botClassChosen)
                    {   

                        Random damageGenerator = new Random();
                        int damageClass1 = damageGenerator.Next(5, 11);
                        int damageClass2 = damageGenerator.Next(1, 22);
                        int damageClass3 = damageGenerator.Next(5, 16);
                        int damageClass4 = damageGenerator.Next(0, 999999);

                        // jämför inputLength med det bestämda intervallet.
                        if (botClassChosen == "1") {
                            return damageClass1;
                        }

                        if (botClassChosen == "2") {
                            return damageClass2;
                        }

                        if (botClassChosen == "3") {
                            return damageClass3;
                        }

                        else {
                            return damageClass4;
                        }
                    }

                    int damage = GetPlayerDamage(classChosen);
                    int botDamage = GetBotDamage(botClassChosen);

                    botHealth = botHealth - damage;
                    playerHealth = playerHealth - botDamage;

                    if (playerHealth < 1) {
                        Console.WriteLine("Your enemy strikes you down and wins!");
                        inMenu = true;
                        gameStarted = false;
                    }

                    else if (botHealth < 1) {
                        Console.WriteLine("You strike down your enemy and win!");
                        inMenu = true;
                        gameStarted = false;
                    }

                    if (gameStarted) {
                        Console.WriteLine("You strike and deal " + damage + " damage. Your enemy now has " + botHealth + " health.");
                        Console.WriteLine("");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();

                        Console.WriteLine("Your enemy strikes and deals " + botDamage + " damage. You now have " + playerHealth + " health.");
                        Console.WriteLine("");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    if (gameStarted) {
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("Your health: " + playerHealth);
                        Console.WriteLine("Enemy health: " + botHealth);
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                    }
                }

                Console.ReadLine();
                Console.Clear();
                }
            }
        }
    }