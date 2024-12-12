using System;
using Hotelaria.Models.Quartos;


namespace Hotelaria.Models.Estrategia
{
    public class PrecoMedio : IEstrategiaDePreco
    {
        public string CalcularPreco(Quarto quarto)
        {
            return "200";
        }
    }
}