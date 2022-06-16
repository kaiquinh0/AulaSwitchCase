using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Peça uma data para o usuário;
            //2 - Mostre o mês da data em extenso;
            string mesExtenso =  null;
            int mes, dia, ano;
            Console.WriteLine("Digite a data: \n[Formato: DD/MM/AAAA]");
            var numero1 = Convert.ToDateTime(Console.ReadLine());
            mes = numero1.Month;
            dia = numero1.Day;
            ano = numero1.Year;
            switch (mes)
            {
                case 1:
                    mesExtenso = "Janeiro";
                    break;
                case 2:
                    mesExtenso = "Fevereiro";
                    break;
                case 3:
                    mesExtenso = "Março";
                    break;
                case 4:
                    mesExtenso = "Abril";
                    break;
                case 5:
                    mesExtenso = "Maio";
                    break;
                case 6:
                    mesExtenso = "Junho";
                    break;
                case 7:
                    mesExtenso = "Julho";
                    break;
                case 8:
                    mesExtenso = "Agosto";
                    break;
                case 9:
                    mesExtenso = "Setembro";
                    break;
                case 10:
                    mesExtenso = "Outubro";
                    break;
                case 11:
                    mesExtenso = "Novembro";
                    break;
                case 12:
                    mesExtenso = "Dezembro";
                    break;
            }
            Console.WriteLine(dia + " de " + mesExtenso + " de " + ano);
            Console.ReadKey();
        }
    }
}
