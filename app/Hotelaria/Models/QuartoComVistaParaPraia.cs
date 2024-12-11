using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public class QuartoComVistaParaPraia : QuartoAdicionais
    {

        public QuartoComVistaParaPraia (Quarto quarto) : base(quarto) { }

        public override string Descricao() => $"{base.Descricao()} com vista para praia";
    }
}