using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eserveur {
    public partial class InterfaceCliente : Form {

        // Atributos
        private EServeurDatabaseEntities eserveurEntities = new EServeurDatabaseEntities();
        private BindingList<TblProduto> bindingProdutos = new BindingList<TblProduto>();
        private Decimal transactionTotal;

        public Decimal TransactionTotal {
            get { return transactionTotal; }
            set {
                transactionTotal = value;
                txtTotalDoPedido.Text = transactionTotal.ToString();

            }
        }


        public InterfaceCliente() {
            InitializeComponent();

            createTabbedPanel();
        }

        private void createTabbedPanel() {
            foreach (TblCategoria categoria in eserveurEntities.TblCategoria) {
                tabControl1.TabPages.Add(categoria.ToString(), categoria.Nome);
            }
        }

        private void btnAdicionarALista_Click(object sender, EventArgs e) {
            TblProduto p = new TblProduto() { Categoria_id = 2, Nome = "Coca-Cola", Preco = 1.99M, Descricao = "Bebida Refrescante" };
            bindingProdutos.Add(p);
        }

        private void btnRemoverDaLista_Click(object sender, EventArgs e) {
            TblProduto selectedProduct = (TblProduto)lstListaDoPedido.SelectedItem;
            bindingProdutos.Remove(selectedProduct);
        }

        private void FormatarLista(object sender, ListControlConvertEventArgs e) {
            string nomeAtual = ((TblProduto)e.ListItem).Nome;
            string precoAtual = string.Format("{0:C}", ((TblProduto)e.ListItem).Preco);

            string currentDescriptionPadded = nomeAtual.PadRight(40);

            e.Value = currentDescriptionPadded + precoAtual;
        }
    }
}
