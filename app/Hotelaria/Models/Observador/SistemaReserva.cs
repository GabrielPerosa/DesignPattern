using System;
using System.Collections.Generic;

namespace Hotelaria.Models.Observador
{
    public class SistemaReserva
    {
        private readonly List<IObservador> _observadores = new List<IObservador>();

        // Expondo os observadores através de uma propriedade somente leitura
        public IReadOnlyList<IObservador> Observadores => _observadores;
        
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

            // Cria um novo registrador de log
            RegistradorDeLog registrador = new RegistradorDeLog();

            // Adiciona o registrador à lista de observadores
            _observadores.Add(registrador);

        }
    }
}