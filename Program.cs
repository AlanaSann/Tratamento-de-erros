using System;

namespace Tratar_erros
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Verifica a data
             Console.WriteLine("Digite uma data");
             string data = Console.ReadLine();
             bool verificarData = Validador.VerificarData(data); //utilisa a classe.metodo
             Console.WriteLine(verificarData);*/

            //Verifica se a string pode se converter em inteiro
           // Console.WriteLine("Digite um valor");
           // string inteiro = Console.ReadLine();
           // bool verificarInteiro = Validador.verificarInteiro(inteiro);
           // Console.WriteLine(verificarInteiro);

            //Verifica se a string pode ser convertida em um email válido
            //Console.WriteLine("Digite um email");
           // string email = Console.ReadLine();
           // bool verificarEmail = Validador.verificarEmail(email);
           // Console.WriteLine(verificarEmail);

            //Verifica se a string pode ser convertida em um decimal válido
            Console.WriteLine("Digite um valor");
            string decim = Console.ReadLine();
            bool verificarDec = Validador.verificarDecimal(decim);
            Console.WriteLine(verificarDec);
        }
    }
}
