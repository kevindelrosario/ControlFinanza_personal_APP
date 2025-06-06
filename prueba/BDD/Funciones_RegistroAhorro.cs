using finanzasApp.BDD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba.BDD
{
    class Funciones_RegistroAhorro
    {
        /*********************AGREGAR NUEVO AHORRO******************************/
        public static bool AgregarAhorro(Ahorro ahorro)
        {
            Conexion mConexion = new Conexion();
            string consulta = @"
        INSERT INTO ahorros (monto, descripcion, fecha, id_objetivo)
        VALUES (@monto, @descripcion, @fecha, @id_objetivo)";

            try
            {
                using (MySqlConnection conexion = mConexion.getConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@monto", ahorro.monto);
                    cmd.Parameters.AddWithValue("@descripcion", ahorro.descripcion ?? "");
                    cmd.Parameters.AddWithValue("@fecha", ahorro.fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@id_objetivo", ahorro.id_objetivo);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Ahorro agregado correctamente.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el ahorro.");
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el ahorro.");
                return false;
            }
        }

     


        //la utilizo para encontrar el objetivo al que el usuario le quiere agregar ahorro y poder agregar el nuevo ahorro.
        public static int ObtenerIdPorNombre(string nombre)
        {
            Conexion mConexion = new Conexion();
            int id = 0;
            string consulta = "SELECT id FROM objetivos_ahorro WHERE nombre = @nombre";

            try
            {
                using (MySqlConnection conexion = mConexion.getConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    object resultado = cmd.ExecuteScalar();
                    id = resultado != DBNull.Value ? Convert.ToInt32(resultado) : 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el ID del objetivo de ahorro.");
            }

            return id;
        }
        /*********************MOSTRAR AHORROS******************************/
        public static DataTable MostrarAhorros()
        {
            Conexion mConexion = new Conexion();
            DataTable data = new DataTable();
            string consulta = "SELECT * FROM ahorros";

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta, mConexion.getConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                adapter.Fill(data);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al consultar los ahorros.");
            }
            finally
            {
                mConexion.getConexion().Close();
            }

            return data;
        }


        /*********************OBTENER TOTAL AHORROS******************************/
        public static decimal ObtenerTotalAhorros()
        {
            Conexion mConexion = new Conexion();
            decimal total = 0;
            string consulta = "SELECT SUM(monto) FROM ahorros";

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta, mConexion.getConexion());
                object resultado = mySqlCommand.ExecuteScalar();
                total = resultado != DBNull.Value ? Convert.ToDecimal(resultado) : 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el total de ahorros.");
            }
            finally
            {
                mConexion.getConexion().Close();
            }

            return total;
        }

        /*********************ELIMINAR AHORRO******************************/
        public static void EliminarAhorroPorId(int id)
        {
            Conexion mConexion = new Conexion();
            string consulta = "DELETE FROM ahorros WHERE id = @id";

            try
            {
                MySqlConnection conexion = mConexion.getConexion();
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Ahorro eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró un ahorro con ese ID.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el ahorro.");
            }
            finally
            {
                mConexion.getConexion().Close();
            }
        }

        //para mostrarlos en un comboBox
        public static List<ObjetivoAhorro> ObtenerObjetivos()
        {
            List<ObjetivoAhorro> lista = new List<ObjetivoAhorro>();
            Conexion mConexion = new Conexion();
            string query = "SELECT id, nombre FROM objetivos_ahorro";

            try
            {
                using (MySqlConnection conexion = mConexion.getConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ObjetivoAhorro
                            {
                                Id = reader.GetInt32("id"),
                                Nombre = reader.GetString("nombre")
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los objetivos de ahorro.");
            }

            return lista;
        }

        //para mostrar los objetivos y el total de cada uno:
        public static DataTable ObtenerTotalesPorObjetivo()
        {
            Conexion mConexion = new Conexion();
            DataTable data = new DataTable();

            string consulta = @"
        SELECT 
            oa.nombre AS Objetivo,
            SUM(a.monto) AS TotalAhorrado
        FROM 
            ahorros a
        JOIN 
            objetivos_ahorro oa ON a.id_objetivo = oa.id
        GROUP BY 
            a.id_objetivo;
    ";

            try
            {
                using (MySqlConnection conexion = mConexion.getConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los totales por objetivo.");
            }

            return data;
        }


    }
}

