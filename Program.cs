int Numero = 0;

Console.Write("Igrese numero: ");
string? Input = Console.ReadLine();

if (int.TryParse(Input, out Numero)) {
    if (Numero > 0) {
        Console.WriteLine("Numero invertido: " + -Numero); 
    } else {
       Console.WriteLine("El numero tiene que ser mayor a 0.");
    }
} else {
    Console.WriteLine("Ingreso invalido: [" + Input + "] Se esperaba un numero.");
}