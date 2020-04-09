﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Limon : IngredienteDecorador
    {
        public Limon(IHelado helado) : base(helado)
        {
            _nombre = "Limon";
            _precio = 5.0;
        }
    }
}
