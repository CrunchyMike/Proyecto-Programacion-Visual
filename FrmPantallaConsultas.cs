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
    /// Formulario para consultar (leer) todos los registros de Productos y Artistas
    /// desde la base de datos y mostrarlos en listas.
    /// </summary>
    public partial class FrmPantallaConsultas : Form
    {
        /// <summary>
        /// Constructor principal del formulario de Consultas.
        /// </summary>
        public FrmPantallaConsultas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Click para el botón Regresar.
        /// Oculta este formulario y muestra el formulario inicial.
        /// </summary>
        private void btnConsultasRegresar_Click(object sender, EventArgs e)
        {
            FrmPantallaInicial nuevoFormulario = new FrmPantallaInicial();

            this.Hide();

            nuevoFormulario.Show();

            nuevoFormulario.FormClosed += (s, args) => this.Close();
        }

        /// <summary>
        /// Evento Click del botón "Consultar Productos".
        /// Llama al método 'MostrarProductos' para poblar la lista.
        /// </summary>
        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            lstConsultaProductos.Visible = true;
            MostrarProductos();
        }

        /// <summary>
        /// (CONSULTA) Obtiene todos los productos de la BD
        /// y los formatea para mostrarlos en el ListBox 'lstConsultaProductos'.
        /// </summary>
        private void MostrarProductos()
        {
            // Limpia la lista para evitar duplicados si se presiona el botón varias veces
            lstConsultaProductos.Items.Clear();

            // Obtiene los datos frescos de la base de datos
            List<Productos> productos = ConexionMySQL.ObtenerTodosLosProductos();

            if (productos.Count == 0)
            {
                lstConsultaProductos.Items.Add("No hay productos registrados");
                return;
            }

            // Itera sobre la lista y añade cada producto al ListBox
            foreach (var producto in productos)
            {
                string item = $"ID: {producto.Id} | {producto.Nombre} | " +
                             $"Categoría: {producto.Categoria} | " +
                             $"Precio: {producto.Precio:C2} | " + // :C2 formatea como moneda
                             $"Stock: {producto.Stock}";

                lstConsultaProductos.Items.Add(item);
            }
        }

        /// <summary>
        /// Evento Click del botón "Consultar Artistas".
        /// Llama al método 'MostrarArtistas' para poblar la lista.
        /// </summary>
        private void btnConsultarArtistas_Click(object sender, EventArgs e)
        {
            lstConsultaArtistas.Visible = true;
            MostrarArtistas();
        }

        /// <summary>
        /// (CONSULTA) Obtiene todos los artistas de la BD
        /// y los formatea para mostrarlos en el ListBox 'lstConsultaArtistas'.
        /// </summary>
        private void MostrarArtistas()
        {
            // Limpia la lista para evitar duplicados
            lstConsultaArtistas.Items.Clear();

            // Obtiene los datos frescos de la base de datos
            List<Artistas> artistas = ConexionMySQL.ObtenerTodosLosArtistas();

            if (artistas.Count == 0)
            {
                lstConsultaArtistas.Items.Add("No hay artistas registrados");
                return;
            }

            // Itera sobre la lista y añade cada artista al ListBox
            foreach (var artista in artistas)
            {
                string estado = artista.Activo ? "ACTIVO" : "INACTIVO";
                string item = $"ID: {artista.Id} | {artista.NombreArtistico} | " +
                             $"Edad: {artista.Edad} | " +
                             $"Género: {artista.Genero} | " +
                             $"Especialidad: {artista.Especialidad} | " +
                             $"Salario: {artista.SalarioBase:C2} | " + // :C2 formatea como moneda
                             $"Estado: {estado}";

                lstConsultaArtistas.Items.Add(item);
            }
        }
    }
}