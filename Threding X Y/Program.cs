using System;
using System.Threading;


namespace Threding_X_Y
{
    public class Program
    {
        public static void Main()
        {
            int posX = 40, posY = 10;
            string simbolos = "^>v<";
            byte simboloActual = 0;
            bool terminado = false;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(posX, posY);
                Console.Write(simbolos[simboloActual]);
                Thread.Sleep(500);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.RightArrow) posX++;
                    if (tecla.Key == ConsoleKey.LeftArrow) posY--;
                    if (tecla.Key == ConsoleKey.Escape) terminado = true;

                }
                simboloActual++;
                if (simboloActual > 3) simboloActual = 0;
            }
            while (!terminado);
            
        }
    }
}
