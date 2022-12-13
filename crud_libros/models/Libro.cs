using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_libros.models
{
    internal class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Paginas { get; set; }


        public string NombreAutor
        {
            get { return Nombre + " " + Autor; }
        }

        public override string ToString()
        {
            return NombreAutor;
        }

    }


}
