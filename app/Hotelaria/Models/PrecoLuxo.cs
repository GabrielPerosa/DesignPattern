using System;

namespace Hotelaria.Models
{
    public class PrecoLuxo : IEstrategiaDePreco
    {
        public decimal CalcularPreco(Quarto quarto)
        {
            // Preço fixo para o quarto luxo
            return 500m;
        }
    }
}