using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisAulasOpusDei
{
    public partial class frmMateriasManut : Form
    {
        //Dados Materia
        private int _idMateria = -1;
        private int _tpMateria = -1;
        private string _nomeMateria = "";
        private string _anoMateria = "";

        
        private frmMateriasList _owner;
        private frmAssociarTurmas _frmAssociarTurmas;

        public frmMateriasManut()
        {
            InitializeComponent();
            carregaCombos();
        }
        public frmMateriasManut(frmMateriasList owner)
        {
            _owner = owner;
            InitializeComponent();
            carregaCombos();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMateriasManut_FormClosing);
        }

        private void frmMateriasManut_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh();
        }

        public frmMateriasManut(frmMateriasList owner, int idMateria)
        {
            _owner = owner;
            this._idMateria = idMateria;
            InitializeComponent();
            carregaCombos();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMateriasManut_FormClosing);
        }


        private void frmMateriasManut_Load(object sender, EventArgs e)
        {
            if (-1 != _idMateria)
            {
                this.tbMateriaTableAdapter.FillBy(this.sisAulasPiteDataSet.tbMateria, _idMateria);
                //Recupera dados antes de serem alterados para gerar a ata
                _tpMateria = this.sisAulasPiteDataSet.tbMateria[0].fkIdTipoMateria ;
                _nomeMateria = this.sisAulasPiteDataSet.tbMateria[0].strNomeMateria;
                _anoMateria = Utils.ToRoman(this.sisAulasPiteDataSet.tbMateria[0].strAno);

                //Desbloqueia o botão para imprimir ata
                btnAdicionarTurma.Enabled = true;
            }
        }

        private void carregaCombos()
        {
            using (SqlConnection conn = new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString))
            {
                try
                {
                    string query = "select 0 as IdTipoMateria, 'Selecione...' as strNomeTipoMateria union select IdTipoMateria, strNomeTipoMateria from tbTipoMateria order by 1";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tbTipoMateria");

                    cmbTipoMat.DisplayMember = "strNomeTipoMateria";
                    cmbTipoMat.ValueMember = "IdTipoMateria";
                    cmbTipoMat.DataSource = ds.Tables["tbTipoMateria"];
                    
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex.Message.ToString());
                }
            }
        }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            using (SqlCommand sqlComm = new SqlCommand("dbo.sp_ModificarMateria", new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString)))
            {
                if (sqlComm.Connection.State != ConnectionState.Open)
                {
                    sqlComm.Connection.Open();
                }

                try
                {

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    if (-1 != _idMateria)
                    {
                        sqlComm.Parameters.AddWithValue("@TipoManutencao", "A");
                        sqlComm.Parameters.AddWithValue("@IdMateria", _idMateria);
                    }
                    else
                    {
                        sqlComm.Parameters.AddWithValue("@TipoManutencao", "I");
                    }
                    if ("".Equals(this.txtNomeMat.Text.Trim()))
                    {
                        throw new Exception("Favor preencher o nome da matéria.");
                    }
                    sqlComm.Parameters.AddWithValue("@NomeMateria", this.txtNomeMat.Text);
                    sqlComm.Parameters.AddWithValue("@DescMateria", this.txtDescricao.Text);
                    if ((int)this.cmbTipoMat.SelectedValue == 0)
                    {
                        throw new Exception("Favor selecione um tipo de matéria.");
                    }
                    sqlComm.Parameters.AddWithValue("@IdTipoMateria", (int)this.cmbTipoMat.SelectedValue);
                    if (this.cmbAno.SelectedValue != null)
                        sqlComm.Parameters.AddWithValue("@Ano", (int)this.cmbAno.SelectedValue);
                    else
                        throw new Exception("Favor selecione um Ano.");

                    sqlComm.Parameters.AddWithValue("@Opcional", this.chkOpcional.Checked);
                    sqlComm.Parameters.AddWithValue("@Status", this.rdAtivo.Checked);

                    if ("".Equals(this.txtEcts.Text.Trim()))
                    {
                        throw new Exception("Favor preencher o ECTS.");
                    }
                    sqlComm.Parameters.AddWithValue("@Ects", this.txtEcts.Text);
                    if (!this.txtCreditos.MaskCompleted)
                    {
                        throw new Exception("Favor preencher o Nº de Créditos.");
                    }
                    sqlComm.Parameters.AddWithValue("@Creditos", this.txtCreditos.Text);
                    if ("".Equals(this.txtHrAulas45.Text.Trim()))
                    {
                        throw new Exception("Favor preencher o Nº de Horas Aula (45').");
                    }
                    sqlComm.Parameters.AddWithValue("@HrAula45", this.txtHrAulas45.Text);
                    if ("".Equals(this.txtHrAulas60.Text.Trim()))
                    {
                        throw new Exception("Favor preencher o Nº de Horas Aula (60').");
                    }
                    sqlComm.Parameters.AddWithValue("@HrAula60", this.txtHrAulas60.Text);

                    SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
                    DataTable dt = new DataTable();

                    int rowsAffected = sda.Fill(dt);
                    if (-1 != _idMateria)
                    {
                        MessageBox.Show("Matéria alterada com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Matéria incluída com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    this.Close();
                }catch (Exception ex){
                    // write exception info to log or anything else
                    MessageBox.Show("Não foi possível incluir/alterar a matéria: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbTipoMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoMat.SelectedValue == null || this.chkOpcional.Checked)
            {
                this.cmbAno.Enabled = false;
                this.cmbAno.DataSource = null;
                return;
            }
            int valueTpMat = (int)this.cmbTipoMat.SelectedValue;
            List<KeyValuePair<int, string>> myList;
            switch(valueTpMat){
                case 0:
                    this.cmbAno.Enabled = false;
                    this.cmbAno.DataSource = null;
                    break;
                case 1:
                    this.cmbAno.Enabled = true;
                    myList = new List<KeyValuePair<int, string>>();
                    myList.Add(new KeyValuePair<int, string>(1, "I"));
                    myList.Add(new KeyValuePair<int, string>(2, "II"));
                    
                    this.cmbAno.DataSource = myList;

                    this.cmbAno.DisplayMember = "Value";
                    this.cmbAno.ValueMember = "Key";
                    this.cmbAno.SelectedIndex = 0;
                    break;
                case 2:
                    this.cmbAno.Enabled = true;
                    myList = new List<KeyValuePair<int, string>>();
                    myList.Add(new KeyValuePair<int, string>(1, "I"));
                    myList.Add(new KeyValuePair<int, string>(2, "II"));
                    myList.Add(new KeyValuePair<int, string>(3, "III"));
                    myList.Add(new KeyValuePair<int, string>(4, "IV"));
                    
                    this.cmbAno.DataSource = myList;

                    this.cmbAno.DisplayMember = "Value";
                    this.cmbAno.ValueMember = "Key";
                    this.cmbAno.SelectedIndex = 0;
                    break;

            }
        }

        private void rdAtivo_CheckedChanged(object sender, EventArgs e)
        {
            rdInativo.Checked = !rdAtivo.Checked;
        }

        private void chkOpcional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkOpcional.Checked)
            {
                this.cmbAno.Enabled = false;
                this.cmbAno.DataSource = null;
            }
        }

        private void onlyNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnAdicionarTurma_Click(object sender, EventArgs e)
        {
            //cmbTipoMat.DataSource
                //_tpMateria
            string nomeTpMateria = (from DataRow dr in ((DataTable)cmbTipoMat.DataSource).Rows where (int)dr["IdTipoMateria"] == _tpMateria select (string)dr["strNomeTipoMateria"]).FirstOrDefault();

            _frmAssociarTurmas = new frmAssociarTurmas(_idMateria, _nomeMateria, nomeTpMateria, _anoMateria, -1, "");
            _frmAssociarTurmas.ShowDialog();
        }

        

       
    }

    
}
