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
    /// Formulario para cambiar (actualizar) la información de Productos y Artistas existentes.
    /// </summary>
    public partial class FrmPantallasCambios : Form
    {
        /// <summary>
        /// Constructor principal del formulario de Cambios.
        /// </summary>
        public FrmPantallasCambios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Click para el botón Regresar.
        /// Oculta este formulario y muestra el formulario inicial.
        /// </summary>
        private void btnCambiosRegresar_Click(object sender, EventArgs e)
        {
            FrmPantallaInicial nuevoFormulario = new FrmPantallaInicial();

            this.Hide();

            nuevoFormulario.Show();

            nuevoFormulario.FormClosed += (s, args) => this.Close();
        }

        // --- LÓGICA DE PRODUCTOS ---

        /// <summary>
        /// Evento Click del botón "Buscar Producto".
        /// Obtiene el ID del TextBox, busca el producto en la BD
        /// y rellena los campos del formulario con la información encontrada.
        /// </summary>
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCambioProducto.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID numérico válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // (CONSULTA) Llama a la BD para obtener el producto
            Productos? producto = ConexionMySQL.ObtenerProductoPorId(id);

            if (producto != null)
            {
                // Rellena los campos con los datos encontrados
                txtCambioNombreProducto.Text = producto.Value.Nombre;
                txtCambioCategoriaProducto.Text = producto.Value.Categoria;
                txtCambioPrecioProducto.Text = producto.Value.Precio.ToString();
                txtCambioStockProducto.Text = producto.Value.Stock.ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCamposProducto(); // Limpia por si había datos viejos
            }
        }

        /// <summary>
        /// Evento Click del botón "Guardar Cambios Producto".
        /// Llama a la lógica de 'CambiarProducto' para validar y guardar.
        /// </summary>
        private void btnCambioProducto_Click(object sender, EventArgs e)
        {
            CambiarProducto();
        }

        /// <summary>
        /// (ACTUALIZACIÓN) Lógica principal para actualizar un producto.
        /// Valida todos los campos, pide confirmación al usuario
        /// y luego llama a 'ConexionMySQL.CambiarProducto'.
        /// </summary>
        private void CambiarProducto()
        {
            if (string.IsNullOrWhiteSpace(txtIdCambioProducto.Text))
            {
                MessageBox.Show("Primero busque un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdCambioProducto.Text, out int id))
            {
                MessageBox.Show("ID inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtCambioNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCambioCategoriaProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCambioPrecioProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCambioStockProducto.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de tipos de dato
            if (!double.TryParse(txtCambioPrecioProducto.Text, out double precio) || precio <= 0)
            {
                MessageBox.Show("Precio debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCambioStockProducto.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Stock debe ser un número positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creación del objeto actualizado
            Productos productoActualizado = new Productos(
                id: id,
                nombre: txtCambioNombreProducto.Text,
                categoria: txtCambioCategoriaProducto.Text,
                precio: precio,
                stock: stock
            );

            // Confirmación del usuario
            DialogResult result = MessageBox.Show(
                $"¿Está seguro de modificar el producto?\nID: {id} - {txtCambioNombreProducto.Text}",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                ConexionMySQL.CambiarProducto(productoActualizado);
                MessageBox.Show("Producto modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposProducto();
            }
        }

        /// <summary>
        /// Limpia todos los campos de texto del panel de Productos.
        /// </summary>
        private void LimpiarCamposProducto()
        {
            txtIdCambioProducto.Clear();
            txtCambioNombreProducto.Clear();
            txtCambioCategoriaProducto.Clear();
            txtCambioPrecioProducto.Clear();
            txtCambioStockProducto.Clear();
        }

        /// <summary>
        /// Evento Click del botón "Limpiar" para Productos.
        /// Llama al método 'LimpiarCamposProducto'.
        /// </summary>
        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            LimpiarCamposProducto();
        }


        // --- LÓGICA DE ARTISTAS ---

        /// <summary>
        /// Evento Click del botón "Buscar Artista".
        /// Obtiene el ID del TextBox, busca el artista en la BD
        /// y rellena los campos del formulario, incluyendo los RadioButtons.
        /// </summary>
        private void btnBuscarArtista_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCambioArtista.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID numérico válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // (CONSULTA) Llama a la BD para obtener el artista
            Artistas? artista = ConexionMySQL.ObtenerArtistaPorId(id);

            if (artista != null)
            {
                // Rellena los campos de texto
                txtCambioNombreArtista.Text = artista.Value.NombreArtistico;
                txtCambioEdadArtista.Text = artista.Value.Edad.ToString();
                txtCambioGeneroArtista.Text = artista.Value.Genero;
                txtCambioEspecialidadArtista.Text = artista.Value.Especialidad;
                txtCambioSalarioArtista.Text = artista.Value.SalarioBase.ToString();

                // Asigna el RadioButton basado en el valor booleano 'Activo'
                if (artista.Value.Activo == true)
                {
                    rbtnCambioActivoArtista.Checked = true;
                }
                else
                {
                    rbtnCambioNoActivoArtista.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Artista no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCamposArtista(); // Limpia por si había datos viejos
            }
        }


        /// <summary>
        /// Evento Click del botón "Guardar Cambios Artista".
        /// Llama a la lógica de 'CambiarArtista' para validar y guardar.
        /// </summary>
        private void btnCambioArtista_Click(object sender, EventArgs e)
        {
            CambiarArtista();
        }

        /// <summary>
        /// (ACTUALIZACIÓN) Lógica principal para actualizar un artista.
        /// Valida todos los campos, pide confirmación al usuario
        /// y luego llama a 'ConexionMySQL.CambiarArtista'.
        /// </summary>
        private void CambiarArtista()
        {
            if (string.IsNullOrWhiteSpace(txtIdCambioArtista.Text))
            {
                MessageBox.Show("Primero busque un artista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdCambioArtista.Text, out int id))
            {
                MessageBox.Show("ID inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de campos
            if (string.IsNullOrWhiteSpace(txtCambioNombreArtista.Text) ||
                string.IsNullOrWhiteSpace(txtCambioEdadArtista.Text) ||
                string.IsNullOrWhiteSpace(txtCambioGeneroArtista.Text) ||
                string.IsNullOrWhiteSpace(txtCambioEspecialidadArtista.Text) ||
                string.IsNullOrWhiteSpace(txtCambioSalarioArtista.Text) ||
                (!rbtnCambioActivoArtista.Checked && !rbtnCambioNoActivoArtista.Checked))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de tipos de dato
            if (!int.TryParse(txtCambioEdadArtista.Text, out int edad) || edad < 18 || edad > 70)
            {
                MessageBox.Show("Edad debe ser entre 18 y 70 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCambioSalarioArtista.Text, out double salario) || salario <= 0)
            {
                MessageBox.Show("Salario debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creación del objeto actualizado
            Artistas artistaActualizado = new Artistas(
                id: id,
                nombreArtistico: txtCambioNombreArtista.Text,
                edad: edad,
                genero: txtCambioGeneroArtista.Text,
                especialidad: txtCambioEspecialidadArtista.Text,
                salarioBase: salario,
                activo: rbtnCambioActivoArtista.Checked
            );

            // Confirmación del usuario
            DialogResult result = MessageBox.Show(
                $"¿Está seguro de modificar al artista?\nID: {id} - {txtCambioNombreArtista.Text}",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                ConexionMySQL.CambiarArtista(artistaActualizado);
                MessageBox.Show("Artista modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposArtista();
            }
        }

        /// <summary>
        /// Limpia todos los campos de texto y RadioButtons del panel de Artistas.
        /// </summary>
        private void LimpiarCamposArtista()
        {
            txtIdCambioArtista.Clear();
            txtCambioNombreArtista.Clear();
            txtCambioEdadArtista.Clear();
            txtCambioGeneroArtista.Clear();
            txtCambioEspecialidadArtista.Clear();
            txtCambioSalarioArtista.Clear();
            rbtnCambioActivoArtista.Checked = false;
            rbtnCambioNoActivoArtista.Checked = false;
        }

        /// <summary>
        /// Evento Click del botón "Limpiar" para Artistas.
        /// Llama al método 'LimpiarCamposArtista'.
        /// </summary>
        private void btnLimpiarArtista_Click(object sender, EventArgs e)
        {
            LimpiarCamposArtista();
        }

    }
}