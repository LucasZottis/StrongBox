namespace StrongBox.WinForms.Componentes {
    partial class UcCbxLocal {
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
            this.TxtCodigoLocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxLocais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCodigoLocal
            // 
            this.TxtCodigoLocal.Location = new System.Drawing.Point(3, 20);
            this.TxtCodigoLocal.Name = "TxtCodigoLocal";
            this.TxtCodigoLocal.Size = new System.Drawing.Size(73, 25);
            this.TxtCodigoLocal.TabIndex = 1;
            this.TxtCodigoLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodigoLocal.Leave += new System.EventHandler(this.TxtCodigoLocal_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxLocais
            // 
            this.CbxLocais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxLocais.FormattingEnabled = true;
            this.CbxLocais.Location = new System.Drawing.Point(82, 20);
            this.CbxLocais.Name = "CbxLocais";
            this.CbxLocais.Size = new System.Drawing.Size(297, 25);
            this.CbxLocais.TabIndex = 2;
            this.CbxLocais.SelectedIndexChanged += new System.EventHandler(this.CbxLocais_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Locais";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcCbxLocal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CbxLocais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigoLocal);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UcCbxLocal";
            this.Size = new System.Drawing.Size(382, 48);
            this.Enter += new System.EventHandler(this.UcCbxLocal_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigoLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxLocais;
        private System.Windows.Forms.Label label2;
    }
}
