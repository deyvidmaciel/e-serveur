using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eserveur {
    public partial class VerProdutos : Form {

        // Atributos
        private EServeurDatabaseEntities eserveurEntities = new EServeurDatabaseEntities();

        public VerProdutos() {
            InitializeComponent();

            dataGridView1.DataSource = eserveurEntities.TblProduto;
        }
    }
}
