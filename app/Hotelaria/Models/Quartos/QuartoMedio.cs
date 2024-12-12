using System;

namespace Hotelaria.Models.Quartos
{
    public class QuartoMedio : Quarto
    {
        public override string Tipo 
        {   
            get { return "Intermediario"; }
        }
        public override string Descricao ()
        {
            return "Quarto Intermediário, contém duas camas e um banheiro simples";
        }
    }
}