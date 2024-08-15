class Program
{
    static void Main(string[] args)
    {
        int idade = 22;
        double altura = 1.90, salario = 10.000;
        string nome = "Wagner", profissao =  "Ferreiro";
        Console.WriteLine($"Nome {nome}, idade : {idade}, Altura {altura:f2}m");
        Console.WriteLine($"Profissao {profissao}, Salario R${salario:f3}");
    }
}
