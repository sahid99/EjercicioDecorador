using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class ChocolateLiquido : IngredienteDecorador
    {
        public ChocolateLiquido(IHelado helado) : base(helado)
        {
            _nombre = "Chocolate Liquido";
            _precio = 0.0;
        }
    }
}
