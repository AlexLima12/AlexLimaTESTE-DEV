using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JurosAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("**** Olá! por favor digite o número da opção desejada e pressione Enter *****\r\n");
            //Console.WriteLine("1 - Credito Direto - Taxa de 2% ao mês \r\n2 - Credito Consignado - Taxa de 1 % ao mês  \r\n" +
            //                     "3 - Credito Pessoa Jurídica - Taxa de 5 % ao mês  \r\n4 - Credito Pessoa Física - Taxa de 3 % ao mês \r\n" +
            //                        "5 - Credito Imobiliário - Taxa de 9 % ao ano");
            string valorCredito = string.Empty;
            string tipoCredito = string.Empty;
            string quantidadeParcelas = string.Empty;
            string dia = string.Empty;
            string mes = string.Empty;
            string ano = string.Empty;
            string dataPrimeiroVencimento = string.Empty;


            Console.WriteLine("*** Olá! Por favor insira os dados a seguir, pressione Enter, sempre que informar algum dado ***");
            Console.WriteLine("Qual valor do crédito pretendido: ");
            valorCredito = Console.ReadLine();
           

            Console.WriteLine("Qual a quantidade de parcelas desejada:");
            quantidadeParcelas = Console.ReadLine();

            Console.WriteLine("Vamos escolhar a data, digite primeiro o Dia e pressione Enter, \r\ndepois o Mês e pressione Enter \r\ne por último o Ano");
            DateTime hoje = DateTime.Now;
            Console.WriteLine("****Lembrando que a data deve estar entre " + hoje.AddDays(10).ToString("dd/MM/yyyy") +
                    " e " + hoje.AddDays(40).ToString("dd/MM/yyyy"));

            Console.WriteLine("Informe o Dia de Vencimento da primeira parcela: ");
            dia = Console.ReadLine();
            Console.WriteLine("Informe o Mês de Vencimento da primeira parcela: ");
            mes = Console.ReadLine();
            Console.WriteLine("Informe o Ano de Vencimento da primeira parcela: ");
            ano = Console.ReadLine();

            Console.WriteLine("Agora digite a opção do tipo de crédito desejado: ");
            Console.WriteLine("Tipo de Crédito: \r\n 1 - Credito Direto \r\n 2 - Credito Consignado \r\n 3 - Credito Pessoa Jurídica \r\n" +
                               " 4 - Credito Pessoa Física \r\n 5 - Crédito Imobiliário");
            tipoCredito = Console.ReadLine();

            dataPrimeiroVencimento = ano + "/" + mes + "/" + dia;

            bool simularemprestimo;
            Emprestimos emprestimos = new Emprestimos();
            simularemprestimo = emprestimos.CalculuarEmprestimos(valorCredito, quantidadeParcelas, dataPrimeiroVencimento, tipoCredito);

            if (!simularemprestimo)//erro
            {
                Thread.Sleep(9500);
                Console.Read();
                return;

            }

            Console.ReadLine();

        }
    }
}
