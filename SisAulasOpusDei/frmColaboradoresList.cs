using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace SisAulasOpusDei
{
    public partial class frmColaboradoresList : Form
    {
        frmColaboradoresManut _frmColaboradoresManut = null;
        frmNotas _frmNotas= null;
        frmAssociarMateria _frmAssociarMateria = null;
        int _IdColaborador = -1;
        string _NomeColaborador = "";
        string _ApelidoColaborador = "";

        public frmColaboradoresList()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            // TODO: This line of code loads data into the 'sisAulasPiteDataSetProcs.sp_SelecionaTodosColaboradores' table. You can move, or remove it, as needed.
            this.sp_SelecionaTodosColaboradoresTableAdapter.Fill(this.sisAulasPiteDataSetProcs.sp_SelecionaTodosColaboradores);
            CarregaComboTipoColaborador(); 
        }

        private void CarregaComboTipoColaborador()
        {
            using (SqlConnection conn = new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString))
            {
                try
                {
                    string query = "select 0 as idTipoColaborador, 'TODOS' as strTipoColaborador union select idTipoColaborador, strTipoColaborador from tbTipoColaborador order by 1";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tbTipoColaborador");

                    cmbTipoColaborador.DisplayMember = "strTipoColaborador";
                    cmbTipoColaborador.ValueMember = "idTipoColaborador";
                    cmbTipoColaborador.DataSource = ds.Tables["tbTipoColaborador"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex.Message.ToString());
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataView dv;
            String filtro = "";
            if (!"0".Equals(cmbTipoColaborador.SelectedValue.ToString().Trim()))
            {
                filtro += "fkIdTipoColaborador = '" + cmbTipoColaborador.SelectedValue + "' and ";
            }

            if (!"".Equals(txtNomeColaborador.Text.ToString().Trim()))
            {
                filtro += "strNome like '%" + txtNomeColaborador.Text + "%' and ";
            }
            if (!"".Equals(txtSobrenomeColaborador.Text.Trim()))
            {
                filtro += "strSobrenome like '%" + txtSobrenomeColaborador.Text + "%' and ";
            }
            if (!"".Equals(txtApelido.Text.Trim()))
            {
                filtro += "strApelido like '%" + txtApelido.Text + "%'";
            }

            //Remove and caso sobre
            if (filtro.EndsWith("and "))
            {
                filtro = filtro.Substring(0, filtro.Length - 4);
            }

            dv = new DataView(this.sisAulasPiteDataSetProcs.sp_SelecionaTodosColaboradores, filtro, "IdColaborador ", DataViewRowState.CurrentRows);
            dgvListaColaboradores.DataSource = dv;
            if (dv.Count <= 0)
            {
                MessageBox.Show("Não foi possível encontrar nenhum registro com as informações preenchidas. Favor, refazer a pesquisa com outras informações!", "Não foi possível encontrar sua pesquisa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvListaColaboradores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dgvListaColaboradores.Columns[e.ColumnIndex].Name == "coldgvEditar")
            {
                Image img = ((System.Drawing.Image)(Properties.Resources.ico_edit));
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(img, e.CellBounds.Left + 13, e.CellBounds.Top, e.CellBounds.Width - 27, e.CellBounds.Height);
                e.Handled = true;
            }
        }

        private void dgvListaColaboradores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListaColaboradores.Columns[e.ColumnIndex].Name == "coldgvStatus")
            {
                if ((bool)this.dgvListaColaboradores["coldgvStatus", e.RowIndex].Value)
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_stat_on));
                }
                else
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_stat_off));
                }

            }
            if (dgvListaColaboradores.Columns[e.ColumnIndex].Name == "coldgvMaterias")
            {
                e.Value = ((System.Drawing.Image)(Properties.Resources.ico_add));
               
            }

        }

        private void btnAddColaborador_Click(object sender, EventArgs e)
        {
            _frmColaboradoresManut = new frmColaboradoresManut();
            _frmColaboradoresManut.ShowDialog();
            this.RefreshList();
        }

        private void dgvListaColaboradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                bool _status = (bool)this.dgvListaColaboradores["coldgvStatus", e.RowIndex].Value;
                short _tipoColaborador = (short)this.dgvListaColaboradores["coldgvstrfkIdTipoColaborador", e.RowIndex].Value;

                //Botao Editar
                if (e.ColumnIndex ==
                    dgvListaColaboradores.Columns["coldgvEditar"].Index)
                {

                    _frmColaboradoresManut = new frmColaboradoresManut(_IdColaborador);
                    _frmColaboradoresManut.ShowDialog();
                    this.RefreshList();
                }//Somente habilita os botoes se estiver ativo
				 else if (_status ) { 
                    //Botão Matérias
                    if (e.ColumnIndex ==
                            dgvListaColaboradores.Columns["coldgvMaterias"].Index)
                    {
                        _frmAssociarMateria = new frmAssociarMateria(_IdColaborador, _NomeColaborador, _ApelidoColaborador);
                        _frmAssociarMateria.ShowDialog();
                        this.RefreshList();

                    }
                }
            }
            
        }
        private void dgvListaColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int.TryParse(this.dgvListaColaboradores["coldgvIdColaborador", e.RowIndex].Value.ToString(), out _IdColaborador);
                _NomeColaborador = this.dgvListaColaboradores["coldgvNome", e.RowIndex].Value.ToString();
                _ApelidoColaborador = this.dgvListaColaboradores["coldgvApelido", e.RowIndex].Value.ToString();
            }
        }
    }
}
