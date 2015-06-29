using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Arriendo_Vehiculos
{
    static class master
    {
        private static SqlDataReader Dr;
        private static SqlConnection Conn = new SqlConnection();
        private static SqlCommand Tabb = new SqlCommand();
        private static SqlDataAdapter Dadap = new SqlDataAdapter();
        private static DataSet Dset = new DataSet();

        static master()
        {
            try
            {
                //Conn.ConnectionString = "Initial Catalog=master; " +
                //                        "Data Source=localhost;" +
                //                        "Integrated Security=SSPI"; 
                ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["master"];
                string connectionString = conSettings.ConnectionString;
                Conn = new SqlConnection(connectionString);
            }
            catch (Exception RR)
            {
                throw RR;
            }
        }

        public static void test()
        {
            Conn.Open();            
            Conn.Close();
        }

        public static Boolean existebd()
        {
            try
            {
                Conn.Open();
                Tabb = new SqlCommand("select name from sysdatabases where name='Vehiculos'", Conn);
                Dr = Tabb.ExecuteReader();
                if (Dr.Read() == true)
                {
                    Dr.Close();
                    Conn.Close();
                    return true;
                }
                else
                {
                    Dr.Close();
                    Conn.Close();
                    return false;
                }
            }
            catch (Exception RR)
            {
                throw RR;                
            }   
        }

        public static Boolean crearbd()
        {
            try
            {                
                if (existebd() == false)
                {
                    try
                    {
                        Conn.Open();                                      
                        Tabb = new SqlCommand("create database Vehiculos", Conn);
                        Dadap.SelectCommand = Tabb;
                        Dadap.Fill(Dset, "Vehiculos");
                        Dset.Clear();
                        Conn.Close();
                        MessageBox.Show("Database Creada en Nuevo Equipo.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (Exception RR)
                    {
                        MessageBox.Show(RR.Message);
                        
                    }
                    return true;              
                }
                else
                {                    
                    return false;
                }
            }
            catch (Exception RR)
            {
                throw RR;
            }            
        }
    }
}
