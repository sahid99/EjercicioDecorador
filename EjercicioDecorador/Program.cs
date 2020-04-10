using EjercicioDecorador.Moldels;
using System;
using System.Collections.Generic;

namespace EjercicioDecorador
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = -1;
            var pedidos = new List<IHelado>();
            var pedidoActual = 0; 
            while (result == -1)
            {
                Console.Clear();
                Console.WriteLine("Bienvenodo a la maquina de helados!!!");
                Console.WriteLine("Vamos rapido con tu eleccion");
                Console.WriteLine("Mire tengo estos recipientes para tu helado");
                Console.WriteLine("1. Vaso $0.0");
                Console.WriteLine("2. Barquillo $0.5");
                Console.WriteLine("3. Canasta $ 1.0");
                //pedidos.Add()
                var key = Console.ReadKey();
                if (char.IsDigit(key.KeyChar))
                {
                    if (int.Parse(key.KeyChar.ToString()) == 1
                        || int.Parse(key.KeyChar.ToString()) == 2
                        || int.Parse(key.KeyChar.ToString()) == 3)
                    {
                        result = int.Parse(key.KeyChar.ToString());
                        //break;
                    }
                }
                switch (result)
                {
                    case 1:
                        pedidos.Add(new Vaso());
                        break;
                    case 2:
                        pedidos.Add(new Barquillo());
                        break;
                    case 3:
                        pedidos.Add(new Canasta());
                        break;
                }
                pedidoActual = pedidos.Count - 1;
            }
        }
    }
}
