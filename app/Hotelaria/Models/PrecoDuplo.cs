using System;

namespace Hotelaria.Models
{
    public class PrecoDuplo : IEstrategiaDePreco
    {
        public decimal CalcularPreco(Quarto quarto)
        {
            // Preço fixo para o quarto duplo
            return 200m;
        }
    }
}