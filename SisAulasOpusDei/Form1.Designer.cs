namespace SisAulasOpusDei
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.sisAulasPiteDataSetProcs = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.sisAulasPiteDataSetProcs1 = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.sp_SelecionaMateriasCurriculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SelecionaMateriasCurriculoTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaMateriasCurriculoTableAdapter();
            this.tableAdapterManager = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager();
            this.sp_SelecionaMateriasCurriculoTableAdapter1 = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaMateriasCurriculoTableAdapter();
            this.tableAdapterManager1 = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager();
            this.sp_SelecionaMateriasCurriculoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaMateriasCurriculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaMateriasCurriculoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.sp_SelecionaMateriasCurriculoBindingSource1;
            this.listBox1.DisplayMember = "strNomeMateria";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(668, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 303);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "IdMateria";
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.sp_SelecionaMateriasCurriculoBindingSource;
            this.listBox2.DisplayMember = "strNomeMateria";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 89);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(281, 303);
            this.listBox2.TabIndex = 1;
            this.listBox2.ValueMember = "IdMateria";
            // 
            // sisAulasPiteDataSetProcs
            // 
            this.sisAulasPiteDataSetProcs.DataSetName = "SisAulasPiteDataSetProcs";
            this.sisAulasPiteDataSetProcs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SelecionaMateriasCurriculoBindingSource
            // 
            this.sp_SelecionaMateriasCurriculoBindingSource.DataMember = "sp_SelecionaMateriasCurriculo";
            this.sp_SelecionaMateriasCurriculoBindingSource.DataSource = this.sisAulasPiteDataSetProcs;
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
            // sp_SelecionaMateriasCurriculoTableAdapter
            // 
            this.sp_SelecionaMateriasCurriculoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_SelecionaMateriasCurriculoBindingSource1
            // 
            this.sp_SelecionaMateriasCurriculoBindingSource1.DataMember = "sp_SelecionaMateriasCurriculo";
            this.sp_SelecionaMateriasCurriculoBindingSource1.DataSource = this.sisAulasPiteDataSetProcs1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 422);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaMateriasCurriculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SelecionaMateriasCurriculoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaMateriasCurriculoTableAdapter sp_SelecionaMateriasCurriculoTableAdapter;
        private SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sp_SelecionaMateriasCurriculoBindingSource;
        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs1;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaMateriasCurriculoTableAdapter sp_SelecionaMateriasCurriculoTableAdapter1;
        private SisAulasPiteDataSetProcsTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource sp_SelecionaMateriasCurriculoBindingSource1;
    }
}