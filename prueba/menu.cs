using finanzasApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Resumen());
        }

        //ABRE LAS PESTANAS DEL MENU INICIAL

        /******************************Funcion para el cambio de pantalla de los distintos botones************************************/
        private Form activeForm = null;

        private void openChildForm(Form childForm)//toma el form indicado y lo muestra en el panel central...
        {
            if (activeForm != null) //cierra el ultimo panel que se haya abierto y muestra el
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(childForm);
            panelCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarMovimiento agregarMovimiento = new AgregarMovimiento();
            agregarMovimiento.ShowDialog();
        }
    }
}
