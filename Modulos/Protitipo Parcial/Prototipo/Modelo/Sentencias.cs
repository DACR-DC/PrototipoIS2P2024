using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_PrototipoMenu
{
    public class Sentencias
    {
        Conexion con = new Conexion();


        public void InsertarMoneda(string nombre_moneda, int moneda_valor)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_moneda (nombre_moneda, moneda_valor) VALUES (?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@nombre_moneda", nombre_moneda);
                                cmd.Parameters.AddWithValue("@moneda_valor", moneda_valor);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al guardar la moneda: {ex.Message}");
                        }
                    }
                }
            }
        }

        public void BorrarMoneda(string nombre_moneda)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = $"DELETE FROM tbl_moneda   WHERE nombre_moneda = '{nombre_moneda}'";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Dato eliminado");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error al Eliminar la moneda: {ex.Message}");
                        }
                    }
                }
            }
        }



    }
}
