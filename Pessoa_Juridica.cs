namespace ProjetoCadastro 
{
    class Pessoa_Juridica : Clientes //coloca os : e coloca a classe em que se vai herdar caracteristicas
    {
        public string cnpj {get; set;}
        public string ie {get; set;}

        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}