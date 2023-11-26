using FrontEnd_DesafioAPI.BLL;
using FrontEnd_DesafioAPI.Classes;
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

namespace FrontEnd_DesafioAPI
{
    public partial class AtualizarProduto : Form
    {
        DadosProdutos umDados = new DadosProdutos();
        public AtualizarProduto()
        {
            InitializeComponent();
        }

        private void aaa_Click(object sender, EventArgs e)
        {
            umDados.setId(textBox1.Text);
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
                PostProduto(NPNome.Text, NPDescricao.Text, NPValor.Value, qt, categoria, textBox1.Text);
        }

        public void PostProduto(string Nome, string Descricao, decimal Valor, int Qt, string categoria, string Idstring)
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:5284");

            client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", TokenGlobal.TokenGlobalString);
            int id = int.Parse(Idstring);
            ProdutoPost ProdutoNovo = new ProdutoPost { Nome = Nome, Descricao = Descricao, Valor = Valor, Categoria = categoria, Quantidade = Qt };
            var json = System.Text.Json.JsonSerializer.Serialize(ProdutoNovo);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PutAsync("/Produto/" + id, content).Result;


            MessageBox.Show("Produto foi atualizado");
        }
    }
}
