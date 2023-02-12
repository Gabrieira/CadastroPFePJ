using System;
namespace ProjetoCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.Write("Digite o nome: ");
            string var_nome = Console.ReadLine();
            Console.Write("Digite o endereço: ");
            string var_endereco = Console.ReadLine();
            Console.Write("Selecione o tipo: (f) para pessoa física ou (j) para pessoa juridica: ");
            string var_tipo = Console.ReadLine();
            if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica(); // atribui tudo que está na class pessoa_fisica, chama
                pf.nome = var_nome;
                pf.endereço = var_endereco;
                Console.Write("Informe o CPF: ");
                pf.cpf = Console.ReadLine();
                Console.Write("Informe o RG: ");
                pf.rg = Console.ReadLine();
                Console.Write("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("====== Pessoa Física =====");
                Console.WriteLine("Nome: " + pf.nome);
                Console.WriteLine("RG: " + pf.rg);
                Console.WriteLine("CPF: " + pf.cpf);
                Console.WriteLine("Valor compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Valor imposto: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Valor total: " + pf.total.ToString("C"));
            }
            if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereço = var_endereco;
                Console.Write("Digite o CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.Write("Digite a inscrição estadual: ");
                pj.ie = Console.ReadLine();
                Console.Write("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("===== Pessoa Juridica =====");
                Console.WriteLine("Nome: " + var_nome);
                Console.WriteLine("Endereço: " + var_endereco);
                Console.WriteLine("CNPJ: " + pj.cnpj);
                Console.WriteLine("Inscrição estadual: " + pj.ie);
                Console.WriteLine("Valor da compra: " + val_pag.ToString("C"));
                Console.WriteLine("Valor imposto: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Valor total: " + pj.total.ToString("C"));
            }
        }
    }
}