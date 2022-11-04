using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendEjemplo.Models
{
    public class Garage:List<Coche>
    {
        public Garage()
    {
        this.Add(new Coche(1, "Tesla", "Rockstar", "Domingo Garcia"));
        this.Add(new Coche(2, "Tesla", "Rockstar", "Antonio Leon"));
        this.Add(new Coche(3, "Tesla", "Rockstar", "Armando gomez"));
        this.Add(new Coche(4, "Tesla", "Rockstar", "Jorge Eduardo"));
        }
    }
}