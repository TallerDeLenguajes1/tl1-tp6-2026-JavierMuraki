float Operacion = 0;
float NumeroA = 0;
float NumeroB = 0;
float Resultado = 0;
bool Continuar = true;
string? Input = "";

while (Continuar) {
    Console.WriteLine("Operaciones: ");
    Console.WriteLine("1 - Suma");
    Console.WriteLine("2 - Resta");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir\n");

    // Ingreso de tipo de operacion
    Console.Write("Igrese operacion: ");
    Input = Console.ReadLine();
    if (!float.TryParse(Input, out Operacion)) {
        Console.WriteLine("Ingreso invalido: [" + Input + "] Se esperaba un numero.");
        return;
    };
    if ((Operacion < 1 || Operacion > 4 )) {
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

    switch (Operacion) {
        case 1: // Suma
            Resultado = NumeroA + NumeroB;
            break;
        case 2: // Resta
            Resultado = NumeroA - NumeroB;
            break;
        case 3: // Multiplicacion
            Resultado = NumeroA * NumeroB;
            break;
        case 4: // Division
            Resultado = NumeroA / NumeroB;
            break;
    }

    Console.WriteLine("\nResultado de la operacion: " + Resultado);
    Console.Write("Desea realizar otro calculo? (SI = 1 / NO = 0): ");

    // Ingreso de continuar
    Continuar = (Console.ReadLine() == "1");
}