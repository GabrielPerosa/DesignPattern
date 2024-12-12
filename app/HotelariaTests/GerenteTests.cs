using Hotelaria.Models.Gerente;
using Hotelaria.Models.Quartos;
using Xunit;

namespace HotelariaTests
{
    public class GerenteTests
    {
        /*
            Esse teste verifica se o gerente foi criado corretamente.
        */
        [Fact]
        public void Criar_uma_instanciaDoGerente()
        {   
            // Arrange & Act
            Gerente gerente1 = Gerente.ObterInstancia();
            Gerente gerente2 = Gerente.ObterInstancia();
                        
            // Assert
            Assert.Same(gerente1, gerente2);
        }

        /*
            Esse teste verifica se o gerente adicionou uma reserva em sua lista de reservas.
        */    
        [Fact]
        public void Adicionar_uma_reserva_na_lista()
        {
            // Arrange
            Gerente gerente = Gerente.ObterInstancia(); 
            Quarto quarto = QuartoFactory.CriarQuarto(TipoQuarto.Luxo); 
            string cliente = "Gabriel";

            // Act
            gerente.AdicionarReserva(quarto, cliente);

            // Assert
            Assert.Contains($"{cliente} - {quarto.Tipo}", Gerente.Reservas);

        }
        /*
            Esse teste verifica se o gerente removeu uma reserva da sua lista de reservas.
        */

        [Fact]
        public void Remover_uma_reserva_da_lista()
        {
            // Arrange
            Gerente gerente = Gerente.ObterInstancia(); 
            Quarto quarto = QuartoFactory.CriarQuarto(TipoQuarto.Luxo); 
            string cliente = "Gabriel";

            // Act
            gerente.AdicionarReserva(quarto, cliente);
            gerente.RemoverReserva(quarto, cliente);

            // Assert
            Assert.DoesNotContain($"{cliente} - {quarto.Tipo}", Gerente.Reservas);

        }
            
    }
}