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

    }

}
