using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;
using bytebank_ATENDIMENTO.bytebank.Atendimento;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Arrays
/*
void testaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho Total da Array: {idades.Length}");

    float media = 0;
    for ( int i = 0; i < idades.Length; i++)
    {
        media += idades[i];
    }
    Console.WriteLine($"Média de Idade: {media/idades.Length}");
}

void testaBuscaString()
{
    string[] palavras = new string[5];

    for ( int i = 0; i < palavras.Length; i++)
    {
        Console.WriteLine($"Digite a {i+1}ª Palavra: ");
        palavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a Palavra a ser Buscada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in palavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra {busca} encontrada na Lista.");
        }
    }
}

void testaMediana()
{
    Array amostra = Array.CreateInstance(typeof(double), 5);
    amostra.SetValue(5.9, 0);
    amostra.SetValue(1.8, 1);
    amostra.SetValue(7.1, 2);
    amostra.SetValue(10, 3);
    amostra.SetValue(6.9, 4);

    if (amostra == null || amostra.Length == 0)
    {
        Console.WriteLine("Array para cálculo de mediana está nulo ou vazio!");
    }
    
    double[] numerosOrdenados = (double[])amostra.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana é: {mediana}");
}

void testaContaCorrente()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    var contaDoAndre = new ContaCorrente(963);
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibirLista();
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibirLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas.RecuperarContaNoIndice(i);
        Console.WriteLine($"Indice [{i}] = {conta.Numero_agencia}/{conta.Conta}");
    }
}

testaContaCorrente();
*/
#endregion

ByteBankAtendimento byteBankAtendimento = new ByteBankAtendimento();
byteBankAtendimento.AtendimentoCliente();