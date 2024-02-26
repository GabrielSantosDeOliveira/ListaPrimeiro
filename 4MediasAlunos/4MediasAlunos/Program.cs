Console.WriteLine("Quantos alunos deseja inserir?");
int numeroDeAlunos;
while (!int.TryParse(Console.ReadLine(), out numeroDeAlunos) || numeroDeAlunos <= 0)
{
    Console.WriteLine("Por favor, digite um número inteiro positivo maior que zero.");
}

double[] notasG1 = new double[numeroDeAlunos];
double[] notasG2 = new double[numeroDeAlunos];
double[] medias = new double[numeroDeAlunos];

for (int j = 0; j < numeroDeAlunos; j++)
{
    Console.WriteLine("Digite a nota G1 do aluno: " + (j+1));
    while (!double.TryParse(Console.ReadLine(), out notasG1[j]))
    {
        Console.WriteLine("Por favor, digite um número válido.");
    }

    Console.WriteLine("Digite a nota G2 do aluno: " + (j+1));
    while (!double.TryParse(Console.ReadLine(), out notasG2[j]))
    {
        Console.WriteLine("Por favor, digite um número válido.");
    }

    medias[j] = (notasG1[j] + notasG2[j]) / 2;
}

Console.WriteLine("Notas dos alunos:");
for (int j = 0; j < numeroDeAlunos; j++)
{
    Console.WriteLine($"Aluno {j + 1}: G1 = {notasG1[j]}, G2 = {notasG2[j]}, Média = {medias[j]}");
}