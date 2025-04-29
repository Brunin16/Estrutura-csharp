using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapW.Estrutura.Repository
{
    public class UsuarioRepository
    {
        private readonly string _connectionString = "User Id=rmxxxxx;Password=xxxx;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));";
    
        public bool validarUsuario(string usuario, string senha)
        {
            using (OracleConnection conexao = new OracleConnection(_connectionString))
            {
                conexao.Open();
                string query = $"select count(1) from Usuarios_FIAP where NomeUsuario = '{usuario}' and senha = '{senha}'";
                OracleCommand cmd = new OracleCommand(query, conexao);

                object retorno = cmd.ExecuteScalar();

                if (int.Parse(retorno.ToString()) != 0) { 
                return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
