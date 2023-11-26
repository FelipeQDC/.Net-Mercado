using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd_DesafioAPI.BLL
{
    internal class DadosBLL
    {
        public static void ValidaCadastros(DadosAccount umDados)
        {
            Erro.setErro(false);
            if (umDados.getNome().Equals(""))
            {
                Erro.setMsg("O Nome é de preenchimento obrigatório!");
                return;
            }

            if (umDados.getEmail().Equals(""))
            {
                Erro.setMsg("O E-mail é de preenchimento obrigatório!");
                return;
            }
            if (umDados.getPassword().Equals(""))
            {
                Erro.setMsg("O Password é de preenchimento obrigatório!");
                return;
            }
        }

        public static void ValidadadosLogin(DadosAccount umDados)
        {
            Erro.setErro(false);
            if (umDados.getEmail().Equals(""))
            {
                Erro.setMsg("O E-mail é de preenchimento obrigatório!");
                return;
            }
            if (umDados.getPassword().Equals(""))
            {
                Erro.setMsg("O Password é de preenchimento obrigatório!");
                return;
            }
        }
        public static void ValidaProduto(DadosProdutos umDados)
        {
           
            Erro.setErro(false);
            if (umDados.getNome().Equals(""))
            {
                Erro.setMsg("O Nome é de preenchimento obrigatório!");
                return;
            }
            if (umDados.getDescricao().Equals(""))
            {
                Erro.setMsg("A Descrição é de preenchimento obrigatório!");
                return;
            }
            if (umDados.getValor() <= 0 || umDados.getValor().Equals(""))
            {
                Erro.setMsg("O Valor tem que ser positivo");
                return;
            }
            if (umDados.getQT() <= 0 || umDados.getValor().Equals(""))
            {
                Erro.setMsg("A Quantidade tem que ser positivo");
                return;
            }
            if (umDados.getCategoria().Equals(""))
            {
                Erro.setMsg("A Categoria é de preenchimento obrigatório!");
                return;
            }
        }
    }
}
