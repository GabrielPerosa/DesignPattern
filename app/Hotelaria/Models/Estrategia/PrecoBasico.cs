using System;
using Hotelaria.Models.Quartos;


namespace Hotelaria.Models.Estrategia
{
    public class PrecoBasico : IEstrategiaDePreco
    {
        public decimal CalcularPreco(Quarto quarto)
        {
            return 100m;
        }
    }
}