using System;

namespace kolko_i_krzyzyk
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GraczLudzki gA = new GraczLudzki();
            GraczKomputerowy gB = new GraczKomputerowy();
            gA.Imie = "Uzytkownik";
            gB.Imie = "Komputer";
            gA.Znak = 'x';
            gB.Znak = 'o';
            char[,] plansza = new char[3, 3]
            {
                {'1', '2', '3'},
                {'4', '5', '6'},
                {'7', '8', '9'}
            };
            char[,] planszaKopia = plansza.Clone() as char[,];

            //Petla na kolejne ruchy graczy
            
            bool koniceGry = false;
            bool ruchGraczaA = true;
            for (int runda = 0; runda < plansza.Length; ++runda)
            {
                Console.Clear();
                RysujPlansze(plansza);

                if (ruchGraczaA)
                {
                    Console.WriteLine("Ruch wykonuje: " + gA.Imie);
                    koniceGry = gA.WykonajRuch(plansza, planszaKopia);
                    ruchGraczaA = false;
                }
                else
                {
                    Console.WriteLine("Ruch wykonuje: " + gB.Imie);
                    koniceGry = gB.WykonajRuch(plansza, planszaKopia);
                    ruchGraczaA = true;
                }

                Console.ReadKey();
            }
        }

        static void RysujPlansze (char[,] plansza)
        {
            int wysokosc = plansza.GetLength(0);
            int szerokosc = plansza.GetLength(1);

            for(int i= 0; i< wysokosc; ++i)
            {
                for (int j = 0; j < szerokosc; ++j)
                    Console.Write(plansza[i, j]);
                Console.WriteLine();
                
                    
            }
            
        }

        interface IRuch
        {
            bool WykonajRuch(char[,] plansza, char[,] planszaKopia);
        }

        abstract class Gracz
        {
            public string Imie { get; set; }
            public char Znak { get; set; }
        }

        class GraczLudzki : Gracz, IRuch
        {
            public bool WykonajRuch(char[,] plansza, char[,] planszaKopia)
            {
                return false;
            }
        }

        class GraczKomputerowy : Gracz, IRuch
        {
            public bool WykonajRuch(char[,] plansza, char[,] planszaKopia)
            {
                return false;
            }
        }
    }

}
