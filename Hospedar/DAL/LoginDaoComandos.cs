using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedar.DAL
{
         class LoginDaoComandos
        {
            public bool has = false; 
            public String message = "";
            SqlCommand cmd = new SqlCommand(); 
            Conexao con = new Conexao(); 
            SqlDataReader dr;

            public bool validateLogin(String user, String password)
            {
                // Procurar no banco de dados esse login e senha
                cmd.CommandText = "select * from logins where email = @login and senha = @senha";
                cmd.Parameters.AddWithValue("@login", user);
                cmd.Parameters.AddWithValue("@senha", password);

                try
                {
                    cmd.Connection = con.conectar(); 
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows) { has = true; }
                    con.desconectar();
                    dr.Close();
                }

                catch (SqlException)
                {
                    this.message = "Erro com Banco de Dados!";
                }
                return has;
            }
            //public String cadastrar(String email, String senha, String confSenha)
            //{
            //    tem = false;
            //    if (senha.Equals(confSenha))
            //    {
            //        cmd.CommandText = "insert into logins values (@e,@s);";
            //        cmd.Parameters.AddWithValue("@e", email);
            //        cmd.Parameters.AddWithValue("@s", senha);

            //        try
            //        {
            //            cmd.Connection = con.conectar();
            //            cmd.ExecuteNonQuery();
            //            con.desconectar();
            //            this.mensagem = "Cadastrado com Sucesso!";
            //            tem = true;
            //        }
            //        catch (SqlException)
            //        {
            //            this.mensagem = "Erro com o banco de dados";
            //        }
            //    }
            //    else
            //    {   

            //        this.mensagem = "Senhas não correspondem";
            //    }

            //    return mensagem;
            //}
        }
}
