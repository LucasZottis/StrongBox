namespace StrongBox.WinForms.Componentes {
    partial class UcCbxCategoria {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.LblCategoria = new System.Windows.Forms.Label();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.LblCodCategoria = new System.Windows.Forms.Label();
            this.TxtCodigoCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblCategoria
            // 
            this.LblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(242, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(71, 17);
            this.LblCategoria.TabIndex = 0;
            this.LblCategoria.Text = "Categoria";
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(63, 20);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(437, 25);
            this.CbxCategoria.TabIndex = 2;
            this.CbxCategoria.SelectedIndexChanged += new System.EventHandler(this.CbxCategoria_SelectedIndexChanged);
            // 
            // LblCodCategoria
            // 
            this.LblCodCategoria.AutoSize = true;
            this.LblCodCategoria.Location = new System.Drawing.Point(3, 0);
            this.LblCodCategoria.Name = "LblCodCategoria";
            this.LblCodCategoria.Size = new System.Drawing.Size(54, 17);
            this.LblCodCategoria.TabIndex = 2;
            this.LblCodCategoria.Text = "Código";
            // 
            // TxtCodigoCategoria
            // 
            this.TxtCodigoCategoria.Location = new System.Drawing.Point(3, 20);
            this.TxtCodigoCategoria.MaxLength = 3;
            this.TxtCodigoCategoria.Name = "TxtCodigoCategoria";
            this.TxtCodigoCategoria.Size = new System.Drawing.Size(54, 25);
            this.TxtCodigoCategoria.TabIndex = 1;
            this.TxtCodigoCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodigoCategoria.Leave += new System.EventHandler(this.TxtCodigoCategoria_Leave);
            // 
            // UcCbxCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TxtCodigoCategoria);
            this.Controls.Add(this.LblCodCategoria);
            this.Controls.Add(this.CbxCategoria);
            this.Controls.Add(this.LblCategoria);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UcCbxCategoria";
            this.Size = new System.Drawing.Size(504, 48);
            this.Enter += new System.EventHandler(this.UcCbxCategoria_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox CbxCategoria;
        private System.Windows.Forms.Label LblCodCategoria;
        private System.Windows.Forms.TextBox TxtCodigoCategoria;
    }
}
