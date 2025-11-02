using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MAME_Proyecto_StripClubV2
{
    /// <summary>
    /// Clase estatica que maneja toda la comunicacion (CRUD) 
    /// con la base de datos MySQL para Productos y Artistas.
    /// Reemplaza la funcionalidad de 'DatosCompartidos'
    /// que se uso en la version anterior.
    /// </summary>
    public static class ConexionMySQL
    {
        // --- CADENA DE CONEXIÓN ---
        private static string cadenaConexion = "server=127.0.0.1;port=3306;database=stripclub;uid=root;password=Debiltuputamadre1234*;";

        /// <summary>
        /// Crea y devuelve un objeto de conexion a la base de datos.
        /// </summary>
        /// <returns>Un objeto MySqlConnection.</returns>
        private static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }

        // --- CRUD DE PRODUCTOS ---

        /// <summary>
        /// (ALTA) Registra un nuevo producto en la base de datos.
        /// El ID del producto es ignorado ya que la BD lo genera automaticamente.
        /// </summary>
        /// <param name="producto">El objeto Productos con la información a guardar.</param>
        public static void AltaProducto(Productos producto)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO productos (nombre, categoria, precio, stock) VALUES (@nombre, @categoria, @precio, @stock)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@categoria", producto.Categoria);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@stock", producto.Stock);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// (BAJA) Elimina un producto de la base de datos usando su ID.
        /// </summary>
        /// <param name="id">El ID del producto que se desea eliminar.</param>
        public static void EliminarProducto(int id)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "DELETE FROM productos WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// (ACTUALIZACIÓN) Modifica los datos de un producto existente en la base de datos.
        /// </summary>
        /// <param name="producto">El objeto Productos con la informacion actualizada. El ID se usa para encontrar el registro.</param>
        public static void CambiarProducto(Productos producto)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "UPDATE productos SET nombre = @nombre, categoria = @categoria, precio = @precio, stock = @stock WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@categoria", producto.Categoria);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@id", producto.Id);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cambiar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// (CONSULTA) Obtiene una lista de todos los productos registrados en la base de datos.
        /// </summary>
        /// <returns>Una lista (List<Productos>) con todos los productos.</returns>
        public static List<Productos> ObtenerTodosLosProductos()
        {
            List<Productos> lista = new List<Productos>();
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "SELECT id, nombre, categoria, precio, stock FROM productos";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Productos p = new Productos(
                            id: reader.GetInt32("id"),
                            nombre: reader.GetString("nombre"),
                            categoria: reader.GetString("categoria"),
                            precio: reader.GetDouble("precio"),
                            stock: reader.GetInt32("stock")
                        );
                        lista.Add(p);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return lista;
        }

        /// <summary>
        /// (CONSULTA) Busca y devuelve un producto especifico por su ID.
        /// </summary>
        /// <param name="id">El ID del producto a buscar.</param>
        /// <returns>Un objeto Productos si se encuentra. Devuelve null si no se encuentra.</returns>
        public static Productos? ObtenerProductoPorId(int id)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "SELECT id, nombre, categoria, precio, stock FROM productos WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Productos(
                            id: reader.GetInt32("id"),
                            nombre: reader.GetString("nombre"),
                            categoria: reader.GetString("categoria"),
                            precio: reader.GetDouble("precio"),
                            stock: reader.GetInt32("stock")
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }


        // --- CRUD DE ARTISTAS ---

        /// <summary>
        /// (ALTA) Registra un nuevo artista en la base de datos.
        /// </summary>
        /// <param name="artista">El objeto Artistas con la informacion a guardar.</param>
        public static void AltaArtista(Artistas artista)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO artistas (nombre_artistico, edad, genero, especialidad, salario_base, activo) " +
                                 "VALUES (@nombre, @edad, @genero, @especialidad, @salario, @activo)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@nombre", artista.NombreArtistico);
                    cmd.Parameters.AddWithValue("@edad", artista.Edad);
                    cmd.Parameters.AddWithValue("@genero", artista.Genero);
                    cmd.Parameters.AddWithValue("@especialidad", artista.Especialidad);
                    cmd.Parameters.AddWithValue("@salario", artista.SalarioBase);
                    cmd.Parameters.AddWithValue("@activo", artista.Activo);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Artista registrad@ exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar artista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// (BAJA) Elimina un artista de la base de datos usando su ID.
        /// </summary>
        /// <param name="id">El ID del artista que se desea eliminar.</param>
        public static void EliminarArtista(int id)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "DELETE FROM artistas WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar artista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// (ACTUALIZACION) Modifica los datos de un artista existente en la base de datos.
        /// </summary>
        /// <param name="artista">El objeto Artistas con la informacion actualizada. El ID se usa para encontrar el registro.</param>
        public static void CambiarArtista(Artistas artista)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "UPDATE artistas SET nombre_artistico = @nombre, edad = @edad, genero = @genero, " +
                                 "especialidad = @especialidad, salario_base = @salario, activo = @activo WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@nombre", artista.NombreArtistico);
                    cmd.Parameters.AddWithValue("@edad", artista.Edad);
                    cmd.Parameters.AddWithValue("@genero", artista.Genero);
                    cmd.Parameters.AddWithValue("@especialidad", artista.Especialidad);
                    cmd.Parameters.AddWithValue("@salario", artista.SalarioBase);
                    cmd.Parameters.AddWithValue("@activo", artista.Activo);
                    cmd.Parameters.AddWithValue("@id", artista.Id);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cambiar artista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// (CONSULTA) Obtiene una lista de todos los artistas registrados en la base de datos.
        /// </summary>
        /// <returns>Una lista (List<Artistas>) con todos los artistas.</returns>
        public static List<Artistas> ObtenerTodosLosArtistas()
        {
            List<Artistas> lista = new List<Artistas>();
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "SELECT id, nombre_artistico, edad, genero, especialidad, salario_base, activo FROM artistas";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Artistas a = new Artistas(
                            id: reader.GetInt32("id"),
                            nombreArtistico: reader.GetString("nombre_artistico"),
                            edad: reader.GetInt32("edad"),
                            genero: reader.GetString("genero"),
                            especialidad: reader.GetString("especialidad"),
                            salarioBase: reader.GetDouble("salario_base"),
                            activo: reader.GetBoolean("activo")
                        );
                        lista.Add(a);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener artistas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return lista;
        }

        /// <summary>
        /// (CONSULTA) Busca y devuelve un artista especifico por su ID.
        /// </summary>
        /// <param name="id">El ID del artista a buscar.</param>
        /// <returns>Un objeto Artistas si se encuentra. Devuelve null si no se encuentra.</returns>
        public static Artistas? ObtenerArtistaPorId(int id)
        {
            using (MySqlConnection con = ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string sql = "SELECT id, nombre_artistico, edad, genero, especialidad, salario_base, activo FROM artistas WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Artistas(
                            id: reader.GetInt32("id"),
                            nombreArtistico: reader.GetString("nombre_artistico"),
                            edad: reader.GetInt32("edad"),
                            genero: reader.GetString("genero"),
                            especialidad: reader.GetString("especialidad"),
                            salarioBase: reader.GetDouble("salario_base"),
                            activo: reader.GetBoolean("activo")
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener artista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }
    }
}