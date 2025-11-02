using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAME_Proyecto_StripClubV2
{
    public partial class FrmPantallaInicial : Form
    {
        public FrmPantallaInicial()
        {
            InitializeComponent();

        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            FrmPantallaAltas nuevoFormulario = new FrmPantallaAltas();

            this.Hide();

            nuevoFormulario.Show();

            nuevoFormulario.FormClosed += (s, args) => this.Close();
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            FrmPantallasCambios nuevoFormulario = new FrmPantallasCambios();

            this.Hide();

            nuevoFormulario.Show();

            nuevoFormulario.FormClosed += (s, args) => this.Close();
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            FrmPantallaBajas nuevoFormulario = new FrmPantallaBajas();

            this.Hide();

            nuevoFormulario.Show();

            nuevoFormulario.FormClosed += (s, args) => this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FrmPantallaConsultas nuevoFormulario = new FrmPantallaConsultas();

            this.Hide();

            nuevoFormulario.Show();

            nuevoFormulario.FormClosed += (s, args) => this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
