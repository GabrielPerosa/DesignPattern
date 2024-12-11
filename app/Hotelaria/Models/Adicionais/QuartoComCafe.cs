using System;
using Hotelaria.Models.Quartos;


namespace Hotelaria.Models.Adicionais
{
    public class QuartoComCafe : QuartoAdicionais
    {
        public QuartoComCafe(Quarto quarto) : base(quarto) { } 

        public override string Descricao() => $"{base.Descricao()} com café da manhã";  
    }
}