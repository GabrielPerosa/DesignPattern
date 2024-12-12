using Xunit;
using Hotelaria.Models.Quartos;

namespace Hotelaria.Tests
{
    public class QuartoFactoryTests
    {

        /*
            Esse teste avaliará se a criação de um quarto do tipo "Economico" retorna um objeto do tipo "QuartoBasico".
        */
        [Fact]
        public void CriarQuarto_Economico_RetornaQuartoBasico()
        {
            // Arrange
            TipoQuarto tipo = TipoQuarto.Economico;

            // Act
            Quarto quarto = QuartoFactory.CriarQuarto(tipo);

            // Assert
            Assert.IsType<QuartoBasico>(quarto); // Verifica se o tipo do quarto é QuartoBasico
            Assert.Equal("Economico", quarto.Tipo); // Verifica o tipo de quarto (agora comparando string)
        }
        /*
            Esse teste avaliará se a criação de um quarto do tipo "Medio" retorna um objeto do tipo "QuartoMedio".
        */
        [Fact]
        public void CriarQuarto_Medio_RetornaQuartoMedio()
        {
            // Arrange
            TipoQuarto tipo = TipoQuarto.Intermediario;

            // Act
            Quarto quarto = QuartoFactory.CriarQuarto(tipo);

            // Assert
            Assert.IsType<QuartoMedio>(quarto); // Verifica se o tipo do quarto é QuartoMedio
            Assert.Equal("Intermediario", quarto.Tipo); // Verifica o tipo de quarto (agora comparando string)
        }

        /*
            Esse teste avaliará se a criação de um quarto do tipo "Luxo" retorna um objeto do tipo "QuartoLuxo".
        */
        [Fact]
        public void CriarQuarto_Luxo_RetornaQuartoLuxo()
        {
            // Arrange
            TipoQuarto tipo = TipoQuarto.Luxo;

            // Act
            Quarto quarto = QuartoFactory.CriarQuarto(tipo);

            // Assert
            Assert.IsType<QuartoLuxo>(quarto); // Verifica se o tipo do quarto é QuartoLuxo
            Assert.Equal("Luxo", quarto.Tipo); // Verifica o tipo de quarto (agora comparando string)
        }

        /*
            Esse teste avaliará se ao tentarmos criar um quarto que não existe retorna uma exceção.
        */
        [Fact]
        public void CriarQuarto_TipoInvalido_LancaArgumentException()
        {
            // Arrange
            TipoQuarto tipoInvalido = (TipoQuarto)999; // Um valor inválido para TipoQuarto

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => QuartoFactory.CriarQuarto(tipoInvalido));
            Assert.Equal("Quarto inexistente", exception.Message); // Verifica se a mensagem de exceção é a esperada
        }
    }
}
