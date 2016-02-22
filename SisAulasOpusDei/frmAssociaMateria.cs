using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisAulasOpusDei
{
    public partial class frmAssociaMateria : Form
    {
        public frmAssociaMateria()
        {
            InitializeComponent();
        }

        private void frmAssociaMateria_Load(object sender, EventArgs e)
        {
            RefreshScreen();

        }
        private void RefreshScreen()
        {


            SisAulasPiteDataSetProcs.sp_SelecionaMateriasCurriculoDataTable dt = new SisAulasPiteDataSetProcs.sp_SelecionaMateriasCurriculoDataTable();
            sp_SelecionaMateriasCurriculoTableAdapter.Fill(dt, "A", 2);

            dgvMateriasAssociadas.DataSource = dt;

            SisAulasPiteDataSetProcs.sp_SelecionaMateriasCurriculoDataTable dtN = new SisAulasPiteDataSetProcs.sp_SelecionaMateriasCurriculoDataTable();
            sp_SelecionaMateriasCurriculoTableAdapter.Fill(dtN, "N", 2);

            dgvMateriasNAssociadas.DataSource = dtN;

            //Preview.DataContext=dt;

            /*
            DataView dv;
            // Populando o DataGrid com as matérias associadas;
            dv = new DataView(this.sisAulasPiteDataSetProcs.sp_SelecionaMateriasCurriculo, "'A', 2", "strNomeMateria", DataViewRowState.CurrentRows);
            dgvMateriasAssociadas.DataSource = dv;
            if (dv.Count <= 0)
            {
                MessageBox.Show("Não há registros.");
            }

            // Populando o DataGrid com as matérias NÃO associadas;
            dv = new DataView(this.sisAulasPiteDataSetProcs.sp_SelecionaMateriasCurriculo, "'N', 2", "strNomeMateria", DataViewRowState.CurrentRows);
            dgvMateriasNAssociadas.DataSource = dv;
            if (dv.Count <= 0)
            {
                MessageBox.Show("Não há registros.");
            }*/
        }
    }
}
