using System.ComponentModel.DataAnnotations;
/*using System.Globalization;
int n;
Console.WriteLine("Digite o tamanho do vetor:");
n = int.Parse(Console.ReadLine());

int[] V = new int[n];

for (int i = 0; i < V.Length; i++)
{
    Console.WriteLine("digite um número inteiro para o vetor:", i);
    V[i] = int.Parse(Console.ReadLine());
}
 
Console.WriteLine($"O conteúdo do vetor é:{} ");



//2 

int n, soma=0,media=0;
Console.WriteLine("Digite o tamanho do vetor:");
n = int.Parse(Console.ReadLine());

int[] V = new int[n];


for (int i = 0; i < V.Length; i++)
{
    Console.WriteLine("digite um número inteiro para o vetor:", i);
    V[i] = int.Parse(Console.ReadLine());
    soma = soma + V[i];
}



Console.WriteLine($"a soma dos elementos e: {soma}");

Console.WriteLine($"a media dos elementos e: {soma/n}");

Console.ReadLine();*/

int count = 0, n;
Console.Write("Informe o tamanho do vetor (n): ");
n = int.Parse(Console.ReadLine());
int[] V = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Escreva os números do vetor: ");
    V[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < V.Length; i++)
{

    for (int j = 0; j < V.Length; j++)
    {
        if (V[i] == V[j])
            count++;
    }
    Console.WriteLine($"O valor {V[i]} aparece {count} vezes");

}












