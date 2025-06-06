using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finanzasApp.BDD
{
    class Movimiento
    {
        public int id { get; set; }
        public String tipo { get; set; }
        public double monto { get; set; }
        public String categoria { get; set; } //comida, transporte, gym , gasto imprevisto
        public DateTime fecha { get; set; }
        public String descripcion { get; set; }

        public Movimiento() { }

        public Movimiento(string tipo, double monto, string categoria, DateTime fecha, string descripcion)
        {
            this.tipo = tipo;
            this.monto = monto;
            this.categoria = categoria;
            this.fecha = fecha;
            this.descripcion = descripcion;

        }



    }
}
