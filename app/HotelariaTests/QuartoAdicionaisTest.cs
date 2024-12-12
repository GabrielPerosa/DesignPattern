using System;
using Xunit;
using Hotelaria.Models.Adicionais;
using Hotelaria.Models.Quartos;


namespace HotelariaTests
{
    public class QuartoAdicionaisTest
    {
        /*
            Esse teste verifica se o quarto com adicionais foi criado corretamente.
        */
        [Fact]
        public void Criar_uma_instanciaDeQuartoComAdicionais()
        {
            //Arrange 
            Quarto quarto1 = QuartoFactory.CriarQuarto(TipoQuarto.Luxo);
            Quarto quarto2 = QuartoFactory.CriarQuarto(TipoQuarto.Intermediario);

            // Act
            QuartoAdicionais quartoComCafe = new QuartoComCafe(quarto1);
            QuartoAdicionais quartoComVistaParaPraia = new QuartoComVistaParaPraia(quarto2);

            // Assert
            Assert.IsType<QuartoComCafe>(quartoComCafe);
            Assert.IsType<QuartoComVistaParaPraia>(quartoComVistaParaPraia);
        }
    }
}