using System;

class Program
{
    static void Main()
    {
        string[,,] geladeira = new string[3, 2, 4];

        geladeira[0, 0, 0] = "Melancia";
        geladeira[0, 0, 1] = "Banana";
        geladeira[0, 1, 0] = "Tomate";
        geladeira[0, 1, 1] = "Alface";
        geladeira[1, 0, 0] = "Leite";
        geladeira[1, 0, 1] = "Queijo";
        geladeira[1, 1, 0] = "Manteiga";
        geladeira[1, 1, 1] = "Salsicha";
        geladeira[2, 0, 0] = "Linguiça";
        geladeira[2, 0, 1] = "Mortadela";
        geladeira[2, 1, 0] = "Carne moída";
        geladeira[2, 1, 1] = "Ovos";

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
