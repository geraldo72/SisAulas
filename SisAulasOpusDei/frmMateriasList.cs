using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SisAulasOpusDei
{
    public partial class frmMateriasList : Form
    {
        private frmMateriasManut frmManut = null;
        public frmMateriasList()
        {
            InitializeComponent();
        }

        private void frmMateriasList_Load(object sender, EventArgs e)
        {
            PerformRefresh();
        }

        private void atualizaAnos()
        {

            using (SqlConnection conn = new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString))
            {
                try
                {
                    string query = "select '' As Id, 'Todos'  As strAno, 1 As indexS union select distinct STR(strAno) , STR(strAno), 3 from tbMateria where strAno > 0 order by indexS";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tbMateria");
                    
                    cmbAno.DisplayMember = "strAno";
                    cmbAno.ValueMember = "Id";
                    cmbAno.DataSource = ds.Tables["tbMateria"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex.ToString());
                }
            }
        }

        public void PerformRefresh()
        {
            // TODO: This line of code loads data into the 'sisAulasPiteDataSetProcs.sp_SelecionaTodasMaterias' table. You can move, or remove it, as needed.
            this.sp_SelecionaTodasMateriasTableAdapter.Fill(this.sisAulasPiteDataSetProcs.sp_SelecionaTodasMaterias);
            // TODO: This line of code loads data into the 'sisAulasPiteDataSet.tbTipoMateria' table. You can move, or remove it, as needed.
            this.tbTipoMateriaTableAdapter.ComboFillBy(this.sisAulasPiteDataSet.tbTipoMateria);
            // TODO: This line of code loads data into the 'sisAulasPiteDataSet.tbMateria' table. You can move, or remove it, as needed.
            this.tbMateriaTableAdapter.Fill(this.sisAulasPiteDataSet.tbMateria);
            atualizaAnos();
        }

        void dataGritView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
            return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEdit")
            {
                Image img = ((System.Drawing.Image)(Properties.Resources.ico_edit));
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            e.Graphics.DrawImage(img, e.CellBounds.Left + 13, e.CellBounds.Top, e.CellBounds.Width- 27, e.CellBounds.Height);
            e.Handled = true;
            }
        }

        void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "flgStatusDataGridViewCheckBoxColumn")
            {
                if ((bool)this.dataGridView1["flgStatusDataGridViewCheckBoxColumn", e.RowIndex].Value)
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_stat_on));
                }
                else
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_stat_off));
                }
                
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "flgOpcionalDataGridViewCheckBoxColumn")
            {
                if ((bool)this.dataGridView1["flgOpcionalDataGridViewCheckBoxColumn", e.RowIndex].Value)
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_optional));
                }
                else
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_blank));
                }
            }
        } 

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataView dv;
            String filtro = "";
            if (!"0".Equals(cmbTipoMat.SelectedValue.ToString().Trim()))
            {
                filtro += "fkIdTipoMateria = '" + cmbTipoMat.SelectedValue + "' and ";
            }
            if (!"".Equals(cmbAno.SelectedValue.ToString().Trim()))
            {
                filtro += "strAno = '" + cmbAno.SelectedValue+"' and ";
            }
            if (!"".Equals(txtMateria.Text.Trim()))
            {
                filtro += "strNomeMateria like '%" + txtMateria.Text+"%'";
            }

            //Remove and caso sobre
            if (filtro.EndsWith("and "))
            {
                filtro = filtro.Substring(0, filtro.Length - 4);
            }

            dv = new DataView(this.sisAulasPiteDataSetProcs.sp_SelecionaTodasMaterias, filtro, "IdMateria Desc", DataViewRowState.CurrentRows);
            dataGridView1.DataSource = dv;
            if (dv.Count <= 0)
            {
                MessageBox.Show("Não há registros.");
            }
        }

        private void btnAddMateria_Click(object sender, EventArgs e)
        {
            frmManut = new frmMateriasManut(this);
            frmManut.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells.  
            if (e.RowIndex < 0 || e.ColumnIndex !=
                dataGridView1.Columns["colEdit"].Index) return;

            if (this.dataGridView1["IdMateria", e.RowIndex].Value != null)
            {
                int idMateria = -1;
                if (int.TryParse(this.dataGridView1["IdMateria", e.RowIndex].Value.ToString(), out idMateria))
                {
                    frmManut = new frmMateriasManut(this,idMateria);
                    frmManut.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Matéria não encontrada", "Warning");
                }
            }
            
        }

    }
}
