int a = 10;
int b = 6;

void Calculo (int a, int b)
{
    Console.WriteLine($"{a} e {b}");

    Console.WriteLine($"A soma de a e b = {a + b}");
    Console.WriteLine($"A subtração de a e b = {a - b}");
    Console.WriteLine($"A divisão de a e b = {a / b}");
    Console.WriteLine($"A multiplicação de a e b = {a * b}");
}

Calculo(a, b);

List<string> bandas = new List<string>();

bool op = true;

while (op)
{
    Console.WriteLine("Digite o nome de uma banda: ");
    string banda = Console.ReadLine();
    bandas.Add( banda );
    Console.WriteLine("Deseja sair? s ou n");
    string opcao = Console.ReadLine()!;

    if (opcao == "s")
    {
        op = false;
    }
}

for (int i = 0; i < bandas.Count; i++)
{
    Console.WriteLine($"Bandas: {bandas[i]}");
}