using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.BDD
{
    class Categoria
    {
        public static class Categorias
        {
            public const string Comida = "Comida";
            public const string Transporte = "Transporte";
            public const string Gym = "Gym";
            public const string Nomina = "Nomina";
            public const string Alquiler = "Alquiler";
            public const string Educacion = "Educación";
            public const string GastoImprevisto = "Gasto imprevisto";
            public const string Otro = "Otro";

            public static readonly string[] Todas = {Nomina, Comida, Transporte, Gym, GastoImprevisto, Alquiler, Educacion, Otro };
        }

        public static class Tipo
        {
            public const string Gasto = "Gasto";
            public const string Ingreso = "Ingreso";
          

            public static readonly string[] Todas ={ Gasto, Ingreso };
        }

    }
}
