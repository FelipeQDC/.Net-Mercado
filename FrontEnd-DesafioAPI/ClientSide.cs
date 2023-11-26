using FrontEnd_DesafioAPI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd_DesafioAPI
{
    public partial class ClientSide : Form
    {
        public ClientSide()
        {
            InitializeComponent();
        }

        private void ClientSide_Load(object sender, EventArgs e)
        {
            TextoInicial.Text = "Ola " + TokenGlobal.NamenGlobalString + ", Bem vindo!";
        }
    }
}
