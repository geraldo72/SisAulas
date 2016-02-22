namespace SisAulasOpusDei
{
    partial class frmAssociarMateria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAssociarTurma = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApelidoColaborador = new System.Windows.Forms.Label();
            this.lblNomeColaborador = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAssociar = new System.Windows.Forms.Button();
            this.dgvMateriasAssociadas = new System.Windows.Forms.DataGridView();
            this.coldgvidCurriculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvidMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvstrNomeMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvstrNomeTipoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvstrAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvflgOpcional = new System.Windows.Forms.DataGridViewImageColumn();
            this.coldgvIdTipoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvflgConcluida = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sp_SelecionaMateriasCurriculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisAulasPiteDataSetProcs = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.dgvMateriasNAssociadas = new System.Windows.Forms.DataGridView();
            this.coldgvidCurriculoN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvidMateriaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvstrNomeMateriaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvstrNomeTipoMateriaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvstrAnoN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvflgOpcionalN = new System.Windows.Forms.DataGridViewImageColumn();
            this.coldgvIdTipoMateriaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvflgConcluidaN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sp_SelecionaMateriasCurriculoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sisAulasPiteDataSetProcs1 = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_SelecionaMateriasCurriculoTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaMateriasCurriculoTableAdapter();
            this.tableAdapterManager = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager();
            this.sp_SelecionaMateriasCurriculoTableAdapter1 = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaMateriasCurriculoTableAdapter();
            this.tableAdapterManager1 = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAssociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaMateriasCurriculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasNAssociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaMateriasCurriculoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAssociarTurma);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTurma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblApelidoColaborador);
            this.groupBox1.Controls.Add(this.lblNomeColaborador);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Colaborador";
            // 
            // btnAssociarTurma
            // 
            this.btnAssociarTurma.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssociarTurma.Location = new System.Drawing.Point(1022, 16);
            this.btnAssociarTurma.Name = "btnAssociarTurma";
            this.btnAssociarTurma.Size = new System.Drawing.Size(75, 44);
            this.btnAssociarTurma.TabIndex = 11;
            this.btnAssociarTurma.Text = "Associar Turma";
            this.btnAssociarTurma.UseVisualStyleBackColor = true;
            this.btnAssociarTurma.Click += new System.EventHandler(this.btnAssociarTurma_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(872, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Turma:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(946, 30);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(58, 22);
            this.lblTurma.TabIndex = 9;
            this.lblTurma.Text = "0001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apelido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome:";
            // 
            // lblApelidoColaborador
            // 
            this.lblApelidoColaborador.AutoSize = true;
            this.lblApelidoColaborador.Location = new System.Drawing.Point(529, 30);
            this.lblApelidoColaborador.Name = "lblApelidoColaborador";
            this.lblApelidoColaborador.Size = new System.Drawing.Size(240, 22);
            this.lblApelidoColaborador.TabIndex = 6;
            this.lblApelidoColaborador.Text = "Matérias não associadas";
            // 
            // lblNomeColaborador
            // 
            this.lblNomeColaborador.AutoSize = true;
            this.lblNomeColaborador.Location = new System.Drawing.Point(99, 30);
            this.lblNomeColaborador.Name = "lblNomeColaborador";
            this.lblNomeColaborador.Size = new System.Drawing.Size(240, 22);
            this.lblNomeColaborador.TabIndex = 5;
            this.lblNomeColaborador.Text = "Matérias não associadas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.btnAssociar);
            this.groupBox2.Controls.Add(this.dgvMateriasAssociadas);
            this.groupBox2.Controls.Add(this.dgvMateriasNAssociadas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1103, 428);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(533, 271);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(36, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "<";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAssociar
            // 
            this.btnAssociar.Location = new System.Drawing.Point(533, 176);
            this.btnAssociar.Name = "btnAssociar";
            this.btnAssociar.Size = new System.Drawing.Size(36, 23);
            this.btnAssociar.TabIndex = 8;
            this.btnAssociar.Text = ">";
            this.btnAssociar.UseVisualStyleBackColor = true;
            this.btnAssociar.Click += new System.EventHandler(this.btnAssociar_Click);
            // 
            // dgvMateriasAssociadas
            // 
            this.dgvMateriasAssociadas.AllowUserToAddRows = false;
            this.dgvMateriasAssociadas.AllowUserToDeleteRows = false;
            this.dgvMateriasAssociadas.AllowUserToResizeColumns = false;
            this.dgvMateriasAssociadas.AllowUserToResizeRows = false;
            this.dgvMateriasAssociadas.AutoGenerateColumns = false;
            this.dgvMateriasAssociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMateriasAssociadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMateriasAssociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasAssociadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coldgvidCurriculo,
            this.coldgvidMateria,
            this.coldgvstrNomeMateria,
            this.coldgvstrNomeTipoMateria,
            this.coldgvstrAno,
            this.coldgvflgOpcional,
            this.coldgvIdTipoMateria,
            this.coldgvflgConcluida});
            this.dgvMateriasAssociadas.DataSource = this.sp_SelecionaMateriasCurriculoBindingSource;
            this.dgvMateriasAssociadas.Location = new System.Drawing.Point(581, 48);
            this.dgvMateriasAssociadas.MultiSelect = false;
            this.dgvMateriasAssociadas.Name = "dgvMateriasAssociadas";
            this.dgvMateriasAssociadas.ReadOnly = true;
            this.dgvMateriasAssociadas.RowHeadersVisible = false;
            this.dgvMateriasAssociadas.RowTemplate.Height = 24;
            this.dgvMateriasAssociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasAssociadas.ShowEditingIcon = false;
            this.dgvMateriasAssociadas.Size = new System.Drawing.Size(516, 374);
            this.dgvMateriasAssociadas.TabIndex = 7;
            this.dgvMateriasAssociadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriasAssociadas_CellClick);
            this.dgvMateriasAssociadas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMateriasAssociadas_CellFormatting);
            // 
            // coldgvidCurriculo
            // 
            this.coldgvidCurriculo.DataPropertyName = "IdCurriculo";
            this.coldgvidCurriculo.HeaderText = "IdCurriculo";
            this.coldgvidCurriculo.Name = "coldgvidCurriculo";
            this.coldgvidCurriculo.ReadOnly = true;
            this.coldgvidCurriculo.Visible = false;
            this.coldgvidCurriculo.Width = 81;
            // 
            // coldgvidMateria
            // 
            this.coldgvidMateria.DataPropertyName = "IdMateria";
            this.coldgvidMateria.HeaderText = "IdMateria";
            this.coldgvidMateria.Name = "coldgvidMateria";
            this.coldgvidMateria.ReadOnly = true;
            this.coldgvidMateria.Visible = false;
            this.coldgvidMateria.Width = 72;
            // 
            // coldgvstrNomeMateria
            // 
            this.coldgvstrNomeMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldgvstrNomeMateria.DataPropertyName = "strNomeMateria";
            this.coldgvstrNomeMateria.HeaderText = "Matéria";
            this.coldgvstrNomeMateria.Name = "coldgvstrNomeMateria";
            this.coldgvstrNomeMateria.ReadOnly = true;
            this.coldgvstrNomeMateria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // coldgvstrNomeTipoMateria
            // 
            this.coldgvstrNomeTipoMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvstrNomeTipoMateria.DataPropertyName = "strNomeTipoMateria";
            this.coldgvstrNomeTipoMateria.HeaderText = "Tipo";
            this.coldgvstrNomeTipoMateria.Name = "coldgvstrNomeTipoMateria";
            this.coldgvstrNomeTipoMateria.ReadOnly = true;
            this.coldgvstrNomeTipoMateria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coldgvstrNomeTipoMateria.Width = 61;
            // 
            // coldgvstrAno
            // 
            this.coldgvstrAno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvstrAno.DataPropertyName = "strAno";
            this.coldgvstrAno.HeaderText = "Ano";
            this.coldgvstrAno.Name = "coldgvstrAno";
            this.coldgvstrAno.ReadOnly = true;
            this.coldgvstrAno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coldgvstrAno.Width = 58;
            // 
            // coldgvflgOpcional
            // 
            this.coldgvflgOpcional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvflgOpcional.DataPropertyName = "flgOpcional";
            this.coldgvflgOpcional.HeaderText = "Opcional";
            this.coldgvflgOpcional.Name = "coldgvflgOpcional";
            this.coldgvflgOpcional.ReadOnly = true;
            this.coldgvflgOpcional.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coldgvflgOpcional.Width = 70;
            // 
            // coldgvIdTipoMateria
            // 
            this.coldgvIdTipoMateria.DataPropertyName = "fkIdTipoMateria";
            this.coldgvIdTipoMateria.HeaderText = "fkIdTipoMateria";
            this.coldgvIdTipoMateria.Name = "coldgvIdTipoMateria";
            this.coldgvIdTipoMateria.ReadOnly = true;
            this.coldgvIdTipoMateria.Visible = false;
            this.coldgvIdTipoMateria.Width = 130;
            // 
            // coldgvflgConcluida
            // 
            this.coldgvflgConcluida.DataPropertyName = "flgConcluida";
            this.coldgvflgConcluida.HeaderText = "flgConcluida";
            this.coldgvflgConcluida.Name = "coldgvflgConcluida";
            this.coldgvflgConcluida.ReadOnly = true;
            this.coldgvflgConcluida.Visible = false;
            this.coldgvflgConcluida.Width = 91;
            // 
            // sp_SelecionaMateriasCurriculoBindingSource
            // 
            this.sp_SelecionaMateriasCurriculoBindingSource.DataMember = "sp_SelecionaMateriasCurriculo";
            this.sp_SelecionaMateriasCurriculoBindingSource.DataSource = this.sisAulasPiteDataSetProcs;
            // 
            // sisAulasPiteDataSetProcs
            // 
            this.sisAulasPiteDataSetProcs.DataSetName = "SisAulasPiteDataSetProcs";
            this.sisAulasPiteDataSetProcs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvMateriasNAssociadas
            // 
            this.dgvMateriasNAssociadas.AllowUserToAddRows = false;
            this.dgvMateriasNAssociadas.AllowUserToDeleteRows = false;
            this.dgvMateriasNAssociadas.AllowUserToResizeColumns = false;
            this.dgvMateriasNAssociadas.AllowUserToResizeRows = false;
            this.dgvMateriasNAssociadas.AutoGenerateColumns = false;
            this.dgvMateriasNAssociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMateriasNAssociadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMateriasNAssociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasNAssociadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coldgvidCurriculoN,
            this.coldgvidMateriaN,
            this.coldgvstrNomeMateriaN,
            this.coldgvstrNomeTipoMateriaN,
            this.coldgvstrAnoN,
            this.coldgvflgOpcionalN,
            this.coldgvIdTipoMateriaN,
            this.coldgvflgConcluidaN});
            this.dgvMateriasNAssociadas.DataSource = this.sp_SelecionaMateriasCurriculoBindingSource1;
            this.dgvMateriasNAssociadas.Location = new System.Drawing.Point(6, 48);
            this.dgvMateriasNAssociadas.MultiSelect = false;
            this.dgvMateriasNAssociadas.Name = "dgvMateriasNAssociadas";
            this.dgvMateriasNAssociadas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriasNAssociadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMateriasNAssociadas.RowHeadersVisible = false;
            this.dgvMateriasNAssociadas.RowTemplate.Height = 24;
            this.dgvMateriasNAssociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasNAssociadas.ShowEditingIcon = false;
            this.dgvMateriasNAssociadas.Size = new System.Drawing.Size(516, 374);
            this.dgvMateriasNAssociadas.TabIndex = 6;
            this.dgvMateriasNAssociadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriasNAssociadas_CellClick);
            this.dgvMateriasNAssociadas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMateriasNAssociadas_CellFormatting);
            // 
            // coldgvidCurriculoN
            // 
            this.coldgvidCurriculoN.DataPropertyName = "IdCurriculo";
            this.coldgvidCurriculoN.HeaderText = "IdCurriculo";
            this.coldgvidCurriculoN.Name = "coldgvidCurriculoN";
            this.coldgvidCurriculoN.ReadOnly = true;
            this.coldgvidCurriculoN.Visible = false;
            this.coldgvidCurriculoN.Width = 81;
            // 
            // coldgvidMateriaN
            // 
            this.coldgvidMateriaN.DataPropertyName = "IdMateria";
            this.coldgvidMateriaN.HeaderText = "IdMateria";
            this.coldgvidMateriaN.Name = "coldgvidMateriaN";
            this.coldgvidMateriaN.ReadOnly = true;
            this.coldgvidMateriaN.Visible = false;
            this.coldgvidMateriaN.Width = 72;
            // 
            // coldgvstrNomeMateriaN
            // 
            this.coldgvstrNomeMateriaN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldgvstrNomeMateriaN.DataPropertyName = "strNomeMateria";
            this.coldgvstrNomeMateriaN.HeaderText = "Matéria";
            this.coldgvstrNomeMateriaN.Name = "coldgvstrNomeMateriaN";
            this.coldgvstrNomeMateriaN.ReadOnly = true;
            this.coldgvstrNomeMateriaN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // coldgvstrNomeTipoMateriaN
            // 
            this.coldgvstrNomeTipoMateriaN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvstrNomeTipoMateriaN.DataPropertyName = "strNomeTipoMateria";
            this.coldgvstrNomeTipoMateriaN.HeaderText = "Tipo";
            this.coldgvstrNomeTipoMateriaN.Name = "coldgvstrNomeTipoMateriaN";
            this.coldgvstrNomeTipoMateriaN.ReadOnly = true;
            this.coldgvstrNomeTipoMateriaN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coldgvstrNomeTipoMateriaN.Width = 61;
            // 
            // coldgvstrAnoN
            // 
            this.coldgvstrAnoN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvstrAnoN.DataPropertyName = "strAno";
            this.coldgvstrAnoN.HeaderText = "Ano";
            this.coldgvstrAnoN.Name = "coldgvstrAnoN";
            this.coldgvstrAnoN.ReadOnly = true;
            this.coldgvstrAnoN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coldgvstrAnoN.Width = 58;
            // 
            // coldgvflgOpcionalN
            // 
            this.coldgvflgOpcionalN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvflgOpcionalN.DataPropertyName = "flgOpcional";
            this.coldgvflgOpcionalN.HeaderText = "Opcional";
            this.coldgvflgOpcionalN.Name = "coldgvflgOpcionalN";
            this.coldgvflgOpcionalN.ReadOnly = true;
            this.coldgvflgOpcionalN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coldgvflgOpcionalN.Width = 70;
            // 
            // coldgvIdTipoMateriaN
            // 
            this.coldgvIdTipoMateriaN.DataPropertyName = "fkIdTipoMateria";
            this.coldgvIdTipoMateriaN.HeaderText = "fkIdTipoMateria";
            this.coldgvIdTipoMateriaN.Name = "coldgvIdTipoMateriaN";
            this.coldgvIdTipoMateriaN.ReadOnly = true;
            this.coldgvIdTipoMateriaN.Visible = false;
            this.coldgvIdTipoMateriaN.Width = 130;
            // 
            // coldgvflgConcluidaN
            // 
            this.coldgvflgConcluidaN.DataPropertyName = "flgConcluida";
            this.coldgvflgConcluidaN.HeaderText = "flgConcluida";
            this.coldgvflgConcluidaN.Name = "coldgvflgConcluidaN";
            this.coldgvflgConcluidaN.ReadOnly = true;
            this.coldgvflgConcluidaN.Visible = false;
            this.coldgvflgConcluidaN.Width = 91;
            // 
            // sp_SelecionaMateriasCurriculoBindingSource1
            // 
            this.sp_SelecionaMateriasCurriculoBindingSource1.DataMember = "sp_SelecionaMateriasCurriculo";
            this.sp_SelecionaMateriasCurriculoBindingSource1.DataSource = this.sisAulasPiteDataSetProcs1;
            // 
            // sisAulasPiteDataSetProcs1
            // 
            this.sisAulasPiteDataSetProcs1.DataSetName = "SisAulasPiteDataSetProcs";
            this.sisAulasPiteDataSetProcs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matérias associadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matérias não associadas";
            // 
            // sp_SelecionaMateriasCurriculoTableAdapter
            // 
            this.sp_SelecionaMateriasCurriculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_SelecionaMateriasCurriculoTableAdapter1
            // 
            this.sp_SelecionaMateriasCurriculoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(1013, 523);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 33);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnNotas.Location = new System.Drawing.Point(12, 523);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(164, 33);
            this.btnNotas.TabIndex = 13;
            this.btnNotas.Text = "Associar Notas";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // frmAssociarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::SisAulasOpusDei.Properties.Resources.img_sjme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 562);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAssociarMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Associação de matérias";
            this.Shown += new System.EventHandler(this.frmAssociarMateria_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAssociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaMateriasCurriculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasNAssociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaMateriasCurriculoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaMateriasCurriculoTableAdapter sp_SelecionaMateriasCurriculoTableAdapter;
        private SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sp_SelecionaMateriasCurriculoBindingSource;
        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs1;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaMateriasCurriculoTableAdapter sp_SelecionaMateriasCurriculoTableAdapter1;
        private SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource sp_SelecionaMateriasCurriculoBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMateriasAssociadas;
        private System.Windows.Forms.DataGridView dgvMateriasNAssociadas;
        private System.Windows.Forms.Label lblApelidoColaborador;
        private System.Windows.Forms.Label lblNomeColaborador;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAssociar;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvidCurriculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvidMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvstrNomeMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvstrNomeTipoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvstrAno;
        private System.Windows.Forms.DataGridViewImageColumn coldgvflgOpcional;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvIdTipoMateria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coldgvflgConcluida;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvidCurriculoN;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvidMateriaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvstrNomeMateriaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvstrNomeTipoMateriaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvstrAnoN;
        private System.Windows.Forms.DataGridViewImageColumn coldgvflgOpcionalN;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvIdTipoMateriaN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coldgvflgConcluidaN;
        private System.Windows.Forms.Button btnAssociarTurma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNotas;
    }
}