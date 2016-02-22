namespace SisAulasOpusDei
{
    partial class frmColaboradoresManut
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
            this.gpbColaboradores = new System.Windows.Forms.GroupBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.tbColaboradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisAulasPiteDataSet = new SisAulasOpusDei.SisAulasPiteDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocalNasci = new System.Windows.Forms.TextBox();
            this.chkMaterias = new System.Windows.Forms.CheckBox();
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.lblDataNomeacao = new System.Windows.Forms.Label();
            this.txtDataNomeacao = new System.Windows.Forms.MaskedTextBox();
            this.rbProfessora = new System.Windows.Forms.RadioButton();
            this.rbAluna = new System.Windows.Forms.RadioButton();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbTitulo = new System.Windows.Forms.ComboBox();
            this.lblLatimAcusa = new System.Windows.Forms.Label();
            this.txtLatimAcusa = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblLatimNomi = new System.Windows.Forms.Label();
            this.txtLatimNomi = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeColaborador = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCurriculum = new System.Windows.Forms.Button();
            this.btnAssociarMaterias = new System.Windows.Forms.Button();
            this.tbColaboradorTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.tbColaboradorTableAdapter();
            this.tableAdapterManager = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.TableAdapterManager();
            this.saveCurriculo = new System.Windows.Forms.SaveFileDialog();
            this.gpbColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbColaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).BeginInit();
            this.gpbStatus.SuspendLayout();
            this.gpbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbColaboradores
            // 
            this.gpbColaboradores.BackColor = System.Drawing.Color.MintCream;
            this.gpbColaboradores.Controls.Add(this.txtDataNascimento);
            this.gpbColaboradores.Controls.Add(this.label3);
            this.gpbColaboradores.Controls.Add(this.label2);
            this.gpbColaboradores.Controls.Add(this.txtLocalNasci);
            this.gpbColaboradores.Controls.Add(this.chkMaterias);
            this.gpbColaboradores.Controls.Add(this.gpbStatus);
            this.gpbColaboradores.Controls.Add(this.gpbTipo);
            this.gpbColaboradores.Controls.Add(this.lblCategoria);
            this.gpbColaboradores.Controls.Add(this.cmbCategoria);
            this.gpbColaboradores.Controls.Add(this.lblTitulo);
            this.gpbColaboradores.Controls.Add(this.cmbTitulo);
            this.gpbColaboradores.Controls.Add(this.lblLatimAcusa);
            this.gpbColaboradores.Controls.Add(this.txtLatimAcusa);
            this.gpbColaboradores.Controls.Add(this.lblApelido);
            this.gpbColaboradores.Controls.Add(this.txtApelido);
            this.gpbColaboradores.Controls.Add(this.lblSobrenome);
            this.gpbColaboradores.Controls.Add(this.txtSobrenome);
            this.gpbColaboradores.Controls.Add(this.lblLatimNomi);
            this.gpbColaboradores.Controls.Add(this.txtLatimNomi);
            this.gpbColaboradores.Controls.Add(this.lblNome);
            this.gpbColaboradores.Controls.Add(this.txtNomeColaborador);
            this.gpbColaboradores.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.gpbColaboradores.Location = new System.Drawing.Point(7, 5);
            this.gpbColaboradores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbColaboradores.Name = "gpbColaboradores";
            this.gpbColaboradores.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbColaboradores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpbColaboradores.Size = new System.Drawing.Size(563, 314);
            this.gpbColaboradores.TabIndex = 0;
            this.gpbColaboradores.TabStop = false;
            this.gpbColaboradores.Text = "Colaborador(a)";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbColaboradorBindingSource, "datNascimento", true));
            this.txtDataNascimento.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtDataNascimento.Location = new System.Drawing.Point(152, 184);
            this.txtDataNascimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(119, 20);
            this.txtDataNascimento.TabIndex = 7;
            this.txtDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbColaboradorBindingSource
            // 
            this.tbColaboradorBindingSource.DataMember = "tbColaborador";
            this.tbColaboradorBindingSource.DataSource = this.sisAulasPiteDataSet;
            // 
            // sisAulasPiteDataSet
            // 
            this.sisAulasPiteDataSet.DataSetName = "SisAulasPiteDataSet";
            this.sisAulasPiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Data Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(6, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Local Nascimento:";
            // 
            // txtLocalNasci
            // 
            this.txtLocalNasci.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbColaboradorBindingSource, "strLatimAcusativo", true));
            this.txtLocalNasci.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtLocalNasci.Location = new System.Drawing.Point(152, 159);
            this.txtLocalNasci.Name = "txtLocalNasci";
            this.txtLocalNasci.Size = new System.Drawing.Size(404, 20);
            this.txtLocalNasci.TabIndex = 6;
            // 
            // chkMaterias
            // 
            this.chkMaterias.AutoSize = true;
            this.chkMaterias.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMaterias.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaterias.Location = new System.Drawing.Point(8, 282);
            this.chkMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMaterias.Name = "chkMaterias";
            this.chkMaterias.Size = new System.Drawing.Size(252, 22);
            this.chkMaterias.TabIndex = 16;
            this.chkMaterias.Text = "Associar todas as matérias?";
            this.chkMaterias.UseVisualStyleBackColor = true;
            // 
            // gpbStatus
            // 
            this.gpbStatus.Controls.Add(this.rbInativo);
            this.gpbStatus.Controls.Add(this.rbAtivo);
            this.gpbStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStatus.Location = new System.Drawing.Point(474, 184);
            this.gpbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbStatus.Size = new System.Drawing.Size(84, 120);
            this.gpbStatus.TabIndex = 22;
            this.gpbStatus.TabStop = false;
            this.gpbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInativo.Location = new System.Drawing.Point(5, 72);
            this.rbInativo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(72, 19);
            this.rbInativo.TabIndex = 15;
            this.rbInativo.Tag = "False";
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tbColaboradorBindingSource, "flgStatus", true));
            this.rbAtivo.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtivo.Location = new System.Drawing.Point(5, 32);
            this.rbAtivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(59, 19);
            this.rbAtivo.TabIndex = 14;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Tag = "True";
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.lblDataNomeacao);
            this.gpbTipo.Controls.Add(this.txtDataNomeacao);
            this.gpbTipo.Controls.Add(this.rbProfessora);
            this.gpbTipo.Controls.Add(this.rbAluna);
            this.gpbTipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipo.Location = new System.Drawing.Point(275, 184);
            this.gpbTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbTipo.Size = new System.Drawing.Size(195, 120);
            this.gpbTipo.TabIndex = 21;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo:";
            // 
            // lblDataNomeacao
            // 
            this.lblDataNomeacao.AutoSize = true;
            this.lblDataNomeacao.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDataNomeacao.Location = new System.Drawing.Point(3, 58);
            this.lblDataNomeacao.Name = "lblDataNomeacao";
            this.lblDataNomeacao.Size = new System.Drawing.Size(95, 36);
            this.lblDataNomeacao.TabIndex = 26;
            this.lblDataNomeacao.Text = "Data \r\nNomeação:";
            // 
            // txtDataNomeacao
            // 
            this.txtDataNomeacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbColaboradorBindingSource, "datNomeacao", true));
            this.txtDataNomeacao.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtDataNomeacao.Location = new System.Drawing.Point(107, 75);
            this.txtDataNomeacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDataNomeacao.Mask = "00/00/0000";
            this.txtDataNomeacao.Name = "txtDataNomeacao";
            this.txtDataNomeacao.Size = new System.Drawing.Size(65, 20);
            this.txtDataNomeacao.TabIndex = 13;
            this.txtDataNomeacao.ValidatingType = typeof(System.DateTime);
            // 
            // rbProfessora
            // 
            this.rbProfessora.AutoSize = true;
            this.rbProfessora.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProfessora.Location = new System.Drawing.Point(84, 18);
            this.rbProfessora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbProfessora.Name = "rbProfessora";
            this.rbProfessora.Size = new System.Drawing.Size(108, 19);
            this.rbProfessora.TabIndex = 12;
            this.rbProfessora.TabStop = true;
            this.rbProfessora.Tag = "2";
            this.rbProfessora.Text = "Professor(a)";
            this.rbProfessora.UseVisualStyleBackColor = true;
            this.rbProfessora.CheckedChanged += new System.EventHandler(this.rbProfessora_CheckedChanged);
            // 
            // rbAluna
            // 
            this.rbAluna.AutoSize = true;
            this.rbAluna.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tbColaboradorBindingSource, "fkIdTipoColaborador", true));
            this.rbAluna.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tbColaboradorBindingSource, "fkIdTipoColaborador", true));
            this.rbAluna.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAluna.Location = new System.Drawing.Point(4, 18);
            this.rbAluna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAluna.Name = "rbAluna";
            this.rbAluna.Size = new System.Drawing.Size(82, 19);
            this.rbAluna.TabIndex = 11;
            this.rbAluna.TabStop = true;
            this.rbAluna.Tag = "1";
            this.rbAluna.Text = "Aluno(a)";
            this.rbAluna.UseVisualStyleBackColor = true;
            this.rbAluna.CheckedChanged += new System.EventHandler(this.rbAluna_CheckedChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCategoria.Location = new System.Drawing.Point(6, 258);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(91, 18);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "",
            "Categoria 1",
            "Categoria 2",
            "Categoria 3",
            "Categoria 4"});
            this.cmbCategoria.Location = new System.Drawing.Point(152, 257);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(119, 21);
            this.cmbCategoria.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.Location = new System.Drawing.Point(6, 232);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(60, 18);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Título:";
            // 
            // cmbTitulo
            // 
            this.cmbTitulo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbColaboradorBindingSource, "fkIdTitulo", true));
            this.cmbTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.cmbTitulo.FormattingEnabled = true;
            this.cmbTitulo.Location = new System.Drawing.Point(152, 231);
            this.cmbTitulo.Name = "cmbTitulo";
            this.cmbTitulo.Size = new System.Drawing.Size(119, 21);
            this.cmbTitulo.TabIndex = 9;
            // 
            // lblLatimAcusa
            // 
            this.lblLatimAcusa.AutoSize = true;
            this.lblLatimAcusa.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLatimAcusa.Location = new System.Drawing.Point(6, 132);
            this.lblLatimAcusa.Name = "lblLatimAcusa";
            this.lblLatimAcusa.Size = new System.Drawing.Size(141, 18);
            this.lblLatimAcusa.TabIndex = 16;
            this.lblLatimAcusa.Text = "Latim Acusativo:";
            // 
            // txtLatimAcusa
            // 
            this.txtLatimAcusa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbColaboradorBindingSource, "strLatimAcusativo", true));
            this.txtLatimAcusa.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtLatimAcusa.Location = new System.Drawing.Point(152, 132);
            this.txtLatimAcusa.Name = "txtLatimAcusa";
            this.txtLatimAcusa.Size = new System.Drawing.Size(404, 20);
            this.txtLatimAcusa.TabIndex = 5;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblApelido.Location = new System.Drawing.Point(6, 82);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(73, 18);
            this.lblApelido.TabIndex = 14;
            this.lblApelido.Text = "Apelido:";
            // 
            // txtApelido
            // 
            this.txtApelido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbColaboradorBindingSource, "strApelido", true));
            this.txtApelido.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtApelido.Location = new System.Drawing.Point(152, 82);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(404, 20);
            this.txtApelido.TabIndex = 3;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSobrenome.Location = new System.Drawing.Point(6, 57);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(105, 18);
            this.lblSobrenome.TabIndex = 12;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbColaboradorBindingSource, "strSobrenome", true));
            this.txtSobrenome.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtSobrenome.Location = new System.Drawing.Point(152, 57);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(404, 20);
            this.txtSobrenome.TabIndex = 2;
            // 
            // lblLatimNomi
            // 
            this.lblLatimNomi.AutoSize = true;
            this.lblLatimNomi.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLatimNomi.Location = new System.Drawing.Point(6, 107);
            this.lblLatimNomi.Name = "lblLatimNomi";
            this.lblLatimNomi.Size = new System.Drawing.Size(152, 18);
            this.lblLatimNomi.TabIndex = 10;
            this.lblLatimNomi.Text = "Latim Nominativo:";
            // 
            // txtLatimNomi
            // 
            this.txtLatimNomi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbColaboradorBindingSource, "strLatimNominativo", true));
            this.txtLatimNomi.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtLatimNomi.Location = new System.Drawing.Point(152, 107);
            this.txtLatimNomi.Name = "txtLatimNomi";
            this.txtLatimNomi.Size = new System.Drawing.Size(404, 20);
            this.txtLatimNomi.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNome.Location = new System.Drawing.Point(6, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 18);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // txtNomeColaborador
            // 
            this.txtNomeColaborador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbColaboradorBindingSource, "strNome", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNomeColaborador.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtNomeColaborador.Location = new System.Drawing.Point(152, 32);
            this.txtNomeColaborador.Name = "txtNomeColaborador";
            this.txtNomeColaborador.Size = new System.Drawing.Size(404, 20);
            this.txtNomeColaborador.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Location = new System.Drawing.Point(504, 323);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(66, 25);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(434, 323);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 25);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCurriculum
            // 
            this.btnCurriculum.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCurriculum.Location = new System.Drawing.Point(216, 323);
            this.btnCurriculum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCurriculum.Name = "btnCurriculum";
            this.btnCurriculum.Size = new System.Drawing.Size(134, 25);
            this.btnCurriculum.TabIndex = 20;
            this.btnCurriculum.Text = "Imprimir Curriculum";
            this.btnCurriculum.UseVisualStyleBackColor = true;
            this.btnCurriculum.Click += new System.EventHandler(this.btnCurriculum_Click);
            // 
            // btnAssociarMaterias
            // 
            this.btnAssociarMaterias.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAssociarMaterias.Location = new System.Drawing.Point(7, 323);
            this.btnAssociarMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssociarMaterias.Name = "btnAssociarMaterias";
            this.btnAssociarMaterias.Size = new System.Drawing.Size(134, 25);
            this.btnAssociarMaterias.TabIndex = 19;
            this.btnAssociarMaterias.Text = "Associar Matérias";
            this.btnAssociarMaterias.UseVisualStyleBackColor = true;
            this.btnAssociarMaterias.Click += new System.EventHandler(this.btnAssociarMaterias_Click);
            // 
            // tbColaboradorTableAdapter
            // 
            this.tbColaboradorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tbAutenticacaoTableAdapter = null;
            this.tableAdapterManager.tbColaboradorTableAdapter = null;
            this.tableAdapterManager.tbCurriculoTableAdapter = null;
            this.tableAdapterManager.tbMateriaTableAdapter = null;
            this.tableAdapterManager.tbNotaTableAdapter = null;
            this.tableAdapterManager.tbSisAuditTableAdapter = null;
            this.tableAdapterManager.tbTipoColaboradorTableAdapter = null;
            this.tableAdapterManager.tbTipoMateriaTableAdapter = null;
            this.tableAdapterManager.tbTituloTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // saveCurriculo
            // 
            this.saveCurriculo.Filter = "docx files|*.docx";
            // 
            // frmColaboradoresManut
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisAulasOpusDei.Properties.Resources.img_sjme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(575, 353);
            this.Controls.Add(this.btnAssociarMaterias);
            this.Controls.Add(this.btnCurriculum);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbColaboradores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmColaboradoresManut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Colaboradores";
            this.Load += new System.EventHandler(this.frmColaboradoresManut_Load);
            this.gpbColaboradores.ResumeLayout(false);
            this.gpbColaboradores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbColaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).EndInit();
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbColaboradores;
        private System.Windows.Forms.Label lblLatimAcusa;
        private System.Windows.Forms.TextBox txtLatimAcusa;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblLatimNomi;
        private System.Windows.Forms.TextBox txtLatimNomi;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeColaborador;
        private System.Windows.Forms.GroupBox gpbStatus;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rbAluna;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTitulo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label lblDataNomeacao;
        private System.Windows.Forms.MaskedTextBox txtDataNomeacao;
        private System.Windows.Forms.RadioButton rbProfessora;
        private System.Windows.Forms.CheckBox chkMaterias;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCurriculum;
        private System.Windows.Forms.Button btnAssociarMaterias;
        private SisAulasPiteDataSet sisAulasPiteDataSet;
        private System.Windows.Forms.BindingSource tbColaboradorBindingSource;
        private SisAulasPiteDataSetTableAdapters.tbColaboradorTableAdapter tbColaboradorTableAdapter;
        private SisAulasPiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocalNasci;
        private System.Windows.Forms.SaveFileDialog saveCurriculo;
    }
}