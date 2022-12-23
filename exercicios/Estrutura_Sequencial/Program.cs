// - Criar um algoritmo que leia um número inteiro e apresente na tela o seu antecedente e o seu sucessor.

using System;

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero inteiro.");
        int num = int.Parse(Console.ReadLine());

        int suc = num + 1;
        int ant = num - 1;        

        Console.WriteLine($"O numero digitado foi ({num}) seu sucessor é ({suc}) e seu antecessor é ({ant})" );
    }
}