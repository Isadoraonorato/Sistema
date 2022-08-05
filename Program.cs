namespace Sistema{
    class Program{
        static void Main(string[] args){
            PessoaFisica Isadora = new PessoaFisica();

            PessoaJuridica Avon = new PessoaJuridica();

            Avon.cnpj = "445463365";
            Avon.Nome = "Qualquer coisa!";

            Isadora.Nome = "Isadora Onorato";
            Isadora.Endereco = "Rua X, Nª 44";
            Isadora.cpf = "77887";

            Console.WriteLine(Isadora.Nome);
            Console.WriteLine(Isadora.cpf);

            Console.WriteLine(Avon.cnpj);
        }
    }
}



