using Hospedar.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedar.Models
{
    public class Controle
    {
        public bool has; 
        public String message = "";

        // Método de Validação
        public bool acessar(String user, String password)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            has = loginDao.validateLogin(user, password);
            if (!loginDao.message.Equals(""))
            {
                this.message = loginDao.message;
            }
            return has;
        }

        // Método de Cadastro
        //public String cadastrar(String email, String senha, String confSenha)
        //{
        //    LoginDaoComandos loginDao = new LoginDaoComandos();
        //    this.mensagem = loginDao.cadastrar(email, senha, confSenha);
        //    if(loginDao.tem)
        //    {
        //        this.tem = true;
        //    }
        //    return mensagem;
        //}

    }
}