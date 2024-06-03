namespace juegodereleta
{
    internal enum Color
    {
        Rojo,
        Negro
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 300;
            int girosRealizados = 0;
            List<int> historialGiros = new List<int>();
            List<string> resultados = new List<string>();
            Random random = new Random();

            while (balance > 0)
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Apostar a un número específico (0-36)");
                Console.WriteLine("2. Apostar a que el número es de color rojo o negro");
                Console.WriteLine("3. Apostar si el número será par o impar");
                Console.WriteLine("4. Ver historial de giros");
                Console.WriteLine("5. Ver estadísticas");
                Console.WriteLine("6. Retirarse");
                Console.Write("Ingrese la opción deseada: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el número al que desea apostar: ");
                        int numero = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad de dinero que desea apostar (múltiplo de 10): ");
                        int apuesta = int.Parse(Console.ReadLine());
                        if (apuesta % 10 == 0)
                        {
                            balance -= apuesta;
                            int resultado = random.Next(0, 37);
                            historialGiros.Add(resultado);
                            girosRealizados++;
                            if (resultado == numero)
                            {
                                balance += apuesta * 10;
                                resultados.Add($"Ganaste {apuesta * 10} en el giro {girosRealizados}");
                            }
                            else
                            {
                                resultados.Add($"Perdiste {apuesta} en el giro {girosRealizados}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("La cantidad debe ser múltiplo de 10.");
                        }
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad de dinero que desea apostar (múltiplo de 10): ");
                        apuesta = int.Parse(Console.ReadLine());
                        if (apuesta % 10 == 0)
                        {
                            balance -= apuesta;
                            int resultado = random.Next(0, 37);
                            historialGiros.Add(resultado);
                            girosRealizados++;
                            if (resultado == 0 || (resultado % 2 == 0 && resultado <= 36))
                            {
                                if (resultado == 0)
                                {
                                    resultados.Add("Perdiste la apuesta en el giro " + girosRealizados);
                                }
                                else
                                {
                                    resultados.Add("Ganaste " + apuesta * 5 + " en el giro " + girosRealizados);
                                    balance += apuesta * 5;
                                }
                            }
                            else
                            {
                                resultados.Add("Perdiste la apuesta en el giro " + girosRealizados);
                            }
                        }
                        else
                        {
                            Console.WriteLine("La cantidad debe ser múltiplo de 10.");
                        }
                        break;
                    case 3:
                        Console.Write("Ingrese la cantidad de dinero que desea apostar (múltiplo de 10): ");
                        apuesta = int.Parse(Console.ReadLine());
                        if (apuesta % 10 == 0)
                        {
                            balance -= apuesta;
                            int resultado = random.Next(0, 37);
                            historialGiros.Add(resultado);
                            girosRealizados++;
                            if (resultado == 0 || (resultado % 2 == 0 && resultado <= 36))
                            {
                                if (resultado == 0)
                                {
                                    resultados.Add("Perdiste la apuesta en el giro " + girosRealizados);
                                }
                                else
                                {
                                    resultados.Add("Ganaste " + apuesta * 2 + " en el giro " + girosRealizados);
                                    balance += apuesta * 2;
                                }
                            }
                            else
                            {
                                resultados.Add("Perdiste la apuesta en el giro " + girosRealizados);
                            }
                        }
                        else
                        {
                            Console.WriteLine("La cantidad debe ser múltiplo de 10.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Historial de giros:");
                        foreach (int giro in historialGiros)
                        {
                            Console.WriteLine(giro);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Estadísticas:");
                        Console.WriteLine("Balance: " + balance);
                        Console.WriteLine("Giros realizados: " + girosRealizados);
                        int[] contador = new int[37];
                        foreach (int giro in historialGiros)
                        {
                            contador[giro]++;
                        }
                        int max = 0;
                        int min = int.MaxValue;
                        int maxNumero = 0;
                        int minNumero = 0;
                        int rojos = 0;
                        int negros = 0;
                        int pares = 0;
                        int impares = 0;
                        for (int i = 0; i < contador.Length; i++)
                        {
                            if (contador[i] > max)
                            {
                                max = contador[i];
                                maxNumero = i;
                            }
                            if (contador[i] < min && contador[i] != 0)
                            {
                                min = contador[i];
                                minNumero = i;
                            }
                            if (i == 0)
                            {
                                rojos = contador[i];
                                negros = contador[i + 1];
                                pares = contador[i + 1];
                                impares = contador[i + 2];
                            }
                            else if (i % 2 == 0)
                            {
                                rojos += contador[i];
                            }
                            else
                            {
                                negros += contador[i];
                            }
                            if (i % 2 == 0)
                            {
                                pares += contador[i];
                            }
                            else
                            {
                                impares += contador[i];
                            }
                        }
                        Console.WriteLine("Número que más veces se ha tirado: " + maxNumero);
                        Console.WriteLine("Número que menos veces se ha tirado: " + minNumero);
                        Console.WriteLine("Cantidad de resultados rojos: " + rojos);
                        Console.WriteLine("Cantidad de resultados negros: " + negros);
                        Console.WriteLine("Cantidad de resultados pares: " + pares);
                        Console.WriteLine("Cantidad de resultados impares: " + impares);
                        break;
                    case 6:
                        Console.WriteLine("Su balance final es: " + balance);
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            Console.WriteLine("Se ha quedado sin dinero.");
            Console.ReadLine();
        }
    }
}
    

