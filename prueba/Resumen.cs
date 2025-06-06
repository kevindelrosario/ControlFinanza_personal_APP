using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finanzasApp.BDD;
using prueba;
using prueba.BDD;

namespace finanzasApp
{
    public partial class Resumen : Form
    {
        private String tipo = "";
        private string monto = "";
        private String categoria = "";
        private String descripcion = "";
        private DateTime fecha;
        public Resumen()
        {
            InitializeComponent();
            recargar();
        }

        //Encargada de recargar los datos de la interfaz
        public void recargar()
        {
            cargarTotalAhorros();
            mostrarMovimientos();
            obtenerTotal_ingresos();
            obtenerTotal_gastos();
            obtenerTotal_balance();
            dibujarGrafica();
        }

        public  void mostrarMovimientos()
        {
            gridMovimientos.DataSource = Funciones_RegistroMovimiento.MostrarMovimientos();
        }
        public void obtenerTotal_ingresos()
        {
            lbTotalIngreso.Text = Funciones_RegistroMovimiento.ObtenerTotalPorTipo("Ingreso").ToString("c");
        }

        public void obtenerTotal_gastos()
        {
            lbTotalGasto.Text =  Funciones_RegistroMovimiento.ObtenerTotalPorTipo("Gasto").ToString("C"); 
        }

        public void dibujarGrafica()
        {
            //
            this.Grafico.Series["Movimientos"].Points.Clear();


            this.Grafico.Series["Movimientos"].Points.AddXY("Gastos", Funciones_RegistroMovimiento.ObtenerTotalPorTipo("Gasto"));
            this.Grafico.Series["Movimientos"].Points.AddXY("Ingreso", Funciones_RegistroMovimiento.ObtenerTotalPorTipo("Ingreso"));
        }


        public void obtenerTotal_balance()
        {
            decimal balance = Funciones_RegistroMovimiento.ObtenerBalance();
            lbBalanceTotal.Text = balance.ToString("C"); // Muestra como moneda
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarMovimiento agregarMovimiento = new AgregarMovimiento();
            agregarMovimiento.ShowDialog();
            recargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminarMovimiento();
            recargar();

        }

        private void gridMovimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //agregamos los valores a las variables globales para enviar los datos a la interfaz que utilizaremos para modificar.
            lbId.Text = gridMovimientos.SelectedCells[0].Value.ToString();
            tipo = gridMovimientos.SelectedCells[1].Value.ToString();
            monto=gridMovimientos.SelectedCells[2].Value.ToString();
            categoria = gridMovimientos.SelectedCells[3].Value.ToString();
            descripcion = gridMovimientos.SelectedCells[4].Value.ToString();
            fecha = (DateTime)gridMovimientos.SelectedCells[5].Value;
        }
        //funcion reiniciar datos
        public void reiniciarDatos()
        {
           DialogResult resultado = MessageBox.Show(
            "¿Estás seguro de que quieres eliminar todos los movimientos?",
            "Confirmar reinicio",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (resultado == DialogResult.Yes)
        {
            Funciones_RegistroMovimiento.EliminarTodosLosMovimientos();
            recargar(); 
            }
        }
        public void cargarTotalAhorros()
        {
            lbAhorro.Text = Funciones_RegistroAhorro.ObtenerTotalAhorros().ToString();
        }
        public void eliminarMovimiento() {

            if (lbId.Text.Equals("0"))
            {
                MessageBox.Show("Debes seleccionar un movimiento de la tabla...");
            }
            else
            {
                DialogResult resultado2 = MessageBox.Show(
             "¿Estás seguro de que quieres eliminar este movimiento?",
             "Confirmar eliminar",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
                );

                if (resultado2 == DialogResult.Yes)
                {
                    Funciones_RegistroMovimiento.EliminarMovimientoPorId(Convert.ToInt32(lbId.Text));
                    recargar();
                }

            }
        }
        //boton reiniciar datos
        private void btReiniciar_Click(object sender, EventArgs e)
        {
            reiniciarDatos();
         }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbId.Text.Equals("0"))
            {
                MessageBox.Show("Debes seleccionar un movimiento de la tabla...");
            }
            else
            {
                string tex = "Modificar \nMovimiento";
                AgregarMovimiento agregarMovimiento = new AgregarMovimiento(tex, Convert.ToInt32(lbId.Text), tipo, monto, categoria, descripcion, fecha);
                agregarMovimiento.ShowDialog();
                recargar();
            }
            
        }

        private void btAhorro_Click(object sender, EventArgs e)
        {
            Ahorros ahorro = new Ahorros();
            ahorro.ShowDialog();
            recargar();
        }
    }
}
