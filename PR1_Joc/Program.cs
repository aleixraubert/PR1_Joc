using System;

namespace PR1_Joc
{
    class Joc
    {
        static void Main ()
        {
            const string MSG_Start = "Què vols fer?\n 1. Jugar!\n 0. Sortir";
            const string MSG_END_CHOOSE = "Adèu!";
            const string MSG_Archer_Start = "Primer personatge: Arquera. Introdueix els valors requerits:";
            const string MSG_Fighter_Start = "Primer personatge: Bàrbar. Introdueix els valors requerits:";
            const string MSG_Mage_Start = "Primer personatge: Maga. Introdueix els valors requerits:";
            const string MSG_Druid_Start = "Primer personatge: Druida. Introdueix els valors requerits:";
            const string MSG_Health = "Vida [";
            const string MSG_Attack = "Atac [";
            const string MSG_Defense = "Defensa (Valor percentual) [";
            const string MSG_Healing = "Recuperació de vida (Valor percentual) [";
            const string MSG_Error_Parameters = "El valor no és correcte.";
            const string MSG_Final = "El joc ha acabat!";
            const string MSG_Character_Not_Complete = "No has introduit els valors correctament en 3 intents, torna-ho a intentar!";

            const int MAX_Archer_Heath = 2000, MIN_Archer_Health = 1500, MAX_Archer_Attack = 300, MIN_Archer_Attack = 180, MAX_Archer_Defense = 50, MIN_Archer_Defense = 30;
            const int MAX_Fighter_Heath = 3750, MIN_Fighter_Health = 3000, MAX_Fighter_Attack = 250, MIN_Fighter_Attack = 180, MAX_Fighter_Defense = 65, MIN_Fighter_Defense = 40;
            const int MAX_Mage_Heath = 2000, MIN_Mage_Health = 1500, MAX_Mage_Attack = 300, MIN_Mage_Attack = 180, MAX_Mage_Defense = 65, MIN_Mage_Defense = 40;
            const int MAX_Druid_Heath = 2000, MIN_Druid_Health = 1500, MAX_Druid_Attack = 300, MIN_Druid_Attack = 180, MAX_Druid_Defense = 65, MIN_Druid_Defense = 40;
            const int MAX_Boss_Heath = 2000, MIN_Boss_Health = 1500, MAX_Boss_Attack = 300, MIN_Boss_Attack = 180, MAX_Boss_Defense = 65, MIN_Boss_Defense = 40;
            
            const int Max_Trys = 3;


            double Archer_Health, Archer_Attack, Archer_Healing, Archer_Defense;
            double Fighter_Health, Fighter_Attack, Fighter_Healing, Fighter_Defense;
            double Mage_Health, Mage_Attack, Mage_Healing, Mage_Defense;
            double Druid_Health, Druid_Attack, Druid_Healing, Druid_Defense;
            double Boss_Health, Boss_Attack, Boss_Healing, Boss_Defense;


            int option, trys;

            bool started=true, Archer_Hability = false, Fighter_Hability = false, Mage_Hability = false, Druid_Hability = false, character_complete;

            Console.WriteLine("Benvingut a Herois vs Monstre!");

            while (started) /* Bucle que permet tornar a jugar un cop finalitza la partida.*/
            {
                Console.WriteLine(MSG_Start);

                option = Convert.ToInt32(Console.ReadLine());

                switch (option) /* Switch per decidir si el jugador vol jugar una nova partida o vol sortir del joc */
                {
                    default:
                        Console.WriteLine(MSG_Error_Parameters);
                    option = Convert.ToInt32(Console.ReadLine());
                    trys++;
                    Console.Write(trys);
                }

                    case 0:
                        started = false;
                        Console.WriteLine(MSG_END_CHOOSE);
                        break;
                    case 1:

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

                                while ((Archer_Health < MIN_Archer_Health || Archer_Health > MAX_Archer_Heath) && trys < Max_Trys)
                                {
                                    
                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Health + MIN_Archer_Health + "-" + MAX_Archer_Heath + "]: ");

                                    Archer_Health = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Attack + MIN_Archer_Attack + "-" + MAX_Archer_Attack + "]: ");

                                Archer_Attack = Convert.ToDouble(Console.ReadLine());

                                while ((Archer_Attack < MIN_Archer_Attack || Archer_Attack > MAX_Archer_Attack) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Attack + MIN_Archer_Attack + "-" + MAX_Archer_Attack + "]: ");

                                    Archer_Attack = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Defense + MIN_Archer_Defense + "-" + MAX_Archer_Defense + "]: ");

                                Archer_Defense = Convert.ToDouble(Console.ReadLine());

                                while ((Archer_Defense < MIN_Archer_Defense || Archer_Defense > MAX_Archer_Defense) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Defense + MIN_Archer_Defense + "-" + MAX_Archer_Defense + "]: ");

                                    Archer_Defense = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
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

                                while ((Fighter_Health < MIN_Fighter_Health || Fighter_Health > MAX_Fighter_Heath) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Health + MIN_Fighter_Health + "-" + MAX_Fighter_Heath + "]: ");

                                    Fighter_Health = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Attack + MIN_Fighter_Attack + "-" + MAX_Fighter_Attack + "]: ");

                                Archer_Attack = Convert.ToDouble(Console.ReadLine());

                                while ((Archer_Attack < MIN_Archer_Attack || Archer_Attack > MAX_Archer_Attack) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Attack + MIN_Archer_Attack + "-" + MAX_Archer_Attack + "]: ");

                                    Archer_Attack = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Defense + MIN_Archer_Defense + "-" + MAX_Archer_Defense + "]: ");

                                Archer_Defense = Convert.ToDouble(Console.ReadLine());

                                while ((Archer_Defense < MIN_Archer_Defense || Archer_Defense > MAX_Archer_Defense) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Defense + MIN_Archer_Defense + "-" + MAX_Archer_Defense + "]: ");

                                    Archer_Defense = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                            }

                            if (trys >= Max_Trys) Console.WriteLine(MSG_Character_Not_Complete);
                            else character_complete = true;

                            Console.WriteLine("fet");
                        }

                        break;

                }
                /*Console.WriteLine(MSG_Final);*/
            }
            
        }

    }
}