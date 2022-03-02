using System;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Enum;
using XGame.Domain.Resoucers;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador : Notifiable
    {
        
        public Jogador(Email email, string senha)
        {
           
            //Foi Adicionado o framework PrmToolki, a classe Jogador foi definida como notificavel
            //E foi feita uma  uma validação para e-mail e senha usando o framework 

            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
               // .IfNotEmail(X => X.Email.Endereco, "Informe um e-mail válido ") n precisa mais pq O e-mail se alto valida
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve ter entre 6 a 32 " +
                "Caracteres; ");

            //Sem o framework o serviço iria ficar validando a nos if's 
            //if (string.IsNullOrEmpty(request.Email))
            //{
            //    throw new Exception("Informe um e-mail");
            //}
            //if (IsEmail(request.Email))
            //{
            //    throw new Exception("Informe um e-mail");
            //}
            //como era feita a validação da senha antes do new AddNotifications
            //if (string.IsNullOrEmpty(request.Senha))
            //{
            //    throw new Exception("Informe uma senha");
            //}
            //if (request.Senha.Length < 6)
            //{
            //    throw new Exception("Digite uma Senha de no minimo 6 caracteres");
            //}

        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
               .IfNullOrInvalidLength(x => x.Senha, 6, 32, Message.X0_E_OBRIGATORIA_E_DEVE_CONTER_X2_CARACTER.ToFormat("Primeiro nome", "3", "50"));

        }

        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public  EnumSituacaoJogador Status { get; private set; }

       
    }
}
