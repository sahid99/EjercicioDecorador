using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Canasta : IHelado
    {
        public double ObtenerCosto()
        {
            return 1.0;
        }

        public string ObtenerDescripcion()
        {
            return "Canasta";
        }
    }
}
