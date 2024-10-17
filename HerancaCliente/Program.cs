// Método Main()

using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Teo";
c.Mostrar();

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Beatriz";
cf.Cpf = 111;
cf.Rg = "11";
cf.Mostrar();

Cliente c2 = new Cliente(3, "Mário");
c2.Mostrar();

ClienteFisico cf2 = new ClienteFisico(4, "Izadora", 444, "44");
cf2.Mostrar();

ClienteFisico cf3 = new ClienteFisico(5, "Mateus", 555, "55");
cf3.Mostrar();