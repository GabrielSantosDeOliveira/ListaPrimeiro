Console.WriteLine("Quantos valores você deseja inserir?");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Por favor, digite um número inteiro positivo maior que zero.");
}
Console.WriteLine("");
double[] valores = new double[n];
double soma = 0;
int j = 0;
string? i;
Console.WriteLine("DIGITE 0 PARA PARAR A SOMA");
Console.WriteLine("");
do
{
    Console.WriteLine("Digite o valor de posição " + (j+1));
    i = Console.ReadLine();
    if (Double.TryParse(i, out valores[j]))
    {
        soma += valores[j];
        j++;
    }
    else
    {
        j--;
    }

} while (valores[j-1]!=0 && j<valores.Length);
Console.WriteLine("");
if(j>0)
{
    double media = soma / j;
    Console.WriteLine("A media aritmética dos valores é: " + String.Format("{0:.#}", media));
}
else
{
    Console.WriteLine("Nenhum valor válido foi digitado.");
}
