using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_OrientacaoAObjetos.Desafios
{
    class Aluno
    {
        private int matricula;
        public int Matricula 
        {
            get { return matricula; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Valor da matrícula não permitido!");
                }
                else
                {
                    matricula = value;
                }
            }
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }
    }
}
