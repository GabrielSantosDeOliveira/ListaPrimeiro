double[] vet1 = new double[5];
double[] vet2 = new double[5];
string? i;

for (int j = 0; j < 5; j++)
{
    Console.WriteLine("VETOR 1: Digite o valor" + (j + 1));
    i= Console.ReadLine();
    while(!Double.TryParse(i, out vet1[j]))
    {
        Console.WriteLine("Valor inválido, redigite");
        i = Console.ReadLine();
    }
}
for (int j = 0; j < 5; j++)
{
    Console.WriteLine("VETOR 2: Digite o valor" + (j + 1));
    i = Console.ReadLine();
    while (!Double.TryParse(i, out vet2[j]))
    {
        Console.WriteLine("Valor inválido, redigite");
        i = Console.ReadLine();
    }
}
Console.WriteLine("");
Console.WriteLine("");
int Menu()
{
    int op;
    Console.WriteLine("=============MENU DE OPERAÇÕES=============");
    Console.WriteLine("");
    Console.WriteLine("0 - Finalizar programa");
    Console.WriteLine("1 - Soma das posições");
    Console.WriteLine("2 - Diferença das posições");
    Console.WriteLine("3 - Produto das posições");
    Console.WriteLine("4 - Divisão entre as posições");

    while(!Int32.TryParse(Console.ReadLine(), out op) || op <0 ||op>4)
    {
        Console.WriteLine("Valor inválido, redigite");

    }
    Console.WriteLine("");
    Console.WriteLine("");
    return op;
}
    int escolha;
    do
    {
    escolha = Menu();


    if (escolha == 1)
    {
        double[] soma = new double[5];
        for (int j = 0; j < 5; j++)
        {
            soma[j] = vet1[j] + vet2[j];
            Console.WriteLine("A soma das posições " + (j + 1) + "do vetor 1 e do vetor 2 é: " + soma[j]);
        }
    }
    if (escolha == 2)
    {
        double[] dif = new double[5];
        for (int j = 0; j < 5; j++)
        {
            dif[j] = vet1[j] - vet2[j];
            Console.WriteLine("A diferença das posições " + (j + 1) + " do vetor 1 e do vetor 2 é: " + dif[j]);
        }
    }
    if (escolha == 3)
    {
        double[] prod = new double[5];
        for (int j = 0; j < 5; j++)
        {
            prod[j] = vet1[j] * vet2[j];
            Console.WriteLine("O produto das posições " + (j + 1) + " do vetor 1 e do vetor 2 é: " + prod[j]);
        }
    }
    if (escolha == 4)
    {
        double[] div = new double[5];
        for (int j = 0; j < 5; j++)
        {
            if (vet2[j] == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                continue;
            }
            div[j] = vet1[j] / vet2[j];
            Console.WriteLine("A divisão das posições " + (j + 1) + " do vetor 1 e do vetor 2 é: " + div[j]);
        }
    }
} while (escolha != 0);