using System;

namespace Entidades
{
    public static class Juego
    {
                
        public static int Jugar(int jugadaHumano, int jugadaBot)
        {
           int resultado= -1;

            //array bidimensional

            int[,] jugada = new int[5, 5] {
                                                 { 0, 1, 2, 2, 1 },
                                                 { 2, 0, 1, 1, 2 },
                                                 { 1, 2 ,0, 2, 1 },
                                                 { 1, 2, 1, 0, 2 },
                                                 { 2, 1 ,2, 1, 0 }
                
                                           };
            resultado = jugada[jugadaHumano,jugadaBot];
            return resultado;

        }

        public static int CalcularRandom()
        {
            Random r = new Random();
            return r.Next(0, 5);
        }

        public static string DevolverNombre(int jugada)
        {
            string[] nombres = new string[5] { "Piedra", "Papel", "Tijera", "Lagarto", "Spock" };
            return nombres[jugada];
        }

        public static string DevolverResultado(int resultado)
        {
            string[] resultado_texto = new string[3] { "Empatamos", "Yo gane", "Ganaste vos" };
            return resultado_texto[resultado];

        }

        public static string DevolverLeyenda(int jugada1, int jugada2)
        {
            string[ ,] leyenda = new string[5,5] {


                {"Piedra empata con Piedra", "Papel tapa a Piedra", "Piedra aplasta a Tijera", "Piedra aplasta a Lagarto", "Spock vaporiza a Piedra" },
                {"Papel tapa a Piedra", "Papel empata con Papel", "Tijera corta a Papel","Lagarto devora a Papel", "Papel desautoriza a Spock" },
                {"Piedra aplasta a Tijera",  "Tijera corta a Papel" ,"Tijera empata con Tijera", "Tijera decapita a Lagarto", "Spock rompe la Tijera" },
                {"Piedra aplasta a Lagarto", "Lagarto devora a Papel", "Tijera decapita a Lagarto", "Lagarto empata con Lagarto", "Lagarto envenena a Spock" },
                {"Spock vaporiza a Piedra",  "Papel desautoriza a Spock" ,"Spock rompe la Tijera", "Lagarto envenena a Spock", "Spock empata con Spock" }

                                                   };

            return leyenda[jugada1,jugada2];
        }

       
    }
}
