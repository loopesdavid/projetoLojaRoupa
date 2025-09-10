using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using System;

namespace projetoLojaRoupa
{
    class Conexao
    {
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=BDProjeto;user=root;pwd=Argentina@412"); 

        public static string msg;
        
        public MySqlConnection ConnectarBD()
        {
            try
            {
                con.Open();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }

        public MySqlConnection DesConnectarBD()
        {
            try
            {
                con.Close();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }
    }
}
