using finanzasApp.BDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static prueba.BDD.Categoria;

namespace prueba
{
    public partial class AgregarMovimiento : Form
    {
        public int id;
        public AgregarMovimiento()
        {

            InitializeComponent();
            this.Load += Form1_Load;
        }



        public AgregarMovimiento(string tex,int id , string tipo,string monto, string categoria, string descripcion, DateTime fecha)
        {
            InitializeComponent();
       
            lbTex.Text =tex;
            this.id = id;
            tbMonto.Text = monto;
            comboCategoria.Text = categoria;
            comboTipo.Text = tipo;
            richDescrip.Text = descripcion;
            dateFecha.Value = fecha;

            btGuardar.Text = "Actualizar";

          
        }
        private void button1_Click(object sender, EventArgs e)
        {

          
            if (btGuardar.Text.Equals("Actualizar"))
            {
                modificarDatos();
            }
            else
            {
                agregarMovimiento();
            };
        }


        public void agregarMovimiento()
        {
            Movimiento mv = new Movimiento(
               comboTipo.Text,
               Convert.ToDouble(tbMonto.Text),
               comboCategoria.Text,
               dateFecha.Value,
               richDescrip.Text);
          


            Funciones_RegistroMovimiento.AgregarMovimiento(mv); //debo verificar que si hay un error lo avise
            this.Close(); //cerramos el modal
        }

        public void modificarDatos()
        {
            //Creamos el objeto para que entre por el metodo
            Movimiento mv = new Movimiento(
              comboTipo.Text,
              Convert.ToDouble(tbMonto.Text),
              comboCategoria.Text,
              dateFecha.Value,
              richDescrip.Text);
            mv.id = id;
                 
            Funciones_RegistroMovimiento.EditarMovimiento(mv);
            this.Close(); //cerramos el modal
        }

        //evento para mostrar las categorias que quiero tener ingresadas
        private void Form1_Load(object sender, EventArgs e)
        {
            comboCategoria.Items.AddRange(Categorias.Todas);
            comboTipo.Items.AddRange(Tipo.Todas);
        }
    }
}
