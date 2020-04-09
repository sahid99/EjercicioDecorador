using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Vaso : IHelado
    {
        public double ObtenerCosto()
        {
            return 0.0;
        }

        public string ObtenerDescripcion()
        {
            return "Vaso";
        }
    }
}
