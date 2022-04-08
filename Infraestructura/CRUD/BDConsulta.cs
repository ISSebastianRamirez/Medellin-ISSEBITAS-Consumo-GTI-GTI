using System;
using System.Data;
using System.Data.SqlClient;

namespace Infraestructura.CRUD
{
    public class BDConsulta
    {
        public void EjecutarSPIngre(string NombreProcedimiento, int IdDoc, string NomDoc,int IdCia)
        {

            SqlConnection _SqlConnection = new SqlConnection(SETT.Default.Conexion);
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
           
            try
            {
                _SqlCommand.Connection.Open();
                _SqlCommand.Parameters.AddWithValue("@IdDocumento", IdDoc);
                _SqlCommand.Parameters.AddWithValue("@NombreDocumento", NomDoc);
                _SqlCommand.Parameters.AddWithValue("@IdCompañia", IdCia);
                _SqlCommand.ExecuteNonQuery();
              
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                _SqlCommand.Connection.Close();
            }
        }
        public DataSet EjecutarSP(string NombreProcedimiento)
        {
            DataSet DsGenerico = new DataSet();

            SqlConnection _SqlConnection = new SqlConnection(SETT.Default.Conexion);
            SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
            SqlCommand _SqlCommand = new SqlCommand();

            _SqlCommand.Connection = _SqlConnection;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.CommandText = NombreProcedimiento;
            _SqlCommand.CommandTimeout = 999999999;
            _SqlDataAdapter.SelectCommand = _SqlCommand;

            try
            {
                _SqlCommand.Connection.Open();
                _SqlDataAdapter.Fill(DsGenerico);
                return DsGenerico;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                _SqlCommand.Connection.Close();
            }
        }
    }
}
