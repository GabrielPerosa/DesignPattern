using System;

namespace Hotelaria.Models
{
    public class PrecoSimples : IEstrategiaDePreco
    {
        public decimal CalcularPreco(Quarto quarto)
        {
            // Preço fixo para o quarto simples
            return 100m;
        }
    }
}