﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlServerCe;

namespace Utils
{
    public static class Parametro
    {
        public static string GetParametro(string chave)
        {
            //string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.dbintegracaoConnectionString"].ConnectionString;
            string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.ConnectionString"].ConnectionString;
            string retorno = string.Empty;
            //MySqlConnection con = new MySqlConnection(ConnectionString);
            SqlCeConnection con = new SqlCeConnection(ConnectionString);
            try
            {
                con.Open();
                //MySqlCommand cmd = new MySqlCommand("SELECT valor from parametro where chave = ?chave", con);
                SqlCeCommand cmd = new SqlCeCommand("SELECT valor from parametro where chave = @chave", con);
                cmd.Parameters.AddWithValue("@chave", chave);
                
                //MySqlDataReader dr = cmd.ExecuteReader();
                SqlCeDataReader dr = cmd.ExecuteReader();
                bool HasRows = dr.Read();
                if (HasRows)
                {
                    retorno = dr.GetString(0);
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
        
        public static void SetParametro(string chave, string valor)
        {
            //string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.dbintegracaoConnectionString"].ConnectionString;
            string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.ConnectionString"].ConnectionString;
            string retorno = string.Empty;
            //MySqlConnection con = new MySqlConnection(ConnectionString);
            SqlCeConnection con = new SqlCeConnection(ConnectionString);
            try
            {
                con.Open();
                //MySqlCommand cmd = new MySqlCommand("update parametro set valor=?valor where chave = ?chave", con);
                SqlCeCommand cmd = new SqlCeCommand("update parametro set valor=@valor where chave = @chave", con);
                cmd.Parameters.AddWithValue("@chave", chave);
                cmd.Parameters.AddWithValue("@valor", valor);
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

        public static void AddParametro(string chave, string valor)
        {
            //string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.dbintegracaoConnectionString"].ConnectionString;
            string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.ConnectionString"].ConnectionString;
            string retorno = string.Empty;
            //MySqlConnection con = new MySqlConnection(ConnectionString);
            SqlCeConnection con = new SqlCeConnection(ConnectionString);
            try
            {
                con.Open();                
                //MySqlCommand cmd = new MySqlCommand("insert into parametro (chave,valor) values(?chave,?valor)", con);
                SqlCeCommand cmd = new SqlCeCommand("insert into parametro (chave,valor) values(@chave,@valor)", con);
                cmd.Parameters.AddWithValue("@chave", chave);
                cmd.Parameters.AddWithValue("@valor", valor);
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

        public static void DelParametro(string chave)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.ConnectionString"].ConnectionString;
            string retorno = string.Empty;
            //MySqlConnection con = new MySqlConnection(ConnectionString);
            SqlCeConnection con = new SqlCeConnection(ConnectionString);
            try
            {
                con.Open();
                //MySqlCommand cmd = new MySqlCommand("insert into parametro (chave,valor) values(?chave,?valor)", con);
                SqlCeCommand cmd = new SqlCeCommand("delete from parametro where chave = @chave", con);
                cmd.Parameters.AddWithValue("@chave", chave);                
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
