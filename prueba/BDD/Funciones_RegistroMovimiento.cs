using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finanzasApp.BDD
{
    class Funciones_RegistroMovimiento
    {



        /**************MOSTRAR MOVIMIENTOS***********************/
        public static DataTable MostrarMovimientos()
        {
            Conexion mConexion = new Conexion();
            DataTable data;
            string consulta = "SELECT * FROM movimientos";
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = mConexion.getConexion();
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                data = new DataTable();
                adapter.Fill(data);
                return data;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error en la conexion.");
                return data = new DataTable();
            }
            finally
            {
                mConexion.getConexion().Close();
            }

        }


        /************************OBTENER TOTAL POR TIPO**********************************/

        public static double ObtenerTotalPorTipo(string tipo)
        {
            Conexion mConexion = new Conexion();
            double total = 0;
            string consulta = "SELECT SUM(monto) FROM movimientos WHERE tipo = @tipo";

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta, mConexion.getConexion());
                mySqlCommand.Parameters.AddWithValue("@tipo", tipo);
                object resultado = mySqlCommand.ExecuteScalar();
                total = resultado != DBNull.Value ? Convert.ToDouble(resultado) : 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el total.");
            }
            finally
            {
                mConexion.getConexion().Close();
            }

            return total;
        }

        /***************************OBTENER BALANCE**************************************/
        //Balance = Total de Ingresos - Total de Gastos
        /*
         * Si el balance es positivo, estás ahorrando.
         * Si el balance es negativo, estás gastando más de lo que ganas.
         */
        public static decimal ObtenerBalance()
        {
            decimal totalIngresos = 0;
            decimal totalGastos = 0;
            Conexion mConexion = new Conexion();
            using (MySqlConnection conexion = mConexion.getConexion())
            {
                string consultaIngresos = "SELECT SUM(monto) FROM movimientos WHERE tipo = 'Ingreso'";
                MySqlCommand cmdIngresos = new MySqlCommand(consultaIngresos, conexion);
                object resultadoIngresos = cmdIngresos.ExecuteScalar();
                if (resultadoIngresos != DBNull.Value)
                    totalIngresos = Convert.ToDecimal(resultadoIngresos);

                string consultaGastos = "SELECT SUM(monto) FROM movimientos WHERE tipo = 'Gasto'";
                MySqlCommand cmdGastos = new MySqlCommand(consultaGastos, conexion);
                object resultadoGastos = cmdGastos.ExecuteScalar();
                if (resultadoGastos != DBNull.Value)
                    totalGastos = Convert.ToDecimal(resultadoGastos);
            }
            return totalIngresos - totalGastos;
        }

        /*********************AGREGAR NUEVO MOVIMIENTO (gasto-ingreso)******************************/
        public static int AgregarMovimiento(Movimiento movimiento)
        {
            int retorna = 0;
            Conexion mConexion = new Conexion();
            using (MySqlConnection conexion = mConexion.getConexion())
            {
                string consulta = "INSERT INTO movimientos (tipo, monto, categoria, descripcion, fecha) " +
                                  "VALUES (@tipo, @monto, @categoria, @descripcion, @fecha)";

                MySqlCommand mySqlCommand = new MySqlCommand(consulta, conexion);

                // Parámetros seguros (evitan SQL Injection)
                mySqlCommand.Parameters.AddWithValue("@tipo", movimiento.tipo);
                mySqlCommand.Parameters.AddWithValue("@monto", movimiento.monto);
                mySqlCommand.Parameters.AddWithValue("@categoria", movimiento.categoria);
                mySqlCommand.Parameters.AddWithValue("@descripcion", movimiento.descripcion);
                mySqlCommand.Parameters.AddWithValue("@fecha", movimiento.fecha);

                retorna = mySqlCommand.ExecuteNonQuery();
            }
            return retorna;
        }

        /**********************ELIMINAR***********************************/
        public static void EliminarMovimientoPorId(int id)
        {
            Conexion mConexion = new Conexion();
            string consulta = "DELETE FROM movimientos WHERE id = @id";

            try
            {
                MySqlConnection conexion = mConexion.getConexion();
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Movimiento eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró un movimiento con ese ID.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el movimiento.");
            }
            finally
            {
                mConexion.getConexion().Close(); // Cierra la conexión que se abrió
            }
        }

        /*************************ELIMINAR TODO PARA REINICIAR********************************/

        public static void EliminarTodosLosMovimientos()
        {
            Conexion mConexion = new Conexion();
            string consulta = "DELETE FROM movimientos";

            try
            {
                MySqlConnection conexion = mConexion.getConexion();
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                int filasAfectadas = cmd.ExecuteNonQuery();

                MessageBox.Show($"Se eliminaron {filasAfectadas} movimientos.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar todos los movimientos.");
            }
            finally
            {
                mConexion.getConexion().Close();
            }
        }

        /***********************EDITAR MOVIMIENTO***************************/
        public static int EditarMovimiento(Movimiento mv)
        {
            int resultado = 0;
            Conexion mConexion = new Conexion();
            using (MySqlConnection conexion = mConexion.getConexion())
            {
                string consulta = @"UPDATE movimientos SET 
                                tipo = @tipo,
                                monto = @monto,
                                categoria = @categoria,
                                descripcion = @descripcion,
                                fecha = @fecha
                            WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@tipo", mv.tipo);
                cmd.Parameters.AddWithValue("@monto", mv.monto);
                cmd.Parameters.AddWithValue("@categoria", mv.categoria);
                cmd.Parameters.AddWithValue("@descripcion", mv.descripcion);
                cmd.Parameters.AddWithValue("@fecha", mv.fecha);
                cmd.Parameters.AddWithValue("@id", mv.id);

                resultado = cmd.ExecuteNonQuery();
            }
            return resultado;
        }

    }
}
