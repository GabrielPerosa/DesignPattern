using System;
using System.Collections.Generic;
using System.Linq;
using Hotelaria.Models;
using Hotelaria.Models.Estrategia;
using Hotelaria.Models.Observador;
using Hotelaria.Models.Quartos;
using Hotelaria.Models.Adicionais;
using Hotelaria.Models.Gerente;

bool ExibirMenu = true;
int opcao = 0;
Gerente gerente = Gerente.ObterInstancia();

while(ExibirMenu) 
{
    Console.WriteLine("\nBem-vindo ao Hotel Itália!\n");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Reservar novo quarto");
    Console.WriteLine("2 - Listar reservas");
    Console.WriteLine("3 - Remover reserva");
    Console.WriteLine("4 - Sair\n");

    opcao = int.Parse(Console.ReadLine());
    switch(opcao)
    {
        case 1:
            // Nome do cliente
            Console.Clear();
            Console.WriteLine("Digite o nome do cliente:");
            string cliente = Console.ReadLine();

            bool validado = false;
            // Escolha do quarto
            while (!validado)
            {
                Console.Clear();
                Console.WriteLine("Escolha um quarto:");
                Console.WriteLine("1 - Quarto Básico");
                Console.WriteLine("2 - Quarto Médio");
                Console.WriteLine("3 - Quarto Luxo");
                Console.WriteLine("4 - Cancelar\n");

                opcao = int.Parse(Console.ReadLine());
                
                switch(opcao)
                {
                    case 1:
                        Console.Clear();
                        gerente.AdicionarReserva(QuartoFactory.CriarQuarto(TipoQuarto.Economico), cliente);
                        Thread.Sleep(2000);
                        validado = true;
                        break;
                    case 2:
                        Console.Clear();
                        gerente.AdicionarReserva(QuartoFactory.CriarQuarto(TipoQuarto.Medio), cliente);
                        Thread.Sleep(2000); 
                        validado = true;
                        break;
                    case 3:
                        Console.Clear();
                        gerente.AdicionarReserva(QuartoFactory.CriarQuarto(TipoQuarto.Luxo), cliente);
                        Thread.Sleep(2000); 
                        validado = true;
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Reserva cancelada.");
                        Thread.Sleep(1000);
                        Console.ResetColor();
                        Console.Clear();
                        validado = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            }
            
            break;
        case 2:
            listar(gerente);
            break;
        case 3:
            listar(gerente);
            Console.WriteLine("Digite o nome do cliente:");
            string clienteRemover = Console.ReadLine();
            Console.WriteLine("Digite o tipo do quarto:");
            Console.WriteLine("1 - Quarto Básico");
            Console.WriteLine("2 - Quarto Médio");
            Console.WriteLine("3 - Quarto Luxo");
            Console.WriteLine("4 - Cancelar\n");
            string quartoRemover = Console.ReadLine();
            
            // Escolha do quarto a ser removido
            TipoQuarto tipo = TipoQuarto.Economico;
            if (quartoRemover == "1")
            {
                tipo = TipoQuarto.Economico;
            }
            else if (quartoRemover == "2")
            {
                tipo = TipoQuarto.Medio;
            }
            else if (quartoRemover == "3")
            {
                 tipo = TipoQuarto.Luxo;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida! Tente novamente.");
                Thread.Sleep(1200);
            }

            gerente.RemoverReserva(QuartoFactory.CriarQuarto(tipo), clienteRemover);

            break;    
        case 4:
            Console.Clear();
            Console.WriteLine("Saindo.");
            Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("Saindo..");
            Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("Saindo...");
            Thread.Sleep(800);
            Console.Clear();
            ExibirMenu = false;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida! Tente novamente.");
            Thread.Sleep(1200);
            Console.ResetColor();
            Console.Clear();
            break;
    }
}  

static void listar(Gerente gerente)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    gerente.ListarReservas();
    Console.WriteLine("=================================\n");
    Thread.Sleep(2000);
    Console.ResetColor();
}
