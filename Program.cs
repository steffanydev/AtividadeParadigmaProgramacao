using System;

namespace paradigmas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente
            Cliente cliente = new Cliente();
            cliente.Nome = "Stéffany";
            cliente.Cpf = "123.456.789-00";

            //Endereco
            cliente.Rua = "Rua das Flores";
            cliente.Numero = 26;
            cliente.Bairro = "Jardins";
            cliente.Cidade = "Olimpia";
            cliente.Cep = "15400-000";

            //Cidade
            cliente.CidadeNome = "Olímpia";
            cliente.EstadoNome = "São Paulo";
            cliente.EstadoSigla = "SP";

            string msg = "\n Nome: " + cliente.Nome + "\n CPF: " + cliente.Cpf + "\n Rua: " + cliente.Rua + 
            "\n Número: " + cliente.Numero + "\n Bairro: " + cliente.Bairro + "\n Cidade: " + cliente.Cidade + 
            "\n CEP: " + cliente.Cep + "\n Nome do Estado: " + cliente.EstadoNome + "\n Sigla do Estado: " + cliente.EstadoSigla;


            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}