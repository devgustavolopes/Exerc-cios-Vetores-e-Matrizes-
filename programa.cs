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

/*int count = 0, n;
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



int n, impar = 0, par=0;
Console.Write("Informe o tamanho do vetor (n): ");
n = int.Parse(Console.ReadLine());
int[] V = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Informe os valores para prencher o vetor: ");
    V[i] = int.Parse(Console.ReadLine());
    if (V[i] % 2 == 0)
        par++;
    else impar++;
}

Console.Write($"A quantidade de números impares é: {impar} ");
Console.Write($"A quantidade de números pares é: {par} ");

int n;
System.Console.WriteLine("informe o valor dos vetores:");
n = int.Parse(Console.ReadLine());
int[] V1 = new int[n];
int[] V2 = new int[n];
string[] V3 = new string[n];

for (int i = 0; i < n; i++)
{
    System.Console.WriteLine("escreva um valor para[V1]:");
    V1[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    System.Console.WriteLine("escreva um valor para[V2]:");
    V2[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (V1[i] > V2[i])
    {
        V3[i] = "Maior";
    }
    else if (V1[i] < V2[i])
    {
        V3[i] = "menor";
    }
    else
    {
        V3[i] = "igual";
    }
System.Console.WriteLine($"O VALOR E {V3[i]}: ");
}


int TAMANHO = 10;


string[] nomes = new string[TAMANHO];
double[] notas = new double[TAMANHO];
int[] frequencias = new int[TAMANHO];
string[] situacoes = new string[TAMANHO];
for (int i = 0; i < TAMANHO; i++)
{
   Console.Write("Nome: ");
    nomes[i] = Console.ReadLine();
    Console.Write("Nota (0 a 100): ");
    notas[i] = double.Parse(Console.ReadLine());
    Console.Write("Frequência (apenas o número, ex: 75): ");
    frequencias[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < TAMANHO; i++)
{
    if (notas[i] >= 60 && frequencias[i] >= 75)
    {
        situacoes[i] = "Aprovado";
    }
    else
    {
        situacoes[i] = "Reprovado";
    }
}
for (int i = 0; i < TAMANHO; i++)
{
    
    if (situacoes[i] == "Aprovado")
    {
        Console.WriteLine($"Nome: {nomes[i]} (Posição no vetor: [{i}])");
    }
}

for (int i = 0; i < TAMANHO; i++)
{
    Console.WriteLine($"- Aluno: {nomes[i]} | Nota: {notas[i]} | Frequência: {frequencias[i]}% | Situação: {situacoes[i]}");
}


//. Soma dos Elementos Faça um algoritmo em C# para: (a) ler um vetor V de números inteiros de tamanho n 
//(informado pelo usuário); (b) calcular e mostrar a soma de todos os elementos do vetor V.

int n, soma = 0, num;

System.Console.WriteLine("Informe o tamanho do vetor(n): ");
n = int.Parse(Console.ReadLine());

int[] V = new int[n];

for (int i = 0; i < n; i++)
{
    System.Console.WriteLine("um valor a ser somado no vetor: ");
    V[i] = int.Parse(Console.ReadLine());

    soma = soma + V[i];
    }

    System.Console.WriteLine($"a soma dos valores do vetor é: {soma}");



// Média dos Elementos Faça um algoritmo em C# para: (a) ler um vetor V de números reais de tamanho n 
//(informado pelo usuário); (b) calcular e mostrar a média aritmética de todos os elementos do vetor V.

using System.Runtime.InteropServices;

int n, media = 0, soma = 0;

System.Console.WriteLine("Informe o tamanho do vetor(n): ");
n = int.Parse(Console.ReadLine());

int[] V = new int[n];

for (int i = 0; i < n; i++)
{
    System.Console.WriteLine("informe um valor para o vetor: ");
    V[i] = int.Parse(Console.ReadLine());

    soma = soma + V[i];
    media = soma/n;
}

System.Console.WriteLine($"a media dos valores e: {media} ");


//3.Encontrar o Maior Elemento Faça um algoritmo em C# para: (a) ler um vetor V de números inteiros de tamanho n
//(informado pelo usuário); (b) encontrar e mostrar o maior elemento presente no vetor V e a posição (índice i) onde ele foi encontrado.

int n, posicaomaior=0;
System.Console.WriteLine("Informe o tamanho do vetor(n): ");
n = int.Parse(Console.ReadLine());

int[] V = new int[n];

for (int i = 0; i < n; i++)
{
    System.Console.WriteLine("informe um valor para o vetor: ");
    V[i] = int.Parse(Console.ReadLine());
}
int maior = V[0];
for (int i = 0; i < n; i++)
{
if (V[i] > maior)
maior = V[i];
posicaomaior = i + 1;
}

System.Console.WriteLine($"o maior valor e: {maior} na posiçao {posicaomaior} ");

//4. Encontrar o Menor Elemento Faça um algoritmo em C# para: (a) ler um vetor V de números inteiros de tamanho n (informado pelo usuário);
//(b) encontrar e mostrar o menor elemento presente no vetor V e a posição (índice i) onde ele foi encontrado.

using System.Security.Principal;

int n,posicaoMenor = 0;;
System.Console.WriteLine("Informe o tamanho do vetor(n): ");
n = int.Parse(Console.ReadLine());

int[] V = new int[n];

for (int i = 0; i < n; i++)
{
    System.Console.WriteLine("informe um valor para o vetor: ");
    V[i] = int.Parse(Console.ReadLine());
}
int menor = V[0];

for (int i = 0; i < n; i++)
{
    if (V[i] < menor)
        menor = V[i];
    posicaoMenor = i + 1;
}
System.Console.WriteLine($"o maior valor e: {menor} na posiçao {posicaoMenor} ");*/

//5. Multiplicação por Constante Faça um algoritmo em C# para: (a) ler um vetor V de números inteiros de tamanho n (informado pelo usuário); (b) 
//ler um número inteiro x; (c) criar um vetor VC (vetor calculado)onde cada elemento VC[i] é igual ao elemento V[i] multiplicado por x; 
//(d) mostrar o conteúdo do vetor VC.*?








