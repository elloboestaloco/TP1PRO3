using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Personas
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Color { get; set; }
        public List<String> Gustos { get; set; }
        public Personas(List <String> gustitos, String Nombre, String Apellido, DateTime FechaNacimiento, String Sexo, String Color)
        {
            this.Gustos = gustitos;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.FechaNacimiento = FechaNacimiento;
            this.Sexo = Sexo;
            this.Color = Color;
        }
    }
}
