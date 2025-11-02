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

    public partial class FrmPantallaBajas : Form
    {
        /// <summary>
        /// Formulario para dar de baja (eliminar) Productos y Artistas existentes de la base de datos.
        /// </summary>
        public FrmPantallaBajas()
        {
            InitializeComponent();
        }

        private void btnBajasRegresar_Click(object sender, EventArgs e)
        {
            FrmPantallaInicial nuevoFormulario = new FrmPantallaInicial();

            this.Hide();

            nuevoFormulario.Show();

            nuevoFormulario.FormClosed += (s, args) => this.Close();
        }

        private void lstBajaArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CargarArtistas()
        {
            lstBajaArtistas.Items.Clear();

            List<Artistas> artistas = ConexionMySQL.ObtenerTodosLosArtistas();

            if (artistas.Count == 0)
            {
                lstBajaArtistas.Items.Add("No hay artistas registrados");
                return;
            }

            foreach (var artista in artistas)
            {
                string estado = artista.Activo ? "ACTIVO" : "INACTIVO";
                string item = $"ID: {artista.Id} | {artista.NombreArtistico} | " +
                             $"Edad: {artista.Edad} | " +
                             $"Género: {artista.Genero} | " +
                             $"Especialidad: {artista.Especialidad} | " +
                             $"Estado: {estado}";

                lstBajaArtistas.Items.Add(item);
            }
        }

        /// <summary>
        /// Evento Click del botón "Eliminar Producto".
        /// Valida el ID, pide confirmación y llama a 'EliminarProducto'.
        /// </summary>
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        /// <summary>
        /// (BAJA) Lógica principal para eliminar un producto.
        /// Valida el ID, busca el producto para confirmar, pide confirmación al usuario
        /// y luego llama a 'ConexionMySQL.EliminarProducto'.
        /// </summary>
        private void EliminarProducto()
        {
            if (string.IsNullOrWhiteSpace(txtIdBajaProducto.Text))
            {
                MessageBox.Show("Seleccione un producto de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdBajaProducto.Text, out int id))
            {
                MessageBox.Show("ID inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar el producto para confirmar
            var producto = ConexionMySQL.ObtenerProductoPorId(id);
            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar eliminación
            DialogResult result = MessageBox.Show(
                $"¿Está seguro de eliminar el producto?\n{producto.Value.Nombre} - {producto.Value.Categoria}",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                ConexionMySQL.EliminarProducto(id);
                MessageBox.Show("Producto eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Evento Click del botón "Eliminar Artista".
        /// Valida el ID, pide confirmación y llama a 'EliminarArtista'.
        /// </summary>
        private void btnEliminarArtista_Click(object sender, EventArgs e)
        {
            EliminarArtista();
        }

        /// <summary>
        /// (BAJA) Lógica principal para eliminar un artista.
        /// Valida el ID, busca el artista para confirmar, pide confirmación al usuario
        /// y luego llama a 'ConexionMySQL.EliminarArtista'.
        /// </summary>
        private void EliminarArtista()
        {
            if (string.IsNullOrWhiteSpace(txtIdBajaArtista.Text))
            {
                MessageBox.Show("Seleccione un artista de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdBajaArtista.Text, out int id))
            {
                MessageBox.Show("ID inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar el artista para confirmar
            var artista = ConexionMySQL.ObtenerArtistaPorId(id);
            if (artista == null)
            {
                MessageBox.Show("Artista no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar eliminación
            DialogResult result = MessageBox.Show(
                $"¿Está seguro de eliminar al artista?\n{artista.Value.NombreArtistico} - {artista.Value.Especialidad}",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                ConexionMySQL.EliminarArtista(id);
                MessageBox.Show("Artista eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarArtistas();
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Limpia los TextBox que muestran los IDs seleccionados.
        /// </summary>
        private void LimpiarCampos()
        {
            txtIdBajaProducto.Clear();
            txtIdBajaArtista.Clear();
        }

        private void lstBajaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// (CONSULTA) Obtiene todos los productos de la BD y los muestra en el ListBox 'lstBajaProductos'.
        /// </summary>
        private void CargarProductos()
        {
            lstBajaProductos.Items.Clear();

            List<Productos> productos = ConexionMySQL.ObtenerTodosLosProductos();

            if (productos.Count == 0)
            {
                lstBajaProductos.Items.Add("No hay productos registrados");
                return;
            }

            foreach (var producto in productos)
            {
                string item = $"ID: {producto.Id} | {producto.Nombre} | " +
                             $"Categoría: {producto.Categoria} | " +
                             $"Precio: {producto.Precio:C2} | " +
                             $"Stock: {producto.Stock}";

                lstBajaProductos.Items.Add(item);
            }
        }
        /// <summary>
        /// (MÉTODO CORREGIDO)
        /// Evento que se dispara al seleccionar un ítem en la lista de Productos.
        /// Llama a 'ExtraerIdDesdeItem' para poner el ID en el TextBox correspondiente.
        /// </summary>
        private void LstBajaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBajaProductos.SelectedIndex != -1)
            {
                string itemSeleccionado = lstBajaProductos.SelectedItem.ToString();
                ExtraerIdDesdeItem(itemSeleccionado, txtIdBajaProducto);
            }
        }

        private void LstBajaArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBajaArtistas.SelectedIndex != -1)
            {
                string itemSeleccionado = lstBajaArtistas.SelectedItem.ToString();
                ExtraerIdDesdeItem(itemSeleccionado, txtIdBajaArtista);
            }
        }

        /// <summary>
        /// Método de ayuda para parsear el texto de un ítem del ListBox
        /// y extraer el número de ID.
        /// </summary>
        /// <param name="item">El texto completo del ítem seleccionado (ej. "ID: 123 | ...").</param>
        /// <param name="txtId">El TextBox donde se escribirá el ID extraído.</param>
        private void ExtraerIdDesdeItem(string item, TextBox txtId)
        {
            // Extraer el ID del formato "ID: 123 | Nombre: ..."
            int inicio = item.IndexOf("ID: ") + 4;
            int fin = item.IndexOf(" |", inicio);

            if (inicio >= 4 && fin > inicio)
            {
                string idStr = item.Substring(inicio, fin - inicio).Trim();
                txtId.Text = idStr;
            }
        }

        private void FrmPantallaBajas_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarArtistas();
        }
    }
}
