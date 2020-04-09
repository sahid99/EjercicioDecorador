using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Lunetas : IngredienteDecorador
    {
        public Lunetas(IHelado helado) : base(helado)
        {
            _nombre = "Lunetas";
            _precio = 0.7;
        }
    }
}
