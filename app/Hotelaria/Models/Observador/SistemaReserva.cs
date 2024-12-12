using System;
using System.Collections.Generic;
using Hotelaria.Models.Estrategia;
using Hotelaria.Models.Quartos;

namespace Hotelaria.Models.Observador
{
    public class SistemaReserva
    {
        public static SistemaReserva _instancia = new SistemaReserva();
        public LinkedList<string> Reservas { get; private set; } = new LinkedList<string>();

        private readonly List<IObservador> _observadores = new List<IObservador>();

        public IReadOnlyList<IObservador> Observadores => _observadores;

        private SistemaReserva () { }

        public static SistemaReserva ObterInstancia() 
        {
            return _instancia;
        }

        public void AdicionarObservador(IObservador observador)
        {
            _observadores.Add(observador);
        }

        public void NotificarObservadores(string mensagem)
        {
            foreach (var observador in _observadores)
            {
                observador.Atualizar(mensagem);
            }
        }

        public void RealizarReserva(string cliente, Quarto quarto)
        {
            IEstrategiaDePreco estrategia = GerenciadorDeEstrategias.ObterEstrategia(quarto.Tipo);

            string preco = estrategia.CalcularPreco(quarto);
            string reserva = $"Cliente: {cliente} \nTipo: {quarto.Tipo} \nDescrição: {quarto.Descricao() }\nPreço: {preco}";

            if (!Reservas.Contains(reserva))
            {
                Reservas.AddLast(reserva);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Reserva realizada por: {cliente} para o quarto: {quarto.Descricao()}");

                NotificarObservadores($"Nova reserva realizada: {cliente} para o quarto: {quarto.Descricao()}");

                RegistradorDeLog registrador = new RegistradorDeLog();

                _observadores.Add(registrador);

                Thread.Sleep(1000);
                Console.ResetColor();
            }
            else
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A reserva já existe: {reserva}");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }

        public void RemoverReserva(Quarto quarto, string cliente)
        {
            IEstrategiaDePreco estrategia = GerenciadorDeEstrategias.ObterEstrategia(quarto.Tipo);

            string preco = estrategia.CalcularPreco(quarto);
            string reserva = $"Cliente: {cliente} \nTipo: {quarto.Tipo} \nDescrição: {quarto.Descricao() }\nPreço: {preco}";

            if (Reservas.Contains(reserva))
            {
                Reservas.Remove(reserva);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Reserva removida: {cliente} - {quarto.Descricao()}");

                NotificarObservadores($"Reserva removida: {cliente} para o quarto: {quarto.Descricao()}");
                
                Thread.Sleep(1000);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Reserva não encontrada: {reserva}");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }

        public void ListarReservas()
        {
            Console.WriteLine("Reservas: ");
            if (Reservas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Não há reservas no sistema.");
                Console.ResetColor();
            }
            else
            {
                foreach (var reserva in Reservas)
                {
                    Console.WriteLine(reserva);
                }
            }
        }
    }
}