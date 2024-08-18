internal class Program
{
    public void Ola() {
        Console.WriteLine("Olá!");
    }

    private static void Main(string[] args)
    {
        /*
        Console.Write("Digite o ano de nascimento: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        int idade = 2024 - ano;

        System.Console.WriteLine($"Sua idade atual é: " + idade);

        if (idade >= 18)
            System.Console.WriteLine("Maior de idade.");
        else if (idade == 1)
            System.Console.WriteLine("É bebê.");
        else
            System.Console.WriteLine("Menor de idade.");    
        

        int contador = 1;
        while (contador <= 10)
        {
            System.Console.WriteLine("5 x " + contador + " = " + 5 * contador);
            contador++;
        }

        for (int cont = 1; cont <= 10; cont++)
            System.Console.WriteLine("6 x " + cont + " = " + 6 * cont);

                
        Program programa = new Program();
        programa.Ola();

        int cont = 1;
        do
        {
            System.Console.WriteLine("7 x " + cont + " = " + 7 * cont);
            cont++;
        } while (cont <= 10);

        int opcao = 5;
        switch (opcao)
        {
            case 1: System.Console.WriteLine("1. Somar");
                // Lógica para somar
                break;

            case 2: System.Console.WriteLine("Opção 2");
                break;

            case 3: System.Console.WriteLine("Opção 3");
                break;

            default: System.Console.WriteLine("Nada");
                break;
        }

        float media = 5.9f;
        System.Console.WriteLine(media >= 6 ? "Aprovado." : "Reprovado.");
        */

        int[] vet = new int[3];

        vet[0] = 12;
        vet[1] = 37;
        vet[2] = 40;

        foreach (int n in vet)
            System.Console.WriteLine(n);

        for (int i = 0; i < vet.Length; i++)
            System.Console.WriteLine(vet[i]);
    }
}