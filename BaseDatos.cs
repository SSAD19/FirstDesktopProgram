using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace AccesoDatos
{
    public class BaseDatos
    {
        string conexString = @"Data Source =DESKTOP-P0J7R4I\SQLSTEF; Initial Catalog=Almacen1; Integrated Security=true";

        SqlConnection miConex;
        SqlCommand comando;
        DataSet miDataSet;
        DataTable miDataTable;
        SqlDataAdapter adaptadorSQL;

        public void conectarBD(string xcomando)
        {

            miConex = new SqlConnection(conexString);
            comando = new SqlCommand(xcomando);
            comando.Connection = miConex;

            try
            {
                miConex.Open();
                comando.ExecuteNonQuery();
                miConex.Close();

            }
            catch (InvalidCastException e)
            {
                if (e.Data == null)
                {
                    MessageBox.Show("No se ha podido conectar con la base de datos");
                }
            }
        }

        public DataTable recuperarDB(string xcomando)
        {
            miConex = new SqlConnection(conexString);
            comando = new SqlCommand(xcomando);
            comando.Connection = miConex;
            miConex.Open();

            miDataSet = new DataSet();
            miDataTable = new DataTable();
            adaptadorSQL = new SqlDataAdapter();

            adaptadorSQL.SelectCommand = comando;
            adaptadorSQL.Fill(miDataSet);
            miDataTable = miDataSet.Tables[0];

            miConex.Close();

            return miDataTable;
        }

        public int idMax(string entidad)
        {
            String xcomando = @"Select Max(id) FROM '" + entidad + "'";
            miConex = new SqlConnection(conexString);
            comando = new SqlCommand(xcomando);
            comando.Connection = miConex;
            miConex.Open();
            int maxId;
            maxId = (Int32)comando.ExecuteScalar();
            miConex.Close();

            return maxId;
        }
    }
}
