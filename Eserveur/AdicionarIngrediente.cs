using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eserveur {
    public partial class AdicionarIngrediente : Form {

        // Attributos
        private EServeurDatabaseEntities eserveurEntities = new EServeurDatabaseEntities();

        public AdicionarIngrediente() {
            InitializeComponent();
        }

        private void btnAnular_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            TblIngrediente novoIngrediente = new TblIngrediente();

            novoIngrediente.Nome = txtNome.Text;

            //novoIngrediente.Esta_disponivel = chbEstaDisponivel.Checked;
            novoIngrediente.Esta_disponivel = (chbEstaDisponivel.Checked) ? true : false;

            MessageBox.Show("Ingrediente adicionado");
        }
    }
}
