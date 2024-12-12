using System;

namespace Hotelaria.Models.Quartos
{
    // Para tipar a entrada de CriarQuarto
    public enum TipoQuarto
    {
        Economico,
        Intermediario,
        Luxo
    }

    public static class QuartoFactory
    {
        public static Quarto CriarQuarto (TipoQuarto tipo) 
        {   
           switch (tipo) 
           {
            case TipoQuarto.Economico:
                return new QuartoBasico();
            case TipoQuarto.Intermediario:
                return new QuartoMedio();
            case TipoQuarto.Luxo: 
                return new QuartoLuxo();
            default:
                throw new ArgumentException("Quarto inexistente");
           }
        }
    }
}