const string sair = "tchau";
string pergunta;

Console.Clear();

Console.WriteLine(" Conversa com o Groot  ");
Console.WriteLine();

do
{
    Console.Write("Digite sua pergunta: ");
    pergunta = Console.ReadLine()!;
    
    Console.WriteLine($"                          Groot: Eu sou Groot ");
}while (pergunta != sair);