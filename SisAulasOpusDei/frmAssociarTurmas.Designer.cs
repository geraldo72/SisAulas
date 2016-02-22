namespace SisAulasOpusDei
{
    partial class frmAssociarTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssociarTurmas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNomeTurma = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAlunosNAssociados = new System.Windows.Forms.DataGridView();
            this.idAlunoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAlunoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flgConcluida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurriculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAssociar = new System.Windows.Forms.Button();
            this.dgvAlunosAssociados = new System.Windows.Forms.DataGridView();
            this.idAlunoCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAlunoCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temNota1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.flgConcluida1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.idCurriculo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTipoMateria = new System.Windows.Forms.Label();
            this.txtNomeMateria = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.sp_SelecionaAlunosTurmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisAulasPiteDataSetProcs = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.sp_SelecionaAlunosTurmaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sisAulasPiteDataSetProcs1 = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.sp_SelecionaAlunosTurmaTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaAlunosTurmaTableAdapter();
            this.tableAdapterManager = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager();
            this.sp_SelecionaAlunosTurmaTableAdapter1 = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaAlunosTurmaTableAdapter();
            this.tableAdapterManager1 = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager();
            this.btnImprimirAta = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosNAssociados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosAssociados)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaAlunosTurmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaAlunosTurmaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnNotas, "btnNotas");
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.UseVisualStyleBackColor = false;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNomeTurma);
            this.groupBox4.Controls.Add(this.txtMateria);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label21);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // txtNomeTurma
            // 
            resources.ApplyResources(this.txtNomeTurma, "txtNomeTurma");
            this.txtNomeTurma.Name = "txtNomeTurma";
            // 
            // txtMateria
            // 
            resources.ApplyResources(this.txtMateria, "txtMateria");
            this.txtMateria.Name = "txtMateria";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAlunosNAssociados);
            this.groupBox3.Controls.Add(this.btnRemover);
            this.groupBox3.Controls.Add(this.btnAssociar);
            this.groupBox3.Controls.Add(this.dgvAlunosAssociados);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // dgvAlunosNAssociados
            // 
            this.dgvAlunosNAssociados.AllowUserToAddRows = false;
            this.dgvAlunosNAssociados.AllowUserToDeleteRows = false;
            this.dgvAlunosNAssociados.AllowUserToResizeColumns = false;
            this.dgvAlunosNAssociados.AllowUserToResizeRows = false;
            this.dgvAlunosNAssociados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAlunosNAssociados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAlunosNAssociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosNAssociados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlunoCol,
            this.nomeAlunoCol,
            this.temNota,
            this.flgConcluida,
            this.idCurriculo});
            resources.ApplyResources(this.dgvAlunosNAssociados, "dgvAlunosNAssociados");
            this.dgvAlunosNAssociados.Name = "dgvAlunosNAssociados";
            this.dgvAlunosNAssociados.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunosNAssociados.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunosNAssociados.RowHeadersVisible = false;
            this.dgvAlunosNAssociados.RowTemplate.Height = 24;
            this.dgvAlunosNAssociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunosNAssociados.ShowEditingIcon = false;
            // 
            // idAlunoCol
            // 
            resources.ApplyResources(this.idAlunoCol, "idAlunoCol");
            this.idAlunoCol.Name = "idAlunoCol";
            this.idAlunoCol.ReadOnly = true;
            // 
            // nomeAlunoCol
            // 
            this.nomeAlunoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.nomeAlunoCol, "nomeAlunoCol");
            this.nomeAlunoCol.Name = "nomeAlunoCol";
            this.nomeAlunoCol.ReadOnly = true;
            // 
            // temNota
            // 
            this.temNota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.temNota, "temNota");
            this.temNota.Name = "temNota";
            this.temNota.ReadOnly = true;
            this.temNota.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // flgConcluida
            // 
            this.flgConcluida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.flgConcluida, "flgConcluida");
            this.flgConcluida.Name = "flgConcluida";
            this.flgConcluida.ReadOnly = true;
            this.flgConcluida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idCurriculo
            // 
            resources.ApplyResources(this.idCurriculo, "idCurriculo");
            this.idCurriculo.Name = "idCurriculo";
            this.idCurriculo.ReadOnly = true;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnRemover, "btnRemover");
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAssociar
            // 
            this.btnAssociar.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnAssociar, "btnAssociar");
            this.btnAssociar.Name = "btnAssociar";
            this.btnAssociar.UseVisualStyleBackColor = false;
            this.btnAssociar.Click += new System.EventHandler(this.btnAssociar_Click);
            // 
            // dgvAlunosAssociados
            // 
            this.dgvAlunosAssociados.AllowUserToAddRows = false;
            this.dgvAlunosAssociados.AllowUserToDeleteRows = false;
            this.dgvAlunosAssociados.AllowUserToResizeColumns = false;
            this.dgvAlunosAssociados.AllowUserToResizeRows = false;
            this.dgvAlunosAssociados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAlunosAssociados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAlunosAssociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosAssociados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlunoCol1,
            this.nomeAlunoCol1,
            this.temNota1,
            this.flgConcluida1,
            this.idCurriculo1});
            resources.ApplyResources(this.dgvAlunosAssociados, "dgvAlunosAssociados");
            this.dgvAlunosAssociados.Name = "dgvAlunosAssociados";
            this.dgvAlunosAssociados.ReadOnly = true;
            this.dgvAlunosAssociados.RowHeadersVisible = false;
            this.dgvAlunosAssociados.RowTemplate.Height = 24;
            this.dgvAlunosAssociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunosAssociados.ShowEditingIcon = false;
            this.dgvAlunosAssociados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAlunosAssociados_CellFormatting);
            // 
            // idAlunoCol1
            // 
            resources.ApplyResources(this.idAlunoCol1, "idAlunoCol1");
            this.idAlunoCol1.Name = "idAlunoCol1";
            this.idAlunoCol1.ReadOnly = true;
            // 
            // nomeAlunoCol1
            // 
            this.nomeAlunoCol1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.nomeAlunoCol1, "nomeAlunoCol1");
            this.nomeAlunoCol1.Name = "nomeAlunoCol1";
            this.nomeAlunoCol1.ReadOnly = true;
            // 
            // temNota1
            // 
            this.temNota1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.temNota1, "temNota1");
            this.temNota1.Name = "temNota1";
            this.temNota1.ReadOnly = true;
            this.temNota1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.temNota1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // flgConcluida1
            // 
            this.flgConcluida1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.flgConcluida1, "flgConcluida1");
            this.flgConcluida1.Name = "flgConcluida1";
            this.flgConcluida1.ReadOnly = true;
            this.flgConcluida1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.flgConcluida1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idCurriculo1
            // 
            resources.ApplyResources(this.idCurriculo1, "idCurriculo1");
            this.idCurriculo1.Name = "idCurriculo1";
            this.idCurriculo1.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblAno);
            this.groupBox6.Controls.Add(this.txtAno);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.txtTipoMateria);
            this.groupBox6.Controls.Add(this.txtNomeMateria);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // lblAno
            // 
            resources.ApplyResources(this.lblAno, "lblAno");
            this.lblAno.Name = "lblAno";
            // 
            // txtAno
            // 
            resources.ApplyResources(this.txtAno, "txtAno");
            this.txtAno.Name = "txtAno";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label19);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // txtTipoMateria
            // 
            resources.ApplyResources(this.txtTipoMateria, "txtTipoMateria");
            this.txtTipoMateria.Name = "txtTipoMateria";
            // 
            // txtNomeMateria
            // 
            resources.ApplyResources(this.txtNomeMateria, "txtNomeMateria");
            this.txtNomeMateria.Name = "txtNomeMateria";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnConfirmar, "btnConfirmar");
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            // sp_SelecionaAlunosTurmaBindingSource1
            // 
            this.sp_SelecionaAlunosTurmaBindingSource1.DataMember = "sp_SelecionaAlunosTurma";
            this.sp_SelecionaAlunosTurmaBindingSource1.DataSource = this.sisAulasPiteDataSetProcs1;
            // 
            // sisAulasPiteDataSetProcs1
            // 
            this.sisAulasPiteDataSetProcs1.DataSetName = "SisAulasPiteDataSetProcs";
            this.sisAulasPiteDataSetProcs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sp_SelecionaAlunosTurmaTableAdapter1
            // 
            this.sp_SelecionaAlunosTurmaTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnImprimirAta
            // 
            this.btnImprimirAta.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnImprimirAta, "btnImprimirAta");
            this.btnImprimirAta.Name = "btnImprimirAta";
            this.btnImprimirAta.UseVisualStyleBackColor = false;
            this.btnImprimirAta.Click += new System.EventHandler(this.btnImprimirAta_Click);
            // 
            // frmAssociarTurmas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::SisAulasOpusDei.Properties.Resources.img_sjme;
            this.Controls.Add(this.btnImprimirAta);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.btnSair);
            this.Name = "frmAssociarTurmas";
            this.ShowIcon = false;
            this.Shown += new System.EventHandler(this.frmAssociarTurmas_Shown);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosNAssociados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosAssociados)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaAlunosTurmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaAlunosTurmaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaAlunosTurmaTableAdapter sp_SelecionaAlunosTurmaTableAdapter;
        private SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sp_SelecionaAlunosTurmaBindingSource;
        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs1;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaAlunosTurmaTableAdapter sp_SelecionaAlunosTurmaTableAdapter1;
        private SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource sp_SelecionaAlunosTurmaBindingSource1;

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAlunosNAssociados;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAssociar;
        private System.Windows.Forms.DataGridView dgvAlunosAssociados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label txtTipoMateria;
        private System.Windows.Forms.Label txtNomeMateria;
        private System.Windows.Forms.Label txtNomeTurma;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAlunoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn temNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn flgConcluida;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurriculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAlunoCol1;
        private System.Windows.Forms.DataGridViewImageColumn temNota1;
        private System.Windows.Forms.DataGridViewImageColumn flgConcluida1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurriculo1;
        private System.Windows.Forms.Button btnImprimirAta;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label txtAno;
    }
}