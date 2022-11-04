using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendEjemplo.Models
{
    public class Coche
    {
        public int IdCoche { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Propetario { get; set; }
        public Coche(int IdCoche, string Marca, string Modelo, string Propetario)
        {
            this.IdCoche = IdCoche;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Propetario = Propetario;
        }
    }
}