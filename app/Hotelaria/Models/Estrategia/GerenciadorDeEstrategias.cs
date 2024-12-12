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
            { TipoQuarto.Medio, new PrecoMedio() },
            { TipoQuarto.Luxo, new PrecoLuxo() }
        };

        public static IEstrategiaDePreco ObterEstrategia(TipoQuarto tipoQuarto)
        {
            return _estrategias[tipoQuarto];
        }
    }
}
