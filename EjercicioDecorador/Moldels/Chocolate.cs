using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Chocolate : IngredienteDecorador
    {
        public Chocolate(IHelado helado) : base(helado)
        {
            _nombre = "Bola de Chocolate";
            _precio = 8.0;
        }
    }
}
