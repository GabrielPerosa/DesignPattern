using System;
using System.Collections.Generic;

namespace Hotelaria.Models.Observador
{

    public class RegistradorDeLog : IObservador
    {
        private string _caminhoArquivo = "log_reservas.txt";

        public void Atualizar(string mensagem)
        {
            // Formata a mensagem para incluir data e hora
            string mensagemCompleta = $"{DateTime.Now:dd/MM/yyyy HH:mm:ss} - {mensagem}";

            // Abre o arquivo em modo append (adiciona novas linhas ao final)
            using (StreamWriter writer = new StreamWriter(_caminhoArquivo, true))
            {
                writer.WriteLine(mensagemCompleta);
            }

            Console.WriteLine("Reserva registrada no log.");
        }
    }
}