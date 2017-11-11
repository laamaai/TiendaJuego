using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class Juego
    {
        //Propiedades
        public int Id { get; set; }
        public int IdGenero { get; set; }
        public string NombreJuego { get; set; }
        public decimal Precio { get; set; }
        //Constructores
        public Juego() { }
        public Juego(int id, int idGenero, string nombre, decimal precio)
        {
            this.Id = id;
            this.IdGenero = IdGenero;
            this.NombreJuego = nombre;
            this.Precio = precio;
        }

       

    }
}
