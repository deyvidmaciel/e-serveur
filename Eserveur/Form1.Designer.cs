namespace Eserveur {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAdicionarCategoria = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnAdicionarIngrediente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnVerProdutos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnAbrirInterfaceCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnAdicionarCategoria);
            this.groupBox1.Controls.Add(this.btnAdicionarProduto);
            this.groupBox1.Controls.Add(this.btnAdicionarIngrediente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastros";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(23, 266);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(180, 60);
            this.button9.TabIndex = 4;
            this.button9.Text = "Adicionar Combo";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Adicionar Mesa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCategoria
            // 
            this.btnAdicionarCategoria.Location = new System.Drawing.Point(23, 108);
            this.btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            this.btnAdicionarCategoria.Size = new System.Drawing.Size(180, 60);
            this.btnAdicionarCategoria.TabIndex = 2;
            this.btnAdicionarCategoria.Text = "Adicionar Categoria";
            this.btnAdicionarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(23, 186);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(180, 60);
            this.btnAdicionarProduto.TabIndex = 1;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnAdicionarIngrediente
            // 
            this.btnAdicionarIngrediente.Location = new System.Drawing.Point(23, 29);
            this.btnAdicionarIngrediente.Name = "btnAdicionarIngrediente";
            this.btnAdicionarIngrediente.Size = new System.Drawing.Size(180, 60);
            this.btnAdicionarIngrediente.TabIndex = 0;
            this.btnAdicionarIngrediente.Text = "Adicionar Ingrediente";
            this.btnAdicionarIngrediente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.btnVerProdutos);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(258, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 434);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banco de Dados";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(23, 265);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(180, 60);
            this.button12.TabIndex = 4;
            this.button12.Text = "Ver Combos";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(23, 349);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 60);
            this.button8.TabIndex = 3;
            this.button8.Text = "Ver Mesas";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 185);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 60);
            this.button7.TabIndex = 2;
            this.button7.Text = "Ver Categorias";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnVerProdutos
            // 
            this.btnVerProdutos.Location = new System.Drawing.Point(23, 107);
            this.btnVerProdutos.Name = "btnVerProdutos";
            this.btnVerProdutos.Size = new System.Drawing.Size(180, 60);
            this.btnVerProdutos.TabIndex = 1;
            this.btnVerProdutos.Text = "Ver Produtos";
            this.btnVerProdutos.UseVisualStyleBackColor = true;
            this.btnVerProdutos.Click += new System.EventHandler(this.btnVerProdutos_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 60);
            this.button5.TabIndex = 0;
            this.button5.Text = "Ver Ingredientes";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Location = new System.Drawing.Point(510, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 340);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relatórios";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(20, 107);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(180, 60);
            this.button13.TabIndex = 2;
            this.button13.Text = "Relatório Gerencial";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(20, 28);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(180, 60);
            this.button11.TabIndex = 1;
            this.button11.Text = "Relatório Operacional";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btnAbrirInterfaceCliente
            // 
            this.btnAbrirInterfaceCliente.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAbrirInterfaceCliente.Location = new System.Drawing.Point(510, 362);
            this.btnAbrirInterfaceCliente.Name = "btnAbrirInterfaceCliente";
            this.btnAbrirInterfaceCliente.Size = new System.Drawing.Size(221, 85);
            this.btnAbrirInterfaceCliente.TabIndex = 4;
            this.btnAbrirInterfaceCliente.Text = "Abrir Interface Cliente";
            this.btnAbrirInterfaceCliente.UseVisualStyleBackColor = false;
            this.btnAbrirInterfaceCliente.Click += new System.EventHandler(this.btnAbrirInterfaceCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 465);
            this.Controls.Add(this.btnAbrirInterfaceCliente);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "e-Serveur ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAdicionarCategoria;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnAdicionarIngrediente;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnVerProdutos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAbrirInterfaceCliente;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

