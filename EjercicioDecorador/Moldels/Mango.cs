﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDecorador.Moldels
{
    public class Mango : IngredienteDecorador
    {
        public Mango(IHelado helado) : base(helado)
        {
            _nombre = "Mango";
            _precio = 6.0;
        }
    }
}
