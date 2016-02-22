namespace SisAulasOpusDei
{
    partial class frmColaboradoresList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblNomeColaborador;
            System.Windows.Forms.Label lblApelidoColaborador;
            System.Windows.Forms.Label lblSobrenomeColaborador;
            System.Windows.Forms.Label lblTipoColaborador;
            this.sisAulasPiteDataSetProcs = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.sp_SelecionaTodosColaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SelecionaTodosColaboradoresTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaTodosColaboradoresTableAdapter();
            this.tableAdapterManager = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager();
            this.dgvListaColaboradores = new System.Windows.Forms.DataGridView();
            this.grbPesquisarColaborador = new System.Windows.Forms.GroupBox();
            this.cmbTipoColaborador = new System.Windows.Forms.ComboBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtSobrenomeColaborador = new System.Windows.Forms.TextBox();
            this.txtNomeColaborador = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblAdicionarColaborador = new System.Windows.Forms.Label();
            this.btnAddColaborador = new System.Windows.Forms.Button();
            this.grbAddColaborador = new System.Windows.Forms.GroupBox();
            this.coldgvStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.coldgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvSobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvApelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvTipoColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvDataNomeacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvdatInsercao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvMaterias = new System.Windows.Forms.DataGridViewImageColumn();
            this.coldgvEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.coldgvIdColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvstrLatimNomi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvstrLatimAcusa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvstrfkIdTipoColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblNomeColaborador = new System.Windows.Forms.Label();
            lblApelidoColaborador = new System.Windows.Forms.Label();
            lblSobrenomeColaborador = new System.Windows.Forms.Label();
            lblTipoColaborador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaTodosColaboradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaColaboradores)).BeginInit();
            this.grbPesquisarColaborador.SuspendLayout();
            this.grbAddColaborador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeColaborador
            // 
            lblNomeColaborador.AutoSize = true;
            lblNomeColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomeColaborador.Location = new System.Drawing.Point(8, 29);
            lblNomeColaborador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNomeColaborador.Name = "lblNomeColaborador";
            lblNomeColaborador.Size = new System.Drawing.Size(59, 18);
            lblNomeColaborador.TabIndex = 0;
            lblNomeColaborador.Text = "Nome:";
            // 
            // lblApelidoColaborador
            // 
            lblApelidoColaborador.AutoSize = true;
            lblApelidoColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblApelidoColaborador.Location = new System.Drawing.Point(424, 29);
            lblApelidoColaborador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblApelidoColaborador.Name = "lblApelidoColaborador";
            lblApelidoColaborador.Size = new System.Drawing.Size(99, 18);
            lblApelidoColaborador.TabIndex = 2;
            lblApelidoColaborador.Text = "ou Apelido:";
            // 
            // lblSobrenomeColaborador
            // 
            lblSobrenomeColaborador.AutoSize = true;
            lblSobrenomeColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSobrenomeColaborador.Location = new System.Drawing.Point(8, 67);
            lblSobrenomeColaborador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSobrenomeColaborador.Name = "lblSobrenomeColaborador";
            lblSobrenomeColaborador.Size = new System.Drawing.Size(105, 18);
            lblSobrenomeColaborador.TabIndex = 4;
            lblSobrenomeColaborador.Text = "Sobrenome:";
            // 
            // lblTipoColaborador
            // 
            lblTipoColaborador.AutoSize = true;
            lblTipoColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTipoColaborador.Location = new System.Drawing.Point(424, 67);
            lblTipoColaborador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTipoColaborador.Name = "lblTipoColaborador";
            lblTipoColaborador.Size = new System.Drawing.Size(152, 18);
            lblTipoColaborador.TabIndex = 6;
            lblTipoColaborador.Text = "Tipo Colaborador:";
            // 
            // sisAulasPiteDataSetProcs
            // 
            this.sisAulasPiteDataSetProcs.DataSetName = "SisAulasPiteDataSetProcs";
            this.sisAulasPiteDataSetProcs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SelecionaTodosColaboradoresBindingSource
            // 
            this.sp_SelecionaTodosColaboradoresBindingSource.DataMember = "sp_SelecionaTodosColaboradores";
            this.sp_SelecionaTodosColaboradoresBindingSource.DataSource = this.sisAulasPiteDataSetProcs;
            // 
            // sp_SelecionaTodosColaboradoresTableAdapter
            // 
            this.sp_SelecionaTodosColaboradoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvListaColaboradores
            // 
            this.dgvListaColaboradores.AllowUserToAddRows = false;
            this.dgvListaColaboradores.AllowUserToDeleteRows = false;
            this.dgvListaColaboradores.AllowUserToResizeColumns = false;
            this.dgvListaColaboradores.AllowUserToResizeRows = false;
            this.dgvListaColaboradores.AutoGenerateColumns = false;
            this.dgvListaColaboradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListaColaboradores.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvListaColaboradores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaColaboradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coldgvStatus,
            this.coldgvNome,
            this.coldgvSobrenome,
            this.coldgvApelido,
            this.coldgvTipoColaborador,
            this.coldgvTitulo,
            this.coldgvDataNomeacao,
            this.coldgvdatInsercao,
            this.coldgvMaterias,
            this.coldgvEditar,
            this.coldgvIdColaborador,
            this.coldgvstrLatimNomi,
            this.coldgvstrLatimAcusa,
            this.coldgvstrfkIdTipoColaborador});
            this.dgvListaColaboradores.DataSource = this.sp_SelecionaTodosColaboradoresBindingSource;
            this.dgvListaColaboradores.GridColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvListaColaboradores.Location = new System.Drawing.Point(1, 105);
            this.dgvListaColaboradores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaColaboradores.MultiSelect = false;
            this.dgvListaColaboradores.Name = "dgvListaColaboradores";
            this.dgvListaColaboradores.ReadOnly = true;
            this.dgvListaColaboradores.RowHeadersVisible = false;
            this.dgvListaColaboradores.RowTemplate.Height = 24;
            this.dgvListaColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListaColaboradores.Size = new System.Drawing.Size(843, 365);
            this.dgvListaColaboradores.TabIndex = 0;
            this.dgvListaColaboradores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaColaboradores_CellClick);
            this.dgvListaColaboradores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaColaboradores_CellContentClick);
            this.dgvListaColaboradores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaColaboradores_CellFormatting);
            this.dgvListaColaboradores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListaColaboradores_CellPainting);
            // 
            // grbPesquisarColaborador
            // 
            this.grbPesquisarColaborador.BackColor = System.Drawing.Color.MintCream;
            this.grbPesquisarColaborador.Controls.Add(this.cmbTipoColaborador);
            this.grbPesquisarColaborador.Controls.Add(this.txtApelido);
            this.grbPesquisarColaborador.Controls.Add(this.txtSobrenomeColaborador);
            this.grbPesquisarColaborador.Controls.Add(this.txtNomeColaborador);
            this.grbPesquisarColaborador.Controls.Add(this.btnPesquisar);
            this.grbPesquisarColaborador.Controls.Add(lblTipoColaborador);
            this.grbPesquisarColaborador.Controls.Add(lblSobrenomeColaborador);
            this.grbPesquisarColaborador.Controls.Add(lblApelidoColaborador);
            this.grbPesquisarColaborador.Controls.Add(lblNomeColaborador);
            this.grbPesquisarColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbPesquisarColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPesquisarColaborador.Location = new System.Drawing.Point(1, 3);
            this.grbPesquisarColaborador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPesquisarColaborador.Name = "grbPesquisarColaborador";
            this.grbPesquisarColaborador.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPesquisarColaborador.Size = new System.Drawing.Size(843, 97);
            this.grbPesquisarColaborador.TabIndex = 2;
            this.grbPesquisarColaborador.TabStop = false;
            this.grbPesquisarColaborador.Text = "Pesquisar";
            // 
            // cmbTipoColaborador
            // 
            this.cmbTipoColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.cmbTipoColaborador.FormattingEnabled = true;
            this.cmbTipoColaborador.Location = new System.Drawing.Point(557, 64);
            this.cmbTipoColaborador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoColaborador.Name = "cmbTipoColaborador";
            this.cmbTipoColaborador.Size = new System.Drawing.Size(170, 26);
            this.cmbTipoColaborador.TabIndex = 12;
            // 
            // txtApelido
            // 
            this.txtApelido.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtApelido.Location = new System.Drawing.Point(520, 28);
            this.txtApelido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(314, 24);
            this.txtApelido.TabIndex = 11;
            // 
            // txtSobrenomeColaborador
            // 
            this.txtSobrenomeColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtSobrenomeColaborador.Location = new System.Drawing.Point(107, 67);
            this.txtSobrenomeColaborador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSobrenomeColaborador.Name = "txtSobrenomeColaborador";
            this.txtSobrenomeColaborador.Size = new System.Drawing.Size(314, 24);
            this.txtSobrenomeColaborador.TabIndex = 10;
            // 
            // txtNomeColaborador
            // 
            this.txtNomeColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtNomeColaborador.Location = new System.Drawing.Point(107, 29);
            this.txtNomeColaborador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeColaborador.Name = "txtNomeColaborador";
            this.txtNomeColaborador.Size = new System.Drawing.Size(314, 24);
            this.txtNomeColaborador.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(738, 67);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 24);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblAdicionarColaborador
            // 
            this.lblAdicionarColaborador.AutoSize = true;
            this.lblAdicionarColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAdicionarColaborador.Location = new System.Drawing.Point(31, 13);
            this.lblAdicionarColaborador.Name = "lblAdicionarColaborador";
            this.lblAdicionarColaborador.Size = new System.Drawing.Size(184, 18);
            this.lblAdicionarColaborador.TabIndex = 1;
            this.lblAdicionarColaborador.Text = "Adicionar Colaborador";
            // 
            // btnAddColaborador
            // 
            this.btnAddColaborador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColaborador.Image = global::SisAulasOpusDei.Properties.Resources.ico_add;
            this.btnAddColaborador.Location = new System.Drawing.Point(6, 10);
            this.btnAddColaborador.Name = "btnAddColaborador";
            this.btnAddColaborador.Size = new System.Drawing.Size(23, 23);
            this.btnAddColaborador.TabIndex = 0;
            this.btnAddColaborador.UseVisualStyleBackColor = true;
            this.btnAddColaborador.Click += new System.EventHandler(this.btnAddColaborador_Click);
            // 
            // grbAddColaborador
            // 
            this.grbAddColaborador.BackColor = System.Drawing.Color.MintCream;
            this.grbAddColaborador.Controls.Add(this.lblAdicionarColaborador);
            this.grbAddColaborador.Controls.Add(this.btnAddColaborador);
            this.grbAddColaborador.Location = new System.Drawing.Point(1, 475);
            this.grbAddColaborador.Name = "grbAddColaborador";
            this.grbAddColaborador.Size = new System.Drawing.Size(843, 36);
            this.grbAddColaborador.TabIndex = 6;
            this.grbAddColaborador.TabStop = false;
            // 
            // coldgvStatus
            // 
            this.coldgvStatus.DataPropertyName = "flgStatus";
            this.coldgvStatus.Frozen = true;
            this.coldgvStatus.HeaderText = "Status";
            this.coldgvStatus.Name = "coldgvStatus";
            this.coldgvStatus.ReadOnly = true;
            this.coldgvStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coldgvStatus.Width = 43;
            // 
            // coldgvNome
            // 
            this.coldgvNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldgvNome.DataPropertyName = "strNome";
            this.coldgvNome.HeaderText = "Nome Colaboradora";
            this.coldgvNome.Name = "coldgvNome";
            this.coldgvNome.ReadOnly = true;
            // 
            // coldgvSobrenome
            // 
            this.coldgvSobrenome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvSobrenome.DataPropertyName = "strSobrenome";
            this.coldgvSobrenome.HeaderText = "Sobrenome";
            this.coldgvSobrenome.Name = "coldgvSobrenome";
            this.coldgvSobrenome.ReadOnly = true;
            this.coldgvSobrenome.Width = 86;
            // 
            // coldgvApelido
            // 
            this.coldgvApelido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvApelido.DataPropertyName = "strApelido";
            this.coldgvApelido.HeaderText = "Apelido";
            this.coldgvApelido.Name = "coldgvApelido";
            this.coldgvApelido.ReadOnly = true;
            this.coldgvApelido.Width = 67;
            // 
            // coldgvTipoColaborador
            // 
            this.coldgvTipoColaborador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvTipoColaborador.DataPropertyName = "strTipoColaborador";
            this.coldgvTipoColaborador.HeaderText = "Tipo";
            this.coldgvTipoColaborador.Name = "coldgvTipoColaborador";
            this.coldgvTipoColaborador.ReadOnly = true;
            this.coldgvTipoColaborador.Width = 53;
            // 
            // coldgvTitulo
            // 
            this.coldgvTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvTitulo.DataPropertyName = "strTitulo";
            this.coldgvTitulo.HeaderText = "Título";
            this.coldgvTitulo.Name = "coldgvTitulo";
            this.coldgvTitulo.ReadOnly = true;
            this.coldgvTitulo.Width = 60;
            // 
            // coldgvDataNomeacao
            // 
            this.coldgvDataNomeacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvDataNomeacao.DataPropertyName = "datNomeacao";
            this.coldgvDataNomeacao.HeaderText = "Data da Nomeação";
            this.coldgvDataNomeacao.Name = "coldgvDataNomeacao";
            this.coldgvDataNomeacao.ReadOnly = true;
            this.coldgvDataNomeacao.Width = 114;
            // 
            // coldgvdatInsercao
            // 
            this.coldgvdatInsercao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvdatInsercao.DataPropertyName = "datInsercao";
            this.coldgvdatInsercao.HeaderText = "Data do Cadastro";
            this.coldgvdatInsercao.Name = "coldgvdatInsercao";
            this.coldgvdatInsercao.ReadOnly = true;
            this.coldgvdatInsercao.Width = 105;
            // 
            // coldgvMaterias
            // 
            this.coldgvMaterias.HeaderText = "Matérias";
            this.coldgvMaterias.Name = "coldgvMaterias";
            this.coldgvMaterias.ReadOnly = true;
            this.coldgvMaterias.Width = 53;
            // 
            // coldgvEditar
            // 
            this.coldgvEditar.HeaderText = "Editar";
            this.coldgvEditar.Name = "coldgvEditar";
            this.coldgvEditar.ReadOnly = true;
            this.coldgvEditar.Width = 40;
            // 
            // coldgvIdColaborador
            // 
            this.coldgvIdColaborador.DataPropertyName = "IdColaborador";
            this.coldgvIdColaborador.HeaderText = "IdColaborador";
            this.coldgvIdColaborador.Name = "coldgvIdColaborador";
            this.coldgvIdColaborador.ReadOnly = true;
            this.coldgvIdColaborador.Visible = false;
            this.coldgvIdColaborador.Width = 98;
            // 
            // coldgvstrLatimNomi
            // 
            this.coldgvstrLatimNomi.DataPropertyName = "strLatimNominativo";
            this.coldgvstrLatimNomi.HeaderText = "strLatimNominativo";
            this.coldgvstrLatimNomi.Name = "coldgvstrLatimNomi";
            this.coldgvstrLatimNomi.ReadOnly = true;
            this.coldgvstrLatimNomi.Visible = false;
            this.coldgvstrLatimNomi.Width = 121;
            // 
            // coldgvstrLatimAcusa
            // 
            this.coldgvstrLatimAcusa.DataPropertyName = "strLatimAcusativo";
            this.coldgvstrLatimAcusa.HeaderText = "strLatimAcusativo";
            this.coldgvstrLatimAcusa.Name = "coldgvstrLatimAcusa";
            this.coldgvstrLatimAcusa.ReadOnly = true;
            this.coldgvstrLatimAcusa.Visible = false;
            this.coldgvstrLatimAcusa.Width = 115;
            // 
            // coldgvstrfkIdTipoColaborador
            // 
            this.coldgvstrfkIdTipoColaborador.DataPropertyName = "fkIdTipoColaborador";
            this.coldgvstrfkIdTipoColaborador.HeaderText = "fkIdTipoColaborador";
            this.coldgvstrfkIdTipoColaborador.Name = "coldgvstrfkIdTipoColaborador";
            this.coldgvstrfkIdTipoColaborador.ReadOnly = true;
            this.coldgvstrfkIdTipoColaborador.Visible = false;
            this.coldgvstrfkIdTipoColaborador.Width = 128;
            // 
            // frmColaboradoresList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SisAulasOpusDei.Properties.Resources.img_sjme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 514);
            this.Controls.Add(this.grbAddColaborador);
            this.Controls.Add(this.grbPesquisarColaborador);
            this.Controls.Add(this.dgvListaColaboradores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmColaboradoresList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colaboradores";
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaTodosColaboradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaColaboradores)).EndInit();
            this.grbPesquisarColaborador.ResumeLayout(false);
            this.grbPesquisarColaborador.PerformLayout();
            this.grbAddColaborador.ResumeLayout(false);
            this.grbAddColaborador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs;
        private System.Windows.Forms.BindingSource sp_SelecionaTodosColaboradoresBindingSource;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaTodosColaboradoresTableAdapter sp_SelecionaTodosColaboradoresTableAdapter;
        private SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvListaColaboradores;
        private System.Windows.Forms.GroupBox grbPesquisarColaborador;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomeColaborador;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtSobrenomeColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvCPF;
        private System.Windows.Forms.ComboBox cmbTipoColaborador;
        private System.Windows.Forms.Label lblAdicionarColaborador;
        private System.Windows.Forms.Button btnAddColaborador;
        private System.Windows.Forms.GroupBox grbAddColaborador;
        private System.Windows.Forms.DataGridViewImageColumn coldgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvSobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvApelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvTipoColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvDataNomeacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvdatInsercao;
        private System.Windows.Forms.DataGridViewImageColumn coldgvMaterias;
        private System.Windows.Forms.DataGridViewButtonColumn coldgvEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvIdColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvstrLatimNomi;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvstrLatimAcusa;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvstrfkIdTipoColaborador;






    }
}

