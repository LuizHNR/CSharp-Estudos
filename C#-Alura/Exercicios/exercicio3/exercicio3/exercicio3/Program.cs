Console.WriteLine("Hello, World!");

var alunos = new Dictionary<string, List<int>> {
    { "Luiz", new List<int>{ 10,7,10 } }
};

List<int> notas = alunos["Luiz"];
double mediaAluno = notas.Average();
Console.WriteLine($"\n\nA media do aluno é de {mediaAluno}");