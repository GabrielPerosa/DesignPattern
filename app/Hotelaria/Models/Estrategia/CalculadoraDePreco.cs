using System;
using Hotelaria.Models.Quartos;


namespace Hotelaria.Models.Estrategia
{
    public class CalculadoraDePreco
    {
    private readonly IEstrategiaDePreco _estrategia;

    public CalculadoraDePreco(IEstrategiaDePreco estrategia)
        {
            _estrategia = estrategia;
        }
        
    public decimal Calcular(Quarto quarto)
        {
            return _estrategia.CalcularPreco(quarto);
        }
     } 
}  