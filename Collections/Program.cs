using Collections.Helper;
int[] arrayNumbers = new int[10]{1,4,6,7,3,100,47,47,100,6};
var arrayUnico = arrayNumbers.Distinct().ToArray();
System.Console.WriteLine($"Soma de todos os valores do array: {arrayNumbers.Sum()}\nArray Original: {string.Join(", ",arrayNumbers)}\nArray distinto:{string.Join(", ",arrayUnico)}");