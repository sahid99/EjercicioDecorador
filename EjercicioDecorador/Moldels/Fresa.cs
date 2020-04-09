﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Fresa : IngredienteDecorador
    {
        public Fresa(IHelado helado) : base(helado)
        {
            _nombre = "Bola de Fresa";
            _precio = 5.0;
        }
    }
}
