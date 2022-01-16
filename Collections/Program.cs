using Collections.Helper;
List<string> states = new List<string>();
states.Add("SP");
states.Add("MG");
states.Add("BA");
System.Console.WriteLine($"Quantidade de elementos na lista: {states.Count}");
foreach (var item in states){System.Console.WriteLine(item);}