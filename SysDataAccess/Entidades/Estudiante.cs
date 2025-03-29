using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysDataAccess.Entidades
{
    [Table("Estudiantes")]
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        private DateTime _fechaNacimiento;

        public int Edad { get {
                var FechaActual = DateTime.Today;
                int Edad = FechaActual.Year - _fechaNacimiento.Year;

                if (FechaActual < _fechaNacimiento.AddYears(Edad))
                {
                    Edad--;
                }

                return Edad;
            }}

        public string NombreCompleto { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get { return _fechaNacimiento; }set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("No puede ingresar una fecha de nacimiento futura");
                }

                _fechaNacimiento = value;
            }
        }

        public string Telefono { get; set; }
        public string Direccion { get; set; }


        
        public virtual string MostrarInfo()
        {
            return $"Datos del estudiante: {NombreCompleto} \n Dirección: {Direccion}\n Edad: {Edad}";
        }

    }
}
