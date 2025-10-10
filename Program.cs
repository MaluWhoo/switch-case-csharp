using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SWTICH E CASE

            // Dias da Semanda

            /* int diaSemana;

            Console.WriteLine("Digite um número de 1 a 7:");
            diaSemana = int.Parse(Console.ReadLine());

            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;

                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;

                default:
                    Console.WriteLine("Número inválido! Tente novamente");
                    break;

            }
            */

            // Meses do Ano + Dados de Input


            /*
            int mes;

            // Algoritm em que o usuario vai colocar seu mes de aniversario e o programa vai retornar o nome do mes

            Console.WriteLine("Digite o número do seu mês: ");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1: Console.WriteLine("Janeiro"); break;
                case 2: Console.WriteLine("Fevereiro"); break;
                case 3: Console.WriteLine("Março"); break;
                case 4: Console.WriteLine("Abril"); break;
                case 5: Console.WriteLine("Maio"); break;
                case 6: Console.WriteLine("Junho"); break;
                case 7: Console.WriteLine("Julho"); break;
                case 8: Console.WriteLine("Agosto"); break;
                case 9: Console.WriteLine("Setembro"); break;
                case 10: Console.WriteLine("Outubro"); break;
                case 11: Console.WriteLine("Novembro"); break;
                case 12: Console.WriteLine("Dezembro"); break;
                default: Console.WriteLine("Número Inválido! Tente Novamente!"); break;
            }
            */


            // Crie um programa que mostre este menu ao usuário: 1 - Cadastrar; 2 - Listar Usuários; 3 - Excluir Usuários; 4 - Sair.

            // Primeiro criar um menu de navegações

            int opcao;

            Console.WriteLine("Menu de Navegação");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Listar Usuários"); 
            Console.WriteLine("3 - Excluir Usuários");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("Digite a opção desejada: ");


            opcao = int.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1: Console.WriteLine("Cadastrar"); break;
                case 2: Console.WriteLine("Listar Usuários"); break;
                case 3: Console.WriteLine("Excluir Usuários"); break;
                case 4: Console.WriteLine("Sair"); break;   
                default: Console.WriteLine("Número Inválido! Tente Novamente!"); break;

            }



            Console.ReadKey();
            Console.Beep();

        }
    }
}
