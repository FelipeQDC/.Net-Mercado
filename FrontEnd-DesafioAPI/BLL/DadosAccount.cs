using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd_DesafioAPI.BLL
{
    internal class DadosAccount
    {
        //Dados Cadastrais
        String Nome;
        String Email;
        String Password;
        //Retorno de Login
        String Token;
        public void setNome(String _Nome) { Nome = _Nome; }
        public String getNome() { return Nome; }
        public void setEmail(String _Email) { Email = _Email; }
        public String getEmail() { return Email; }
        public void setPassword(String _Password) { Password = _Password; }
        public String getPassword() { return Password; }
    }
}
