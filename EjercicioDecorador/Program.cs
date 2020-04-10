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
                int numeroBoalas = 0;
                result = -1;
                while (result != 7 && numeroBoalas < 6)
                {
                    Console.Clear();
                    Console.WriteLine("Toca elegir el # de bolas maximo 5");
                    Console.WriteLine("Los Sabores:");
                    Console.WriteLine("1. Limon $5.0");
                    Console.WriteLine("2. Fresa $5.0");
                    Console.WriteLine("3. Mango $6.0");
                    Console.WriteLine("4. Chocolate $8.0");
                    Console.WriteLine("5. ChocoChips $8.0");
                    Console.WriteLine("6. Vainilla $7.0");
                    Console.WriteLine("7. No mas bolas");
                    key = Console.ReadKey();
                    if (char.IsDigit(key.KeyChar))
                    {
                        if (int.Parse(key.KeyChar.ToString()) >= 1
                            && int.Parse(key.KeyChar.ToString()) <=7)
                        {
                            result = int.Parse(key.KeyChar.ToString());
                        }
                    }
                    switch (result)
                    {
                        case 1:
                            pedidos[pedidoActual] = new Limon(pedidos[pedidoActual]);
                            numeroBoalas += 1;
                            break;
                        case 2:
                            pedidos[pedidoActual] = new Fresa(pedidos[pedidoActual]);
                            numeroBoalas += 1;
                            break;
                        case 3:
                            pedidos[pedidoActual] = new Mango(pedidos[pedidoActual]);
                            numeroBoalas += 1;
                            break;
                        case 4:
                            pedidos[pedidoActual] = new Chocolate(pedidos[pedidoActual]);
                            numeroBoalas += 1;
                            break;
                        case 5:
                            pedidos[pedidoActual] = new ChocoChips(pedidos[pedidoActual]);
                            numeroBoalas += 1;
                            break;
                        case 6:
                            pedidos[pedidoActual] = new Vainilla(pedidos[pedidoActual]);
                            numeroBoalas += 1;
                            break;
                        case 7:
                            break;
                    }
                }

                result = -1;
                int numeroExtras = 0;
                while (result != 7 && numeroExtras < 4)
                {
                    Console.Clear();
                    Console.WriteLine("Toca elegir el # de ingredientes extra maximo 5");
                    Console.WriteLine("Los Extras:");
                    Console.WriteLine("1. Chocolate Liquido $0.0");
                    Console.WriteLine("2. ChocoKrispis $0.50");
                    Console.WriteLine("3. Lunetas $0.70");
                    Console.WriteLine("4. Chispas de Colores $0.20");
                    Console.WriteLine("5. Fresas $7.0");
                    Console.WriteLine("6. Platano $5.0");
                    Console.WriteLine("7. No mas extras");
                    key = Console.ReadKey();
                    if (char.IsDigit(key.KeyChar))
                    {
                        if (int.Parse(key.KeyChar.ToString()) >= 1
                            && int.Parse(key.KeyChar.ToString()) <= 7)
                        {
                            result = int.Parse(key.KeyChar.ToString());
                        }
                    }
                    switch (result)
                    {
                        case 1:
                            pedidos[pedidoActual] = new ChocolateLiquido(pedidos[pedidoActual]);
                            numeroExtras += 1;
                            break;
                        case 2:
                            pedidos[pedidoActual] = new ChocoKrispis(pedidos[pedidoActual]);
                            numeroExtras += 1;
                            break;
                        case 3:
                            pedidos[pedidoActual] = new Lunetas(pedidos[pedidoActual]);
                            numeroExtras += 1;
                            break;
                        case 4:
                            pedidos[pedidoActual] = new ChispasColores(pedidos[pedidoActual]);
                            numeroExtras += 1;
                            break;
                        case 5:
                            pedidos[pedidoActual] = new Fresas(pedidos[pedidoActual]);
                            numeroExtras += 1;
                            break;
                        case 6:
                            pedidos[pedidoActual] = new Platano(pedidos[pedidoActual]);
                            numeroExtras += 1;
                            break;
                        case 7:
                            break;
                    }
                }

                Console.Clear();
                Console.WriteLine("Ya está tu helado amigo!!!");
                Console.WriteLine("Elige:");
                Console.WriteLine("1. Otro helado");
                Console.WriteLine("2. Ya nada, gracias");
                //pedidos.Add()
                key = Console.ReadKey();
                if (char.IsDigit(key.KeyChar))
                {
                    if (int.Parse(key.KeyChar.ToString()) == 1
                        || int.Parse(key.KeyChar.ToString()) == 2)
                    {
                        result = int.Parse(key.KeyChar.ToString());
                    }
                }
                switch (result)
                {
                    case 1:
                        result = -1;
                        break;
                    case 2:
                        result = 99;
                        break;
                }
            }
            foreach (var helado in pedidos)
            {
                Console.WriteLine($"{helado.ObtenerDescripcion()}....${helado.ObtenerCosto()}");
            }
        }
    }
}
