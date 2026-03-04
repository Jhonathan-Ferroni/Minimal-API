namespace ApiCrud.Estudantes
{
    public class Estudante
    {
        //guid é um id que nao se repete, bom pra migrar para outro banco
        //init é um recurso do c# 9 que permite que a propriedade seja setada apenas na inicialização do objeto, ou seja, no construtor ou na inicialização direta
        public Guid Id { get; init; }
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }

        //metodo construtor
        public Estudante(string nome)
        {
            Nome = nome;
            Id = Guid.NewGuid();
            Ativo = true;
        }
        public void AtualizarNome(string nome)
        {
            Nome = nome;
        }

        public void Desativar()
        {
            Ativo = false;
        }
    }
}
