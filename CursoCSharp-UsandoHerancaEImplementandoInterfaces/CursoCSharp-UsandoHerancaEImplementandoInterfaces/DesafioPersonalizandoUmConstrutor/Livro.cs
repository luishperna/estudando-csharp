using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_UsandoHerancaEImplementandoInterfaces.DesafioPersonalizandoUmConstrutor
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; private set; }
        public string ISBN { get; private set; }
        public int AnoDePublicacao { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumeroDePaginas { get; set; }
        public string PaisDePublicacao { get; set; }

        public Livro(string isbn, string titulo)
        {
            this.ISBN = isbn;
            this.Titulo = titulo;
        }
    }
}
