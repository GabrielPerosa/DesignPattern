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
            string reserva = $"{cliente} - {quarto.Tipo}";

            if (!Reservas.Contains(reserva))
            {
                Reservas.AddLast(reserva);
                Console.WriteLine($"Reserva adicionada: {cliente} - {quarto.Descricao()}");
            }
            else
            {
                Console.WriteLine($"A reserva já existe: {reserva}");
            }
        }

        public void RemoverReserva(Quarto quarto, string cliente)
        {
            string reserva = $"{cliente} - {quarto.Tipo}";

            if (Reservas.Contains(reserva))
            {
                Reservas.Remove(reserva);
                Console.WriteLine($"Reserva removida: {cliente} - {quarto.Descricao()}");
            }
            else
            {
                Console.WriteLine($"Reserva não encontrada: {reserva}");
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