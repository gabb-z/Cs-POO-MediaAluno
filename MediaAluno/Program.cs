using System;
using System.Globalization;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instânciação de Objeto - Aluno
            Aluno aluno = new Aluno();

            //Entrada de Dados - Infos do Aluno
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Saída de Dados - Nota do Aluno
            Console.WriteLine("Nota final: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            //Condição - Aprovado ou Reprovado
            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram: " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos!");
            }
        }
    }
}
