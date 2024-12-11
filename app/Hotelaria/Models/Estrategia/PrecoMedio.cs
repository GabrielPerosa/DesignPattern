using System;
using Hotelaria.Models.Quartos;


namespace Hotelaria.Models.Estrategia
{
    public class PrecoMedio : IEstrategiaDePreco
    {
        public decimal CalcularPreco(Quarto quarto)
        {
            return 200m;
        }
    }
}