namespace StrongBox.WinForms.Janelas {
    partial class FormStrongBox {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStrongBox));
            this.TcPrincipal = new System.Windows.Forms.TabControl();
            this.TpLogins = new System.Windows.Forms.TabPage();
            this.FlpDadosLogins = new System.Windows.Forms.FlowLayoutPanel();
            this.GbxDadosUsuario = new System.Windows.Forms.GroupBox();
            this.UcLocal = new StrongBox.WinForms.Componentes.UcCbxLocal();
            this.NudTamanhoSenha = new System.Windows.Forms.NumericUpDown();
            this.LblTamanhoSenha = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtDados = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.GbxDadosSenha = new System.Windows.Forms.GroupBox();
            this.BtnGerarSenha = new System.Windows.Forms.Button();
            this.RbtnSenhaAlfaNumerica = new System.Windows.Forms.RadioButton();
            this.RbtnSenhaAlfabetica = new System.Windows.Forms.RadioButton();
            this.RbtnSenhaNumerica = new System.Windows.Forms.RadioButton();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.BtnSalvarLogins = new System.Windows.Forms.Button();
            this.BtnCancelarLogins = new System.Windows.Forms.Button();
            this.DgvLogins = new System.Windows.Forms.DataGridView();
            this.ClnCodigoLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTipoSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnLoginExcluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnLocalPorLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsLogins = new System.Windows.Forms.MenuStrip();
            this.TsmAdicionarLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAlterarLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmExcluirLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.TpLocais = new System.Windows.Forms.TabPage();
            this.FlpDadosLocal = new System.Windows.Forms.FlowLayoutPanel();
            this.GbxDadosDeLocal = new System.Windows.Forms.GroupBox();
            this.UcCategoria = new StrongBox.WinForms.Componentes.UcCbxCategoria();
            this.TxtNomeLocal = new System.Windows.Forms.TextBox();
            this.LblNomeLocal = new System.Windows.Forms.Label();
            this.BtnSalvarLocal = new System.Windows.Forms.Button();
            this.BtnCancelarLocal = new System.Windows.Forms.Button();
            this.DgvLocais = new System.Windows.Forms.DataGridView();
            this.ClnCodigoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnLocalExcluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNomeCategoriaPorLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsLocais = new System.Windows.Forms.MenuStrip();
            this.TsmIncluirLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmModificarLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmRemoverLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.TpCategorias = new System.Windows.Forms.TabPage();
            this.FlpDadosCategoria = new System.Windows.Forms.FlowLayoutPanel();
            this.GbxDadosDeCategoria = new System.Windows.Forms.GroupBox();
            this.LblPrefixo = new System.Windows.Forms.Label();
            this.TxtPrefixo = new System.Windows.Forms.TextBox();
            this.TxtNomeCategoria = new System.Windows.Forms.TextBox();
            this.LblNomeCategoria = new System.Windows.Forms.Label();
            this.BtnSalvarCategoria = new System.Windows.Forms.Button();
            this.BtnCancelarCategoria = new System.Windows.Forms.Button();
            this.DgvCategorias = new System.Windows.Forms.DataGridView();
            this.ClnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNomeCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPrefixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnExcluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsCategorias = new System.Windows.Forms.MenuStrip();
            this.TsmCriarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAlterarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmExcluirCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.TcPrincipal.SuspendLayout();
            this.TpLogins.SuspendLayout();
            this.FlpDadosLogins.SuspendLayout();
            this.GbxDadosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudTamanhoSenha)).BeginInit();
            this.GbxDadosSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLogins)).BeginInit();
            this.MsLogins.SuspendLayout();
            this.TpLocais.SuspendLayout();
            this.FlpDadosLocal.SuspendLayout();
            this.GbxDadosDeLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocais)).BeginInit();
            this.MsLocais.SuspendLayout();
            this.TpCategorias.SuspendLayout();
            this.FlpDadosCategoria.SuspendLayout();
            this.GbxDadosDeCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).BeginInit();
            this.MsCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcPrincipal
            // 
            this.TcPrincipal.Controls.Add(this.TpLogins);
            this.TcPrincipal.Controls.Add(this.TpLocais);
            this.TcPrincipal.Controls.Add(this.TpCategorias);
            this.TcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TcPrincipal.Name = "TcPrincipal";
            this.TcPrincipal.SelectedIndex = 0;
            this.TcPrincipal.Size = new System.Drawing.Size(1094, 487);
            this.TcPrincipal.TabIndex = 0;
            this.TcPrincipal.SelectedIndexChanged += new System.EventHandler(this.TcPrincipal_SelectedIndexChanged);
            // 
            // TpLogins
            // 
            this.TpLogins.BackColor = System.Drawing.Color.Silver;
            this.TpLogins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TpLogins.Controls.Add(this.FlpDadosLogins);
            this.TpLogins.Controls.Add(this.DgvLogins);
            this.TpLogins.Controls.Add(this.MsLogins);
            this.TpLogins.Location = new System.Drawing.Point(4, 26);
            this.TpLogins.Name = "TpLogins";
            this.TpLogins.Padding = new System.Windows.Forms.Padding(3);
            this.TpLogins.Size = new System.Drawing.Size(1086, 457);
            this.TpLogins.TabIndex = 0;
            this.TpLogins.Text = "Logins";
            // 
            // FlpDadosLogins
            // 
            this.FlpDadosLogins.AutoScroll = true;
            this.FlpDadosLogins.Controls.Add(this.GbxDadosUsuario);
            this.FlpDadosLogins.Controls.Add(this.GbxDadosSenha);
            this.FlpDadosLogins.Controls.Add(this.BtnSalvarLogins);
            this.FlpDadosLogins.Controls.Add(this.BtnCancelarLogins);
            this.FlpDadosLogins.Dock = System.Windows.Forms.DockStyle.Right;
            this.FlpDadosLogins.Enabled = false;
            this.FlpDadosLogins.Location = new System.Drawing.Point(552, 28);
            this.FlpDadosLogins.Name = "FlpDadosLogins";
            this.FlpDadosLogins.Size = new System.Drawing.Size(529, 424);
            this.FlpDadosLogins.TabIndex = 5;
            // 
            // GbxDadosUsuario
            // 
            this.GbxDadosUsuario.BackColor = System.Drawing.Color.Transparent;
            this.GbxDadosUsuario.Controls.Add(this.UcLocal);
            this.GbxDadosUsuario.Controls.Add(this.NudTamanhoSenha);
            this.GbxDadosUsuario.Controls.Add(this.LblTamanhoSenha);
            this.GbxDadosUsuario.Controls.Add(this.Lbl);
            this.GbxDadosUsuario.Controls.Add(this.LblUsuario);
            this.GbxDadosUsuario.Controls.Add(this.TxtDados);
            this.GbxDadosUsuario.Controls.Add(this.TxtUsuario);
            this.GbxDadosUsuario.Enabled = false;
            this.GbxDadosUsuario.Location = new System.Drawing.Point(3, 3);
            this.GbxDadosUsuario.Name = "GbxDadosUsuario";
            this.GbxDadosUsuario.Size = new System.Drawing.Size(517, 177);
            this.GbxDadosUsuario.TabIndex = 2;
            this.GbxDadosUsuario.TabStop = false;
            this.GbxDadosUsuario.Text = "Dados do usuário";
            // 
            // UcLocal
            // 
            this.UcLocal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UcLocal.BackColor = System.Drawing.Color.Transparent;
            this.UcLocal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcLocal.Location = new System.Drawing.Point(6, 123);
            this.UcLocal.Name = "UcLocal";
            this.UcLocal.Size = new System.Drawing.Size(382, 48);
            this.UcLocal.TabIndex = 3;
            this.UcLocal.Leave += new System.EventHandler(this.UcLocal_Leave);
            // 
            // NudTamanhoSenha
            // 
            this.NudTamanhoSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NudTamanhoSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudTamanhoSenha.ForeColor = System.Drawing.Color.Black;
            this.NudTamanhoSenha.Location = new System.Drawing.Point(394, 142);
            this.NudTamanhoSenha.Name = "NudTamanhoSenha";
            this.NudTamanhoSenha.Size = new System.Drawing.Size(117, 25);
            this.NudTamanhoSenha.TabIndex = 4;
            this.NudTamanhoSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudTamanhoSenha.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // LblTamanhoSenha
            // 
            this.LblTamanhoSenha.AutoSize = true;
            this.LblTamanhoSenha.Location = new System.Drawing.Point(417, 122);
            this.LblTamanhoSenha.Name = "LblTamanhoSenha";
            this.LblTamanhoSenha.Size = new System.Drawing.Size(68, 17);
            this.LblTamanhoSenha.TabIndex = 3;
            this.LblTamanhoSenha.Text = "Tamanho";
            this.LblTamanhoSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(235, 72);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(51, 17);
            this.Lbl.TabIndex = 2;
            this.Lbl.Text = "Dados";
            this.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(230, 21);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(58, 17);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuário";
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtDados
            // 
            this.TxtDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDados.Location = new System.Drawing.Point(6, 92);
            this.TxtDados.MaxLength = 30;
            this.TxtDados.Name = "TxtDados";
            this.TxtDados.Size = new System.Drawing.Size(505, 25);
            this.TxtDados.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUsuario.Location = new System.Drawing.Point(6, 41);
            this.TxtUsuario.MaxLength = 30;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(505, 25);
            this.TxtUsuario.TabIndex = 1;
            // 
            // GbxDadosSenha
            // 
            this.GbxDadosSenha.Controls.Add(this.BtnGerarSenha);
            this.GbxDadosSenha.Controls.Add(this.RbtnSenhaAlfaNumerica);
            this.GbxDadosSenha.Controls.Add(this.RbtnSenhaAlfabetica);
            this.GbxDadosSenha.Controls.Add(this.RbtnSenhaNumerica);
            this.GbxDadosSenha.Controls.Add(this.TxtSenha);
            this.GbxDadosSenha.Controls.Add(this.LblSenha);
            this.GbxDadosSenha.Enabled = false;
            this.GbxDadosSenha.Location = new System.Drawing.Point(3, 186);
            this.GbxDadosSenha.Name = "GbxDadosSenha";
            this.GbxDadosSenha.Size = new System.Drawing.Size(517, 142);
            this.GbxDadosSenha.TabIndex = 3;
            this.GbxDadosSenha.TabStop = false;
            this.GbxDadosSenha.Text = "Dados de senha";
            // 
            // BtnGerarSenha
            // 
            this.BtnGerarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGerarSenha.Enabled = false;
            this.BtnGerarSenha.Image = global::StrongBox.WinForms.Properties.Resources.Senha1;
            this.BtnGerarSenha.Location = new System.Drawing.Point(6, 104);
            this.BtnGerarSenha.Name = "BtnGerarSenha";
            this.BtnGerarSenha.Size = new System.Drawing.Size(505, 32);
            this.BtnGerarSenha.TabIndex = 8;
            this.BtnGerarSenha.Text = "Gerar senha";
            this.BtnGerarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGerarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGerarSenha.UseVisualStyleBackColor = true;
            this.BtnGerarSenha.Click += new System.EventHandler(this.BtnGerarSenha_Click);
            // 
            // RbtnSenhaAlfaNumerica
            // 
            this.RbtnSenhaAlfaNumerica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbtnSenhaAlfaNumerica.AutoSize = true;
            this.RbtnSenhaAlfaNumerica.Location = new System.Drawing.Point(394, 24);
            this.RbtnSenhaAlfaNumerica.Name = "RbtnSenhaAlfaNumerica";
            this.RbtnSenhaAlfaNumerica.Size = new System.Drawing.Size(117, 21);
            this.RbtnSenhaAlfaNumerica.TabIndex = 7;
            this.RbtnSenhaAlfaNumerica.TabStop = true;
            this.RbtnSenhaAlfaNumerica.Text = "Alfa Numérica";
            this.RbtnSenhaAlfaNumerica.UseVisualStyleBackColor = true;
            // 
            // RbtnSenhaAlfabetica
            // 
            this.RbtnSenhaAlfabetica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbtnSenhaAlfabetica.AutoSize = true;
            this.RbtnSenhaAlfabetica.Location = new System.Drawing.Point(211, 24);
            this.RbtnSenhaAlfabetica.Name = "RbtnSenhaAlfabetica";
            this.RbtnSenhaAlfabetica.Size = new System.Drawing.Size(86, 21);
            this.RbtnSenhaAlfabetica.TabIndex = 6;
            this.RbtnSenhaAlfabetica.TabStop = true;
            this.RbtnSenhaAlfabetica.Text = "Afabética";
            this.RbtnSenhaAlfabetica.UseVisualStyleBackColor = true;
            // 
            // RbtnSenhaNumerica
            // 
            this.RbtnSenhaNumerica.AutoSize = true;
            this.RbtnSenhaNumerica.Location = new System.Drawing.Point(6, 24);
            this.RbtnSenhaNumerica.Name = "RbtnSenhaNumerica";
            this.RbtnSenhaNumerica.Size = new System.Drawing.Size(89, 21);
            this.RbtnSenhaNumerica.TabIndex = 5;
            this.RbtnSenhaNumerica.TabStop = true;
            this.RbtnSenhaNumerica.Text = "Numérica";
            this.RbtnSenhaNumerica.UseVisualStyleBackColor = true;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSenha.Location = new System.Drawing.Point(6, 73);
            this.TxtSenha.MaxLength = 20;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.ReadOnly = true;
            this.TxtSenha.ShortcutsEnabled = false;
            this.TxtSenha.Size = new System.Drawing.Size(505, 25);
            this.TxtSenha.TabIndex = 0;
            this.TxtSenha.TabStop = false;
            this.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(230, 53);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(50, 17);
            this.LblSenha.TabIndex = 1;
            this.LblSenha.Text = "Senha";
            // 
            // BtnSalvarLogins
            // 
            this.BtnSalvarLogins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvarLogins.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarLogins.Image = global::StrongBox.WinForms.Properties.Resources.Salvar;
            this.BtnSalvarLogins.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarLogins.Location = new System.Drawing.Point(3, 334);
            this.BtnSalvarLogins.Name = "BtnSalvarLogins";
            this.BtnSalvarLogins.Size = new System.Drawing.Size(520, 50);
            this.BtnSalvarLogins.TabIndex = 9;
            this.BtnSalvarLogins.Text = "Salvar";
            this.BtnSalvarLogins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalvarLogins.UseVisualStyleBackColor = true;
            this.BtnSalvarLogins.Click += new System.EventHandler(this.BtnSalvarLogins_Click);
            // 
            // BtnCancelarLogins
            // 
            this.BtnCancelarLogins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarLogins.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarLogins.Image = global::StrongBox.WinForms.Properties.Resources.Cancelar;
            this.BtnCancelarLogins.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarLogins.Location = new System.Drawing.Point(3, 390);
            this.BtnCancelarLogins.Name = "BtnCancelarLogins";
            this.BtnCancelarLogins.Size = new System.Drawing.Size(520, 50);
            this.BtnCancelarLogins.TabIndex = 10;
            this.BtnCancelarLogins.Text = "Cancelar";
            this.BtnCancelarLogins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelarLogins.UseVisualStyleBackColor = true;
            this.BtnCancelarLogins.Click += new System.EventHandler(this.BtnCancelarLogins_Click);
            // 
            // DgvLogins
            // 
            this.DgvLogins.AllowUserToAddRows = false;
            this.DgvLogins.AllowUserToDeleteRows = false;
            this.DgvLogins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvLogins.BackgroundColor = System.Drawing.Color.White;
            this.DgvLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLogins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnCodigoLogin,
            this.ClnUsuario,
            this.ClnObservacao,
            this.ClnSenha,
            this.ClnTamanho,
            this.ClnTipoSenha,
            this.ClnLoginExcluido,
            this.ClnLocal,
            this.ClnLocalPorLogin});
            this.DgvLogins.GridColor = System.Drawing.Color.Black;
            this.DgvLogins.Location = new System.Drawing.Point(7, 31);
            this.DgvLogins.Name = "DgvLogins";
            this.DgvLogins.ReadOnly = true;
            this.DgvLogins.Size = new System.Drawing.Size(539, 421);
            this.DgvLogins.TabIndex = 1;
            // 
            // ClnCodigoLogin
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClnCodigoLogin.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClnCodigoLogin.HeaderText = "Código";
            this.ClnCodigoLogin.Name = "ClnCodigoLogin";
            this.ClnCodigoLogin.ReadOnly = true;
            this.ClnCodigoLogin.Width = 63;
            // 
            // ClnUsuario
            // 
            this.ClnUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnUsuario.HeaderText = "Usuário";
            this.ClnUsuario.MinimumWidth = 100;
            this.ClnUsuario.Name = "ClnUsuario";
            this.ClnUsuario.ReadOnly = true;
            // 
            // ClnObservacao
            // 
            this.ClnObservacao.HeaderText = "Observação";
            this.ClnObservacao.MinimumWidth = 100;
            this.ClnObservacao.Name = "ClnObservacao";
            this.ClnObservacao.ReadOnly = true;
            this.ClnObservacao.Width = 200;
            // 
            // ClnSenha
            // 
            this.ClnSenha.HeaderText = "Senha";
            this.ClnSenha.MinimumWidth = 50;
            this.ClnSenha.Name = "ClnSenha";
            this.ClnSenha.ReadOnly = true;
            // 
            // ClnTamanho
            // 
            this.ClnTamanho.HeaderText = "Tamanho";
            this.ClnTamanho.Name = "ClnTamanho";
            this.ClnTamanho.ReadOnly = true;
            this.ClnTamanho.Visible = false;
            // 
            // ClnTipoSenha
            // 
            this.ClnTipoSenha.HeaderText = "Tipo de senha";
            this.ClnTipoSenha.Name = "ClnTipoSenha";
            this.ClnTipoSenha.ReadOnly = true;
            this.ClnTipoSenha.Visible = false;
            // 
            // ClnLoginExcluido
            // 
            this.ClnLoginExcluido.HeaderText = "Está excluído";
            this.ClnLoginExcluido.Name = "ClnLoginExcluido";
            this.ClnLoginExcluido.ReadOnly = true;
            this.ClnLoginExcluido.Visible = false;
            // 
            // ClnLocal
            // 
            this.ClnLocal.HeaderText = "Código local";
            this.ClnLocal.Name = "ClnLocal";
            this.ClnLocal.ReadOnly = true;
            this.ClnLocal.Visible = false;
            // 
            // ClnLocalPorLogin
            // 
            this.ClnLocalPorLogin.HeaderText = "Local";
            this.ClnLocalPorLogin.MinimumWidth = 100;
            this.ClnLocalPorLogin.Name = "ClnLocalPorLogin";
            this.ClnLocalPorLogin.ReadOnly = true;
            this.ClnLocalPorLogin.Width = 150;
            // 
            // MsLogins
            // 
            this.MsLogins.BackColor = System.Drawing.Color.DimGray;
            this.MsLogins.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsLogins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmAdicionarLogin,
            this.TsmAlterarLogin,
            this.TsmAlterarSenha,
            this.TsmExcluirLogin});
            this.MsLogins.Location = new System.Drawing.Point(3, 3);
            this.MsLogins.Name = "MsLogins";
            this.MsLogins.Size = new System.Drawing.Size(1078, 25);
            this.MsLogins.TabIndex = 0;
            this.MsLogins.Text = "Menu de logins";
            // 
            // TsmAdicionarLogin
            // 
            this.TsmAdicionarLogin.ForeColor = System.Drawing.Color.Silver;
            this.TsmAdicionarLogin.Name = "TsmAdicionarLogin";
            this.TsmAdicionarLogin.ShortcutKeyDisplayString = "F3";
            this.TsmAdicionarLogin.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.TsmAdicionarLogin.Size = new System.Drawing.Size(80, 21);
            this.TsmAdicionarLogin.Text = "Adicionar";
            this.TsmAdicionarLogin.Click += new System.EventHandler(this.TsmAdicionarLogin_Click);
            // 
            // TsmAlterarLogin
            // 
            this.TsmAlterarLogin.ForeColor = System.Drawing.Color.Silver;
            this.TsmAlterarLogin.Name = "TsmAlterarLogin";
            this.TsmAlterarLogin.ShortcutKeyDisplayString = "F4";
            this.TsmAlterarLogin.Size = new System.Drawing.Size(96, 21);
            this.TsmAlterarLogin.Text = "Alterar login";
            this.TsmAlterarLogin.Click += new System.EventHandler(this.TsmAlterarLogin_Click);
            // 
            // TsmAlterarSenha
            // 
            this.TsmAlterarSenha.ForeColor = System.Drawing.Color.Silver;
            this.TsmAlterarSenha.Name = "TsmAlterarSenha";
            this.TsmAlterarSenha.ShortcutKeyDisplayString = "F5";
            this.TsmAlterarSenha.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.TsmAlterarSenha.Size = new System.Drawing.Size(106, 21);
            this.TsmAlterarSenha.Text = "Alterar senha";
            this.TsmAlterarSenha.Click += new System.EventHandler(this.TsmAlterarSenha_Click);
            // 
            // TsmExcluirLogin
            // 
            this.TsmExcluirLogin.ForeColor = System.Drawing.Color.Silver;
            this.TsmExcluirLogin.Name = "TsmExcluirLogin";
            this.TsmExcluirLogin.ShortcutKeyDisplayString = "F6";
            this.TsmExcluirLogin.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.TsmExcluirLogin.Size = new System.Drawing.Size(64, 21);
            this.TsmExcluirLogin.Text = "Excluir";
            this.TsmExcluirLogin.Click += new System.EventHandler(this.TsmExcluirLogin_Click);
            // 
            // TpLocais
            // 
            this.TpLocais.BackColor = System.Drawing.Color.Silver;
            this.TpLocais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TpLocais.Controls.Add(this.FlpDadosLocal);
            this.TpLocais.Controls.Add(this.DgvLocais);
            this.TpLocais.Controls.Add(this.MsLocais);
            this.TpLocais.Location = new System.Drawing.Point(4, 26);
            this.TpLocais.Name = "TpLocais";
            this.TpLocais.Padding = new System.Windows.Forms.Padding(3);
            this.TpLocais.Size = new System.Drawing.Size(1086, 457);
            this.TpLocais.TabIndex = 1;
            this.TpLocais.Text = "Locais";
            // 
            // FlpDadosLocal
            // 
            this.FlpDadosLocal.AutoScroll = true;
            this.FlpDadosLocal.Controls.Add(this.GbxDadosDeLocal);
            this.FlpDadosLocal.Controls.Add(this.BtnSalvarLocal);
            this.FlpDadosLocal.Controls.Add(this.BtnCancelarLocal);
            this.FlpDadosLocal.Dock = System.Windows.Forms.DockStyle.Right;
            this.FlpDadosLocal.Enabled = false;
            this.FlpDadosLocal.Location = new System.Drawing.Point(552, 28);
            this.FlpDadosLocal.Name = "FlpDadosLocal";
            this.FlpDadosLocal.Size = new System.Drawing.Size(529, 424);
            this.FlpDadosLocal.TabIndex = 3;
            // 
            // GbxDadosDeLocal
            // 
            this.GbxDadosDeLocal.Controls.Add(this.UcCategoria);
            this.GbxDadosDeLocal.Controls.Add(this.TxtNomeLocal);
            this.GbxDadosDeLocal.Controls.Add(this.LblNomeLocal);
            this.GbxDadosDeLocal.Location = new System.Drawing.Point(3, 3);
            this.GbxDadosDeLocal.Name = "GbxDadosDeLocal";
            this.GbxDadosDeLocal.Size = new System.Drawing.Size(517, 129);
            this.GbxDadosDeLocal.TabIndex = 0;
            this.GbxDadosDeLocal.TabStop = false;
            this.GbxDadosDeLocal.Text = "Dados de local";
            // 
            // UcCategoria
            // 
            this.UcCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UcCategoria.BackColor = System.Drawing.Color.Transparent;
            this.UcCategoria.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcCategoria.Location = new System.Drawing.Point(7, 73);
            this.UcCategoria.Name = "UcCategoria";
            this.UcCategoria.Size = new System.Drawing.Size(507, 48);
            this.UcCategoria.TabIndex = 2;
            // 
            // TxtNomeLocal
            // 
            this.TxtNomeLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNomeLocal.Location = new System.Drawing.Point(6, 41);
            this.TxtNomeLocal.MaxLength = 30;
            this.TxtNomeLocal.Name = "TxtNomeLocal";
            this.TxtNomeLocal.Size = new System.Drawing.Size(505, 25);
            this.TxtNomeLocal.TabIndex = 1;
            // 
            // LblNomeLocal
            // 
            this.LblNomeLocal.AutoSize = true;
            this.LblNomeLocal.Location = new System.Drawing.Point(240, 21);
            this.LblNomeLocal.Name = "LblNomeLocal";
            this.LblNomeLocal.Size = new System.Drawing.Size(47, 17);
            this.LblNomeLocal.TabIndex = 0;
            this.LblNomeLocal.Text = "Nome";
            // 
            // BtnSalvarLocal
            // 
            this.BtnSalvarLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvarLocal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarLocal.Image = global::StrongBox.WinForms.Properties.Resources.Salvar;
            this.BtnSalvarLocal.Location = new System.Drawing.Point(3, 138);
            this.BtnSalvarLocal.Name = "BtnSalvarLocal";
            this.BtnSalvarLocal.Size = new System.Drawing.Size(520, 50);
            this.BtnSalvarLocal.TabIndex = 3;
            this.BtnSalvarLocal.Text = "Salvar";
            this.BtnSalvarLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalvarLocal.UseVisualStyleBackColor = true;
            this.BtnSalvarLocal.Click += new System.EventHandler(this.BtnSalvarLocal_Click);
            // 
            // BtnCancelarLocal
            // 
            this.BtnCancelarLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarLocal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarLocal.Image = global::StrongBox.WinForms.Properties.Resources.Cancelar;
            this.BtnCancelarLocal.Location = new System.Drawing.Point(3, 194);
            this.BtnCancelarLocal.Name = "BtnCancelarLocal";
            this.BtnCancelarLocal.Size = new System.Drawing.Size(520, 50);
            this.BtnCancelarLocal.TabIndex = 4;
            this.BtnCancelarLocal.Text = "Cancelar";
            this.BtnCancelarLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelarLocal.UseVisualStyleBackColor = true;
            this.BtnCancelarLocal.Click += new System.EventHandler(this.BtnCancelarLocal_Click);
            // 
            // DgvLocais
            // 
            this.DgvLocais.AllowUserToAddRows = false;
            this.DgvLocais.AllowUserToDeleteRows = false;
            this.DgvLocais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvLocais.BackgroundColor = System.Drawing.Color.White;
            this.DgvLocais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLocais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnCodigoLocal,
            this.ClnNomeLocal,
            this.ClnCategoria,
            this.ClnLocalExcluido,
            this.ClnNomeCategoriaPorLocal});
            this.DgvLocais.GridColor = System.Drawing.Color.Black;
            this.DgvLocais.Location = new System.Drawing.Point(7, 31);
            this.DgvLocais.Name = "DgvLocais";
            this.DgvLocais.ReadOnly = true;
            this.DgvLocais.Size = new System.Drawing.Size(539, 417);
            this.DgvLocais.TabIndex = 2;
            // 
            // ClnCodigoLocal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClnCodigoLocal.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClnCodigoLocal.HeaderText = "Código";
            this.ClnCodigoLocal.Name = "ClnCodigoLocal";
            this.ClnCodigoLocal.ReadOnly = true;
            this.ClnCodigoLocal.Width = 63;
            // 
            // ClnNomeLocal
            // 
            this.ClnNomeLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnNomeLocal.HeaderText = "Local";
            this.ClnNomeLocal.MinimumWidth = 50;
            this.ClnNomeLocal.Name = "ClnNomeLocal";
            this.ClnNomeLocal.ReadOnly = true;
            // 
            // ClnCategoria
            // 
            this.ClnCategoria.HeaderText = "Código categoria";
            this.ClnCategoria.Name = "ClnCategoria";
            this.ClnCategoria.ReadOnly = true;
            this.ClnCategoria.Visible = false;
            // 
            // ClnLocalExcluido
            // 
            this.ClnLocalExcluido.HeaderText = "Está excluído";
            this.ClnLocalExcluido.Name = "ClnLocalExcluido";
            this.ClnLocalExcluido.ReadOnly = true;
            this.ClnLocalExcluido.Visible = false;
            // 
            // ClnNomeCategoriaPorLocal
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClnNomeCategoriaPorLocal.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClnNomeCategoriaPorLocal.HeaderText = "Categoria";
            this.ClnNomeCategoriaPorLocal.Name = "ClnNomeCategoriaPorLocal";
            this.ClnNomeCategoriaPorLocal.ReadOnly = true;
            this.ClnNomeCategoriaPorLocal.Width = 150;
            // 
            // MsLocais
            // 
            this.MsLocais.BackColor = System.Drawing.Color.DimGray;
            this.MsLocais.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsLocais.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmIncluirLocal,
            this.TsmModificarLocal,
            this.TsmRemoverLocal});
            this.MsLocais.Location = new System.Drawing.Point(3, 3);
            this.MsLocais.Name = "MsLocais";
            this.MsLocais.Size = new System.Drawing.Size(1078, 25);
            this.MsLocais.TabIndex = 0;
            this.MsLocais.Text = "MsLocais";
            // 
            // TsmIncluirLocal
            // 
            this.TsmIncluirLocal.ForeColor = System.Drawing.Color.Silver;
            this.TsmIncluirLocal.Name = "TsmIncluirLocal";
            this.TsmIncluirLocal.ShortcutKeyDisplayString = "F7";
            this.TsmIncluirLocal.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.TsmIncluirLocal.Size = new System.Drawing.Size(58, 21);
            this.TsmIncluirLocal.Text = "Incluir";
            this.TsmIncluirLocal.Click += new System.EventHandler(this.TsmIncluirLocal_Click);
            // 
            // TsmModificarLocal
            // 
            this.TsmModificarLocal.ForeColor = System.Drawing.Color.Silver;
            this.TsmModificarLocal.Name = "TsmModificarLocal";
            this.TsmModificarLocal.ShortcutKeyDisplayString = "F8";
            this.TsmModificarLocal.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.TsmModificarLocal.Size = new System.Drawing.Size(78, 21);
            this.TsmModificarLocal.Text = "Modificar";
            this.TsmModificarLocal.Click += new System.EventHandler(this.TsmModificarLocal_Click);
            // 
            // TsmRemoverLocal
            // 
            this.TsmRemoverLocal.ForeColor = System.Drawing.Color.Silver;
            this.TsmRemoverLocal.Name = "TsmRemoverLocal";
            this.TsmRemoverLocal.ShortcutKeyDisplayString = "F9";
            this.TsmRemoverLocal.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.TsmRemoverLocal.Size = new System.Drawing.Size(80, 21);
            this.TsmRemoverLocal.Text = "Remover";
            this.TsmRemoverLocal.Click += new System.EventHandler(this.TsmRemoverLocal_Click);
            // 
            // TpCategorias
            // 
            this.TpCategorias.BackColor = System.Drawing.Color.Silver;
            this.TpCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TpCategorias.Controls.Add(this.FlpDadosCategoria);
            this.TpCategorias.Controls.Add(this.DgvCategorias);
            this.TpCategorias.Controls.Add(this.MsCategorias);
            this.TpCategorias.Location = new System.Drawing.Point(4, 26);
            this.TpCategorias.Name = "TpCategorias";
            this.TpCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.TpCategorias.Size = new System.Drawing.Size(1086, 457);
            this.TpCategorias.TabIndex = 2;
            this.TpCategorias.Text = "Categorias";
            // 
            // FlpDadosCategoria
            // 
            this.FlpDadosCategoria.AutoScroll = true;
            this.FlpDadosCategoria.Controls.Add(this.GbxDadosDeCategoria);
            this.FlpDadosCategoria.Controls.Add(this.BtnSalvarCategoria);
            this.FlpDadosCategoria.Controls.Add(this.BtnCancelarCategoria);
            this.FlpDadosCategoria.Dock = System.Windows.Forms.DockStyle.Right;
            this.FlpDadosCategoria.Enabled = false;
            this.FlpDadosCategoria.Location = new System.Drawing.Point(552, 28);
            this.FlpDadosCategoria.Name = "FlpDadosCategoria";
            this.FlpDadosCategoria.Size = new System.Drawing.Size(529, 424);
            this.FlpDadosCategoria.TabIndex = 5;
            // 
            // GbxDadosDeCategoria
            // 
            this.GbxDadosDeCategoria.Controls.Add(this.LblPrefixo);
            this.GbxDadosDeCategoria.Controls.Add(this.TxtPrefixo);
            this.GbxDadosDeCategoria.Controls.Add(this.TxtNomeCategoria);
            this.GbxDadosDeCategoria.Controls.Add(this.LblNomeCategoria);
            this.GbxDadosDeCategoria.Location = new System.Drawing.Point(3, 3);
            this.GbxDadosDeCategoria.Name = "GbxDadosDeCategoria";
            this.GbxDadosDeCategoria.Size = new System.Drawing.Size(517, 127);
            this.GbxDadosDeCategoria.TabIndex = 0;
            this.GbxDadosDeCategoria.TabStop = false;
            this.GbxDadosDeCategoria.Text = "Dados de categoria";
            // 
            // LblPrefixo
            // 
            this.LblPrefixo.AutoSize = true;
            this.LblPrefixo.Location = new System.Drawing.Point(237, 69);
            this.LblPrefixo.Name = "LblPrefixo";
            this.LblPrefixo.Size = new System.Drawing.Size(53, 17);
            this.LblPrefixo.TabIndex = 2;
            this.LblPrefixo.Text = "Prefixo";
            // 
            // TxtPrefixo
            // 
            this.TxtPrefixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrefixo.Location = new System.Drawing.Point(6, 89);
            this.TxtPrefixo.MaxLength = 3;
            this.TxtPrefixo.Name = "TxtPrefixo";
            this.TxtPrefixo.Size = new System.Drawing.Size(505, 25);
            this.TxtPrefixo.TabIndex = 2;
            this.TxtPrefixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNomeCategoria
            // 
            this.TxtNomeCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNomeCategoria.Location = new System.Drawing.Point(6, 41);
            this.TxtNomeCategoria.MaxLength = 30;
            this.TxtNomeCategoria.Name = "TxtNomeCategoria";
            this.TxtNomeCategoria.Size = new System.Drawing.Size(505, 25);
            this.TxtNomeCategoria.TabIndex = 1;
            this.TxtNomeCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNomeCategoria
            // 
            this.LblNomeCategoria.AutoSize = true;
            this.LblNomeCategoria.Location = new System.Drawing.Point(240, 21);
            this.LblNomeCategoria.Name = "LblNomeCategoria";
            this.LblNomeCategoria.Size = new System.Drawing.Size(47, 17);
            this.LblNomeCategoria.TabIndex = 0;
            this.LblNomeCategoria.Text = "Nome";
            // 
            // BtnSalvarCategoria
            // 
            this.BtnSalvarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvarCategoria.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarCategoria.Image = global::StrongBox.WinForms.Properties.Resources.Salvar;
            this.BtnSalvarCategoria.Location = new System.Drawing.Point(3, 136);
            this.BtnSalvarCategoria.Name = "BtnSalvarCategoria";
            this.BtnSalvarCategoria.Size = new System.Drawing.Size(520, 50);
            this.BtnSalvarCategoria.TabIndex = 3;
            this.BtnSalvarCategoria.Text = "Salvar";
            this.BtnSalvarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalvarCategoria.UseVisualStyleBackColor = true;
            this.BtnSalvarCategoria.Click += new System.EventHandler(this.BtnSalvarCategoria_Click);
            // 
            // BtnCancelarCategoria
            // 
            this.BtnCancelarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarCategoria.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCategoria.Image = global::StrongBox.WinForms.Properties.Resources.Cancelar;
            this.BtnCancelarCategoria.Location = new System.Drawing.Point(3, 192);
            this.BtnCancelarCategoria.Name = "BtnCancelarCategoria";
            this.BtnCancelarCategoria.Size = new System.Drawing.Size(520, 50);
            this.BtnCancelarCategoria.TabIndex = 4;
            this.BtnCancelarCategoria.Text = "Cancelar";
            this.BtnCancelarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelarCategoria.UseVisualStyleBackColor = true;
            this.BtnCancelarCategoria.Click += new System.EventHandler(this.BtnCancelarCategoria_Click);
            // 
            // DgvCategorias
            // 
            this.DgvCategorias.AllowUserToAddRows = false;
            this.DgvCategorias.AllowUserToDeleteRows = false;
            this.DgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnCodigo,
            this.ClnNomeCategoria,
            this.ClnPrefixo,
            this.ClnExcluido});
            this.DgvCategorias.GridColor = System.Drawing.Color.Black;
            this.DgvCategorias.Location = new System.Drawing.Point(7, 31);
            this.DgvCategorias.Name = "DgvCategorias";
            this.DgvCategorias.ReadOnly = true;
            this.DgvCategorias.Size = new System.Drawing.Size(539, 417);
            this.DgvCategorias.TabIndex = 4;
            // 
            // ClnCodigo
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClnCodigo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClnCodigo.HeaderText = "Código";
            this.ClnCodigo.Name = "ClnCodigo";
            this.ClnCodigo.ReadOnly = true;
            this.ClnCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnCodigo.Width = 63;
            // 
            // ClnNomeCategoria
            // 
            this.ClnNomeCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnNomeCategoria.FillWeight = 75F;
            this.ClnNomeCategoria.HeaderText = "Categoria";
            this.ClnNomeCategoria.Name = "ClnNomeCategoria";
            this.ClnNomeCategoria.ReadOnly = true;
            this.ClnNomeCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnPrefixo
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClnPrefixo.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClnPrefixo.HeaderText = "Prefixo";
            this.ClnPrefixo.Name = "ClnPrefixo";
            this.ClnPrefixo.ReadOnly = true;
            this.ClnPrefixo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnPrefixo.Width = 60;
            // 
            // ClnExcluido
            // 
            this.ClnExcluido.HeaderText = "Está excluído";
            this.ClnExcluido.Name = "ClnExcluido";
            this.ClnExcluido.ReadOnly = true;
            this.ClnExcluido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnExcluido.Visible = false;
            // 
            // MsCategorias
            // 
            this.MsCategorias.BackColor = System.Drawing.Color.DimGray;
            this.MsCategorias.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsCategorias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmCriarCategoria,
            this.TsmAlterarCategoria,
            this.TsmExcluirCategoria});
            this.MsCategorias.Location = new System.Drawing.Point(3, 3);
            this.MsCategorias.Name = "MsCategorias";
            this.MsCategorias.Size = new System.Drawing.Size(1078, 25);
            this.MsCategorias.TabIndex = 0;
            this.MsCategorias.Text = "Menu de categorias";
            // 
            // TsmCriarCategoria
            // 
            this.TsmCriarCategoria.BackColor = System.Drawing.Color.DimGray;
            this.TsmCriarCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsmCriarCategoria.ForeColor = System.Drawing.Color.Silver;
            this.TsmCriarCategoria.Name = "TsmCriarCategoria";
            this.TsmCriarCategoria.ShortcutKeyDisplayString = "F12";
            this.TsmCriarCategoria.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.TsmCriarCategoria.Size = new System.Drawing.Size(52, 21);
            this.TsmCriarCategoria.Text = "Criar";
            this.TsmCriarCategoria.Click += new System.EventHandler(this.TsmCriarCategoria_Click);
            // 
            // TsmAlterarCategoria
            // 
            this.TsmAlterarCategoria.BackColor = System.Drawing.Color.DimGray;
            this.TsmAlterarCategoria.ForeColor = System.Drawing.Color.Silver;
            this.TsmAlterarCategoria.Name = "TsmAlterarCategoria";
            this.TsmAlterarCategoria.ShortcutKeyDisplayString = "F11";
            this.TsmAlterarCategoria.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.TsmAlterarCategoria.Size = new System.Drawing.Size(62, 21);
            this.TsmAlterarCategoria.Text = "Alterar";
            this.TsmAlterarCategoria.Click += new System.EventHandler(this.TsmAlterarCategoria_Click);
            // 
            // TsmExcluirCategoria
            // 
            this.TsmExcluirCategoria.ForeColor = System.Drawing.Color.Silver;
            this.TsmExcluirCategoria.Name = "TsmExcluirCategoria";
            this.TsmExcluirCategoria.ShortcutKeyDisplayString = "F10";
            this.TsmExcluirCategoria.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.TsmExcluirCategoria.Size = new System.Drawing.Size(64, 21);
            this.TsmExcluirCategoria.Text = "Excluir";
            this.TsmExcluirCategoria.Click += new System.EventHandler(this.TsmExcluirCategoria_Click);
            // 
            // FormStrongBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1094, 487);
            this.Controls.Add(this.TcPrincipal);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStrongBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strong Box";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStrongBox_Load);
            this.TcPrincipal.ResumeLayout(false);
            this.TpLogins.ResumeLayout(false);
            this.TpLogins.PerformLayout();
            this.FlpDadosLogins.ResumeLayout(false);
            this.GbxDadosUsuario.ResumeLayout(false);
            this.GbxDadosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudTamanhoSenha)).EndInit();
            this.GbxDadosSenha.ResumeLayout(false);
            this.GbxDadosSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLogins)).EndInit();
            this.MsLogins.ResumeLayout(false);
            this.MsLogins.PerformLayout();
            this.TpLocais.ResumeLayout(false);
            this.TpLocais.PerformLayout();
            this.FlpDadosLocal.ResumeLayout(false);
            this.GbxDadosDeLocal.ResumeLayout(false);
            this.GbxDadosDeLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocais)).EndInit();
            this.MsLocais.ResumeLayout(false);
            this.MsLocais.PerformLayout();
            this.TpCategorias.ResumeLayout(false);
            this.TpCategorias.PerformLayout();
            this.FlpDadosCategoria.ResumeLayout(false);
            this.GbxDadosDeCategoria.ResumeLayout(false);
            this.GbxDadosDeCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).EndInit();
            this.MsCategorias.ResumeLayout(false);
            this.MsCategorias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TcPrincipal;
        private System.Windows.Forms.TabPage TpLogins;
        private System.Windows.Forms.MenuStrip MsLogins;
        private System.Windows.Forms.TabPage TpLocais;
        private System.Windows.Forms.MenuStrip MsLocais;
        private System.Windows.Forms.TabPage TpCategorias;
        private System.Windows.Forms.MenuStrip MsCategorias;
        private System.Windows.Forms.ToolStripMenuItem TsmCriarCategoria;
        private System.Windows.Forms.ToolStripMenuItem TsmAlterarCategoria;
        private System.Windows.Forms.ToolStripMenuItem TsmExcluirCategoria;
        private System.Windows.Forms.ToolStripMenuItem TsmIncluirLocal;
        private System.Windows.Forms.ToolStripMenuItem TsmModificarLocal;
        private System.Windows.Forms.ToolStripMenuItem TsmRemoverLocal;
        private System.Windows.Forms.ToolStripMenuItem TsmAdicionarLogin;
        private System.Windows.Forms.ToolStripMenuItem TsmAlterarLogin;
        private System.Windows.Forms.ToolStripMenuItem TsmAlterarSenha;
        private System.Windows.Forms.DataGridView DgvLogins;
        private System.Windows.Forms.ToolStripMenuItem TsmExcluirLogin;
        private System.Windows.Forms.GroupBox GbxDadosUsuario;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtDados;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.NumericUpDown NudTamanhoSenha;
        private System.Windows.Forms.Label LblTamanhoSenha;
        private System.Windows.Forms.GroupBox GbxDadosSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.RadioButton RbtnSenhaNumerica;
        private System.Windows.Forms.Button BtnSalvarLogins;
        private System.Windows.Forms.Button BtnCancelarLogins;
        private System.Windows.Forms.Button BtnGerarSenha;
        private System.Windows.Forms.RadioButton RbtnSenhaAlfaNumerica;
        private System.Windows.Forms.RadioButton RbtnSenhaAlfabetica;
        private System.Windows.Forms.FlowLayoutPanel FlpDadosLogins;
        private System.Windows.Forms.FlowLayoutPanel FlpDadosLocal;
        private System.Windows.Forms.DataGridView DgvLocais;
        private System.Windows.Forms.GroupBox GbxDadosDeLocal;
        private System.Windows.Forms.Button BtnCancelarLocal;
        private System.Windows.Forms.Button BtnSalvarLocal;
        private System.Windows.Forms.TextBox TxtNomeLocal;
        private System.Windows.Forms.Label LblNomeLocal;
        private System.Windows.Forms.FlowLayoutPanel FlpDadosCategoria;
        private System.Windows.Forms.GroupBox GbxDadosDeCategoria;
        private System.Windows.Forms.Button BtnCancelarCategoria;
        private System.Windows.Forms.Button BtnSalvarCategoria;
        private System.Windows.Forms.Label LblPrefixo;
        private System.Windows.Forms.TextBox TxtNomeCategoria;
        private System.Windows.Forms.Label LblNomeCategoria;
        private System.Windows.Forms.DataGridView DgvCategorias;
        private System.Windows.Forms.TextBox TxtPrefixo;
        private Componentes.UcCbxCategoria UcCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNomeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPrefixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnExcluido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCodigoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNomeLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnLocalExcluido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNomeCategoriaPorLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCodigoLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTipoSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnLoginExcluido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnLocalPorLogin;
        private Componentes.UcCbxLocal UcLocal;
    }
}