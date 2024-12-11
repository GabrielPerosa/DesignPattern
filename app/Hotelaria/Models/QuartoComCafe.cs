using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public class QuartoComCafe : QuartoAdicionais
    {
        public QuartoComCafe(Quarto quarto) : base(quarto) { } 

        public override string Descricao() => $"{base.Descricao()} com café da manhã";  
    }
}