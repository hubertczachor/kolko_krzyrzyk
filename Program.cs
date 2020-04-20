using System;

namespace kolko_i_krzyzyk
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string imieGraczaA = "";
            string imieGraczaB = "";
            //char znakGraczaA = 'x';
            //char znakGraczaB = 'o';
            char[,] plansza = new char[3, 3]
            {
                {'1', '2', '3'},
                {'4', '5', '6'},
                {'7', '8', '9'}
            };
            char[,] planszaKopia = plansza.Clone() as char[,];

            Console.Write("Wprowadź imię gracza A: ");
            imieGraczaA = Console.ReadLine();
            Console.Write("Wprowadź imię gracza B: ");
            imieGraczaB = Console.ReadLine();

            //Petla na kolejne ruchy graczy
            //bool koniceGry = false;
            for (int runda = 0; runda < plansza.Length; ++runda)
            {
                Console.Clear();
                RysujPlansze(plansza);

                Console.ReadKey();
//ssss



            }
            



        }

        static void RysujPlansze (char[,] plansza)
        {
            int wysokosc = plansza.GetLength(0);
            int szerokosc = plansza.GetLength(1);

            for(int i= 0; i< wysokosc; ++i)
            {
                for (int j = 0; j < szerokosc; ++j)
                {
                    Console.Write(plansza[i, j]);
                }
                    
            }
                Console.ReadKey();
                
        }
    }
}
