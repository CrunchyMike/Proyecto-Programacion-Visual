using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAME_Proyecto_StripClubV2
{
    public struct Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Productos(int id, string nombre, string categoria, double precio, int stock)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Stock = stock;
        }
    }

    public struct Artistas
    {
        public int Id { get; set; }
        public string NombreArtistico { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string Especialidad { get; set; }
        public double SalarioBase { get; set; }
        public bool Activo { get; set; }

        public Artistas(int id, string nombreArtistico, int edad, string genero, string especialidad, double salarioBase, bool activo)
        {
            Id = id;
            NombreArtistico = nombreArtistico;
            Edad = edad;
            Genero = genero;
            Especialidad = especialidad;
            SalarioBase = salarioBase;
            Activo = activo;
        }
    }

    public static class DatosCompartidos
    {

    }
}