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
using prueba.BDD;

namespace prueba
{
    public partial class Ahorros : Form
    {
        public Ahorros()
        {
            InitializeComponent();
            recargarTODO();
          
           // this.Load += Formulario_Load; //se encarga de cargar los objetivos al comboBoxObjetivos
        }

        public void recargarTODO()
        {
            MostrarTotales();
            cargarAhorros();
            this.Load += Formulario_Load; //se encarga de cargar los objetivos al comboBoxObjetivos
        }

        public void cargarAhorros()
        {
            gridAhorros.DataSource = Funciones_RegistroAhorro.MostrarAhorros();
        }

        private void MostrarTotales()
        {
            DataTable datos = Funciones_RegistroAhorro.ObtenerTotalesPorObjetivo();
            gridTotales.DataSource = datos;
        }

        public void agregarAhorro()
        {
            

            Ahorro nAhorro = new Ahorro();
            nAhorro.monto = Convert.ToDecimal(tbMonto.Text);
            nAhorro.descripcion = tbDescripcion.Text;
            nAhorro.fecha = dtFecha.Value;
            nAhorro.id = Funciones_RegistroAhorro.ObtenerIdPorNombre(comboBoxObjetivos.Text);

            MessageBox.Show(Funciones_RegistroAhorro.ObtenerIdPorNombre(comboBoxObjetivos.Text).ToString());
           Funciones_RegistroAhorro.AgregarAhorro(nAhorro);

            recargarTODO();
        }

        //Funcion encargada de ingresar los objetivos en el comboBox para que sean las opciones del usuario
        private void Formulario_Load(object sender, EventArgs e)
        {
            comboBoxObjetivos.Items.Clear();

            // Opción por si no quieres asignar ningún objetivo
            comboBoxObjetivos.Items.Add(new ObjetivoAhorro { Id = 0, Nombre = "Sin objetivo" });

            var objetivos = Funciones_RegistroAhorro.ObtenerObjetivos();

            foreach (var obj in objetivos)
            {
                comboBoxObjetivos.Items.Add(obj);

            }

            comboBoxObjetivos.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarAhorro();
        }
    }
}
