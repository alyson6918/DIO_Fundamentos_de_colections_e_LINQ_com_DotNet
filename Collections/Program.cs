using Collections.Helper;
Dictionary<string, string> states = new Dictionary<string, string>();
states.Add("SP", "São Paulo");
states.Add("RJ", "Rio De Janeiro");
states.Add("MG", "Minas Gerais");

foreach (KeyValuePair<string, string> item in states)
{
    System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}
System.Console.WriteLine(states["SP"]);