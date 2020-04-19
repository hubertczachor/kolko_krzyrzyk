using System;

namespace kolko_i_krzyzyk
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string imieGraczaA = "";
            string imieGraczaB = "";
            char znakGraczaA = 'x';
            char znakGraczaB = 'o';
            char[,] plansza = new char[3, 3]
            {
                {'1', '2', '3'},
                {'4', '5', '6'},
                {'7', '8', '9'}
            };

            Console.Write("Wprowadź imię gracza A: ");
            imieGraczaA = Console.ReadLine();
            Console.Write("Wprowadź imię gracza B: ");
            imieGraczaB = Console.ReadLine();

            Console.ReadKey();

        }

    }
}
