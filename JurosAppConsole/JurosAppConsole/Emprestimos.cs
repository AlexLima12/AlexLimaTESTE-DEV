using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurosAppConsole
{
    public class Emprestimos
    {
        public bool CalculuarEmprestimos(string valor, string parcelas, string dia, string opcao)
        {
            bool retorno = false;

            int valorCredito = Convert.ToInt32(valor);
            int quatidadeParcelas = Convert.ToInt32(parcelas);
           // int diaVencimento = Convert.ToInt32(dia);
            int tipoCredito = Convert.ToInt32(opcao);

            string msg = ValidarDados(valorCredito, quatidadeParcelas, dia, tipoCredito);

            if (msg != "OK")
            {
                Console.WriteLine(msg);
                Console.WriteLine("Vamos reiniciar a simulação!");
                retorno = false;
              //  Console.ReadKey();
             //   return msg;
            }

            else// validado com sucesso
            {
                retorno = true;
                Console.WriteLine(CalcualarEmprestimo(valorCredito, quatidadeParcelas, tipoCredito));
                
            }
           
            return retorno;
        }


        public string CalcualarEmprestimo(int valorCredito, int quatidadeParcelas, int tipoCredito) {

            string retorno = string.Empty;
            string valorTotal = string.Empty;
            double acrescimo;
            double taxa = 0.1;

            switch (tipoCredito)
            {
                case 1:
                    taxa = 0.02;
                    break;
                case 2:
                    taxa = 0.01;
                    break;
                case 3:
                    taxa = 0.05;
                    break;
                case 4:
                    taxa = 0.03;
                    break;
                case 5:
                    taxa = 0.0075;
                    break;
            }

            acrescimo = valorCredito * taxa * quatidadeParcelas;
            valorTotal = "R$" + (acrescimo + valorCredito).ToString();

            retorno = "STATUS DO CRÉDITO: Aprovado \r\n Valor Total com Juros = " + valorTotal + ",00" +
                         "\r\n Valor do juros = R$" + acrescimo + ",00";

            return retorno;
        }


        public string ValidarDados(int valorCredito, int quatidadeParcelas, string diaVencimento, int tipoCredito)
        {

            //validações
            if (valorCredito < 0 || valorCredito > 1000000)
            {
                return "Insira um valor entre R$0,00 e R$1.000.000,00";
            }

            if (quatidadeParcelas < 5)
            {
                return "A quantidade mínima de parcelas é 5";
            }

            if (quatidadeParcelas > 72)
            {
                return "A quantidade máxima de parcelas é 72";
            }

            if (tipoCredito == 3)
            {
                if (valorCredito < 15000)
                {
                    return "Para ''Credito Pessoa Jurídica '' o valor mínimo é R$15.000,00";
                }
            }

            DateTime dataPretendida = Convert.ToDateTime(diaVencimento);
            DateTime hoje = DateTime.Now;

            if ((dataPretendida - hoje).TotalDays < 10 || (dataPretendida - hoje).TotalDays > 40)
            {
                return "Escolha uma data entre " + hoje.AddDays(10).ToString("dd/MM/yyyy") +
                    " e " + hoje.AddDays(40).ToString("dd/MM/yyyy");
            }    


            return "OK";
        }

    }
}
