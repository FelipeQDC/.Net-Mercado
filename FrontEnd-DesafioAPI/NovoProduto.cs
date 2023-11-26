using FrontEnd_DesafioAPI.BLL;
using FrontEnd_DesafioAPI.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FrontEnd_DesafioAPI
{
    public partial class NovoProduto : Form
    {
       
        DadosProdutos umDados = new DadosProdutos();
        public NovoProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            umDados.setNome(NPNome.Text);
            umDados.setDescricao(NPDescricao.Text);
            umDados.setValor(NPValor.Value);
            int qt = Decimal.ToInt32(NPQT.Value);
            object a = NPCategoria.SelectedItem;
            string categoria = a.ToString();
            umDados.setQT(qt);
            umDados.setCategoria(categoria);
            DadosBLL.ValidaProduto(umDados);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            PostProduto(NPNome.Text, NPDescricao.Text, NPValor.Value, qt, categoria);
        }

        public void PostProduto(string Nome, string Descricao, decimal Valor, int Qt, string categoria)
        {
           var client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:5284");

           client.DefaultRequestHeaders.Authorization =
                           new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);
                    MessageBox.Show(Nome+" " +Descricao+" "+Valor+" "+Qt+" "+categoria);
                    ProdutoPost ProdutoNovo = new ProdutoPost { Nome = Nome, Descricao = Descricao, Valor = Valor, Categoria = categoria, Quantidade = Qt };
                    var json = System.Text.Json.JsonSerializer.Serialize(ProdutoNovo);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("/Produto", content).Result;

               
                    MessageBox.Show("Produto criado");    
        }

        private void NPQT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NPValor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NPCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Descrição_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NPDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void NPNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
