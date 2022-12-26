using System;
class diasDeVida
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Informe o ano atual");
        int anoAtual = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Informe o ano de nascimento");
        int anoNasc = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Informe o mês atual");
        int mesAtual = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Informe o mês de nascimento");
        int mesNasc = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Informe que dia é hoje");
        int diaAtual = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Informe o dia do seu nascimento");
        int diaNasc = int.Parse(Console.ReadLine());
        
        int idade = (anoAtual - anoNasc);
        int difMes = (mesAtual - mesNasc);
        int difDia = (diaAtual - diaNasc);
           
        System.Console.WriteLine("Atualmente vc tem {0} anos {1} meses e {2} dias de vida.", idade, difMes, difDia);

    }
}