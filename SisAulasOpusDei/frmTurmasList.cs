using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SisAulasOpusDei
{
    public partial class frmTurmasList : Form
    {
        private frmAssociarTurmas frmTurma = null;
        public frmTurmasList()
        {
            InitializeComponent();
        }

        private void frmTurmasList_Load(object sender, EventArgs e)
        {
            PerformRefresh(null,-1);
            carregaMaterias();
        }

        private void carregaMaterias()
        {

            using (SqlConnection conn = new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString))
            {
                try
                {
                    string query = "select -1 As IdMateria, 'Todos'  As strNomeMateria, 1 As indexS union select IdMateria, strNomeMateria, 3 As indexS from tbMateria where flgStatus = 1 order by indexS";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tbMateria");

                    cmbMateria.DisplayMember = "strNomeMateria";
                    cmbMateria.ValueMember = "IdMateria";
                    cmbMateria.DataSource = ds.Tables["tbMateria"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex.ToString());
                }
            }
        }

        public void PerformRefresh(String nome, int idMateria)
        {
            // TODO: This line of code loads data into the 'sisAulasPiteDataSetProcs.sp_SelecionaTodasMaterias' table. You can move, or remove it, as needed.
            this.sp_SelecionaTurmas_ParamTableAdapter.Fill(this.sisAulasPiteDataSetProcs.sp_SelecionaTurmas_Param,nome,idMateria);

        }

        void dataGritView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
            return;

            if (dgvTurmas.Columns[e.ColumnIndex].Name == "colEdit" )
            {
                Image img = ((System.Drawing.Image)(Properties.Resources.ico_edit));
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(img, e.CellBounds.Left + 13, e.CellBounds.Top, e.CellBounds.Width- 27, e.CellBounds.Height);
                e.Handled = true;
            }
        }

        void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvTurmas.Columns[e.ColumnIndex].Name == "flgEncerrada")
            {
                if ((bool)this.dgvTurmas["flgEncerrada", e.RowIndex].Value)
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
            int idMateria = -1;
            int.TryParse(cmbMateria.SelectedValue.ToString().Trim(), out idMateria);
            PerformRefresh(txtTurma.Text.Trim(), idMateria);
            
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells.  
            if (e.RowIndex < 0 || e.ColumnIndex !=
                dgvTurmas.Columns["colEdit"].Index) return;

            if (this.dgvTurmas["IdTurma", e.RowIndex].Value != null)
            {
                int idMateria = -1;
                int.TryParse(this.dgvTurmas["IdMateria", e.RowIndex].Value.ToString(), out idMateria);
                int idTurma = -1;
                int.TryParse(this.dgvTurmas["IdTurma", e.RowIndex].Value.ToString(), out idTurma);
                frmTurma = new frmAssociarTurmas(idMateria, this.dgvTurmas["strNomeMateria", e.RowIndex].Value.ToString(), this.dgvTurmas["strNomeTipoMateria", e.RowIndex].Value.ToString(), Utils.ToRoman((int)this.dgvTurmas["strAno", e.RowIndex].Value), idTurma, this.dgvTurmas["strNomeTurma", e.RowIndex].Value.ToString());
                frmTurma.ShowDialog();
                this.btnPesquisar_Click(null, null);
            }
            
        }


    }
}
