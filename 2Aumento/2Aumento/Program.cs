double[] salarios = new double[5];
string? i;

for (int j = 0; j < salarios.Length; j++)
{
    Console.WriteLine("Digite o salarios de posição " + (j+1));     //Ler valores//
    i = Console.ReadLine();
    bool conv = Double.TryParse(i, out salarios[j]);
    if (!conv || salarios[j]<0)      //Verificação do valor como double//
    {
        Console.WriteLine("Valor inválido");
        j--;
    }
    if (salarios[j] < 1000)
    {
        salarios[j] *= 1.1;
    }
}
Console.WriteLine("Salários com valores menores de 1000 reais recebem aumento de 10%");
for (int j = 0;j < salarios.Length; j++)
{
    Console.WriteLine("Salario de posição " + (j+1) + ": R$" +
         String.Format("{0:.#}", salarios[j] ));
}