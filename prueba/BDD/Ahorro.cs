using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.BDD
{
    class Ahorro
    {
        public int id { get; set; }
        public decimal monto { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
       
        public int id_objetivo { get; set; } // <--- importante
    }



}
