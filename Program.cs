using trilha_net_poo_desafio.models;

internal class Program
{
    private static void Main(string[] args)
    {
        // criando um iphone 
        Iphone i1 = new Iphone("123abc", "iphone 12", "12222", 256);
        Console.WriteLine($"Iphone: {i1.Modelo}, com {i1.Memoria} GB de memória. ");
        i1.InstalarAplicativo("Instagram");
        i1.Ligar();
        i1.ReceberLigacao();

        // criando um nokia 

        Nokia n1 = new Nokia("12356cx", "nokia 2000", "233344", 128);
        Console.WriteLine($"Nokia: {i1.Modelo}, com {i1.Memoria} GB de memória. ");
        n1.InstalarAplicativo("Twitter");
        n1.Ligar();
        n1.ReceberLigacao();

    }
}