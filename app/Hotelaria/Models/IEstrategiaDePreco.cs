using System;

namespace Hotelaria.Models
{
    public interface IEstrategiaDePreco
    {
        decimal CalcularPreco(Quarto quarto);
    }
}