using System;
using Hotelaria.Models.Quartos;

namespace Hotelaria.Models.Adicionais
{
    public abstract class QuartoAdicionais : Quarto
    {
        protected Quarto _quarto;

        public override string Tipo { get => _quarto.Tipo; }
        
        public QuartoAdicionais(Quarto quarto)
        {
            _quarto = quarto;
        }

        public override string Descricao()
        {
            return _quarto.Descricao();
        }
    }
}