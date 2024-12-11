using System;
using System.Collections.Generic;

namespace Hotelaria.Models
{
    public class Administrador : IObservador
    {
        public void Atualizar(string mensagem)
        {
            // Exibe a mensagem recebida da notificação
            Console.WriteLine($"Administrador notificado: {mensagem}");
        }
    }
}