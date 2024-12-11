using System;
using Hotelaria.Models.Quartos;


namespace Hotelaria.Models.Adicionais
{
    public class QuartoComVistaParaPraia : QuartoAdicionais
    {

        public QuartoComVistaParaPraia (Quarto quarto) : base(quarto) { }

        public override string Descricao() => $"{base.Descricao()} com vista para praia";
    }
}