using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXEC 1: int para float é possível, porém, float para int não é possível. Float é um número com casa decimal. Ex: não se dá para transformar um 3,5 em um 3.


            //int num1=5
            //    float num
            //    num = num1
            //    num1 = num

            //não é possíevl fazer uma conversão direta

            //EXEC 2 

            //RESPOSTA: O console.readline é usado para se ler uma linha, e o outro (console.read) utilizado para ler o próximo caractere do fluxo de entrada padrão. 


            //EXEC 3 

            // Resposta: a quantidade de caracteres tem que ser usado.
            // Ex: int número inteiro positivo (1,2,3,50...)
            // float: núemros reais, declarar uma variável como sendo um número de ponto flutuante (3.0f, 12.4f...)
            // double: números reais com casa decimal (12.5, 6,9, 2,11...) 

            //EXEC 4

            //int num, num2, num3;

            //Console.WriteLine("digite um valor:");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2*2 > 10 )
            //    Console.WriteLine("mensagem 1");
            //else
            //    Console.WriteLine("mensagem 2");

            //O número 8 obteve a resposta "mensagem 2", o 27 é igual a "mensagem 2" e o número 28 "mensagem 1"

            //EXEC 5 

            //float velocidade, temp, pos, posF;

            //Console.WriteLine("quantos km/h o obejto está se movimentando?");
            //velocidade = float.Parse(Console.ReadLine());
            //Console.WriteLine("Por quanto tempo esse obejeto se moveu?");
            //temp = float.Parse(Console.ReadLine());
            //Console.WriteLine("qual é a posição inical dele? ");
            //pos = float.Parse(Console.ReadLine());
            //posF = pos + (velocidade * temp);
            //Console.WriteLine("sua posição final é" + posF);

            //EXEC 6 

            //int num;

            //Console.WriteLine("digite um número");
            //num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 5 == 0 && num % 10 == 0)
            //{
            //    Console.WriteLine("seu número é divisivel por 3 e 5 e 10");
            //}

            //else if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("seu número é divisivel por 3 e 5");
            //}
            //else
            //{
            //    if (num % 3 == 0)
            //    {
            //        Console.WriteLine("ele é divisilvel por 3");
            //    }
            //    else if (num % 5 == 0)
            //    {
            //        Console.WriteLine("ele é divisilvel por 5");
            //    }
            //    else
            //    {
            //        Console.WriteLine("ele não é divisilvel por 3 ou 5");
            //    }
            //}

            //EXEC 7

            //         int DIST = 100; 

            //       Console.WriteLine("Digite a distância entre a sua casa e a escola em km: ");
            //        int DistCasa = int.Parse(Console.ReadLine());

            //        int tempo = 0;

            //        if (DistCasa < 12)
            //        {
            //            tempo = 14;
            //        }
            //        else if (DistCasa < 29)
            //        {
            //            tempo = 17;
            //        }
            //        else if (DistCasa < 55)
            //        {
            //            tempo = 13;
            //        }
            //        else if (DistCasa < 82)
            //        {
            //            tempo = 15;
            //        }
            //        else if (DistCasa <= 100)
            //        {
            //            tempo = 12;
            //        }

            //        Console.WriteLine("O tempo necessário para chegar à escola é de " + tempo + " minutos.");
            //        Console.ReadKey();
            //    }
            //}
            //}


            // EXEC 8

            //        double precoUM, custo, ImpLuc, valorTotal, lucroLiquido, ImpDev;
            //        int quant;
            //        string marca;

            //        Console.WriteLine("qual é a marca do produto?");
            //        marca = Console.ReadLine();

            //        Console.WriteLine("quantas unidades você irá comprar?");
            //        quantidade = int.Parse(Console.ReadLine());

            //        switch (marca.ToUpper())
            //        {
            //            case "ROYAL":
            //                precoUM = 129.50;
            //                custo = 77.5;
            //                ImpLuc = 33;
            //                break;
            //            case "WISKAS":
            //                precoUM = 182.78;
            //                custo = 89.7;
            //                ImpLuc = 27.5;
            //                break;
            //            case "GOLDEN":
            //                precoUM = 159.46;
            //                custo = 71.7;
            //                ImpLuc = 22.5;
            //                break;
            //            case "NUTRIEN":
            //                precoUM = 144.80;
            //                custo = 88.9;
            //                ImpLuc = 25;
            //                break;
            //            case "SPECIAL CAT":
            //                precoUM = 205.40;
            //                custo = 83.24;
            //                ImpLuc = 22;
            //                break;
            //            case "MARBA":
            //                precoUM = 125.10;
            //                custo = 90.4;
            //                impLuc = 17.9;
            //                break;
            //            case "GATUS":
            //                precoUM = 133.99;
            //                custo = 94.6;
            //                ImpLuc = 20;
            //                break;
            //            default:
            //                Console.WriteLine("Marca inválida.");
            //                return;
            //        }

            //        valorTotal = quant * precoUM;
            //        lucroLiquido = (precoUM - custo) - (ImpLuc / 100) * (precoUM - custo);
            //        ImpDev = (ImpLuc / 100) * (precoUM - custo) * quant;

            //        Console.WriteLine("Valor total da compra: R$" + valorTotalCompra.ToString("F2"));
            //        Console.WriteLine("Lucro líquido por unidade: R$" + lucroLiquido.ToString("F2"));
            //        Console.WriteLine("Imposto devido: R$" + impostoDevido.ToString("F2"));
            //    }
            //}











        }
    }
}