using System;
using System.Collections.Generic;

namespace Hotelaria.Models.Observador
{
    public interface IObservador
    {
    void Atualizar(string mensagem);
    }
}