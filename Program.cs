
bool vali = false;
do
{
    int n;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("———Ingrese '1' para acceder Estadistica———");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("——————— Ingrese '2' para acceder Diccionario———————");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("———Ingrese '3' si desea salir del Menú———\n");
    Console.ResetColor();

    if (int.TryParse(Console.ReadLine(), out n) && (n > 0 && n <= 3))
    {
        switch (n)
        {
            case 1:
                estadisticas();
                break;
            case 2:
                diccionario();
                break;
            default:
                Console.WriteLine("Ha decidido salir del programa!");
                vali = true;
                break;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("No es un valor valido, intentelo de nuevo");
        Console.ResetColor();
    }
}
while (vali == false);

static void diccionario()
{
    bool vali = false;
    int idioma;
    string[] spanish = { "acercarse", "prestamo", "traer", "nuestro", "con", "querer", "tener", "oso", "perro", "gato" };
    string[] english = { "approach", "loan", "bring", "our", "with", "want", "have", "bear", "dog", "cat" };
    do
    {
        string? word;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("¿Que idioma desea?, Ingrese 1 para español, 2 para inglés o 3 para salir");
        Console.ResetColor();
        if (int.TryParse(Console.ReadLine(), out idioma))
        {
            bool validate = false;
            switch (idioma)
            {
                case 1:
                    while (validate == false)
                    {
                        Console.WriteLine("Ingrese una palabra en español");
                        word = Console.ReadLine();
                        for (int i = 0; i < 10; i++)
                        {
                            if (word.ToLower() == spanish[i])
                            {
                                Console.WriteLine($"La palabra en inglés es: {char.ToUpper(english[i][0])}{english[i].Substring(1)}");
                                validate = true;
                            }
                        }
                        if (validate == false)
                        {
                            Console.WriteLine("—— La palabra no se encuentra en el diccionario, intentelo otra vez ——");
                        }
                    }
                    break;
                case 2:
                    while (validate == false)
                    {
                        Console.WriteLine("Ingrese una palabra en inglés");
                        word = Console.ReadLine();
                        for (int i = 0; i < 10; i++)
                        {
                            if (word.ToLower() == english[i])
                            {
                                Console.WriteLine($"La palabra en inglés es: {char.ToUpper(spanish[i][0])}{spanish[i].Substring(1)}");
                                validate = true;
                            }
                        }
                        if (validate == false)
                        {
                            Console.WriteLine("La palabra no se encuentra en el diccionario, intentelo otra vez");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Usted ha elegido salir del diccionario");
                    vali = true;
                    break;
                default:
                    Console.WriteLine("—— Ha ingresado un valor invalido, intente de nuevo ——");
                    break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("—— Lo que ingreso no es un valor valido, intentelo de nuevo ——");
            Console.ResetColor();
        }
    }
    while (vali == false);

}
static void estadisticas()
{
    int count = 0, value, sum = 0, prom;

    int[] numbers = new int[10];

    while (count < 10)
    {
        Console.WriteLine("Ingrese un número entre 0 y 100");
        if (int.TryParse(Console.ReadLine(), out value))
        {
            if (value < 100 && value > 0)
            {
                numbers[count] = value;
                sum += numbers[count];
                count++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("—— No ingreso un número dentro del rango ——");
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("—— No ingreso un número, intente otra vez ——");
            Console.ResetColor();
        }
    }
    Array.Sort(numbers);
    prom = sum / 10;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"El número mayor es {numbers[9]}");
    Console.WriteLine($"El número menor es {numbers[0]}");
    Console.WriteLine($"La suma de los valores es {sum}");
    Console.WriteLine($"La media es {prom}");
    Console.ResetColor();
}