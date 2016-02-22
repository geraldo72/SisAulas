namespace SisAulasOpusDei
{
    partial class frmColaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColaboradores));
            this.sisAulasPiteDataSet = new SisAulasOpusDei.SisAulasPiteDataSet();
            this.tbAutenticacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAutenticacaoTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.tbAutenticacaoTableAdapter();
            this.tableAdapterManager = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.TableAdapterManager();
            this.tbAutenticacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAutenticacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbAutenticacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutenticacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutenticacaoBindingNavigator)).BeginInit();
            this.tbAutenticacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutenticacaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sisAulasPiteDataSet
            // 
            this.sisAulasPiteDataSet.DataSetName = "SisAulasPiteDataSet";
            this.sisAulasPiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAutenticacaoBindingSource
            // 
            this.tbAutenticacaoBindingSource.DataMember = "tbAutenticacao";
            this.tbAutenticacaoBindingSource.DataSource = this.sisAulasPiteDataSet;
            // 
            // tbAutenticacaoTableAdapter
            // 
            this.tbAutenticacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbAutenticacaoTableAdapter = this.tbAutenticacaoTableAdapter;
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
            // tbAutenticacaoBindingNavigator
            // 
            this.tbAutenticacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbAutenticacaoBindingNavigator.BindingSource = this.tbAutenticacaoBindingSource;
            this.tbAutenticacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbAutenticacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbAutenticacaoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbAutenticacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbAutenticacaoBindingNavigatorSaveItem});
            this.tbAutenticacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbAutenticacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbAutenticacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbAutenticacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbAutenticacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbAutenticacaoBindingNavigator.Name = "tbAutenticacaoBindingNavigator";
            this.tbAutenticacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbAutenticacaoBindingNavigator.Size = new System.Drawing.Size(868, 27);
            this.tbAutenticacaoBindingNavigator.TabIndex = 0;
            this.tbAutenticacaoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbAutenticacaoBindingNavigatorSaveItem
            // 
            this.tbAutenticacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAutenticacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbAutenticacaoBindingNavigatorSaveItem.Image")));
            this.tbAutenticacaoBindingNavigatorSaveItem.Name = "tbAutenticacaoBindingNavigatorSaveItem";
            this.tbAutenticacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbAutenticacaoBindingNavigatorSaveItem.Text = "Save Data";
            this.tbAutenticacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbAutenticacaoBindingNavigatorSaveItem_Click);
            // 
            // tbAutenticacaoDataGridView
            // 
            this.tbAutenticacaoDataGridView.AutoGenerateColumns = false;
            this.tbAutenticacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbAutenticacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbAutenticacaoDataGridView.DataSource = this.tbAutenticacaoBindingSource;
            this.tbAutenticacaoDataGridView.Location = new System.Drawing.Point(0, 32);
            this.tbAutenticacaoDataGridView.Name = "tbAutenticacaoDataGridView";
            this.tbAutenticacaoDataGridView.RowTemplate.Height = 24;
            this.tbAutenticacaoDataGridView.Size = new System.Drawing.Size(576, 240);
            this.tbAutenticacaoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fkIdColaborador";
            this.dataGridViewTextBoxColumn2.HeaderText = "fkIdColaborador";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "strEmail";
            this.dataGridViewTextBoxColumn3.HeaderText = "strEmail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "strUsuario";
            this.dataGridViewTextBoxColumn4.HeaderText = "strUsuario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "strSenha";
            this.dataGridViewTextBoxColumn5.HeaderText = "strSenha";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 460);
            this.Controls.Add(this.tbAutenticacaoDataGridView);
            this.Controls.Add(this.tbAutenticacaoBindingNavigator);
            this.Name = "frmColaboradores";
            this.Text = "Colaboradores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutenticacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutenticacaoBindingNavigator)).EndInit();
            this.tbAutenticacaoBindingNavigator.ResumeLayout(false);
            this.tbAutenticacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutenticacaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SisAulasPiteDataSet sisAulasPiteDataSet;
        private System.Windows.Forms.BindingSource tbAutenticacaoBindingSource;
        private SisAulasPiteDataSetTableAdapters.tbAutenticacaoTableAdapter tbAutenticacaoTableAdapter;
        private SisAulasPiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbAutenticacaoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbAutenticacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tbAutenticacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;



    }
}

