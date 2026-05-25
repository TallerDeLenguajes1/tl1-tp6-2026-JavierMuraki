float Operacion = 0;
float NumeroA = 0;
float NumeroB = 0;
bool Continuar = true;
string? Input = "";

while (Continuar) {
    Console.WriteLine("Operaciones:");
    Console.WriteLine("1 - El valor absoluto de un número");
    Console.WriteLine("2 - El cuadrado");
    Console.WriteLine("3 - La raíz cuadrada");
    Console.WriteLine("4 - El Seno");
    Console.WriteLine("5 - El Coseno");
    Console.WriteLine("6 - La parte entera de un tipo float");
    Console.WriteLine("7 - Suma");
    Console.WriteLine("8 - Resta");
    Console.WriteLine("9 - Multiplicar");
    Console.WriteLine("10 - Dividir\n");

    // Ingreso de tipo de operacion
    Console.Write("Igrese operacion: ");
    Input = Console.ReadLine();
    if (!float.TryParse(Input, out Operacion)) {
        Console.WriteLine("Ingreso invalido: [" + Input + "] Se esperaba un numero.");
        return;
    };
    if ((Operacion < 1 || Operacion > 10 )) {
        Console.WriteLine("Operacion invalida: [" + Operacion + "] no pertenece a ninguna de las opciones.");
        return; 
    }

    // Ingreso del Numero A
    Console.Write("Igrese Numero A: ");
    Input = Console.ReadLine();
    if (!float.TryParse(Input, out NumeroA)) {
        Console.WriteLine("Ingreso invalido: [" + Input + "] Se esperaba un numero.");
        return;
    };

    // Ingreso del Numero B
    Console.Write("Igrese Numero B: ");
    Input = Console.ReadLine();
    if (!float.TryParse(Input, out NumeroB)) {
        Console.WriteLine("Ingreso invalido: [" + Input + "] Se esperaba un numero.");
        return;
    };

    Console.WriteLine("\nResultado de las operaciones:");
    switch (Operacion) {
        case 1: // El valor absoluto de un número
            Console.WriteLine("Valor absoluto de A y B: " + Math.Abs(NumeroA) + " | " + Math.Abs(NumeroB));
            break;
        case 2: // El cuadrado
            Console.WriteLine("El cuadrado de A y B: " + Math.Pow(NumeroA, 2) + " | " + Math.Pow(NumeroB, 2));
            break;
        case 3: // La raíz cuadrada
            Console.WriteLine("La raíz cuadrada de A y B: " + Math.Sqrt(NumeroA) + " | " + Math.Sqrt(NumeroB));
            break;
        case 4: // El Seno
            Console.WriteLine("El Seno de A y B: " + Math.Sin(NumeroA) + " | " + Math.Sin(NumeroB));
            break;
        case 5: // El Coseno
            Console.WriteLine("El Coseno de A y B: " + Math.Cos(NumeroA) + " | " + Math.Cos(NumeroB));
            break;
        case 6: // La parte entera de un tipo float
            Console.WriteLine("El entero de A y B: " + Math.Floor(NumeroA) + " | " + Math.Floor(NumeroB));
            break;
        case 7: // Suma
            Console.WriteLine("Suma de A y B" + (NumeroA + NumeroB));
            break;
        case 8: // Resta
            Console.WriteLine("Resta de A y B" + (NumeroA - NumeroB));
            break;
        case 9: // Multiplicacion
            Console.WriteLine("Multiplicacion de A y B" + (NumeroA * NumeroB));
            break;
        case 10: // Division
            Console.WriteLine("Division de A y B" + (NumeroA / NumeroB));
            break;
    }
    Console.WriteLine("Numero Maximo: " + Math.Max(NumeroA, NumeroB));
    Console.WriteLine("Numero Minimo: " + Math.Min(NumeroA, NumeroB));

    Console.Write("\nDesea realizar otro calculo? (SI = 1 / NO = 0): ");

    // Ingreso de continuar
    Continuar = (Console.ReadLine() == "1");
}