namespace SisAulasOpusDei
{
    partial class frmNotas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListaMaterias = new System.Windows.Forms.DataGridView();
            this.sp_SelecionaAlunosTurmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisAulasPiteDataSetProcs = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.sp_SelecionaAlunosTurmaTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaAlunosTurmaTableAdapter();
            this.tableAdapterManager = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager();
            this.txtTipoMat = new System.Windows.Forms.Label();
            this.lblTipoMat = new System.Windows.Forms.Label();
            this.strNomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvNotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvIdNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvIdCurriculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvConcluida = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.coldgvStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.coldgvAtribuir = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtAnoMat = new System.Windows.Forms.Label();
            this.lblAnoMat = new System.Windows.Forms.Label();
            this.txtNomeMat = new System.Windows.Forms.Label();
            this.lblNomeMat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaAlunosTurmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeMat);
            this.groupBox1.Controls.Add(this.lblNomeMat);
            this.groupBox1.Controls.Add(this.txtAnoMat);
            this.groupBox1.Controls.Add(this.lblAnoMat);
            this.groupBox1.Controls.Add(this.txtTipoMat);
            this.groupBox1.Controls.Add(this.lblTipoMat);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Turma";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtNome.Location = new System.Drawing.Point(85, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(63, 18);
            this.txtNome.TabIndex = 3;
            this.txtNome.Text = "lblNome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNome.Location = new System.Drawing.Point(7, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 255);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alunos Associados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListaMaterias);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(7, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 219);
            this.panel1.TabIndex = 0;
            // 
            // dgvListaMaterias
            // 
            this.dgvListaMaterias.AllowUserToAddRows = false;
            this.dgvListaMaterias.AllowUserToDeleteRows = false;
            this.dgvListaMaterias.AllowUserToResizeColumns = false;
            this.dgvListaMaterias.AllowUserToResizeRows = false;
            this.dgvListaMaterias.AutoGenerateColumns = false;
            this.dgvListaMaterias.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvListaMaterias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strNomeCol,
            this.coldgvNota,
            this.coldgvNotaFinal,
            this.coldgvIdNota,
            this.coldgvIdCurriculo,
            this.coldgvConcluida,
            this.coldgvStatus,
            this.coldgvAtribuir});
            this.dgvListaMaterias.DataSource = this.sp_SelecionaAlunosTurmaBindingSource;
            this.dgvListaMaterias.GridColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvListaMaterias.Location = new System.Drawing.Point(0, 0);
            this.dgvListaMaterias.MultiSelect = false;
            this.dgvListaMaterias.Name = "dgvListaMaterias";
            this.dgvListaMaterias.ReadOnly = true;
            this.dgvListaMaterias.RowHeadersVisible = false;
            this.dgvListaMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListaMaterias.Size = new System.Drawing.Size(672, 219);
            this.dgvListaMaterias.TabIndex = 0;
            this.dgvListaMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaMateria_CellContentClick);
            this.dgvListaMaterias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaMateria_CellFormatting);
            // 
            // sp_SelecionaAlunosTurmaBindingSource
            // 
            this.sp_SelecionaAlunosTurmaBindingSource.DataMember = "sp_SelecionaAlunosTurma";
            this.sp_SelecionaAlunosTurmaBindingSource.DataSource = this.sisAulasPiteDataSetProcs;
            // 
            // sisAulasPiteDataSetProcs
            // 
            this.sisAulasPiteDataSetProcs.DataSetName = "SisAulasPiteDataSetProcs";
            this.sisAulasPiteDataSetProcs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(622, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Sair";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // sp_SelecionaAlunosTurmaTableAdapter
            // 
            this.sp_SelecionaAlunosTurmaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtTipoMat
            // 
            this.txtTipoMat.AutoSize = true;
            this.txtTipoMat.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtTipoMat.Location = new System.Drawing.Point(426, 43);
            this.txtTipoMat.Name = "txtTipoMat";
            this.txtTipoMat.Size = new System.Drawing.Size(113, 18);
            this.txtTipoMat.TabIndex = 5;
            this.txtTipoMat.Text = "lblNomeMateria";
            // 
            // lblTipoMat
            // 
            this.lblTipoMat.AutoSize = true;
            this.lblTipoMat.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTipoMat.Location = new System.Drawing.Point(308, 43);
            this.lblTipoMat.Name = "lblTipoMat";
            this.lblTipoMat.Size = new System.Drawing.Size(112, 18);
            this.lblTipoMat.TabIndex = 4;
            this.lblTipoMat.Text = "Tipo Matéria:";
            // 
            // strNomeCol
            // 
            this.strNomeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strNomeCol.DataPropertyName = "strNome";
            this.strNomeCol.HeaderText = "Nome Colaborador";
            this.strNomeCol.Name = "strNomeCol";
            this.strNomeCol.ReadOnly = true;
            // 
            // coldgvNota
            // 
            this.coldgvNota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvNota.DataPropertyName = "strNomeNota";
            this.coldgvNota.HeaderText = "Nota";
            this.coldgvNota.Name = "coldgvNota";
            this.coldgvNota.ReadOnly = true;
            this.coldgvNota.Width = 55;
            // 
            // coldgvNotaFinal
            // 
            this.coldgvNotaFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coldgvNotaFinal.DataPropertyName = "dcNotaFinal";
            this.coldgvNotaFinal.HeaderText = "Nota Final";
            this.coldgvNotaFinal.Name = "coldgvNotaFinal";
            this.coldgvNotaFinal.ReadOnly = true;
            this.coldgvNotaFinal.Width = 80;
            // 
            // coldgvIdNota
            // 
            this.coldgvIdNota.DataPropertyName = "fkIdNota";
            this.coldgvIdNota.HeaderText = "fkIdNota";
            this.coldgvIdNota.Name = "coldgvIdNota";
            this.coldgvIdNota.ReadOnly = true;
            this.coldgvIdNota.Visible = false;
            // 
            // coldgvIdCurriculo
            // 
            this.coldgvIdCurriculo.DataPropertyName = "IdCurriculo";
            this.coldgvIdCurriculo.HeaderText = "IdCurriculo";
            this.coldgvIdCurriculo.Name = "coldgvIdCurriculo";
            this.coldgvIdCurriculo.ReadOnly = true;
            this.coldgvIdCurriculo.Visible = false;
            // 
            // coldgvConcluida
            // 
            this.coldgvConcluida.DataPropertyName = "flgConcluida";
            this.coldgvConcluida.HeaderText = "flgConcluida";
            this.coldgvConcluida.Name = "coldgvConcluida";
            this.coldgvConcluida.ReadOnly = true;
            this.coldgvConcluida.Visible = false;
            // 
            // coldgvStatus
            // 
            this.coldgvStatus.DataPropertyName = "flgStatus";
            this.coldgvStatus.HeaderText = "flgStatus";
            this.coldgvStatus.Name = "coldgvStatus";
            this.coldgvStatus.ReadOnly = true;
            this.coldgvStatus.Visible = false;
            // 
            // coldgvAtribuir
            // 
            this.coldgvAtribuir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.coldgvAtribuir.HeaderText = "Atribuir";
            this.coldgvAtribuir.Name = "coldgvAtribuir";
            this.coldgvAtribuir.ReadOnly = true;
            this.coldgvAtribuir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coldgvAtribuir.Width = 45;
            // 
            // txtAnoMat
            // 
            this.txtAnoMat.AutoSize = true;
            this.txtAnoMat.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtAnoMat.Location = new System.Drawing.Point(426, 61);
            this.txtAnoMat.Name = "txtAnoMat";
            this.txtAnoMat.Size = new System.Drawing.Size(113, 18);
            this.txtAnoMat.TabIndex = 7;
            this.txtAnoMat.Text = "lblNomeMateria";
            // 
            // lblAnoMat
            // 
            this.lblAnoMat.AutoSize = true;
            this.lblAnoMat.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAnoMat.Location = new System.Drawing.Point(311, 61);
            this.lblAnoMat.Name = "lblAnoMat";
            this.lblAnoMat.Size = new System.Drawing.Size(109, 18);
            this.lblAnoMat.TabIndex = 6;
            this.lblAnoMat.Text = "Ano Matéria:";
            // 
            // txtNomeMat
            // 
            this.txtNomeMat.AutoSize = true;
            this.txtNomeMat.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtNomeMat.Location = new System.Drawing.Point(426, 26);
            this.txtNomeMat.Name = "txtNomeMat";
            this.txtNomeMat.Size = new System.Drawing.Size(113, 18);
            this.txtNomeMat.TabIndex = 9;
            this.txtNomeMat.Text = "lblNomeMateria";
            // 
            // lblNomeMat
            // 
            this.lblNomeMat.AutoSize = true;
            this.lblNomeMat.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNomeMat.Location = new System.Drawing.Point(298, 25);
            this.lblNomeMat.Name = "lblNomeMat";
            this.lblNomeMat.Size = new System.Drawing.Size(122, 18);
            this.lblNomeMat.TabIndex = 8;
            this.lblNomeMat.Text = "Nome Matéria:";
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::SisAulasOpusDei.Properties.Resources.img_sjme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 410);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas das Matérias";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            this.Shown += new System.EventHandler(this.frmNotas_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaAlunosTurmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs;
        private System.Windows.Forms.BindingSource sp_SelecionaAlunosTurmaBindingSource;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaAlunosTurmaTableAdapter sp_SelecionaAlunosTurmaTableAdapter;
        private SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvListaMaterias;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTipoMat;
        private System.Windows.Forms.Label lblTipoMat;
        private System.Windows.Forms.Label txtNomeMat;
        private System.Windows.Forms.Label lblNomeMat;
        private System.Windows.Forms.Label txtAnoMat;
        private System.Windows.Forms.Label lblAnoMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvNotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvIdNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvIdCurriculo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coldgvConcluida;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coldgvStatus;
        private System.Windows.Forms.DataGridViewImageColumn coldgvAtribuir;
    }
}