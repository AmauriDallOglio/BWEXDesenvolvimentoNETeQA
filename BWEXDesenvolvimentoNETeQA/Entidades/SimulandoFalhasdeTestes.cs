namespace BWEXDesenvolvimentoNETeQA.Entidades
{
    public class SimulandoFalhasdeTestes
    {
        public void Executar()
        {
            Console.Write("Digite o nome do teste: ");
            string nomeDoTeste = Console.ReadLine();

            // Solicite ao usuário que digite a descrição do erro:
            Console.Write("Digite a descrição do erro: ");
            string descricaoDoErro = Console.ReadLine();

            // Use switch case para determinar a saída com base no nome do teste:
            switch (nomeDoTeste)
            {
                case "Teste de Compra Online O carrinho de compras nao atualiza":
                    Console.WriteLine($"O teste falhou: Descrição do erro: {descricaoDoErro}");
                    break;
                case "Teste de API Rest A solicitacao GET retornou erro 404":
                    Console.WriteLine($"O teste falhou: Descrição do erro: {descricaoDoErro}");
                    break;
                case "Teste de Envio de Formulario O formulario nao foi enviado":
                    Console.WriteLine($"O teste falhou: Descrição do erro: {descricaoDoErro}");
                    break;
            }
        }

    }
}
