using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Barquillo : IHelado
    {
        private int _NumeroBolas;
        public double ObtenerCosto()
        {
            return 0.5;
        }

        public string ObtenerDescripcion()
        {
            return "Canasta";
        }

        public int ObtenerNumeroBolas()
        {
            return _NumeroBolas;
        }
        public void AgregarBola()
        {
            _NumeroBolas += 1;
        }
    }
}
