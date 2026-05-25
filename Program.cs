string Operacion = "";
float NumeroA = 0;
float NumeroB = 0;
bool Continuar = true;
string? Input = "";

// Ejercicios con String //
Console.Write("Ingrese un texto: ");
string? Cadena1 = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(Cadena1)) {
    Console.WriteLine($"Longitud: {Cadena1.Length}\n");
    Console.Write("Ingrese segundo texto: ");
    string? Cadena2 = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(Cadena2)) {
        Console.WriteLine($"Texto concatenado: {Cadena1}{Cadena2}");
        Console.WriteLine($"Texto con Substring(5): {Cadena1.Substring(Math.Min(5, Cadena1.Length))}"); // Para evitar error usando Math.Min

        Console.Write("Letras de Texto: ");
        foreach (char Letra in Cadena1) Console.Write(Letra + " ");
        Console.Write("\n\n");

        if (Cadena1.Contains("hola")) Console.WriteLine("El Texto contiene \"hola\"");
        else Console.WriteLine("El Texto NO tiene \"hola\"");

        Console.WriteLine("Texto en Mayusculas: " + Cadena1.ToUpper());
        Console.WriteLine("Texto en Minusculas: " + Cadena1.ToLower());
        
        string[] TextoSeparado = Cadena1.Split("a");
        Console.WriteLine("Texto separado por \"a\":");
        foreach (string Texto in TextoSeparado) Console.WriteLine("- " + Texto);
    } else {
        Console.WriteLine("Texto vacio\n");
    }
} else {
    Console.WriteLine("Texto vacio\n");
}


// Caluladora //
while (Continuar) {
    // Ingreso del Calculo
    Console.Write("Igrese su calculo: ");
    Input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(Input)) {
        Console.WriteLine("Operacion vacia");
        return;
    };

    if (Input.Contains("+")) Operacion = "+";
    else if (Input.Contains("-")) Operacion = "-";
    else if (Input.Contains("*")) Operacion = "*";
    else if (Input.Contains("/")) Operacion = "/";
    else {
        Console.WriteLine("Operador inválido");
        return;
    }

    string[] Partes = Input.Split(Operacion);
    if (!float.TryParse(Partes[0], out NumeroA)) {
        Console.WriteLine("No se pudo conseguir el primer numero");
        return;
    }
    if (!float.TryParse(Partes[1], out NumeroB)) {
        Console.WriteLine("No se pudo conseguir el segundo numero");
        return;
    }

    Console.WriteLine("\nResultado de las operaciones:");
    switch (Operacion) {
        case "+": // Suma
            Console.WriteLine("Suma de \"A\" y \"B\": " + (NumeroA + NumeroB));
            break;
        case "-": // Resta
            Console.WriteLine("Resta de \"A\" y \"B\": " + (NumeroA - NumeroB));
            break;
        case "*": // Multiplicacion
            Console.WriteLine("Multiplicacion de \"A\" y \"B\": " + (NumeroA * NumeroB));
            break;
        case "/": // Division
            Console.WriteLine("Division de \"A\" y \"B\": " + (NumeroA / NumeroB));
            break;
    }
    Console.WriteLine("Numero Maximo: " + Math.Max(NumeroA, NumeroB));
    Console.WriteLine("Numero Minimo: " + Math.Min(NumeroA, NumeroB));

    Console.Write("\nDesea realizar otro calculo? (SI = 1 / NO = 0): ");

    // Ingreso de continuar
    Continuar = (Console.ReadLine() == "1");
}