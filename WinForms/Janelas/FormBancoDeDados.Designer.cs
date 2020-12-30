namespace StrongBox.WinForms.Janelas {
    partial class FormBancoDeDados {
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
            this.PnlDadosDb = new System.Windows.Forms.Panel();
            this.BtnNegarDb = new System.Windows.Forms.Button();
            this.BtnNegarServer = new System.Windows.Forms.Button();
            this.BtnConfirmarDb = new System.Windows.Forms.Button();
            this.BtnConfirmarServer = new System.Windows.Forms.Button();
            this.LblDataSource = new System.Windows.Forms.Label();
            this.BtnBuscarBanco = new System.Windows.Forms.Button();
            this.TxtNomeDb = new System.Windows.Forms.TextBox();
            this.LblNomeDb = new System.Windows.Forms.Label();
            this.TxtCaminhoDb = new System.Windows.Forms.TextBox();
            this.BtnSalvarConfig = new System.Windows.Forms.Button();
            this.BtnTestarDb = new System.Windows.Forms.Button();
            this.LblCaminhoDb = new System.Windows.Forms.Label();
            this.PnlEstadoDb = new System.Windows.Forms.Panel();
            this.LblEstadoConexao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OfdBuscarDb = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCadeiaConexao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDataSource = new System.Windows.Forms.TextBox();
            this.PnlDadosDb.SuspendLayout();
            this.PnlEstadoDb.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlDadosDb
            // 
            this.PnlDadosDb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDadosDb.Controls.Add(this.BtnNegarDb);
            this.PnlDadosDb.Controls.Add(this.BtnNegarServer);
            this.PnlDadosDb.Controls.Add(this.BtnConfirmarDb);
            this.PnlDadosDb.Controls.Add(this.BtnConfirmarServer);
            this.PnlDadosDb.Controls.Add(this.TxtDataSource);
            this.PnlDadosDb.Controls.Add(this.LblDataSource);
            this.PnlDadosDb.Controls.Add(this.BtnBuscarBanco);
            this.PnlDadosDb.Controls.Add(this.TxtNomeDb);
            this.PnlDadosDb.Controls.Add(this.LblNomeDb);
            this.PnlDadosDb.Controls.Add(this.TxtCaminhoDb);
            this.PnlDadosDb.Controls.Add(this.BtnSalvarConfig);
            this.PnlDadosDb.Controls.Add(this.BtnTestarDb);
            this.PnlDadosDb.Controls.Add(this.LblCaminhoDb);
            this.PnlDadosDb.Location = new System.Drawing.Point(12, 8);
            this.PnlDadosDb.Name = "PnlDadosDb";
            this.PnlDadosDb.Size = new System.Drawing.Size(620, 143);
            this.PnlDadosDb.TabIndex = 0;
            // 
            // BtnNegarDb
            // 
            this.BtnNegarDb.Enabled = false;
            this.BtnNegarDb.Image = global::StrongBox.WinForms.Properties.Resources.Cancelar2_20x20;
            this.BtnNegarDb.Location = new System.Drawing.Point(573, 72);
            this.BtnNegarDb.Name = "BtnNegarDb";
            this.BtnNegarDb.Size = new System.Drawing.Size(40, 30);
            this.BtnNegarDb.TabIndex = 6;
            this.BtnNegarDb.UseVisualStyleBackColor = true;
            this.BtnNegarDb.Click += new System.EventHandler(this.BtnNegarDb_Click);
            // 
            // BtnNegarServer
            // 
            this.BtnNegarServer.Enabled = false;
            this.BtnNegarServer.Image = global::StrongBox.WinForms.Properties.Resources.Cancelar2_20x20;
            this.BtnNegarServer.Location = new System.Drawing.Point(573, 5);
            this.BtnNegarServer.Name = "BtnNegarServer";
            this.BtnNegarServer.Size = new System.Drawing.Size(40, 30);
            this.BtnNegarServer.TabIndex = 6;
            this.BtnNegarServer.UseVisualStyleBackColor = true;
            this.BtnNegarServer.Click += new System.EventHandler(this.BtnNegarServer_Click);
            // 
            // BtnConfirmarDb
            // 
            this.BtnConfirmarDb.Enabled = false;
            this.BtnConfirmarDb.Image = global::StrongBox.WinForms.Properties.Resources.Confirm20x20;
            this.BtnConfirmarDb.Location = new System.Drawing.Point(527, 72);
            this.BtnConfirmarDb.Name = "BtnConfirmarDb";
            this.BtnConfirmarDb.Size = new System.Drawing.Size(40, 30);
            this.BtnConfirmarDb.TabIndex = 6;
            this.BtnConfirmarDb.UseVisualStyleBackColor = true;
            this.BtnConfirmarDb.Click += new System.EventHandler(this.BtnConfirmarDb_Click);
            // 
            // BtnConfirmarServer
            // 
            this.BtnConfirmarServer.Image = global::StrongBox.WinForms.Properties.Resources.Confirm20x20;
            this.BtnConfirmarServer.Location = new System.Drawing.Point(527, 5);
            this.BtnConfirmarServer.Name = "BtnConfirmarServer";
            this.BtnConfirmarServer.Size = new System.Drawing.Size(40, 30);
            this.BtnConfirmarServer.TabIndex = 6;
            this.BtnConfirmarServer.UseVisualStyleBackColor = true;
            this.BtnConfirmarServer.Click += new System.EventHandler(this.BtnConfirmarServer_Click);
            // 
            // LblDataSource
            // 
            this.LblDataSource.AutoSize = true;
            this.LblDataSource.Location = new System.Drawing.Point(32, 11);
            this.LblDataSource.Name = "LblDataSource";
            this.LblDataSource.Size = new System.Drawing.Size(70, 17);
            this.LblDataSource.TabIndex = 4;
            this.LblDataSource.Text = "Servidor: ";
            // 
            // BtnBuscarBanco
            // 
            this.BtnBuscarBanco.Enabled = false;
            this.BtnBuscarBanco.Image = global::StrongBox.WinForms.Properties.Resources.Buscar;
            this.BtnBuscarBanco.Location = new System.Drawing.Point(527, 40);
            this.BtnBuscarBanco.Name = "BtnBuscarBanco";
            this.BtnBuscarBanco.Size = new System.Drawing.Size(86, 28);
            this.BtnBuscarBanco.TabIndex = 1;
            this.BtnBuscarBanco.Text = "Buscar";
            this.BtnBuscarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscarBanco.UseVisualStyleBackColor = true;
            this.BtnBuscarBanco.Click += new System.EventHandler(this.BtnBuscarBanco_Click);
            // 
            // TxtNomeDb
            // 
            this.TxtNomeDb.Enabled = false;
            this.TxtNomeDb.Location = new System.Drawing.Point(108, 74);
            this.TxtNomeDb.Name = "TxtNomeDb";
            this.TxtNomeDb.ReadOnly = true;
            this.TxtNomeDb.Size = new System.Drawing.Size(414, 25);
            this.TxtNomeDb.TabIndex = 0;
            this.TxtNomeDb.TabStop = false;
            // 
            // LblNomeDb
            // 
            this.LblNomeDb.AutoSize = true;
            this.LblNomeDb.Location = new System.Drawing.Point(22, 77);
            this.LblNomeDb.Name = "LblNomeDb";
            this.LblNomeDb.Size = new System.Drawing.Size(80, 17);
            this.LblNomeDb.TabIndex = 0;
            this.LblNomeDb.Text = "Nome DB: ";
            // 
            // TxtCaminhoDb
            // 
            this.TxtCaminhoDb.Enabled = false;
            this.TxtCaminhoDb.Location = new System.Drawing.Point(108, 41);
            this.TxtCaminhoDb.Name = "TxtCaminhoDb";
            this.TxtCaminhoDb.ReadOnly = true;
            this.TxtCaminhoDb.Size = new System.Drawing.Size(414, 25);
            this.TxtCaminhoDb.TabIndex = 0;
            this.TxtCaminhoDb.TabStop = false;
            // 
            // BtnSalvarConfig
            // 
            this.BtnSalvarConfig.Enabled = false;
            this.BtnSalvarConfig.Image = global::StrongBox.WinForms.Properties.Resources.Salvar;
            this.BtnSalvarConfig.Location = new System.Drawing.Point(314, 105);
            this.BtnSalvarConfig.Name = "BtnSalvarConfig";
            this.BtnSalvarConfig.Size = new System.Drawing.Size(300, 30);
            this.BtnSalvarConfig.TabIndex = 3;
            this.BtnSalvarConfig.Text = "Salvar";
            this.BtnSalvarConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalvarConfig.UseVisualStyleBackColor = true;
            this.BtnSalvarConfig.Click += new System.EventHandler(this.BtnSalvarConfig_Click);
            // 
            // BtnTestarDb
            // 
            this.BtnTestarDb.Enabled = false;
            this.BtnTestarDb.Image = global::StrongBox.WinForms.Properties.Resources.Data_Base;
            this.BtnTestarDb.Location = new System.Drawing.Point(4, 105);
            this.BtnTestarDb.Name = "BtnTestarDb";
            this.BtnTestarDb.Size = new System.Drawing.Size(300, 30);
            this.BtnTestarDb.TabIndex = 2;
            this.BtnTestarDb.Text = "Testar banco";
            this.BtnTestarDb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTestarDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTestarDb.UseVisualStyleBackColor = true;
            this.BtnTestarDb.Click += new System.EventHandler(this.BtnTestarDb_Click);
            // 
            // LblCaminhoDb
            // 
            this.LblCaminhoDb.AutoSize = true;
            this.LblCaminhoDb.Location = new System.Drawing.Point(2, 44);
            this.LblCaminhoDb.Name = "LblCaminhoDb";
            this.LblCaminhoDb.Size = new System.Drawing.Size(100, 17);
            this.LblCaminhoDb.TabIndex = 0;
            this.LblCaminhoDb.Text = "Caminho DB: ";
            // 
            // PnlEstadoDb
            // 
            this.PnlEstadoDb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlEstadoDb.Controls.Add(this.LblEstadoConexao);
            this.PnlEstadoDb.Location = new System.Drawing.Point(12, 223);
            this.PnlEstadoDb.Name = "PnlEstadoDb";
            this.PnlEstadoDb.Size = new System.Drawing.Size(620, 26);
            this.PnlEstadoDb.TabIndex = 1;
            // 
            // LblEstadoConexao
            // 
            this.LblEstadoConexao.AutoSize = true;
            this.LblEstadoConexao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadoConexao.Location = new System.Drawing.Point(3, 5);
            this.LblEstadoConexao.Name = "LblEstadoConexao";
            this.LblEstadoConexao.Size = new System.Drawing.Size(0, 15);
            this.LblEstadoConexao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado da conexão";
            // 
            // OfdBuscarDb
            // 
            this.OfdBuscarDb.Filter = "Arquivos DB | *.mdf";
            this.OfdBuscarDb.Title = "Selecionar banco de dados...";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblCadeiaConexao);
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 26);
            this.panel1.TabIndex = 1;
            // 
            // LblCadeiaConexao
            // 
            this.LblCadeiaConexao.AutoSize = true;
            this.LblCadeiaConexao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadeiaConexao.Location = new System.Drawing.Point(1, 5);
            this.LblCadeiaConexao.Name = "LblCadeiaConexao";
            this.LblCadeiaConexao.Size = new System.Drawing.Size(0, 15);
            this.LblCadeiaConexao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadeia de conexão";
            // 
            // TxtDataSource
            // 
            this.TxtDataSource.Location = new System.Drawing.Point(108, 8);
            this.TxtDataSource.Name = "TxtDataSource";
            this.TxtDataSource.Size = new System.Drawing.Size(414, 25);
            this.TxtDataSource.TabIndex = 5;
            // 
            // FormBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(644, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlEstadoDb);
            this.Controls.Add(this.PnlDadosDb);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de dados";
            this.Load += new System.EventHandler(this.FormVerificaBanco_Load);
            this.PnlDadosDb.ResumeLayout(false);
            this.PnlDadosDb.PerformLayout();
            this.PnlEstadoDb.ResumeLayout(false);
            this.PnlEstadoDb.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlDadosDb;
        private System.Windows.Forms.Button BtnBuscarBanco;
        private System.Windows.Forms.Button BtnTestarDb;
        private System.Windows.Forms.TextBox TxtNomeDb;
        private System.Windows.Forms.TextBox TxtCaminhoDb;
        private System.Windows.Forms.Label LblNomeDb;
        private System.Windows.Forms.Label LblCaminhoDb;
        private System.Windows.Forms.Panel PnlEstadoDb;
        private System.Windows.Forms.Button BtnSalvarConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog OfdBuscarDb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCadeiaConexao;
        private System.Windows.Forms.Label LblDataSource;
        private System.Windows.Forms.Button BtnNegarServer;
        private System.Windows.Forms.Button BtnConfirmarServer;
        private System.Windows.Forms.Button BtnNegarDb;
        private System.Windows.Forms.Button BtnConfirmarDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEstadoConexao;
        private System.Windows.Forms.TextBox TxtDataSource;
    }
}