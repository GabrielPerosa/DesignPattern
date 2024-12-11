using System;

namespace Hotelaria.Models
{
    public class QuartoMedio : Quarto
    {
        public override string Tipo 
        {   
            get { return "Intermediário"; }
        }
        public override string Descricao ()
        {
            return "Quarto Intermediário, contém duas camas e um banheiro simples";
        }
    }
}