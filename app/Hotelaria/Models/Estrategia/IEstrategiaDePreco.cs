using System;
using Hotelaria.Models.Quartos;


namespace Hotelaria.Models.Estrategia
{
    public interface IEstrategiaDePreco
    {
        decimal CalcularPreco(Quarto quarto);
    }
}