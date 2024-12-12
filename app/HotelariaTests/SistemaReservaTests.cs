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
            var sistemaReserva = SistemaReserva.ObterInstancia();
            var observador = new AdministradorFake();

            // Act
            sistemaReserva.AdicionarObservador(observador);

            // Assert
            Assert.Contains(observador, sistemaReserva.Observadores); // Verifica se o observador foi adicionado
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
}