using System;

namespace Hotelaria.Models.Quartos
{
    public class QuartoLuxo : Quarto
    {
        public override string Tipo
        {   
            get { return "Luxo"; }
        }
        public override string Descricao ()
        {
            return "Quarto Luxuoso, contém duas camas e um banheiro com banheira de hidromassagem";
        }
    }
}