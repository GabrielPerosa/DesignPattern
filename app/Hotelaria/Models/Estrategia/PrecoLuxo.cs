using System;
using Hotelaria.Models.Quartos;


namespace Hotelaria.Models.Estrategia
{
    public class PrecoLuxo : IEstrategiaDePreco
    {
        public string CalcularPreco(Quarto quarto)
        {
            return "500";
        }
    }
}