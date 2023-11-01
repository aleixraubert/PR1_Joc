using System;

namespace PR1_Joc
{
    class Joc
    {
        static void Main()
        {
            const string MSG_Welcome = "Benvingut a Herois vs Monstre!";
            const string MSG_Start = "Què vols fer?\n 1. Jugar!\n 0. Sortir";
            const string MSG_Action = "Selecciona l’acció: \n 1. Atacar\n 2. Protegir-se\n 3. Habilitat especial";
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
            const string MSG_Healing = "Recuperació de vida (Valor percentual) [";
            const string MSG_Error_Parameters = "El valor no és correcte.";
            const string MSG_Final = "El joc ha acabat!";
            const string MSG_Character_Not_Complete = "No has introduit els valors correctament en 3 intents, torna-ho a intentar!";
            const string MSG_Turn = "Torn ";
            const string MSG_Archer_Attack = "Arquera ataca a Monstre amb ";
            const string MSG_Fighter_Attack = "Bàrbar ataca a Monstre amb ";
            const string MSG_Mage_Attack = "Maga ataca a Monstre amb ";
            const string MSG_Druid_Attack = "Druida ataca a Monstre amb ";
            const string MSG_Boss_Attack = "Monstre ataca a Monstre amb ";
            const string MSG_Archer_Defense = "La Arquera es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.\n";
            const string MSG_Fighter_Defense = "El Bàrbar es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.\n";
            const string MSG_Mage_Defense = "La Maga es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.\n";
            const string MSG_Druid_Defense = "El Druida es protegeix del monstre i duplica la seva reducció de dany pel pròxim atac.\n";
            const string MSG_Boss_Defense = "El Monstre es defensa i rep només ";
            const string MSG_Boss_health = "Vida restant del Monstre: ";
            const string MSG_Archer_Death = "La Arquera està morta i no pot actuar.";
            const string MSG_Fighter_Death = "El Bàrbar està morta i no pot actuar.";
            const string MSG_Mage_Death = "La Maga està morta i no pot actuar.";
            const string MSG_Druid_Death = "El Druida està morta i no pot actuar.";

            const int MAX_Archer_Heath = 2000, MIN_Archer_Health = 1500, MAX_Archer_Attack = 300, MIN_Archer_Attack = 180, MAX_Archer_Defense = 40, MIN_Archer_Defense = 25;
            const int MAX_Fighter_Heath = 3750, MIN_Fighter_Health = 3000, MAX_Fighter_Attack = 250, MIN_Fighter_Attack = 150, MAX_Fighter_Defense = 45, MIN_Fighter_Defense = 35;
            const int MAX_Mage_Heath = 1500, MIN_Mage_Health = 1000, MAX_Mage_Attack = 350, MIN_Mage_Attack = 300, MAX_Mage_Defense = 35, MIN_Mage_Defense = 20;
            const int MAX_Druid_Heath = 2500, MIN_Druid_Health = 2000, MAX_Druid_Attack = 120, MIN_Druid_Attack = 70, MAX_Druid_Defense = 40, MIN_Druid_Defense = 25;
            const int MAX_Boss_Heath = 12000, MIN_Boss_Health = 9000, MAX_Boss_Attack = 400, MIN_Boss_Attack = 250, MAX_Boss_Defense = 30, MIN_Boss_Defense = 20;
            
            const int Max_Trys = 3;


            double Archer_Health = 0, Archer_Attack = 0, Archer_Healing = 0, Archer_Defense = 0;
            double Fighter_Health = 0, Fighter_Attack = 0, Fighter_Healing = 0, Fighter_Defense = 0;
            double Mage_Health = 0, Mage_Attack = 0, Mage_Healing = 0, Mage_Defense = 0;
            double Druid_Health = 0, Druid_Attack = 0, Druid_Healing = 0, Druid_Defense = 0;
            double Boss_Health = 0, Boss_Attack = 0, Boss_Healing = 0, Boss_Defense = 0;


            int option, trys, turn = 1;

            bool started=true, Archer_Hability = false, Fighter_Hability = false, Mage_Hability = false, Druid_Hability = false, character_complete, game_started=true;
            bool Fighter_Alive = true, Archer_Alive = true, Mage_Alive = true, Druid_Alive = true, Boss_Alive = true;
            bool Archer_Defensed = false, Fighter_Defensed = false, Mage_Defensed = false, Druid_Defensed = false;

            Console.WriteLine(MSG_Welcome);

            while (started) /* Bucle que permet tornar a jugar un cop finalitza la partida.*/
            {
                Console.WriteLine(MSG_Start);

                option = Convert.ToInt32(Console.ReadLine());
                trys = 1;

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
                                Console.WriteLine();
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
                                Console.WriteLine();
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

                                while ((Fighter_Health < MIN_Fighter_Health || Fighter_Health > MAX_Fighter_Heath) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Health + MIN_Fighter_Health + "-" + MAX_Fighter_Heath + "]: ");

                                    Fighter_Health = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Attack + MIN_Fighter_Attack + "-" + MAX_Fighter_Attack + "]: ");

                                Fighter_Attack = Convert.ToDouble(Console.ReadLine());

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

                                while ((Mage_Health < MIN_Mage_Health || Mage_Health > MAX_Mage_Heath) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Health + MIN_Mage_Health + "-" + MAX_Mage_Heath + "]: ");

                                    Mage_Health = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Attack + MIN_Mage_Attack + "-" + MAX_Mage_Attack + "]: ");

                                Mage_Attack = Convert.ToDouble(Console.ReadLine());

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

                                while ((Druid_Health < MIN_Druid_Health || Druid_Health > MAX_Druid_Heath) && trys < Max_Trys)
                                {

                                    Console.WriteLine(MSG_Error_Parameters);
                                    Console.WriteLine(MSG_Health + MIN_Druid_Health + "-" + MAX_Druid_Heath + "]: ");

                                    Druid_Health = Convert.ToDouble(Console.ReadLine());
                                    trys++;
                                }
                                Console.WriteLine();
                            }

                            if (trys < Max_Trys)
                            {
                                Console.WriteLine(MSG_Attack + MIN_Druid_Attack + "-" + MAX_Druid_Attack + "]: ");

                                Druid_Attack = Convert.ToDouble(Console.ReadLine());

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

                Console.WriteLine(MSG_Start_Game);

                Console.WriteLine();

                while (game_started)
                {
                    Console.WriteLine(MSG_Turn + turn + ":\n");

                    if(Archer_Alive && Boss_Alive)
                    {
                        Console.WriteLine(MSG_Archer + MSG_Action);

                        option=Convert.ToInt32(Console.ReadLine());

                        while(!(option==1 || option==2 || option==3))
                        {
                            Console.WriteLine(MSG_Error_Parameters);
                            Console.WriteLine();
                            Console.WriteLine(MSG_Archer + MSG_Action);
                            option = Convert.ToInt32(Console.ReadLine());
                        }

                        switch (option)
                        {
                            case 1:
                                        
                                double Damage_Dealt;
                                Damage_Dealt = Archer_Attack - (Archer_Attack * (Boss_Defense / 100));
                                Boss_Health -= Damage_Dealt;
                                if (Boss_Health < 0)
                                {
                                Boss_Health = 0;
                                Boss_Alive = false;
                                }

                                Console.WriteLine(MSG_Archer_Attack + Archer_Attack + " de dany. " + MSG_Boss_Defense + Damage_Dealt + " de dany. " + MSG_Boss_health + Boss_Health);

                                Console.WriteLine();
                                break;

                            case 2:

                                Archer_Defense *= 2;
                                Archer_Defensed = true;

                                Console.WriteLine(MSG_Archer_Defense);

                                break;

                            case 3:



                                break;
                        }
                    }else if(!Archer_Alive) Console.WriteLine(MSG_Archer_Death);

                    if (Fighter_Alive && Boss_Alive)
                    {
                        Console.WriteLine(MSG_Fighter + MSG_Action);

                        option = Convert.ToInt32(Console.ReadLine());

                        while (!(option == 1 || option == 2 || option == 3))
                        {
                            Console.WriteLine(MSG_Error_Parameters);
                            Console.WriteLine();
                            Console.WriteLine(MSG_Fighter + MSG_Action);
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

                                Console.WriteLine(MSG_Fighter_Attack + Fighter_Attack + " de daño. " + MSG_Boss_Defense + Damage_Dealt + " de daño. " + MSG_Boss_health + Boss_Health);

                                Console.WriteLine();
                                break;

                            case 2:

                                Fighter_Defense *= 2;
                                Fighter_Defensed = true;

                                Console.WriteLine(MSG_Fighter_Defense);

                                break;

                            case 3:

                                break;
                        }
                    }
                    else if (!Fighter_Alive)
                    {
                        Console.WriteLine(MSG_Fighter_Death);
                    }


                    if (Mage_Alive && Boss_Alive)
                    {
                        Console.WriteLine(MSG_Mage + MSG_Action);

                        option = Convert.ToInt32(Console.ReadLine());

                        while (!(option == 1 || option == 2 || option == 3))
                        {
                            Console.WriteLine(MSG_Error_Parameters);
                            Console.WriteLine();
                            Console.WriteLine(MSG_Mage + MSG_Action);
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

                                Console.WriteLine(MSG_Mage_Attack + Mage_Attack + " de daño. " + MSG_Boss_Defense + Damage_Dealt + " de daño. " + MSG_Boss_health + Boss_Health);

                                Console.WriteLine();
                                break;

                            case 2:

                                Mage_Defense *= 2;
                                Mage_Defensed = true;

                                Console.WriteLine(MSG_Mage_Defense);

                                break;

                            case 3:

                                break;
                        }
                    }
                    else if (!Mage_Alive)
                    {
                        Console.WriteLine(MSG_Mage_Death);
                    }


                    if (Druid_Alive && Boss_Alive)
                    {
                        Console.WriteLine(MSG_Druid + MSG_Action);

                        option = Convert.ToInt32(Console.ReadLine());

                        while (!(option == 1 || option == 2 || option == 3))
                        {
                            Console.WriteLine(MSG_Error_Parameters);
                            Console.WriteLine();
                            Console.WriteLine(MSG_Druid + MSG_Action);
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

                                Console.WriteLine(MSG_Druid_Attack + Druid_Attack + " de daño. " + MSG_Boss_Defense + Damage_Dealt + " de daño. " + MSG_Boss_health + Boss_Health);

                                Console.WriteLine();
                                break;

                            case 2:

                                Druid_Defense *= 2;
                                Druid_Defensed = true;

                                Console.WriteLine(MSG_Druid_Defense);

                                break;

                            case 3:

                                break;
                        }
                    }
                    else if (!Druid_Alive)
                    {
                        Console.WriteLine(MSG_Druid_Death);
                    }


                    if (!Druid_Alive && !Archer_Alive && !Mage_Alive && !Druid_Alive) game_started = false;
                    else
                    {
                        double Damage_Dealt;

                        Damage_Dealt=Boss_Attack-(Boss_Attack*(Archer_Defense / 100));

                        if(Archer_Defensed)
                        {
                            Archer_Defense /= 2;
                            Archer_Defensed=false;
                        }

                        Archer_Health -= Damage_Dealt;

                        if(Archer_Health < 0)
                        {
                            Archer_Health = 0;
                            Archer_Alive = false;
                        }


                        Damage_Dealt = Boss_Attack - (Boss_Attack * (Fighter_Defense / 100));

                        if (Fighter_Defensed)
                        {
                            Fighter_Defense /= 2;
                            Fighter_Defensed = false;
                        }

                        Fighter_Health -= Damage_Dealt;

                        if (Fighter_Health < 0)
                        {
                            Fighter_Health = 0;
                            Fighter_Alive = false;
                        }

                        if (Mage_Defensed)
                        {
                            Mage_Defense /= 2;
                            Mage_Defensed = false;
                        }

                        Mage_Health -= Damage_Dealt;

                        if (Mage_Health < 0)
                        {
                            Mage_Health = 0;
                            Mage_Alive = false;
                        }

                        if (Druid_Defensed)
                        {
                            Druid_Defense /= 2;
                            Druid_Defensed = false;
                        }

                        Druid_Health -= Damage_Dealt;

                        if (Druid_Health < 0)
                        {
                            Druid_Health = 0;
                            Druid_Alive = false;
                        }

                    }
                    turn+=1;
                }

                        

            }
            /*Console.WriteLine(MSG_Final);*/
        }
            
    }

}
