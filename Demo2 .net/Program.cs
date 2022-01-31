using System;
using static System.Console;

namespace Demo2_.net
{
    //Aula Utilização do "ref"
    class Program
    {
        /*A primera forma de utilização de ref é colocando ele na declaração
        dos parâmetos do método e após na chamada do método
        */

        //======================================================

        //Cria o método, referenciando a variável
        static void Adcionar20(ref int a){
            a += 20;
        }
        static void Main(string[] args)
        {
            //Cria variável
            int a = 10;
            //Chama o método, usando "ref" 
            Adcionar20(ref a); 
            WriteLine($"O valor de a é: {a}");
        }
    }
}
