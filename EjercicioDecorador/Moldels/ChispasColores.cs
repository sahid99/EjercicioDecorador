using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class ChispasColores : IngredienteDecorador
    {
        public ChispasColores(IHelado helado) : base(helado)
        {
            _nombre = "Chispas de Colores";
            _precio = 0.2;
        }
    }
}
