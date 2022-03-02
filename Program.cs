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

static void desafio2(){
    /*
    Desafio
Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000). 
Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

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
       

        static void Main(string[] args)
        {


/*

O programa deve ler um valor inteiro D indefinidas vezes, 
ele só irá parar quando o valor de D for igual a 0. 
Para cada D lido, imprima a soma dos 5 pares consecutivos 
a partir de D, inclusive ele mesmo , se for par. Se o valor
 de entrada for 4, por exemplo, a saída deve ser 40, que é 
 o resultado da operação: 4+6+8+10+12, enquanto que se o valor
  de entrada for 11, por exempo, a saída deve ser 80, que é a 
  soma de 12+14+16+18+20.

Entrada
O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero.

Saída
Imprima a saida conforme a explicação acima e o exemplo abaixo.

 
Exemplo de Entrada	Exemplo de Saída
4
11
0

40
80




*/



    
     int x1 = 4;
       if(!(x1%2==0)) {
           x1 = x1+1;
       }
      
       int c1 = x1;
       int a1 = 0;
       int qtd1 = 0;
      while(qtd1 < 5 ){
         
       for (int i1 = c1; i1 < x1+10;  i1++ ){
         
         if(i1%2 == 0){
          qtd1++;
            a1+=i1;
            
                
            } 
        } 
    }
       int x = 11;
       if(!(x%2==0)) {
           x = x+1;
       }
      
       int c = x;
       int a = 0;
       int qtd = 0;
      while(qtd < 5 ){
         
       for (int i = c; i < x+10;  i++ ){
         
         if(i%2 == 0){
          qtd++;
            a+=i;
            
                
            } 
        } 
    }
  
        Console.WriteLine($"{a1}");
        Console.WriteLine($"{a}");








     
        }
    }
}
