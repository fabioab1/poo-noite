// Método Main()

using ComposicaoNotaFiscal;

ItemNotaFiscal it1 = new ItemNotaFiscal(4);
ItemNotaFiscal it2 = new ItemNotaFiscal(12);

NotaFiscal nf = new NotaFiscal(1, "11/09/2024");
nf.VetItens.Add(it1);
nf.VetItens.Add(it2);

nf = null; // Forçando a destruição da instância
GC.Collect(); // Forçando a chamada do coletor de lixo e consequentemente o destrutor