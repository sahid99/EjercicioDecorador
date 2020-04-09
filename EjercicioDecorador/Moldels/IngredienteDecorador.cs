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
        //private string[] _nombresSabores = {"Limon", "Fresa", "Mango", "Chocolate", "ChocoChips", "Vainilla"};
        public IngredienteDecorador(IHelado helado)
        {
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
    }
}
