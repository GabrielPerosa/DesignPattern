using System;

namespace Hotelaria.Models
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