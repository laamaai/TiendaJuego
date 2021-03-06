﻿using System.Collections.Generic;
using CapaDatos.DSTiendaJuegosTableAdapters;
using CapaClases;
//Class Curso
//public string Nombre
// public static string Numero
//Para acceder a nombre: Curso cur new Curso()
//cur.nombre
//Curso.numero (tiene que ser la clase, no hay que crear ningun objeto)
namespace CapaDatos{
    public class Gestion
    {
        private DSTiendaJuegos ds; //DataSet l

        public Gestion() 
        {
            CrearDataSet();
        }

        public List <Genero> Generos()
        {
             var lista = new List<Genero>();
             foreach (var dr in ds.Genero)
             {
                lista.Add(new Genero(dr.IdGenero, dr.Genero));
             }
            return lista;
        }

        public List <Juego> Juegos()
        {
            var lista = new List<Juego>();
            foreach (var dr in ds.Juegos)
            {
                lista.Add(new Juego(dr.IdJuego, dr.IdGenero, dr.Juego, dr.Precio));
            }
            return lista;
        }

        private void CrearDataSet()
        {
            ds = new DSTiendaJuegos();
            JuegosTableAdapter daJuegos = new JuegosTableAdapter();
            daJuegos.Fill(ds.Juegos);
            GeneroTableAdapter daGenero = new GeneroTableAdapter();
            daGenero.Fill(ds.Genero);
        }

    }
}
