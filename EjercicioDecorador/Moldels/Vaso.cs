using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Vaso : IHelado
    {
        private int _NumeroBolas;
        public double ObtenerCosto()
        {
            return 0.0;
        }

        public string ObtenerDescripcion()
        {
            return "Vaso";
        }
        public int ObtenerNumeroBolas()
        {
            return _NumeroBolas;
        }
    }
}
