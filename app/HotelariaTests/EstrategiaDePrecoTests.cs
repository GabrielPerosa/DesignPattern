using Xunit;
using Hotelaria.Models.Estrategia;
using Hotelaria.Models.Quartos;

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
            var estrategia = new PrecoBasico();
            var quartoSimples = new QuartoBasico();

            // Act
            var preco = estrategia.CalcularPreco(quartoSimples);

            // Assert
            Assert.Equal("100", preco); // Preço esperado é 100
        }

        /*
            Este teste verifica se a estratégia `PrecoDuplo` calcula o preço corretamente.
        */
        [Fact]
        public void PrecoDuplo_CalculaPrecoCorretamente()
        {
            // Arrange
            var estrategia = new PrecoMedio();
            var quartoDuplo = new QuartoMedio();

            // Act
            var preco = estrategia.CalcularPreco(quartoDuplo);

            // Assert
            Assert.Equal("200", preco); // Preço esperado é 200
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
            Assert.Equal("500", preco); // Preço esperado é 500
        }

        /*
            Este teste verifica se a calculadora utiliza corretamente a estratégia fornecida.
        */
        [Fact]
        public void CalculadoraDePreco_UsaEstrategiaCorreta()
        {
            // Arrange
            var estrategia = new PrecoBasico();
            var calculadora = new CalculadoraDePreco(estrategia);
            var quartoSimples = QuartoFactory.CriarQuarto(TipoQuarto.Economico);

            // Act
            var preco = calculadora.Calcular(quartoSimples);

            // Assert
            Assert.Equal("100", preco); // Preço esperado é 100
        }
    }
}
