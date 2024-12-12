using System;
using System.Collections.Generic;
using Hotelaria.Models.Quartos;
using Hotelaria.Models.Estrategia;

namespace Hotelaria.Models.Estrategia
{
    public class GerenciadorDeEstrategias
    {
        private static readonly Dictionary<TipoQuarto, IEstrategiaDePreco> _estrategias = new()
        {
            { TipoQuarto.Economico, new PrecoBasico() },
            { TipoQuarto.Intermediario, new PrecoMedio() },
            { TipoQuarto.Luxo, new PrecoLuxo() }
        };

        public static IEstrategiaDePreco ObterEstrategia(string tipoQuarto)
        {
            if (Enum.TryParse(tipoQuarto, true, out TipoQuarto tipoEnum) && _estrategias.ContainsKey(tipoEnum))
            {
                return _estrategias[tipoEnum];
            }
            throw new ArgumentException($"Estratégia para o tipo '{tipoQuarto}' não encontrada.");
        }
    }
}
