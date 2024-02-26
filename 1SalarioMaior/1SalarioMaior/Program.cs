double[] salarios = new double[10];
double maior = salarios[0];
string? i;
for (int j = 0; j < salarios.Length; j++)
{
    Console.WriteLine("Digite o salário de posição: " + (j+1));
    i = Console.ReadLine();
    Double.TryParse(i, out salarios[j]);
    if (salarios[j] > maior)
    {
        maior = salarios[j];
    }
}
Console.WriteLine("O maior salario é " + maior);
