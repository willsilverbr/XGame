using System;
using System.Collections.Generic;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.Resoucers;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Services
{
    //Nessa Classe temos as auten
    public class ServiceJogador : Notifiable,  IServiceJogador
    {
        private readonly IRepositoryJogador repositoryJogador;
        public ServiceJogador()
        {
        }
        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            this.repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorResquest request)
        {
            Jogador jogador = new Jogador();
            jogador.Email = request.Email;
            jogador.Nome = request.Nome;

            jogador.Status = Enum.EnumSituacaoJogador.EmAndamento;

           Guid id = repositoryJogador.AdicionarJogador(jogador);

            jogador.Status = Enum.EnumSituacaoJogador.Ativo;

            return new AdicionarJogadorResponse() { Id = id, Message = "Operacao Realizada Com Sucesso!" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
               AddNotification("AutenticarJogadorRequest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticadorJogador"));

            }

            var email = new Email(request.Email);

            var Jogador = new Jogador(email, request.Senha);

            //AddNotification(Jogador, email);


            if (Jogador.IsValid())
            {
                return null; 
            }

            var response = repositoryJogador.AutenticarJogador(Jogador.Email.Endereco, Jogador.Senha);

            return response; 
        }

        private void AddNotification(IReadOnlyCollection<Notification> notifications)
        {
            throw new NotImplementedException();
        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
