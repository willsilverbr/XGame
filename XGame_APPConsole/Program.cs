using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame_APPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando... ");

            var Service = new ServiceJogador();
            Console.WriteLine("Criei instancia do Servico ");


            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do Meu Objeto ");
            request.Email = "Paulo";


            var response = Service.AutenticarJogador(request);

            //Service.AutenticarJogador();

            Console.ReadKey();
        }
    }
}
