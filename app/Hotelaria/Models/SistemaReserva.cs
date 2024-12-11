using System;
using System.Collections.Generic;

namespace Hotelaria.Models
{
    public class SistemaReserva
    {
        private readonly List<IObservador> _observadores = new List<IObservador>();

        // Adiciona um observador (administrador) à lista
        public void AdicionarObservador(IObservador observador)
        {
            _observadores.Add(observador);
        }

        // Notifica todos os observadores registrados
        public void NotificarObservadores(string mensagem)
        {
            foreach (var observador in _observadores)
            {
                observador.Atualizar(mensagem);
            }
        }
        public void RealizarReserva(string cliente)
        {
            // Simula a realização de uma reserva
            Console.WriteLine($"Reserva realizada por: {cliente}");
            
            // Notifica todos os administradores sobre a nova reserva
            NotificarObservadores($"Nova reserva realizada: {cliente}");
        }
    }
}