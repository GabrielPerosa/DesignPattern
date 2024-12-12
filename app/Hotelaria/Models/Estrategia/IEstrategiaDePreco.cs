using System;
using Hotelaria.Models.Quartos;


namespace Hotelaria.Models.Estrategia
{
    public interface IEstrategiaDePreco
    {
        string CalcularPreco(Quarto quarto);
    }
}