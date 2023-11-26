using FrontEnd_DesafioAPI.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd_DesafioAPI.BLL;

namespace FrontEnd_DesafioAPI
{
    public partial class AdmSide : Form
    {
        NovoProduto Novoproduto = new NovoProduto();
        AtualizarProduto AtualizarProduto = new AtualizarProduto();
        DadosAccount umDados = new DadosAccount();
        public AdmSide()
        {
            InitializeComponent();
        }

        private void AdmSide_Load(object sender, EventArgs e)
        {
            TextoInicial.Text = "Ola " + TokenGlobal.NamenGlobalString + ", Bem vindo!";

            getProdutosAsync();
            getContasAsync();
            gettransaçõesAsync();
        }

        public async Task getProdutosAsync()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    //USar TOKEN FUNFA FODA
                    httpClient.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);
                    var reponse = httpClient.GetAsync("http://localhost:5284/Produto").Result;
                    if (reponse.IsSuccessStatusCode)
                    {
                        var Result = reponse.Content.ReadAsStringAsync().Result;
                        var res = JsonConvert.DeserializeObject<List<Produto>>(Result);
                        dataGridView1.DataSource = res;
                    }
                    else
                    {
                        MessageBox.Show("não autorizado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex);
            }
        }

        public async Task getContasAsync()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    //USar TOKEN FUNFA FODA
                    httpClient.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);
                    var reponse = httpClient.GetAsync("http://localhost:5284/Contas").Result;
                    if (reponse.IsSuccessStatusCode)
                    {
                        var Result = reponse.Content.ReadAsStringAsync().Result;
                        var res = JsonConvert.DeserializeObject<List<AccountAdm>>(Result);
                        dataGridView2.DataSource = res;
                    }
                    else
                    {
                        MessageBox.Show("não autorizado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex);
            }
        }
        public async Task gettransaçõesAsync()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    //USar TOKEN FUNFA FODA
                    httpClient.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);
                    var reponse = httpClient.GetAsync("http://localhost:5284/transacoes").Result;
                    if (reponse.IsSuccessStatusCode)
                    {
                        var Result = reponse.Content.ReadAsStringAsync().Result;
                        var res = JsonConvert.DeserializeObject<List<transacoes>>(Result);
                        dataGridView3.DataSource = res;
                    }
                    else
                    {
                        MessageBox.Show("não autorizado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Novoproduto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    //USar TOKEN FUNFA FODA
                    httpClient.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);

                    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    var reponse = httpClient.DeleteAsync("http://localhost:5284/Produto/" + id).Result;

                    MessageBox.Show("Produto com ID: " + id.ToString() + " Deletado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            getProdutosAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarProduto.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            object a = tirarouadd.SelectedItem;
            string addoutirar = a.ToString();
            int qtd = Decimal.ToInt32(numericUpDown1.Value);

            var client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:5284");

            client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);
            
            string url = "/Produto/"+id+"/"+addoutirar+"/"+ qtd;

            var response = client.PutAsync(url,null).Result;

            MessageBox.Show("Produto com ID: " + id.ToString() + " Atualizado");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            umDados.setNome(attNome.Text);
            umDados.setEmail(AttEmail.Text);
            umDados.setPassword(Attsenha.Text);
            DadosBLL.ValidaCadastros(umDados);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());

            int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());

            var client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:5284");

            client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);
            object a = attrole.SelectedItem;
            string role = a.ToString();
            AccountAdm Atualizaçãoaccount = new AccountAdm { Name = attNome.Text, Email = AttEmail.Text, Password = Attsenha.Text, Role = role};
            var json = System.Text.Json.JsonSerializer.Serialize(Atualizaçãoaccount);
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            string url = "/AtualizarConta/" + id;

            var response = client.PutAsync(url,content).Result;

            MessageBox.Show("Conta com ID: " + id.ToString() + " Atualizado");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.Refresh();
            getContasAsync();
        }

        private void button8_Click(object sender, EventArgs e)
        {
          

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    //USar TOKEN FUNFA FODA
                    httpClient.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);

                    int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    var reponse = httpClient.DeleteAsync("http://localhost:5284/DeletarConta/" + id).Result;

                    MessageBox.Show("Conta com ID: "+id.ToString()+ " Deletado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView3.Refresh();
            getContasAsync();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());

            var client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:5284");

            client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);

            string url = "/StatusAtualizar/" + id;

            var response = client.PutAsync(url, null).Result;

            MessageBox.Show("Transação com ID: " + id.ToString() + " Atualizado");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    //USar TOKEN FUNFA FODA
                    httpClient.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);

                    int id = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
                    var reponse = httpClient.DeleteAsync("http://localhost:5284/DeleteTransacao/" + id).Result;

                    MessageBox.Show("Transação com ID: " + id.ToString() + " Deletado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex);
            }
        }
    }
}
