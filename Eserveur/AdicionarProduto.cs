using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Eserveur {
    public partial class AdicionarProduto : Form {

        // Attributos
        private EServeurDatabaseEntities eserveurEntities = new EServeurDatabaseEntities();
        Byte[] byteBLOBData;


        public AdicionarProduto() {
            InitializeComponent();

            cboCategoria.DataSource = eserveurEntities.TblCategoria;
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.ValueMember = "Categoria_id";
        }


        private void btnUploadImagem_Click(object sender, EventArgs e) {
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK) {
                FileStream fsBLOBFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                byteBLOBData = new Byte[fsBLOBFile.Length];

                fsBLOBFile.Read(byteBLOBData, 0, byteBLOBData.Length);
                fsBLOBFile.Close();

                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                pboxImagem.Image = Image.FromStream(stmBLOBData);
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e) {
            TblProduto novoProduto = new TblProduto();

            // Modificar linhas do novo produto
            novoProduto.Nome = txtNome.Text;
            novoProduto.Preco = Decimal.Parse(txtPreco.Text);
            novoProduto.Categoria_id = (int)cboCategoria.SelectedValue;
            novoProduto.Descricao = txtDescricao.Text;
            novoProduto.Foto = byteBLOBData;

            // Adicionar ao banco de dados
            eserveurEntities.AddToTblProduto(novoProduto);
            eserveurEntities.SaveChanges();

            MessageBox.Show("Produto registrado com sucesso");
            this.Close();
        }
    }
}
