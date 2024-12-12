using System;
using System.Collections.Generic;
using System.Linq;
using Hotelaria.Models;
using Hotelaria.Models.Estrategia;
using Hotelaria.Models.Observador;
using Hotelaria.Models.Quartos;
using Hotelaria.Models.Adicionais;
using Hotelaria.Models.Gerente;

// Terminar Adicionais na função NovaReserva

bool ExibirMenu = true;
int opcao = 0;
Gerente gerente = Gerente.ObterInstancia();

while(ExibirMenu) 
{   
    Console.Clear();
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
            NovaReserva( gerente);
            break;
        case 2:
            listar(gerente);
            break;
        case 3:
            listar(gerente);
            if(gerente.Reservas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhuma reserva cadastrada.");
                Thread.Sleep(1500);
                Console.ResetColor();
                break;
            }
            Console.WriteLine("Digite o nome do cliente:");
            string clienteRemover = Console.ReadLine();

            Console.Clear();
            // Opcao de Quarto
            int quartoRemover = ObterOpcao(
                "Digite o tipo do quarto:\n1 - Quarto Básico\n2 - Quarto Médio\n3 - Quarto Luxo\n4 - Cancelar\n",
                1, 4
            );

            Console.Clear();

            if (quartoRemover == 4)
            {
                Cancelado();
                break;
            }

            Console.Clear();
        
            // Opcao de Adicional
            int adicional = ObterOpcao(
            "Qual pacote adicional?\n1 - Vista para a Praia\n2 - Café da manhã\n3 - Nenhum\n",
            1, 3
            );

            Console.Clear();

            var tipoRemover = (TipoQuarto)(quartoRemover - 1); // Mapeia a opção diretamente ao enum
            var quarto = CriarQuartoComAdicional(tipoRemover, adicional);
            
            gerente.RemoverReserva(quarto, clienteRemover);
            
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
            TenteNovamente();
        break;

    }
}  



static int ObterOpcao(string mensagem, int min, int max)
{
    int opcao;
    do
    {
        Console.WriteLine(mensagem);
        if (int.TryParse(Console.ReadLine(), out opcao) && opcao >= min && opcao <= max)
            return opcao;
        Console.WriteLine("Entrada inválida. Tente novamente.\n");
    } while (true);
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

static void TenteNovamente()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Opção inválida! Tente novamente.");
    Thread.Sleep(1200);
    Console.ResetColor();
    Console.Clear();
}
static void Cancelado()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Operação cancelada.");
    Thread.Sleep(1000);
    Console.ResetColor();
    Console.Clear();
}

static void NovaReserva(Gerente gerente)
{
    Console.Clear();
    Console.WriteLine("Digite o nome do cliente:");
    string cliente = Console.ReadLine();
    Console.Clear();

    int adicional = ObterOpcao(
        "Deseja qual pacote adicional?\n1 - Vista para a Praia\n2 - Café da manhã\n3 - Não quero nada\n",
        1, 3
    );

    Console.Clear();

    int opcao = ObterOpcao(
        "Escolha um quarto:\n1 - Quarto Básico\n2 - Quarto Médio\n3 - Quarto Luxo\n4 - Cancelar\n",
        1, 4
    );

    Console.Clear();

    if (opcao == 4)
    {
        Cancelado();
        return;
    }

    var tipoQuarto = (TipoQuarto)(opcao - 1); // Mapeia a opção diretamente ao enum
    var quarto = CriarQuartoComAdicional(tipoQuarto, adicional);

    gerente.AdicionarReserva(quarto, cliente);
}

static Quarto CriarQuartoComAdicional(TipoQuarto tipo, int adicional)
{
    var quarto = QuartoFactory.CriarQuarto(tipo);
    return adicional switch
    {
        1 => new QuartoComVistaParaPraia(quarto),
        2 => new QuartoComCafe(quarto),
        _ => quarto
    };
}


