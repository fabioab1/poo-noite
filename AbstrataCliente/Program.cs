using AbstrataCliente;
internal class Program
{
    private static void Main(string[] args)
    {

        //Cliente c = new Cliente(1, "Bia"); - Não é possível instanciar uma classe abstrata, o programa não

        ClienteFisico cf = new ClienteFisico(2, "Teo", 18, "123");
        Teste t = new Teste();
        t.AnalisarIdade(cf);

        ClienteJuridico cj = new ClienteJuridico(3, "BelasArtes", 47, "222");
        t.AnalisarIdade(cj);
    }
}