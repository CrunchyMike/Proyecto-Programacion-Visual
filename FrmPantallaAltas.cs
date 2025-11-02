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
    /// <summary>
    /// Formulario para dar de alta nuevos Productos y Artistas en la base de datos.
    /// </summary>
    public partial class FrmPantallaAltas : Form
    {
        /// <summary>
        /// Constructor principal del formulario de Altas.
        /// </summary>
        public FrmPantallaAltas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Click para el botón Regresar.
        /// Oculta este formulario y muestra el formulario inicial.
        /// </summary>
        private void btnAltasRegresar_Click(object sender, EventArgs e)
        {
            FrmPantallaInicial nuevoFormulario = new FrmPantallaInicial();

            this.Hide();

            nuevoFormulario.Show();

            nuevoFormulario.FormClosed += (s, args) => this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento Click del botón "Alta Producto".
        /// Valida los campos de texto y, si son correctos,
        /// crea un objeto Productos y lo envía a la base de datos
        /// llamando a ConexionMySQL.AltaProducto().
        /// </summary>
        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación de campos (recuerda que el ID ya no se pide)
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoriaProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecioProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtStockProducto.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Creación del objeto Producto
                Productos nuevoProducto = new Productos(
                    id: 0, // El ID lo asigna la BD
                    nombre: txtNombreProducto.Text,
                    categoria: txtCategoriaProducto.Text,
                    precio: double.Parse(txtPrecioProducto.Text),
                    stock: int.Parse(txtStockProducto.Text)
                );

                // 3. Llamada a la BD (el método ya muestra el MessageBox)
                ConexionMySQL.AltaProducto(nuevoProducto);

                // 4. Limpieza de campos
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que los datos numéricos sean válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento Click del botón "Alta Artista".
        /// Valida los campos de texto y, si son correctos,
        /// crea un objeto Artistas y lo envía a la base de datos
        /// llamando a ConexionMySQL.AltaArtista().
        /// </summary>
        private void btnAltaArtista_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación de campos
                if (string.IsNullOrWhiteSpace(txtNombreArtista.Text) ||
                    string.IsNullOrWhiteSpace(txtEdadArtista.Text) ||
                    string.IsNullOrWhiteSpace(txtGeneroArtista.Text) ||
                    string.IsNullOrWhiteSpace(txtEspecialidadArtista.Text) ||
                    string.IsNullOrWhiteSpace(txtSalarioArtista.Text) ||
                    (!rbtnActivoArtista.Checked && !rbtnNoActivoArtista.Checked)) // Validar radio buttons
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Creación del objeto Artista
                Artistas nuevoArtista = new Artistas(
                    id: 0, // El ID lo asigna la BD
                    nombreArtistico: txtNombreArtista.Text,
                    edad: int.Parse(txtEdadArtista.Text),
                    genero: txtGeneroArtista.Text,
                    especialidad: txtEspecialidadArtista.Text,
                    salarioBase: double.Parse(txtSalarioArtista.Text),
                    activo: rbtnActivoArtista.Checked
                );

                // 3. Llamada a la BD (el método ya muestra el MessageBox)
                ConexionMySQL.AltaArtista(nuevoArtista);

                // 4. Limpieza de campos
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que los datos numéricos sean válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Limpia todos los campos de entrada en ambos group boxes (Artistas y Productos).
        /// </summary>
        private void LimpiarCampos()
        {
            // Limpiar campos de Artista
            // (Se asume que txtIdArtista fue eliminado del formulario)
            txtNombreArtista.Clear();
            txtEdadArtista.Clear();
            txtGeneroArtista.Clear();
            txtEspecialidadArtista.Clear();
            txtSalarioArtista.Clear();
            rbtnActivoArtista.Checked = false;
            rbtnNoActivoArtista.Checked = false;
            txtNombreArtista.Focus(); // Pone el cursor en el primer campo

            // Limpiar campos de Producto
            // (Se asume que txtIdProducto fue eliminado del formulario)
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtCategoriaProducto.Clear();
            txtStockProducto.Clear();
        }

        private void txtSalarioArtista_TextChanged(object sender, EventArgs e)
        {

        }
    }
}