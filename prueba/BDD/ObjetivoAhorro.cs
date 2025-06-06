using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.BDD
{
    public class ObjetivoAhorro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre; // Esto es lo que verá el usuario en el ComboBox
        }
    }
}
