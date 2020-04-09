using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Barquillo : IHelado
    {
        public double ObtenerCosto()
        {
            return 0.5;
        }

        public string ObtenerDescripcion()
        {
            return "Barquillo";
        }
    }
}
