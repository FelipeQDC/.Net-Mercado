using FrontEnd_DesafioAPI.BLL;
using FrontEnd_DesafioAPI.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd_DesafioAPI
{
    public partial class accountSection : Form
    {
        DadosAccount umDados = new DadosAccount();

        AdmSide Adm = new AdmSide();
        ClientSide Cliente = new ClientSide();
        public accountSection()
        {
            InitializeComponent();
        }
        private string PostCadastro(string Nome, string Email, string Password)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5284");
            AccountCadastro pessoa = new AccountCadastro { Name = Nome, Email = Email, Password = Password };
            var json = System.Text.Json.JsonSerializer.Serialize(pessoa);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("/cadastro", content).Result;

            return response.ToString();
        }

            private void BTNcadastro_Click(object sender, EventArgs e)
        {
            umDados.setNome(CadastroNome.Text);
            umDados.setEmail(CadastroEmail.Text);
            umDados.setPassword(CadastroSenha.Text);
            DadosBLL.ValidaCadastros(umDados);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());

            PostCadastro(CadastroNome.Text, CadastroEmail.Text, CadastroSenha.Text);
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            umDados.setEmail(LoginEmail.Text);
            umDados.setPassword(LoginPassword.Text);
            DadosBLL.ValidadadosLogin(umDados);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());

            var role=Postlogin(LoginEmail.Text, LoginPassword.Text);

            switch (role)
            {
                case "adm":
                    Adm.Show();
                break;
                case "Cliente":
                    Cliente.Show();
                break;
                case "":
                    MessageBox.Show("Esta Conta não existe");
                break;
            }
        }
        public string Postlogin(string email, string password)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5284");
            AccountLogin pessoa = new AccountLogin { Email = email, Password = password };
            var json = System.Text.Json.JsonSerializer.Serialize(pessoa);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("/login", content).Result;
            var Result = response.Content.ReadAsStringAsync().Result;
            var token = JsonConvert.DeserializeObject<TokenController>(Result);
            TokenGlobal.NamenGlobalString = token.Name;
            TokenGlobal.TokenGlobalString = token.Token;
            return token.Role;
        }
    }
}
