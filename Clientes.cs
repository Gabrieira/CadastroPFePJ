namespace ProjetoCadastro
{
    class Clientes
    {
        public string nome {get; set;} //get e set = encapsulamento
        public string endereço {get; set;}
        public float valor {get; set;} //protegendo o set, que não pode ser alterado
        public float valor_imposto {get; set;}
        public float total {get; set;}

        public virtual void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}