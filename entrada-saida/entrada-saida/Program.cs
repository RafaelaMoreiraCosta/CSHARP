        // Saída de dados com Console.WriteLine
        Console.WriteLine("Olá Mundo!");

        // Entrada de dados com Console.ReadLine
        Console.Write("Qual é o seu nome? ");
        string nome = Console.ReadLine();

        Console.Write("Qual é a sua idade? ");
        string idadeTexto = Console.ReadLine();
        int idade = Convert.ToInt32(idadeTexto); // Ou: int idade = int.Parse(idadeTexto);

        // Exibindo a saída final
        Console.WriteLine("Olá, " + nome + "!");
        Console.WriteLine("Você tem " + idade + " anos.");
        