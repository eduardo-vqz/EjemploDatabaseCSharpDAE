using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDatabaseCSharpDAE.Core.Clases
{
    public class Propietario
    {
        private int idPropietario;  // PK
        private string nombre;   // NOT NULL
        private string apellido;     // NOT NULL
        private string dUI;   // UNIQUE, NOT NULL (formato 00000000-0)
        private string telefono;    // NULL
        private string direccion;    // NULL

        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string DUI { get => dUI; set => dUI = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
