using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class ChocoKrispis : IngredienteDecorador
    {
        public ChocoKrispis(IHelado helado) : base(helado)
        {
            _nombre = "Choco Krispis";
            _precio = 0.5;
        }
    }
}
