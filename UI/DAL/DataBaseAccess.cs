using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;

namespace DAL
{
    public class DataBaseAccess {

        private static SqlConnection _conection;
        private static SqlConnection getConection
        {
            get
            {

                if (_conection == null)
                {
                    _conection = new SqlConnection(DAL.Properties.Settings.Default.PM_ConnectionJean);

                }
                else if (_conection.State == ConnectionState.Closed || _conection.State == ConnectionState.Broken)
                {
                    _conection = new SqlConnection(DAL.Properties.Settings.Default.PM_ConnectionJean);

                }
                return _conection;
            }
        }

         private DataBaseAccess() { }

        /**
         * Ejecuta un procedimiento almacenado simple
         * Este metodo estatico proporciona una forma sencilla de ejecutar un Stored Procedure sin que este renorne ningun valor
         */
        public static void simpleStoredProcedureRequest(String name, SPP[] parameters = null)
        {
            String storedProcedure = "dbo." + name;
            SqlCommand cmd = new SqlCommand(name, getConection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (parameters != null && parameters.Length > 0)
            {
                foreach (SPP p in parameters)
                {
                    cmd.Parameters.AddWithValue("@" + p.Name, p.Value);
                }
            }

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        /**
         * Advance Store Procedure
         */
        public static DataTable advanceStoredProcedureRequest(String name, SPP[] parameters = null)
        {

            String storedProcedure = "dbo." + name;
            SqlCommand cmd = new SqlCommand(name, getConection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (parameters != null && parameters.Length > 0)
            {
                foreach (SPP p in parameters)
                {
                    cmd.Parameters.AddWithValue("@" + p.Name, p.Value);
                }
            }

            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(table);

            return table;
        }






    }
}

