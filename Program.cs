/*
Desafio 5 (Vai Ter Copa?)

Kluper é o país sede da copa do mundo. Porém, há muitas pessoas protestando contra o governo. Em redes 
sociais é possível ver pessoas afirmando que não vai ter copa devido aos protestos e insatisfação 
política.
Mas esses rumores de que não haverá copa são totalmente falsos, e o governo já avisou: vai ter copa sim!

Entrada
A entrada contém vários casos de teste. Cada caso de teste consiste de uma linha contendo o número N de 
reclamações sobre a copa encaminhadas para o governo (0 ≤ N ≤ 100).

Saída
Para cada teste, a saída consiste de uma linha dizendo "vai ter copa!" caso não haja reclamações para o 
governo. Caso haja reclamações, a saída deverá dizer "vai ter duas!".

Exemplo de Entrada	  Exemplo de Saída
0                     vai ter copa!
1                     vai ter duas!
0                     vai ter copa!
2                     vai ter duas!
100                   vai ter duas!
0                     vai ter copa!
*/

using System;

namespace Desafio5
{
    class DIO
    {
        static void Main(String[] args)
        {
            string str;
            while((str=Console.ReadLine()) != null)
            {
                int x = int.Parse(str);
                if (x == 0)
                {
                    Console.WriteLine("Vai ter copa!");
                }
                else
                {
                    Console.WriteLine("vai ter duas!");
                }
            }
        }
    }
}