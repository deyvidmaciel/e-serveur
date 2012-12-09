using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eserveur {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e) {
            AdicionarProduto adicionarProduto = new AdicionarProduto();
            adicionarProduto.Show();
        }

        private void btnVerProdutos_Click(object sender, EventArgs e) {
            VerProdutos verProdutos = new VerProdutos();
            verProdutos.Show();
        }

        private void btnAbrirInterfaceCliente_Click(object sender, EventArgs e) {
            InterfaceCliente interfaceClient = new InterfaceCliente();
            interfaceClient.Show();
        }

    }
}
