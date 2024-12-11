using System;

namespace Hotelaria.Models.Quartos
{
    public class QuartoBasico : Quarto
    {
        public override string Tipo
        {   
            get { return "Economico"; }
        }
        public override string Descricao ()
        {
            return "Quarto Básico, apenas uma cama e um banheiro simples";
        }
    }
}