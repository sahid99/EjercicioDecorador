using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Fresas : IngredienteDecorador
    {
        public Fresas(IHelado helado) : base(helado)
        {
            _nombre = "Fresas";
            _precio = 7.0;
        }
    }
}
