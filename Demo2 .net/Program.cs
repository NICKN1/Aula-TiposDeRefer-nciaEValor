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
        static void Demo1(){
            //Cria variável
            int a = 10;
            //Chama o método, usando "ref" 
            Adcionar20(ref a); 
            WriteLine($"O valor de a é: {a}");
        }
        static void Adcionar20(ref int a){
            a += 20;
        }

        //Cria método para trocar os nomes da lista
        static void Trocarnomes(string[] nomes, string nome, string nomeNovo){
            for (int i = 0; i < nomes.Length; i++)
            {
                if(nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;
                }
            }
        }
        static void Main(string[] args)
        {
            //Cria um array de strings
            var nomes = new string[]{"João", "Maria", "Pedro", "Jonas", "Flávia"};
            
            //Mostro a lista dos nomes salvos no array, uso "\n" para quebrar as linhas
            WriteLine($@"A lista de nomes atual é:
            {string.Join(", \n", nomes )}");
            WriteLine("Digite o nome a ser alterado da lista: ");
            var nome = ReadLine();
            WriteLine("Digite o nome novo: ");
            var nomeNovo = ReadLine();

            //Chamo o método criado 
            Trocarnomes(nomes, nome, nomeNovo);
            WriteLine("");
            WriteLine($@"A lista de nomes atualizada é: 
            {string.Join(", \n", nomes)}");
        }
    }
}
