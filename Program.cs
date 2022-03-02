using System;
using static System.Console;

namespace desafio1
{
    class Program
    {
 static void desafio1(){
     
       /*
    Imprima o por extenso os meses do ano de acordo com seu respectivo
    mês.     
    */


           Console.WriteLine("Enter the Month") ;
        int mes = Int32.Parse(Console.ReadLine());

        switch (mes) {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("February");
                break;
            case 3:
                Console.WriteLine("March");
                break;
           
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
             case 7:
                Console.WriteLine("July");
                break; 
              case 8:
                Console.WriteLine("August");
                break; 
              case 9:
                Console.WriteLine("September");
                break; 
              case 10:
                Console.WriteLine("October");
                break; 
                case 11:
                Console.WriteLine("November");
                break;
                case 12:
                Console.WriteLine("December");
                break;
                default:
                Console.WriteLine("Digite um número válido de 1 a 12");
                break;
        }
 }

       

        static void Main(string[] args)
        {
    
    /*
    Desafio
Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada
O arquivo de entrada contém um número inteiro positivo N.

Saída
Imprima a saída conforme o exemplo fornecido.

 
Exemplo de Entrada	Exemplo de Saída
5

1 1 1
2 4 8
3 9 27
4 16 64
5 25 125
    
    
    
    */

         WriteLine("Enter the number ?");
        int n = Int32.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                
           WriteLine($@"
             { i  }  {i * i} { i*i*i  }
            ");
                
            }








     
        }
    }
}
