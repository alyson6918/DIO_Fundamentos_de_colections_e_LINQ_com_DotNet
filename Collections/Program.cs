using Collections.Helper;
int[] arrayNumbers = new int[5]{1,4,6,7,3};
var numPar = from num in arrayNumbers where num % 2 == 0 orderby num select num;
var numParByMethody = arrayNumbers.Where(n => n % 2 == 0).OrderBy(n => n).ToList();

System.Console.WriteLine($"Numeros pares metodo: {string.Join(", ", numParByMethody)}");
System.Console.WriteLine("---------------------");
System.Console.WriteLine($"Numeros pares Query: {string.Join(", ", numPar)}");