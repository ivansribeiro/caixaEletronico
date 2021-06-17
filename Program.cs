using System;

namespace Caixa_Eletronico
{
    class Program
    {
        static void Main(string[] args)
        {


            //contadores para as notas

            int nota2 = 0;
            int nota5 = 0;
            int nota10 = 0;
            int nota20 = 0;
            int nota50 = 0;
            int nota100 = 0;
            int nota200 = 0;
            int totalSaque = 0;
            int resto = 0;
            double saque = 0.0;
            string valorSaque = "";


            /*/ Reposicao de notas no caixa -  Implementacao futura
				ler a quantidade de notas existentes no caixa para 
				entregar somente as notas disponíveis

				int qtdNota2 = 0;
				int qtdNota5 = 0;
				int qtdNota10 = 0;
				int qtdNota20 = 0;
				int qtdNota100 = 0;
				int qtdNota200 = 0;
			/*/

            Console.WriteLine("Digite o valor do saque:");
            valorSaque = Console.ReadLine();
            saque = Convert.ToDouble(valorSaque);

            //verifica se o valor do saque é par
            if ((saque % 2) == 0)
            {

                while (saque > 0)
                {

                    if (saque >= 200)
                    {
                        saque = saque - 200;
                        //totalSaque = totalSaque - 200;
                        nota200 = nota200 + 1;

                    }

                    else if (saque >= 100)
                    {
                        saque = saque - 100;
                        //totalSaque = totalSaque - 100;
                        nota100 = nota100 + 1;

                    }
                    else if (saque >= 50)
                    {
                        saque = saque - 50;
                        //totalSaque = totalSaque - 50;
                        nota50 = nota50 + 1;

                    }
                    else if (saque >= 20)
                    {
                        saque = saque - 20;
                        //totalSaque = totalSaque - 20;
                        nota20 = nota20 + 1;

                    }
                    else if (saque >= 10)
                    {
                        saque = saque - 10;
                        //totalSaque = totalSaque - 10;
                        nota10 = nota10 + 1;

                    }
                    else if (saque >= 5)
                    {
                        saque = saque - 5;
                        //totalSaque = totalSaque - 5;
                        nota5 = nota5 + 1;

                    }
                    else if (saque >= 2)
                    {
                        saque = saque - 2;
                        //totalSaque = totalSaque - 2;
                        nota2 = nota2 + 1;

                    }
                }


                #region saida
                
                Console.WriteLine(string.Format("Retire {0} de R$ 200,00 ", nota200));
                Console.WriteLine(string.Format("Retire {0} de R$ 100,00 ", nota200));
                Console.WriteLine(string.Format("Retire {0} de R$ 50,00 ", nota50));
                Console.WriteLine(string.Format("Retire {0} de R$ 20,00 ", nota20));
                Console.WriteLine(string.Format("Retire {0} de R$ 10,00 ", nota10));
                Console.WriteLine(string.Format("Retire {0} de R$ 5,00 ", nota5));
                Console.WriteLine(string.Format("Retire {0} de R$ 2,00 ", nota2));
                Console.WriteLine(string.Format("Operacao realizada com sucesso ! Total do Saque : {0} ", totalSaque));
                #endregion
            }

            else
            {
                Console.WriteLine("Escolha um valor multiplo de dois");
                //Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ReadKey();
            }
}
    }
}
