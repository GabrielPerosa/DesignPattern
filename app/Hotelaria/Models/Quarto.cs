using System;

namespace Hotelaria.Models
{
    public abstract class Quarto
    {
        public abstract string Tipo { get; }
        public abstract string Descricao ();
    }
}