using System;

namespace GameProject
{
    class RaubertAleix
    {
        static void Main()
        {
            /* Declaració de Constants*/
            const string MSG_Welcome = "Benvingut a Herois vs Monstre!";
            const string MSG_Start = "Què vols fer?\n 1. Jugar!\n 0. Sortir";
            const string MSG_Action = "Selecciona l’acció: \n 1. Atacar\n 2. Protegir-se\n 3. Habilitat especial: ";
            const string MSG_SP_Archer = "Noqueja el Monstre durant 2 torns (no pot atacar)";
            const string MSG_SP_Fighter = "Augmenta la seva defensa al 100% durant 3 torns.";
            const string MSG_SP_Mage = "Dispara una bola de foc que fa 3 cops el seu atac.";
            const string MSG_SP_Druid = "Cura 500 de vida a tots els herois.";
            const string MSG_Archer = "Arquera. ";
            const string MSG_Fighter = "Bàrbar. ";
            const string MSG_Mage = "Maga. ";
            const string MSG_Druid = "Druida. ";
            const string MSG_Start_Game = "Comença la partida!\n";
            const string MSG_END_CHOOSE = "Adèu!";
            const string MSG_Archer_Start = "Primer personatge: Arquera. Introdueix els valors requerits:";
            const string MSG_Fighter_Start = "Segon personatge: Bàrbar. Introdueix els valors requerits:";
            const string MSG_Mage_Start = "Tercer personatge: Maga. Introdueix els valors requerits:";
            const string MSG_Druid_Start = "Quart personatge: Druida. Introdueix els valors requerits:";
            const string MSG_Boss_Start = "Finalment el Monstre. Introdueix els valors requerits:";
            const string MSG_Health = "Vida [";
            const string MSG_Attack = "Atac [";
            const string MSG_Defense = "Defensa (Valor percentual) [";
            const string MSG_Error_Parameters = "El valor no és correcte.";
            const string MSG_Character_Not_Complete = "No has introduit els valors correctament en 3 intents, torna-ho a intentar!";
            const string MSG_Turn = "Torn ";
            const string MSG_Archer_Attack = "Arquera ataca a Monstre amb ";
            const string MSG_Fighter_Attack = "Bàrbar ataca a Monstre amb ";
            const string MSG_Mage_Attack = "Maga ataca a Monstre amb ";
            const string MSG_Druid_Attack = "Druida ataca a Monstre amb ";
            const string MSG_Archer_Defense = "L'Arquera es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.\n";
            const string MSG_Fighter_Defense = "El Bàrbar es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.\n";
            const string MSG_Mage_Defense = "La Maga es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.\n";
            const string MSG_Druid_Defense = "El Druida es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.\n";
            const string MSG_Boss_Attack_Archer = "El Monstre ataca a l’Arquera amb ";
            const string MSG_Boss_Attack_Fighter = "El Monstre ataca al Bàrbar amb ";
            const string MSG_Boss_Attack_Mage = "El Monstre ataca a la Maga amb ";
            const string MSG_Boss_Attack_Druid = "El Monstre ataca al Druida amb ";
            const string MSG_Archer_Defenseself = "L’Arquera es defensa i rep només ";
            const string MSG_Fighter_Defenseself = "El Bàrbar es defensa i rep només ";
            const string MSG_Mage_Defenseself = "La Maga es defensa i rep només ";
            const string MSG_Druid_Defenseself = "El Druida es defensa i rep només ";
            const string MSG_Boss_Defense = "El Monstre es defensa i rep només ";
            const string MSG_Archer_health = "Vida restant de l’Arquera: ";
            const string MSG_Fighter_health = "Vida restant del Bàrbar: ";
            const string MSG_Mage_health = "Vida restant de la Maga: ";
            const string MSG_Druid_health = "Vida restant del Druida: ";
            const string MSG_Boss_health = "Vida restant del Monstre: ";
            const string MSG_Archer_Death = "L'Arquera està morta i no pot actuar.";
            const string MSG_Fighter_Death = "El Bàrbar està morta i no pot actuar.";
            const string MSG_Mage_Death = "La Maga està morta i no pot actuar.";
            const string MSG_Druid_Death = "El Druida està morta i no pot actuar.";
            const string MSG_Boss_Turn = "El Monstre ataca a tots els herois: \n";
            const string MSG_Damage = " de dany. ";
            const string MSG_Archer_Dead = "L'Arquera ha mort.";
            const string MSG_Fighter_Dead = "El Bàrbar ha mort.";
            const string MSG_Mage_Dead = "La Maga ha mort.";
            const string MSG_Druid_Dead = "El Druida ha mort.";
            const string MSG_Boss_Dead = "El Monstre ha mort.";
            const string MSG_Win = "Enhorabona has guanyat!\n";
            const string MSG_Loss = "Llàstima has perdut!\n";
            const string MSG_Cooldown = "L'habilitat especial no està disponible encara, torns restants: ";
            const string MSG_Archer_Use_Hability = "L'Arquera ha utilitzat la seva habilitat!\n";
            const string MSG_Fighter_Use_Hability = "El Bàrbar ha utilitzat la seva habilitat!\n";
            const string MSG_Mage_Use_Hability = "La Maga ha utilitzat la seva habilitat!\n";
            const string MSG_Druid_Use_Hability = "El Druida ha utilitzat la seva habilitat!\n";
            const string MSG_Boss_Knock_Out = "El Monstre no pot atacar ja que està noquejat.\n";
            const string MSG_Mage_Fireball = "La Maga llança una bola de foc i fa ";
            const string MSG_All_Healed = "Tots els herois s'han curat 500 de vida!\n";

            const int MAX_Archer_Heath = 2000, MIN_Archer_Health = 1500, MAX_Archer_Attack = 300, MIN_Archer_Attack = 180, MAX_Archer_Defense = 40, MIN_Archer_Defense = 25;
            const int MAX_Fighter_Heath = 3750, MIN_Fighter_Health = 3000, MAX_Fighter_Attack = 250, MIN_Fighter_Attack = 150, MAX_Fighter_Defense = 45, MIN_Fighter_Defense = 35;
            const int MAX_Mage_Heath = 1500, MIN_Mage_Health = 1000, MAX_Mage_Attack = 350, MIN_Mage_Attack = 300, MAX_Mage_Defense = 35, MIN_Mage_Defense = 20;
            const int MAX_Druid_Heath = 2500, MIN_Druid_Health = 2000, MAX_Druid_Attack = 120, MIN_Druid_Attack = 70, MAX_Druid_Defense = 40, MIN_Druid_Defense = 25;
            const int MAX_Boss_Heath = 12000, MIN_Boss_Health = 9000, MAX_Boss_Attack = 400, MIN_Boss_Attack = 250, MAX_Boss_Defense = 30, MIN_Boss_Defense = 20;
            
            const int Max_Trys = 3, cooldown_hability=5;

            /* Declaració de variables*/
            double Archer_Health = 0, Archer_Attack = 0, Archer_Defense = 0;
            double Fighter_Health = 0, Fighter_Attack = 0, Fighter_Defense = 0;
            double Mage_Health = 0, Mage_Attack = 0, Mage_Defense = 0;
            double Druid_Health = 0, Druid_Attack = 0, Druid_Defense = 0;
            double Boss_Health = 0, Boss_Attack = 0, Boss_Defense = 0;
            double Current_Archer_Health = 0, Current_Fighter_Health = 0, Current_Mage_Health = 0, Current_Druid_Health = 0;

            int turns_archer=0, turns_fighter=0, turns_druid=0, turns_mage=0, boss_out=0, fighter_hability_counter=0;

            int option, trys, turn = 1;

            /* Declaració de booleans que ens a serveixen com a condicions de bucles i ifs.*/
            bool started=true, Archer_Hability = false, Fighter_Hability = false, Mage_Hability = false, Druid_Hability = false, character_complete, game_started=true;
            bool Fighter_Alive = true, Archer_Alive = true, Mage_Alive = true, Druid_Alive = true, Boss_Alive = true;
            bool Archer_Defensed = false, Fighter_Defensed = false, Mage_Defensed = false, Druid_Defensed = false, Monster_Knock_Out = false;
            bool Fighter_Use_Hability = false;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(MSG_Welcome);

            while (started) /* Bucle que permet tornar a jugar un cop finalitza la partida.*/
            {
                game_started = true;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(MSG_Start);

                option = Convert.ToInt32(Console.ReadLine());
                trys = 1;

                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                while(!(option==1 || option==0) && trys < Max_Trys)
                {
                    Console.WriteLine(MSG_Error_Parameters);
                    Console.WriteLine(MSG_Start);
                    option = Convert.ToInt32(Console.ReadLine());
                    trys++;
                }

                if (trys >= Max_Trys) option = 0;

                switch (option) /* Switch per decidir si el jugador vol jugar una nova partida o vol sortir del joc */
                {
                    case 0:
                        started = false;
                        Console.WriteLine(MSG_END_CHOOSE);
                        game_started = false;
                        break;

                    case 1:

                        Console.ForegroundColor = ConsoleColor.Green;
                        /*Creació de personatges.*/
                        character_complete = false;

                        /*Arquera*/

                        while (!character_complete)
                        {
                            trys = 1;
                            Console.WriteLine(MSG_Archer_Start);

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Health + MIN_Archer_Health + "-" + MAX_Archer_Heath + "]: ");

                                Archer_Health = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Archer_Health < MIN_Archer_Health || Archer_Health > MAX_Archer_Heath) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Health + MIN_Archer_Health + "-" + MAX_Archer_Heath + "]: ");

                                    Archer_Health = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Current_Archer_Health = Archer_Health;
                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Attack + MIN_Archer_Attack + "-" + MAX_Archer_Attack + "]: ");

                                Archer_Attack = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Archer_Attack < MIN_Archer_Attack || Archer_Attack > MAX_Archer_Attack) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Attack + MIN_Archer_Attack + "-" + MAX_Archer_Attack + "]: ");

                                    Archer_Attack = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Defense + MIN_Archer_Defense + "-" + MAX_Archer_Defense + "]: ");

                                Archer_Defense = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Archer_Defense < MIN_Archer_Defense || Archer_Defense > MAX_Archer_Defense) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Defense + MIN_Archer_Defense + "-" + MAX_Archer_Defense + "]: ");

                                    Archer_Defense = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys >= Max_Trys) Console.WriteLine(MSG_Character_Not_Complete);
                            else character_complete = true;
                        }

                        character_complete = false;

                        /*Barbar*/

                        while (!character_complete)
                        {
                            trys = 1;
                            Console.WriteLine(MSG_Fighter_Start);

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Health + MIN_Fighter_Health + "-" + MAX_Fighter_Heath + "]: ");

                                Fighter_Health = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Fighter_Health < MIN_Fighter_Health || Fighter_Health > MAX_Fighter_Heath) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Health + MIN_Fighter_Health + "-" + MAX_Fighter_Heath + "]: ");

                                    Fighter_Health = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Current_Fighter_Health = Fighter_Health;

                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Attack + MIN_Fighter_Attack + "-" + MAX_Fighter_Attack + "]: ");

                                Fighter_Attack = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Fighter_Attack < MIN_Fighter_Attack || Fighter_Attack > MAX_Fighter_Attack) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Attack + MIN_Fighter_Attack + "-" + MAX_Fighter_Attack + "]: ");

                                    Fighter_Attack = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Defense + MIN_Fighter_Defense + "-" + MAX_Fighter_Defense + "]: ");

                                Fighter_Defense = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Fighter_Defense < MIN_Fighter_Defense || Fighter_Defense > MAX_Fighter_Defense) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Defense + MIN_Fighter_Defense + "-" + MAX_Fighter_Defense + "]: ");

                                    Fighter_Defense = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys >= Max_Trys) Console.WriteLine(MSG_Character_Not_Complete);
                            else character_complete = true;
                        }

                        character_complete = false;

                        /*Maga*/

                        while (!character_complete)
                        {
                            trys = 1;
                            Console.WriteLine(MSG_Mage_Start);

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Health + MIN_Mage_Health + "-" + MAX_Mage_Heath + "]: ");

                                Mage_Health = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Mage_Health < MIN_Mage_Health || Mage_Health > MAX_Mage_Heath) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Health + MIN_Mage_Health + "-" + MAX_Mage_Heath + "]: ");

                                    Mage_Health = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }

                                Current_Mage_Health = Mage_Health;

                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Attack + MIN_Mage_Attack + "-" + MAX_Mage_Attack + "]: ");

                                Mage_Attack = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Mage_Attack < MIN_Mage_Attack || Mage_Attack > MAX_Mage_Attack) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Attack + MIN_Mage_Attack + "-" + MAX_Mage_Attack + "]: ");

                                    Mage_Attack = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Defense + MIN_Mage_Defense + "-" + MAX_Mage_Defense + "]: ");

                                Mage_Defense = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Mage_Defense < MIN_Mage_Defense || Mage_Defense > MAX_Mage_Defense) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Defense + MIN_Mage_Defense + "-" + MAX_Mage_Defense + "]: ");

                                    Mage_Defense = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys >= Max_Trys) Console.WriteLine(MSG_Character_Not_Complete);
                            else character_complete = true;
                        }

                        character_complete = false;

                        /*Druida*/

                        while (!character_complete)
                        {
                            trys = 1;
                            Console.WriteLine(MSG_Druid_Start);

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Health + MIN_Druid_Health + "-" + MAX_Druid_Heath + "]: ");

                                Druid_Health = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Druid_Health < MIN_Druid_Health || Druid_Health > MAX_Druid_Heath) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Health + MIN_Druid_Health + "-" + MAX_Druid_Heath + "]: ");

                                    Druid_Health = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }

                                Current_Druid_Health = Druid_Health;

                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Attack + MIN_Druid_Attack + "-" + MAX_Druid_Attack + "]: ");

                                Druid_Attack = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Druid_Attack < MIN_Druid_Attack || Druid_Attack > MAX_Druid_Attack) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Attack + MIN_Druid_Attack + "-" + MAX_Druid_Attack + "]: ");

                                    Druid_Attack = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Defense + MIN_Druid_Defense + "-" + MAX_Druid_Defense + "]: ");

                                Druid_Defense = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Druid_Defense < MIN_Druid_Defense || Druid_Defense > MAX_Druid_Defense) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Defense + MIN_Druid_Defense + "-" + MAX_Druid_Defense + "]: ");

                                    Druid_Defense = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys >= Max_Trys) Console.WriteLine(MSG_Character_Not_Complete);
                            else character_complete = true;
                        }

                        character_complete = false;

                        /*Monstre*/

                        while (!character_complete)
                        {
                            trys = 1;
                            Console.WriteLine(MSG_Boss_Start);

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Health + MIN_Boss_Health + "-" + MAX_Boss_Heath + "]: ");

                                Boss_Health = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Boss_Health < MIN_Boss_Health || Boss_Health > MAX_Boss_Heath) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Health + MIN_Boss_Health + "-" + MAX_Boss_Heath + "]: ");

                                    Boss_Health = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Attack + MIN_Boss_Attack + "-" + MAX_Boss_Attack + "]: ");

                                Boss_Attack = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Boss_Attack < MIN_Boss_Attack || Boss_Attack > MAX_Boss_Attack) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Attack + MIN_Boss_Attack + "-" + MAX_Boss_Attack + "]: ");

                                    Boss_Attack = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Defense + MIN_Boss_Defense + "-" + MAX_Boss_Defense + "]: ");

                                Boss_Defense = Convert.ToDouble(Console.ReadLine());

                                /* Comprobació de que el valor introduit sigui correcte amb un màxim de 3 intents. */
                                while ((Boss_Defense < MIN_Boss_Defense || Boss_Defense > MAX_Boss_Defense) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Defense + MIN_Boss_Defense + "-" + MAX_Boss_Defense + "]: ");

                                    Boss_Defense = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys >= Max_Trys) Console.WriteLine(MSG_Character_Not_Complete);
                            else character_complete = true;


                        }
                        break;
                }
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(MSG_Start_Game);

                Console.WriteLine();

                Archer_Hability = Fighter_Hability = Mage_Hability = Druid_Hability = true;
                Fighter_Alive = Archer_Alive = Mage_Alive =  Druid_Alive = Boss_Alive = true;
                turn = 1;

                /* Bucle de la partida per torns. Cada iteració d'aquest bucle representa un torn al joc. */
                while (game_started)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(MSG_Turn + turn + ":\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    /* Torn Arquera */
                    if (Archer_Alive && Boss_Alive)
                    {
                        Console.WriteLine(MSG_Archer + MSG_Action + MSG_SP_Archer);

                        option = Convert.ToInt32(Console.ReadLine());

                        /* Comprobació de que el valor introduit sigui correcte. */
                        while (!(option == 1 || option == 2 || option == 3))
                        {
                            Console.WriteLine(MSG_Error_Parameters);
                            Console.WriteLine();
                            Console.WriteLine(MSG_Archer + MSG_Action + MSG_SP_Archer);
                            option = Convert.ToInt32(Console.ReadLine());
                        }

                        /* Comprobació que la habilitat especial no estigui en cooldown. */
                        while(!Archer_Hability && option==3)
                        {
                            Console.WriteLine(MSG_Cooldown + (cooldown_hability-turns_archer));
                            Console.WriteLine();
                            Console.WriteLine(MSG_Archer + MSG_Action + MSG_SP_Archer);
                            option = Convert.ToInt32(Console.ReadLine());
                        }

                        /* Switch que controla la acció que vol fer el jugador. */
                        switch (option)
                        {
                            case 1: /*Atacar*/

                                double Damage_Dealt;
                                Damage_Dealt = Archer_Attack - (Archer_Attack * (Boss_Defense / 100));
                                Boss_Health -= Damage_Dealt;
                                if (Boss_Health < 0)
                                {
                                    Boss_Health = 0;
                                    Boss_Alive = false;
                                }

                                Console.WriteLine(MSG_Archer_Attack + Archer_Attack + MSG_Damage + MSG_Boss_Defense + Damage_Dealt + MSG_Damage + MSG_Boss_health + Boss_Health);

                                Console.WriteLine();
                                break;

                            case 2: /* Protegir-se */

                                Archer_Defense *= 2;
                                Archer_Defensed = true;

                                Console.WriteLine(MSG_Archer_Defense);

                                break;

                            case 3: /*Habilitat especial*/
                                Archer_Hability = false;
                                Console.WriteLine(MSG_Archer_Use_Hability);
                                Monster_Knock_Out = true;
                                boss_out = 2;
                                break;
                        }
                    }
                    else if (!Archer_Alive)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(MSG_Archer_Death);
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    /* Mateixa estrctura de codi que l'arquera per als altres 3 personatges. */
                    if (Fighter_Alive && Boss_Alive)
                    {
                        Console.WriteLine(MSG_Fighter + MSG_Action + MSG_SP_Fighter);

                        option = Convert.ToInt32(Console.ReadLine());

                        while (!(option == 1 || option == 2 || option == 3))
                        {
                            Console.WriteLine(MSG_Error_Parameters);
                            Console.WriteLine();
                            Console.WriteLine(MSG_Fighter + MSG_Action + MSG_SP_Fighter);
                            option = Convert.ToInt32(Console.ReadLine());
                        }

                        while (!Fighter_Hability && option == 3)
                        {
                            Console.WriteLine(MSG_Cooldown + (cooldown_hability - turns_fighter));
                            Console.WriteLine();
                            Console.WriteLine(MSG_Fighter + MSG_Action + MSG_SP_Fighter);
                            option = Convert.ToInt32(Console.ReadLine());
                        }

                        switch (option)
                        {
                            case 1:

                                double Damage_Dealt;
                                Damage_Dealt = Fighter_Attack - (Fighter_Attack * (Boss_Defense / 100));
                                Boss_Health -= Damage_Dealt;
                                if (Boss_Health < 0)
                                {
                                    Boss_Health = 0;
                                    Boss_Alive = false;
                                }

                                Console.WriteLine(MSG_Fighter_Attack + Fighter_Attack + MSG_Damage + MSG_Boss_Defense + Damage_Dealt + MSG_Damage + MSG_Boss_health + Boss_Health);

                                Console.WriteLine();
                                break;

                            case 2:

                                Fighter_Defense *= 2;
                                Fighter_Defensed = true;

                                Console.WriteLine(MSG_Fighter_Defense);

                                break;

                            case 3:
                                Fighter_Hability = false;
                                Console.WriteLine(MSG_Fighter_Use_Hability);
                                Fighter_Use_Hability = true;
                                fighter_hability_counter = 3;

                                break;
                        }
                    }
                    else if (!Fighter_Alive)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(MSG_Fighter_Death);
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;


                    if (Mage_Alive && Boss_Alive)
                    {
                        Console.WriteLine(MSG_Mage + MSG_Action + MSG_SP_Mage);

                        option = Convert.ToInt32(Console.ReadLine());

                        while (!(option == 1 || option == 2 || option == 3))
                        {
                            Console.WriteLine(MSG_Error_Parameters);
                            Console.WriteLine();
                            Console.WriteLine(MSG_Mage + MSG_Action + MSG_SP_Mage);
                            option = Convert.ToInt32(Console.ReadLine());
                        }

                        while (!Mage_Hability && option == 3)
                        {
                            Console.WriteLine(MSG_Cooldown + (cooldown_hability - turns_mage));
                            Console.WriteLine();
                            Console.WriteLine(MSG_Mage + MSG_Action + MSG_SP_Mage);
                            option = Convert.ToInt32(Console.ReadLine());
                        }

                        switch (option)
                        {
                            case 1:

                                double Damage_Dealt;
                                Damage_Dealt = Mage_Attack - (Mage_Attack * (Boss_Defense / 100));
                                Boss_Health -= Damage_Dealt;
                                if (Boss_Health < 0)
                                {
                                    Boss_Health = 0;
                                    Boss_Alive = false;
                                }

                                Console.WriteLine(MSG_Mage_Attack + Mage_Attack + MSG_Damage + MSG_Boss_Defense + Damage_Dealt + MSG_Damage + MSG_Boss_health + Boss_Health);

                                Console.WriteLine();
                                break;

                            case 2:

                                Mage_Defense *= 2;
                                Mage_Defensed = true;

                                Console.WriteLine(MSG_Mage_Defense);

                                break;

                            case 3:
                                Mage_Hability = false;
                                Console.WriteLine(MSG_Mage_Use_Hability);

                                Damage_Dealt = Mage_Attack*3 - (Mage_Attack * (Boss_Defense / 100));
                                Boss_Health -= Damage_Dealt;
                                if (Boss_Health < 0)
                                {
                                    Boss_Health = 0;
                                    Boss_Alive = false;
                                }

                                Console.WriteLine(MSG_Mage_Fireball + (Mage_Attack*3) + MSG_Damage + MSG_Boss_Defense + Damage_Dealt + MSG_Damage + MSG_Boss_health + Boss_Health);
                                break;
                        }
                    }
                    else if (!Mage_Alive)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(MSG_Mage_Death);
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;


                    if (Druid_Alive && Boss_Alive)
                    {
                        Console.WriteLine(MSG_Druid + MSG_Action + MSG_SP_Druid);

                        option = Convert.ToInt32(Console.ReadLine());

                        while (!(option == 1 || option == 2 || option == 3))
                        {
                            Console.WriteLine(MSG_Error_Parameters);
                            Console.WriteLine();
                            Console.WriteLine(MSG_Druid + MSG_Action + MSG_SP_Druid);
                            option = Convert.ToInt32(Console.ReadLine());
                        }

                        while (!Druid_Hability && option == 3)
                        {
                            Console.WriteLine(MSG_Cooldown + (cooldown_hability - turns_druid));
                            Console.WriteLine();
                            Console.WriteLine(MSG_Druid + MSG_Action + MSG_SP_Druid);
                            option = Convert.ToInt32(Console.ReadLine());
                        }

                        switch (option)
                        {
                            case 1:

                                double Damage_Dealt;
                                Damage_Dealt = Druid_Attack - (Druid_Attack * (Boss_Defense / 100));
                                Boss_Health -= Damage_Dealt;
                                if (Boss_Health < 0)
                                {
                                    Boss_Health = 0;
                                    Boss_Alive = false;
                                }

                                Console.WriteLine(MSG_Druid_Attack + Druid_Attack + MSG_Damage + MSG_Boss_Defense + Damage_Dealt + MSG_Damage + MSG_Boss_health + Boss_Health);
                                
                                Console.WriteLine();
                                break;

                            case 2:

                                Druid_Defense *= 2;
                                Druid_Defensed = true;

                                Console.WriteLine(MSG_Druid_Defense);

                                break;

                            case 3:
                                Druid_Hability = false;
                                Console.WriteLine(MSG_Druid_Use_Hability);

                                Console.WriteLine(MSG_All_Healed);

                                if(Archer_Alive)
                                {
                                    Archer_Health += 500;
                                    if(Archer_Health > Current_Archer_Health) Archer_Health = Current_Archer_Health;

                                    Console.WriteLine(MSG_Archer_health + Archer_Health);
                                }

                                if (Fighter_Alive)
                                {
                                    Fighter_Health += 500;
                                    if (Fighter_Health > Current_Fighter_Health) Fighter_Health = Current_Fighter_Health;

                                    Console.WriteLine(MSG_Fighter_health + Fighter_Health);
                                }

                                if (Mage_Alive)
                                {
                                    Mage_Health += 500;
                                    if (Mage_Health > Current_Mage_Health) Mage_Health = Current_Mage_Health;

                                    Console.WriteLine(MSG_Mage_health + Mage_Health);
                                }

                                Druid_Health += 500;
                                if (Druid_Health > Current_Druid_Health) Druid_Health = Current_Druid_Health;

                                Console.WriteLine(MSG_Druid_health + Druid_Health);
                                Console.WriteLine();
                                break;
                        }
                    }
                    else if (!Druid_Alive)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(MSG_Druid_Death);
                        Console.WriteLine();
                    }

                    /* Torn del monstre */
                    if (!Fighter_Alive && !Archer_Alive && !Mage_Alive && !Druid_Alive) /* Missatge de derrota si estan tots els herois morts. */
                    {
                        game_started = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(MSG_Loss);
                    }
                    else if (!Boss_Alive) /* Missatge de victòria si el monstre està mort. */
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(MSG_Boss_Dead);
                        game_started = false;

                        Console.WriteLine(MSG_Win);
                    }
                    else if(Monster_Knock_Out) /* Missatge de que el monstre està noquejat i no pot atacar. */
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(MSG_Boss_Knock_Out);
                        boss_out--;
                        if (boss_out == 0) Monster_Knock_Out = false;
                    }
                    else /* Atac del monstre */
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(MSG_Boss_Turn);

                        double Damage_Dealt;

                        /* Atac a l'arquera */
                        if (Archer_Alive)
                        {
                            Damage_Dealt = Boss_Attack - (Boss_Attack * (Archer_Defense / 100));

                            if (Archer_Defensed)
                            {
                                Archer_Defense /= 2;
                                Archer_Defensed = false;
                            }

                            Archer_Health -= Damage_Dealt;

                            if (Archer_Health <= 0)
                            {
                                Archer_Health = 0;
                                Archer_Alive = false;
                            }

                            Console.WriteLine(MSG_Boss_Attack_Archer + Boss_Attack + MSG_Damage + MSG_Archer_Defenseself + Damage_Dealt + MSG_Damage + MSG_Archer_health + Archer_Health);

                            if (!Archer_Alive)
                            {
                                Console.WriteLine(MSG_Archer_Dead);
                            }
                        }

                        Console.WriteLine();

                        /* Atac al Bàrbar */
                        if (Fighter_Alive)
                        {
                            double temp=Fighter_Defense;
                            if (fighter_hability_counter>0)
                            {
                                Fighter_Defense = 100;
                                Fighter_Use_Hability = false;
                                fighter_hability_counter--;
                            }

                            Damage_Dealt = Boss_Attack - (Boss_Attack * (Fighter_Defense / 100));

                            Fighter_Defense = temp;

                            if (Fighter_Defensed)
                            {
                                Fighter_Defense /= 2;
                                Fighter_Defensed = false;
                            }

                            Fighter_Health -= Damage_Dealt;

                            if (Fighter_Health <= 0)
                            {
                                Fighter_Health = 0;
                                Fighter_Alive = false;
                            }

                            Console.WriteLine(MSG_Boss_Attack_Fighter + Boss_Attack + MSG_Damage + MSG_Fighter_Defenseself + Damage_Dealt + MSG_Damage + MSG_Fighter_health + Fighter_Health);

                            if (!Fighter_Alive)
                            {
                                Console.WriteLine(MSG_Fighter_Dead);
                            }
                        }

                        Console.WriteLine();

                        /* Atac a la Maga */
                        if (Mage_Alive)
                        {
                            Damage_Dealt = Boss_Attack - (Boss_Attack * (Mage_Defense / 100));

                            if (Mage_Defensed)
                            {
                                Mage_Defense /= 2;
                                Mage_Defensed = false;
                            }

                            Mage_Health -= Damage_Dealt;

                            if (Mage_Health <= 0)
                            {
                                Mage_Health = 0;
                                Mage_Alive = false;
                            }

                            Console.WriteLine(MSG_Boss_Attack_Mage + Boss_Attack + MSG_Damage + MSG_Mage_Defenseself + Damage_Dealt + MSG_Damage + MSG_Mage_health + Mage_Health);

                            if (!Mage_Alive)
                            {
                                Console.WriteLine(MSG_Mage_Dead);
                            }
                        }

                        Console.WriteLine();

                        /* Atac al druida */
                        if (Druid_Alive)
                        {
                            Damage_Dealt = Boss_Attack - (Boss_Attack * (Druid_Defense / 100));

                            if (Druid_Defensed)
                            {
                                Druid_Defense /= 2;
                                Druid_Defensed = false;
                            }

                            Druid_Health -= Damage_Dealt;

                            if (Druid_Health <= 0)
                            {
                                Druid_Health = 0;
                                Druid_Alive = false;
                            }

                            Console.WriteLine(MSG_Boss_Attack_Druid + Boss_Attack + MSG_Damage + MSG_Druid_Defenseself + Damage_Dealt + MSG_Damage + MSG_Druid_health + Druid_Health);

                            if (!Druid_Alive)
                            {
                                Console.WriteLine(MSG_Druid_Dead);
                            }
                        }
                        Console.WriteLine();


                    }

                    /* Cooldown de torns de les habilitats especials de cada personatge. */
                    if(!Archer_Hability)
                    {
                        turns_archer++;
                        if (turns_archer == cooldown_hability)
                        {
                            Archer_Hability = true;
                            turns_archer = 0;
                        }
                    }

                    if(!Fighter_Hability)
                    {
                        turns_fighter++;
                        if (turns_fighter == cooldown_hability)
                        {
                            Fighter_Hability = true;
                            turns_fighter = 0;
                        }  
                    }

                    if(!Mage_Hability)
                    {
                        turns_mage++;
                        if (turns_mage == cooldown_hability)
                        {
                            turns_mage = 0;
                            Mage_Hability = true;
                        }    
                    }

                    if(!Druid_Hability)
                    {
                        turns_druid++;
                        if (turns_druid == cooldown_hability)
                        {
                            turns_druid = 0;
                            Druid_Hability = true;
                        }
                    }

                    /* Contador de torns */
                    turn+=1;
                }
            }
        }    
    }
}
