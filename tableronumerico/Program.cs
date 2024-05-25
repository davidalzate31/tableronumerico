// Desarrollar un programa en C# que simule un juego de suma y movimiento en un tablero NxN. El objetivo del juego es mover el cero "0" a través del tablero para sumar los valores de las casillas y acumular puntos, evitando los obstáculos.//

using System;

class SumaMovimiento
{
    static void Main(string[] args)
    {
        // TAMAÑO DEL TABLERO
        int n = 5;

        //INICIALIZAR TABLERO
        int[,] tablero = new int[n, n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                tablero[i, j] = random.Next(1, 10);
            }
        }
        //PISICION INICIAL DEL 0
        int x = 0, y = 0;
        tablero[x, y] = 0;

        //PUNTAJE INICIAL
        int puntaje = 0;

        //BUCLE PPAL JUEGO
        while (true) 
        {
            //MOSTRAR TABLERO ACTUAL Y PUNTAJE
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == x && j == y)
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write(tablero[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Puntaje: " + puntaje);

            //OPCION DE MENU
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("W: Mover Arriba");
            Console.WriteLine("A: Mover Izquierda");
            Console.WriteLine("S: Mover Abajo");
            Console.WriteLine("D: Mover Derecha");
            Console.WriteLine("Esc: Salir");

            // LEER OPCOIN JUGADOR
            ConsoleKeyInfo tecla = Console.ReadKey(true);

            //PROCESAR OPCION JUGADOR
            switch (tecla.Key)
            {
                case ConsoleKey.W:
                    if (x > 0)
                    {
                        puntaje += tablero[x - 1, y];
                        tablero[x - 1, y] = 0;
                        x--;
                    }
                    break;
                case ConsoleKey.A:
                    if (y > 0)
                    {
                        puntaje += tablero[x, y - 1];
                        tablero[x, y - 1] = 0;
                        y--;
                    }
                    break;
                case ConsoleKey.S:
                    if (x < n - 1)
                    {
                        puntaje += tablero[x + 1, y];
                        tablero[x + 1, y] = 0;
                        x++;
                    }
                    break;
                case ConsoleKey.D:
                    if (y < n - 1)
                    {
                        puntaje += tablero[x, y + 1];
                        tablero[x, y + 1] = 0;
                        y++;
                    }
                    break;
                case ConsoleKey.Escape:
                    Console.WriteLine("¡Juego terminado!");
                    Console.WriteLine("Puntaje final: " + puntaje);
                    return;
            }


        }
    }

}
