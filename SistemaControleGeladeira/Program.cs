using System;

class Geladeira
{
    private string[,,] geladeira;

    public Geladeira()
    {
        geladeira = new string[3, 2, 4];
    }
    public void AdicionarItem(int andar, int container, int posicao, string item)
    {
        if (string.IsNullOrEmpty(geladeira[andar, container, posicao]))
        {
            geladeira[andar, container, posicao] = item;
            Console.WriteLine($"Item '{item}' adicionado na posição {posicao} do container {container} no andar {andar}.");
        }
        else
        {
            Console.WriteLine($"Posição {posicao} do container {container} no andar {andar} já está ocupada.");
        }
    }

    public void RemoverItem(int andar, int container, int posicao)
    {
        if (!string.IsNullOrEmpty(geladeira[andar, container, posicao]))
        {
            Console.WriteLine($"Item '{geladeira[andar, container, posicao]}' removido da posição {posicao} do container {container} no andar {andar}.");
            geladeira[andar, container, posicao] = null;
        }
        else
        {
            Console.WriteLine($"Posição {posicao} do container {container} no andar {andar} já está vazia.");
        }
    }

    public void RemoverItensContainer(int andar, int container)
    {
        bool containerVazio = true;
        for (int posicao = 0; posicao < 4; posicao++)
        {
            if (!string.IsNullOrEmpty(geladeira[andar, container, posicao]))
            {
                Console.WriteLine($"Item '{geladeira[andar, container, posicao]}' removido da posição {posicao}.");
                geladeira[andar, container, posicao] = null;
                containerVazio = false;
            }
        }
        if (containerVazio)
        {
            Console.WriteLine($"Container {container} no andar {andar} já estava vazio.");
        }
    }

    public void AdicionarItensContainer(int andar, int container, string[] itens)
    {
        int posicaoVazia = -1;
        for (int posicao = 0; posicao < 4; posicao++)
        {
            if (string.IsNullOrEmpty(geladeira[andar, container, posicao]))
            {
                posicaoVazia = posicao;
                break;
            }
        }

        if (posicaoVazia == -1)
        {
            Console.WriteLine($"Container {container} no andar {andar} está cheio.");
        }
        else
        {
            for (int i = 0; i < itens.Length && posicaoVazia < 4; i++, posicaoVazia++)
            {
                geladeira[andar, container, posicaoVazia] = itens[i];
                Console.WriteLine($"Item '{itens[i]}' adicionado na posição {posicaoVazia} do container {container} no andar {andar}.");
            }
        }
    }

    public void ExibirItens()
    {
        Console.WriteLine("Itens na geladeira:");
        for (int andar = 0; andar < 3; andar++)
        {
            for (int container = 0; container < 2; container++)
            {
                for (int posicao = 0; posicao < 4; posicao++)
                {
                    string item = geladeira[andar, container, posicao];
                    if (!string.IsNullOrEmpty(item))
                    {
                        Console.WriteLine($"Andar {andar}, Container {container}, Posição {posicao}: {item}");
                    }
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Geladeira geladeira = new Geladeira();

        geladeira.AdicionarItem(0, 0, 0, "Melancia");
        geladeira.AdicionarItem(0, 0, 1, "Banana");

        geladeira.RemoverItem(0, 0, 0);

        string[] itensParaAdicionar = { "Tomate", "Alface" };
        geladeira.AdicionarItensContainer(0, 1, itensParaAdicionar);

        geladeira.RemoverItensContainer(0, 1);

        geladeira.ExibirItens();
    }
}
