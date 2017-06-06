using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlServerCe;
using MySql.Data.MySqlClient;

namespace Utils
{
    public static class Sequence
    {
        /// <summary>
        /// Retorna o próximo número da sequência informada no parametro. 
        /// </summary>
        /// <param name="Sequence"></param>
        /// <returns></returns>
        public static long GetNextVal(string Sequence)
        {
            //string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.dbintegracaoConnectionString"].ConnectionString;

            string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.ConnectionString"].ConnectionString;

            //"server=localhost;user id=root;Password=pass4admin;database=dbintegracao";
            long retorno = 0;
            SqlCeConnection con = new SqlCeConnection(ConnectionString);
            //MySqlConnection con = new MySqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("SELECT sequence_increment, sequence_cur_value FROM sequence_data WHERE sequence_name = '" + Sequence +"'",con);
                //MySqlCommand cmd = new MySqlCommand("SELECT nextval('" + Sequence + "') as nextsequence", con);
                //MySqlDataReader dr = cmd.ExecuteReader();
                SqlCeDataReader dr = cmd.ExecuteReader();
                bool HasRows = dr.Read();
                if (HasRows)
                {
                    int increment = Convert.ToInt32(dr[0]);
                    long cur_value = Convert.ToInt64(dr[1]);
                    cur_value += increment;
                    retorno = cur_value;
                    SqlCeCommand UPD = new SqlCeCommand("UPDATE sequence_data SET sequence_cur_value = " + cur_value.ToString() + " WHERE sequence_name = '" + Sequence +"'", con);
                    UPD.ExecuteNonQuery();
                    UPD.Dispose();
                }
                
                dr.Close();                
                dr.Dispose();
                cmd.Dispose();
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {                
                con.Close();
                con.Dispose();
            }                       
        }

        public static long GetCurrentVal(string Sequence)
        {
            //string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.dbintegracaoConnectionString"].ConnectionString;
            string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.ConnectionString"].ConnectionString;
            long retorno = 0;
            //MySqlConnection con = new MySqlConnection(ConnectionString);
            SqlCeConnection con = new SqlCeConnection(ConnectionString);
            try
            {
                con.Open();
                //MySqlCommand cmd = new MySqlCommand("SELECT currentval(?Sequence) as currentsequence", con);
                SqlCeCommand cmd = new SqlCeCommand("SELECT sequence_cur_value FROM sequence_data WHERE sequence_name = @Sequence", con);
                cmd.Parameters.AddWithValue("@Sequence", Sequence);
                //MySqlDataReader dr = cmd.ExecuteReader();
                SqlCeDataReader dr = cmd.ExecuteReader();
                bool HasRows = dr.Read();
                if (HasRows)
                {
                    if (!dr.IsDBNull(0))
                    {
                        retorno = dr.GetInt64(0);
                    }
                    
                }
                dr.Close();
                dr.Dispose();
                cmd.Dispose();
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public static void SetCurrentVal(string Sequence, long Value)
        {
            //string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.dbintegracaoConnectionString"].ConnectionString;
            string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.ConnectionString"].ConnectionString;

            //MySqlConnection con = new MySqlConnection(ConnectionString);
            SqlCeConnection con = new SqlCeConnection(ConnectionString);
            try
            {
                con.Open();
                //MySqlCommand cmd = new MySqlCommand("UPDATE sequence_data SET sequence_cur_value = ?Value WHERE sequence_name = ?Sequence", con);
                SqlCeCommand cmd = new SqlCeCommand("UPDATE sequence_data SET sequence_cur_value = @Value WHERE sequence_name = @Sequence", con);
                cmd.Parameters.AddWithValue("@Sequence", Sequence);
                cmd.Parameters.AddWithValue("@Value", Value);
                cmd.ExecuteNonQuery();                
                cmd.Dispose();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
