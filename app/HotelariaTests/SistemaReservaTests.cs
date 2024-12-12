using System.Collections.Generic;
using Xunit;
using Hotelaria.Models.Observador;

namespace Hotelaria.Tests
{
    public class SistemaReservaTests
    {
        /*
            Teste para verificar se um observador pode ser adicionado ao sistema de reservas.
        */
        [Fact]
        public void AdicionarObservador_AdicionaObservadorCorretamente()
        {
            // Arrange
            var sistemaReserva = new SistemaReserva();
            var observador = new AdministradorFake();

            // Act
            sistemaReserva.AdicionarObservador(observador);

            // Assert
            Assert.Contains(observador, sistemaReserva.Observadores); // Verifica se o observador foi adicionado
        }

        /*
            Teste para verificar se os observadores são notificados corretamente após uma nova reserva.
        */
        [Fact]
        public void RealizarReserva_NotificaObservadores()
        {
            // Arrange
            var sistemaReserva = new SistemaReserva();
            var observador1 = new AdministradorFake();
            var observador2 = new AdministradorFake();
            sistemaReserva.AdicionarObservador(observador1);
            sistemaReserva.AdicionarObservador(observador2);

            string cliente = "João Silva";

            // Act
            sistemaReserva.RealizarReserva(cliente);

            // Assert
            string mensagemEsperada = $"Nova reserva realizada: {cliente}";
            Assert.Contains(mensagemEsperada, observador1.MensagensNotificadas);
            Assert.Contains(mensagemEsperada, observador2.MensagensNotificadas);
        }
    }

    /*
        Classe fake que implementa a interface IObservador para uso nos testes.
        Armazena mensagens notificadas para verificação.
    */
    public class AdministradorFake : IObservador
    {
        public List<string> MensagensNotificadas { get; } = new List<string>();

        public void Atualizar(string mensagem)
        {
            MensagensNotificadas.Add(mensagem); // Armazena a mensagem para verificação no teste
        }
    }
}
