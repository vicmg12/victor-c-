//1 - Criar um vetor de 100 posições inteiras
//2 - Criar um loop para percorrer todo o vetor
//3 - Preencher cada posição com um valor aleatório
//4 - Imprimir o vetor na tela

int[] vetor = new int[100];
Random r = new Random();

for(int i = 0; i < vetor.Length; i++)
{
    vetor[i] = r.Next(100);
}

for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

for(int i = 0; i < vetor.Length - 1; i++)
{
    if(vetor[i] > vetor[i + 1])
    {
        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux;
    }
}

Console.WriteLine("\n");
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}