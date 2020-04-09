using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public abstract class IngredienteDecorador : IHelado
    {
        private IHelado _helado;
        private int _NumeroBolas;
        protected string _nombre = "Sin Definir";
        protected double _precio = 0.0;
        private string[] _nombresSabores = {"Limon", "Fresa", "Mango", "Chocolate", "ChocoChips", "Vainilla"};
        private List<String> _sabores;
        public IngredienteDecorador(IHelado helado)
        {
            _sabores = new List<string>(_nombresSabores);
            string saborActual = helado.ObtenerDescripcion();
            if (_sabores.Contains(saborActual))
            {
                int contador = ObtenerNumeroBolas();
                if (contador >= 5)
                {
                    Console.WriteLine("Exceso de bolas.");
                    return;
                }
                _NumeroBolas += 1;
            }
            _helado = helado;
        }
        public double ObtenerCosto()
        {
            return _helado.ObtenerCosto() + _precio;
        }

        public string ObtenerDescripcion()
        {
            return $"{_helado.ObtenerDescripcion()}, {_nombre}";
        }
        public int ObtenerNumeroBolas()
        {
            return _NumeroBolas;
        }
    }
}
