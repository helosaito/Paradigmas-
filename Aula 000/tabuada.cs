
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Ola mundo!!\n");
        int tabuada = 0;
        
        Console.WriteLine("Digite o numero: ");
        int numero = int.Parse(Console.ReadLine()!);
       
        
        for(int i=0; i<11; i++){
            tabuada = numero * i;
            Console.WriteLine ($"{i} X {numero} = {tabuada}");
        }
    }
}