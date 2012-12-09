namespace Eserveur {
    partial class InterfaceCliente {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnRemoverDaLista = new System.Windows.Forms.Button();
            this.txtTotalDoPedido = new System.Windows.Forms.TextBox();
            this.btnAdicionarALista = new System.Windows.Forms.Button();
            this.lstListaDoPedido = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(13, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // btnRemoverDaLista
            // 
            this.btnRemoverDaLista.BackColor = System.Drawing.Color.Red;
            this.btnRemoverDaLista.Location = new System.Drawing.Point(905, 505);
            this.btnRemoverDaLista.Name = "btnRemoverDaLista";
            this.btnRemoverDaLista.Size = new System.Drawing.Size(133, 109);
            this.btnRemoverDaLista.TabIndex = 2;
            this.btnRemoverDaLista.Text = "Remover";
            this.btnRemoverDaLista.UseVisualStyleBackColor = false;
            this.btnRemoverDaLista.Click += new System.EventHandler(this.btnRemoverDaLista_Click);
            // 
            // txtTotalDoPedido
            // 
            this.txtTotalDoPedido.Location = new System.Drawing.Point(1056, 506);
            this.txtTotalDoPedido.Name = "txtTotalDoPedido";
            this.txtTotalDoPedido.Size = new System.Drawing.Size(155, 20);
            this.txtTotalDoPedido.TabIndex = 3;
            // 
            // btnAdicionarALista
            // 
            this.btnAdicionarALista.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdicionarALista.Location = new System.Drawing.Point(13, 506);
            this.btnAdicionarALista.Name = "btnAdicionarALista";
            this.btnAdicionarALista.Size = new System.Drawing.Size(133, 109);
            this.btnAdicionarALista.TabIndex = 4;
            this.btnAdicionarALista.Text = "Adicionar";
            this.btnAdicionarALista.UseVisualStyleBackColor = false;
            this.btnAdicionarALista.Click += new System.EventHandler(this.btnAdicionarALista_Click);
            // 
            // lstListaDoPedido
            // 
            this.lstListaDoPedido.FormattingEnabled = true;
            this.lstListaDoPedido.Location = new System.Drawing.Point(905, 40);
            this.lstListaDoPedido.Name = "lstListaDoPedido";
            this.lstListaDoPedido.Size = new System.Drawing.Size(306, 459);
            this.lstListaDoPedido.TabIndex = 5;
            this.lstListaDoPedido.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatarLista);
            // 
            // InterfaceCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 642);
            this.Controls.Add(this.lstListaDoPedido);
            this.Controls.Add(this.btnAdicionarALista);
            this.Controls.Add(this.txtTotalDoPedido);
            this.Controls.Add(this.btnRemoverDaLista);
            this.Controls.Add(this.tabControl1);
            this.Name = "InterfaceCliente";
            this.Text = "InterfaceCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnRemoverDaLista;
        private System.Windows.Forms.TextBox txtTotalDoPedido;
        private System.Windows.Forms.Button btnAdicionarALista;
        private System.Windows.Forms.ListBox lstListaDoPedido;
    }
}