using System;
using Hotelaria.Models.Quartos;

namespace Hotelaria.Models.Gerente
{
    public class Gerente
    {
        // Instancia pertencente a classe
        private static Gerente _instancia = new Gerente();

        public LinkedList<string> Reservas { get; private set; } = new LinkedList<string>();

        // Construtor privado
        private Gerente() { }

        // Metodo para obter a instancia
        public static Gerente ObterInstancia() 
        {
            return _instancia;
        }

        public void AdicionarReserva(Quarto quarto, string cliente)
        {
            string reserva = $"{cliente} - {quarto.Tipo}: {quarto.Descricao()}";

            if (!Reservas.Contains(reserva))
            {
                Reservas.AddLast(reserva);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Reserva adicionada: {cliente} - {quarto.Descricao()}");
                Thread.Sleep(2000);
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
            string reserva = $"{cliente} - {quarto.Tipo}: {quarto.Descricao()}";

            if (Reservas.Contains(reserva))
            {
                Reservas.Remove(reserva);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Reserva removida: {cliente} - {quarto.Descricao()}");
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
            foreach (var reserva in Reservas)
            {
                Console.WriteLine(reserva);
            }
        }

    }
}