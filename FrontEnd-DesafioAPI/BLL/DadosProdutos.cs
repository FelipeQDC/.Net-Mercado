using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd_DesafioAPI.BLL
{
    internal class DadosProdutos
    {
        //Dados Cadastrais
        String Nome;
        String Descricao;
        decimal valor;
        int QT;
        String Categoria;
        string id;
        public void setNome(String _Nome) { Nome = _Nome; }
        public String getNome() { return Nome; }
        public void setDescricao(String _Descricao) { Descricao = _Descricao; }
        public String getDescricao() { return Descricao; }
        public void setValor(decimal _valor) { valor = _valor; }
        public decimal getValor() { return valor; }
        public void setQT(int _QT) { QT = _QT; }
        public int getQT() { return QT; }
        public void setCategoria(string _Categoria) { Categoria = _Categoria; }
        public string getCategoria() { return Categoria; }
        public void setId(string _id) { id = _id; }
        public string getId() { return id; }
    }
}
