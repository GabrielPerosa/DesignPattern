using Xunit;
using Hotelaria.Models;

namespace Hotelaria.Tests
{
    public class EstrategiaDePrecoTests
    {
        /*
            Este teste verifica se a estratégia `PrecoSimples` calcula o preço corretamente.
        */
        [Fact]
        public void PrecoSimples_CalculaPrecoCorretamente()
        {
            // Arrange
            var estrategia = new PrecoSimples();
            var quartoSimples = new QuartoSimples();

            // Act
            var preco = estrategia.CalcularPreco(quartoSimples);

            // Assert
            Assert.Equal(100m, preco); // Preço esperado é 100
        }

        /*
            Este teste verifica se a estratégia `PrecoDuplo` calcula o preço corretamente.
        */
        [Fact]
        public void PrecoDuplo_CalculaPrecoCorretamente()
        {
            // Arrange
            var estrategia = new PrecoDuplo();
            var quartoDuplo = new QuartoDuplo();

            // Act
            var preco = estrategia.CalcularPreco(quartoDuplo);

            // Assert
            Assert.Equal(200m, preco); // Preço esperado é 200
        }

        /*
            Este teste verifica se a estratégia `PrecoLuxo` calcula o preço corretamente.
        */
        [Fact]
        public void PrecoLuxo_CalculaPrecoCorretamente()
        {
            // Arrange
            var estrategia = new PrecoLuxo();
            var quartoLuxo = new QuartoLuxo();

            // Act
            var preco = estrategia.CalcularPreco(quartoLuxo);

            // Assert
            Assert.Equal(500m, preco); // Preço esperado é 500
        }

        /*
            Este teste verifica se a calculadora utiliza corretamente a estratégia fornecida.
        */
        [Fact]
        public void CalculadoraDePreco_UsaEstrategiaCorreta()
        {
            // Arrange
            var estrategia = new PrecoSimples();
            var calculadora = new CalculadoraDePreco(estrategia);
            var quartoSimples = new QuartoSimples();

            // Act
            var preco = calculadora.Calcular(quartoSimples);

            // Assert
            Assert.Equal(100m, preco); // Preço esperado é 100
        }
    }
}
