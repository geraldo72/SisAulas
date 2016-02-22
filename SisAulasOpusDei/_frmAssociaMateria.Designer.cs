namespace SisAulasOpusDei
{
    partial class frmAssociaMateria
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
            this.dgvMateriasAssociadas = new System.Windows.Forms.DataGridView();
            this.IdCurriculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurriculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNomeMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strAnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flgOpcionalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.strNomeTipoMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkIdTipoMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flgConcluidaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spSelecionaMateriasCurriculoBindingSourceAssociado = new System.Windows.Forms.BindingSource(this.components);
            this.sisAulasPiteDataSetProcs = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.dgvMateriasNAssociadas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurriculoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNomeMateriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strAnoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flgOpcionalDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.strNomeTipoMateriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkIdTipoMateriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flgConcluidaDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spSelecionaMateriasCurriculoBindingSourceNAssociado = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SelecionaMateriasCurriculoTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaMateriasCurriculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAssociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelecionaMateriasCurriculoBindingSourceAssociado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasNAssociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelecionaMateriasCurriculoBindingSourceNAssociado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMateriasAssociadas
            // 
            this.dgvMateriasAssociadas.AllowUserToAddRows = false;
            this.dgvMateriasAssociadas.AllowUserToDeleteRows = false;
            this.dgvMateriasAssociadas.AutoGenerateColumns = false;
            this.dgvMateriasAssociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasAssociadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCurriculo,
            this.idCurriculoDataGridViewTextBoxColumn,
            this.idMateriaDataGridViewTextBoxColumn,
            this.strNomeMateriaDataGridViewTextBoxColumn,
            this.strAnoDataGridViewTextBoxColumn,
            this.flgOpcionalDataGridViewCheckBoxColumn,
            this.strNomeTipoMateriaDataGridViewTextBoxColumn,
            this.fkIdTipoMateriaDataGridViewTextBoxColumn,
            this.flgConcluidaDataGridViewCheckBoxColumn});
            this.dgvMateriasAssociadas.DataSource = this.spSelecionaMateriasCurriculoBindingSourceAssociado;
            this.dgvMateriasAssociadas.Location = new System.Drawing.Point(12, 46);
            this.dgvMateriasAssociadas.Name = "dgvMateriasAssociadas";
            this.dgvMateriasAssociadas.ReadOnly = true;
            this.dgvMateriasAssociadas.RowTemplate.Height = 24;
            this.dgvMateriasAssociadas.Size = new System.Drawing.Size(341, 150);
            this.dgvMateriasAssociadas.TabIndex = 1;
            // 
            // IdCurriculo
            // 
            this.IdCurriculo.DataPropertyName = "IdCurriculo";
            this.IdCurriculo.HeaderText = "IdCurriculo";
            this.IdCurriculo.Name = "IdCurriculo";
            this.IdCurriculo.ReadOnly = true;
            this.IdCurriculo.Visible = false;
            this.IdCurriculo.Width = 5;
            // 
            // idCurriculoDataGridViewTextBoxColumn
            // 
            this.idCurriculoDataGridViewTextBoxColumn.DataPropertyName = "IdCurriculo";
            this.idCurriculoDataGridViewTextBoxColumn.HeaderText = "IdCurriculo";
            this.idCurriculoDataGridViewTextBoxColumn.Name = "idCurriculoDataGridViewTextBoxColumn";
            this.idCurriculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMateriaDataGridViewTextBoxColumn
            // 
            this.idMateriaDataGridViewTextBoxColumn.DataPropertyName = "IdMateria";
            this.idMateriaDataGridViewTextBoxColumn.HeaderText = "IdMateria";
            this.idMateriaDataGridViewTextBoxColumn.Name = "idMateriaDataGridViewTextBoxColumn";
            this.idMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strNomeMateriaDataGridViewTextBoxColumn
            // 
            this.strNomeMateriaDataGridViewTextBoxColumn.DataPropertyName = "strNomeMateria";
            this.strNomeMateriaDataGridViewTextBoxColumn.HeaderText = "strNomeMateria";
            this.strNomeMateriaDataGridViewTextBoxColumn.Name = "strNomeMateriaDataGridViewTextBoxColumn";
            this.strNomeMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strAnoDataGridViewTextBoxColumn
            // 
            this.strAnoDataGridViewTextBoxColumn.DataPropertyName = "strAno";
            this.strAnoDataGridViewTextBoxColumn.HeaderText = "strAno";
            this.strAnoDataGridViewTextBoxColumn.Name = "strAnoDataGridViewTextBoxColumn";
            this.strAnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flgOpcionalDataGridViewCheckBoxColumn
            // 
            this.flgOpcionalDataGridViewCheckBoxColumn.DataPropertyName = "flgOpcional";
            this.flgOpcionalDataGridViewCheckBoxColumn.HeaderText = "flgOpcional";
            this.flgOpcionalDataGridViewCheckBoxColumn.Name = "flgOpcionalDataGridViewCheckBoxColumn";
            this.flgOpcionalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // strNomeTipoMateriaDataGridViewTextBoxColumn
            // 
            this.strNomeTipoMateriaDataGridViewTextBoxColumn.DataPropertyName = "strNomeTipoMateria";
            this.strNomeTipoMateriaDataGridViewTextBoxColumn.HeaderText = "strNomeTipoMateria";
            this.strNomeTipoMateriaDataGridViewTextBoxColumn.Name = "strNomeTipoMateriaDataGridViewTextBoxColumn";
            this.strNomeTipoMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkIdTipoMateriaDataGridViewTextBoxColumn
            // 
            this.fkIdTipoMateriaDataGridViewTextBoxColumn.DataPropertyName = "fkIdTipoMateria";
            this.fkIdTipoMateriaDataGridViewTextBoxColumn.HeaderText = "fkIdTipoMateria";
            this.fkIdTipoMateriaDataGridViewTextBoxColumn.Name = "fkIdTipoMateriaDataGridViewTextBoxColumn";
            this.fkIdTipoMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flgConcluidaDataGridViewCheckBoxColumn
            // 
            this.flgConcluidaDataGridViewCheckBoxColumn.DataPropertyName = "flgConcluida";
            this.flgConcluidaDataGridViewCheckBoxColumn.HeaderText = "flgConcluida";
            this.flgConcluidaDataGridViewCheckBoxColumn.Name = "flgConcluidaDataGridViewCheckBoxColumn";
            this.flgConcluidaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // spSelecionaMateriasCurriculoBindingSourceAssociado
            // 
            this.spSelecionaMateriasCurriculoBindingSourceAssociado.DataMember = "sp_SelecionaMateriasCurriculo";
            this.spSelecionaMateriasCurriculoBindingSourceAssociado.DataSource = this.sisAulasPiteDataSetProcs;
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
            this.dgvMateriasNAssociadas.AutoGenerateColumns = false;
            this.dgvMateriasNAssociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasNAssociadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idCurriculoDataGridViewTextBoxColumn1,
            this.idMateriaDataGridViewTextBoxColumn1,
            this.strNomeMateriaDataGridViewTextBoxColumn1,
            this.strAnoDataGridViewTextBoxColumn1,
            this.flgOpcionalDataGridViewCheckBoxColumn1,
            this.strNomeTipoMateriaDataGridViewTextBoxColumn1,
            this.fkIdTipoMateriaDataGridViewTextBoxColumn1,
            this.flgConcluidaDataGridViewCheckBoxColumn1});
            this.dgvMateriasNAssociadas.DataSource = this.spSelecionaMateriasCurriculoBindingSourceNAssociado;
            this.dgvMateriasNAssociadas.Location = new System.Drawing.Point(462, 46);
            this.dgvMateriasNAssociadas.Name = "dgvMateriasNAssociadas";
            this.dgvMateriasNAssociadas.ReadOnly = true;
            this.dgvMateriasNAssociadas.RowTemplate.Height = 24;
            this.dgvMateriasNAssociadas.Size = new System.Drawing.Size(341, 150);
            this.dgvMateriasNAssociadas.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCurriculo";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCurriculo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // idCurriculoDataGridViewTextBoxColumn1
            // 
            this.idCurriculoDataGridViewTextBoxColumn1.DataPropertyName = "IdCurriculo";
            this.idCurriculoDataGridViewTextBoxColumn1.HeaderText = "IdCurriculo";
            this.idCurriculoDataGridViewTextBoxColumn1.Name = "idCurriculoDataGridViewTextBoxColumn1";
            this.idCurriculoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idMateriaDataGridViewTextBoxColumn1
            // 
            this.idMateriaDataGridViewTextBoxColumn1.DataPropertyName = "IdMateria";
            this.idMateriaDataGridViewTextBoxColumn1.HeaderText = "IdMateria";
            this.idMateriaDataGridViewTextBoxColumn1.Name = "idMateriaDataGridViewTextBoxColumn1";
            this.idMateriaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // strNomeMateriaDataGridViewTextBoxColumn1
            // 
            this.strNomeMateriaDataGridViewTextBoxColumn1.DataPropertyName = "strNomeMateria";
            this.strNomeMateriaDataGridViewTextBoxColumn1.HeaderText = "strNomeMateria";
            this.strNomeMateriaDataGridViewTextBoxColumn1.Name = "strNomeMateriaDataGridViewTextBoxColumn1";
            this.strNomeMateriaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // strAnoDataGridViewTextBoxColumn1
            // 
            this.strAnoDataGridViewTextBoxColumn1.DataPropertyName = "strAno";
            this.strAnoDataGridViewTextBoxColumn1.HeaderText = "strAno";
            this.strAnoDataGridViewTextBoxColumn1.Name = "strAnoDataGridViewTextBoxColumn1";
            this.strAnoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // flgOpcionalDataGridViewCheckBoxColumn1
            // 
            this.flgOpcionalDataGridViewCheckBoxColumn1.DataPropertyName = "flgOpcional";
            this.flgOpcionalDataGridViewCheckBoxColumn1.HeaderText = "flgOpcional";
            this.flgOpcionalDataGridViewCheckBoxColumn1.Name = "flgOpcionalDataGridViewCheckBoxColumn1";
            this.flgOpcionalDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // strNomeTipoMateriaDataGridViewTextBoxColumn1
            // 
            this.strNomeTipoMateriaDataGridViewTextBoxColumn1.DataPropertyName = "strNomeTipoMateria";
            this.strNomeTipoMateriaDataGridViewTextBoxColumn1.HeaderText = "strNomeTipoMateria";
            this.strNomeTipoMateriaDataGridViewTextBoxColumn1.Name = "strNomeTipoMateriaDataGridViewTextBoxColumn1";
            this.strNomeTipoMateriaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fkIdTipoMateriaDataGridViewTextBoxColumn1
            // 
            this.fkIdTipoMateriaDataGridViewTextBoxColumn1.DataPropertyName = "fkIdTipoMateria";
            this.fkIdTipoMateriaDataGridViewTextBoxColumn1.HeaderText = "fkIdTipoMateria";
            this.fkIdTipoMateriaDataGridViewTextBoxColumn1.Name = "fkIdTipoMateriaDataGridViewTextBoxColumn1";
            this.fkIdTipoMateriaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // flgConcluidaDataGridViewCheckBoxColumn1
            // 
            this.flgConcluidaDataGridViewCheckBoxColumn1.DataPropertyName = "flgConcluida";
            this.flgConcluidaDataGridViewCheckBoxColumn1.HeaderText = "flgConcluida";
            this.flgConcluidaDataGridViewCheckBoxColumn1.Name = "flgConcluidaDataGridViewCheckBoxColumn1";
            this.flgConcluidaDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // spSelecionaMateriasCurriculoBindingSourceNAssociado
            // 
            this.spSelecionaMateriasCurriculoBindingSourceNAssociado.DataMember = "sp_SelecionaMateriasCurriculo";
            this.spSelecionaMateriasCurriculoBindingSourceNAssociado.DataSource = this.sisAulasPiteDataSetProcs;
            // 
            // sp_SelecionaMateriasCurriculoTableAdapter
            // 
            this.sp_SelecionaMateriasCurriculoTableAdapter.ClearBeforeFill = true;
            // 
            // frmAssociaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 542);
            this.Controls.Add(this.dgvMateriasNAssociadas);
            this.Controls.Add(this.dgvMateriasAssociadas);
            this.Name = "frmAssociaMateria";
            this.Text = "frmAssociaMateria";
            this.Load += new System.EventHandler(this.frmAssociaMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAssociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelecionaMateriasCurriculoBindingSourceAssociado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasNAssociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelecionaMateriasCurriculoBindingSourceNAssociado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMateriasAssociadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCurriculo;
        private System.Windows.Forms.DataGridView dgvMateriasNAssociadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurriculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNomeMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strAnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flgOpcionalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNomeTipoMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkIdTipoMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flgConcluidaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource spSelecionaMateriasCurriculoBindingSourceAssociado;
        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurriculoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNomeMateriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strAnoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flgOpcionalDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNomeTipoMateriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkIdTipoMateriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flgConcluidaDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource spSelecionaMateriasCurriculoBindingSourceNAssociado;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaMateriasCurriculoTableAdapter sp_SelecionaMateriasCurriculoTableAdapter;
    }
}