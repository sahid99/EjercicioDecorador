using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public interface IHelado
    {
        string ObtenerDescripcion();
        double ObtenerCosto();
        int ObtenerNumeroBolas();
    }
}
