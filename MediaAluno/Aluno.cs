using System;
using System.Globalization;

namespace MediaAluno
{
    class Aluno
    {
        //Atributos - Infos do Aluno
        public string Nome;
        public double N1, N2, N3;

        //Função - Nota Final
        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        //Aluno - Aprovado ou Reprovado
        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Aluno - Nota Restante
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
