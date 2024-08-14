using System;

namespace Exericio
{
    class Program
    {
        static void Main(string[] args)
        {
		    DetalharData();
            CalcularDescontoINSS();
        }

        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if(data.DayOfWeek == DayOfWeek.Sunday) {
                DateTime HorasDomingo = DateTime.Now;
                string resultado = string.Format("{0:dddd, MMM} - {1:HH:mm}", data, HorasDomingo);
                Console.WriteLine(resultado);
            }

            else {
            string DataExibir = string.Format("{0:dddd}, {0:MMM}", data);
            Console.WriteLine(DataExibir);
            }
      
        }

        public static void CalcularDescontoINSS() 
        {
            Console.WriteLine("Digite o valor do salário:");
            double salario = double.Parse(Console.ReadLine());

            if(salario <= 1212) 
            {
                double porcentagem = 7.5;
                double valorPorcentagem = (porcentagem / 100) * salario;
                double valorFinal = salario - valorPorcentagem;
                string Resultado = String.Format("{0:F2}", valorFinal);
                Console.WriteLine("O valor do salário com o INSS descontado é: R$" + Resultado);
            }

           else if(salario <= 2427.35) {
                double porcentagem = 9.0;
                double valorPorcentagem = (porcentagem / 100) * salario;
                double valorFinal = salario - valorPorcentagem;
                string Resultado = String.Format("{0:F2}", valorFinal);
                Console.WriteLine("O valor do salário com o INSS descontado é: R$" + Resultado);
           }

        
           else if(salario <= 3641.03) {
                double porcentagem = 12;
                double valorPorcentagem = (porcentagem / 100) * salario;
                double valorFinal = salario - valorPorcentagem;
                string Resultado = String.Format("{0:F2}", valorFinal);
                Console.WriteLine("O valor do salário com o INSS descontado é: R$" + Resultado);
           }
                
            else if(salario <= 7087.22) {  
                double porcentagem = 14;
                double valorPorcentagem = (porcentagem / 100) * salario;
                double valorFinal = salario - valorPorcentagem;
                string Resultado = String.Format("{0:F2}", valorFinal);
                Console.WriteLine("O valor do salário com o INSS descontado é: R$" + Resultado);
            }

            else {
                Console.WriteLine("Valor do INSS não definido.");
            }
        }
    }
}
