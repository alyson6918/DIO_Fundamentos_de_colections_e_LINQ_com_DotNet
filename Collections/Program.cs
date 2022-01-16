using Collections.Helper;
Queue<string> fila = new Queue<string>();
fila.Enqueue("Mariana Santana");
fila.Enqueue("João Rodrigues");
fila.Enqueue("Byanca Molero");
System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
while (fila.Count > 0)
{
    System.Console.WriteLine($"Vez de {fila.Peek()}");
    System.Console.WriteLine($"chamando {fila.Dequeue()}");
    System.Console.WriteLine(fila.Count);
} 