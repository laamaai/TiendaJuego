using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class Genero
    {
       
       //Propiedades
        public int Id { get; set; }
        public string TipoGenero { get; set; }
        //Constructores
        public Genero() { }
        public Genero(int id, string genero)
        {
            this.Id = id;
            this.TipoGenero = genero;
        }

    }
}
