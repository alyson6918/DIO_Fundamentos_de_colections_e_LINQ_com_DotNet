using Collections.Helper;
Stack<string> pilhaLivros = new Stack<string>();
pilhaLivros.Push("Universo Numa Casca De Nós");
pilhaLivros.Push("Teoria da Relatividade");
pilhaLivros.Push("Breves Respostas Para Grandes Questões");
System.Console.WriteLine($"Quantidade de livros: {pilhaLivros.Count}");
while (pilhaLivros.Count > 0)
{
     System.Console.WriteLine($"Proximo livro para leitura: {pilhaLivros.Peek()}");
     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso!");
     System.Console.WriteLine($"Livros restantes: {pilhaLivros.Count}");
}