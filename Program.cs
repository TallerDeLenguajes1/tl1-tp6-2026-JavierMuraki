int Numero = 0;

Console.Write("Igrese numero: ");
string? Input = Console.ReadLine();

if (int.TryParse(Input, out Numero)) {
    Console.WriteLine(Numero);
} else {
    Console.WriteLine("Ingreso invalido: [" + Input + "] Se esperaba un numero.");
}