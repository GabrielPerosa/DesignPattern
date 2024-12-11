using System;
using System.Collections.Generic;

namespace Hotelaria.Models
{
    public interface IObservador
    {
    void Atualizar(string mensagem);
    }
}