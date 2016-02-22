using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisAulasOpusDei
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
                Application.Exit();
            }
            else
            {
                //Cancela o fechamento da janela caso ele clique no botao X
                if (typeof(FormClosingEventArgs) == e.GetType())
                {
                    ((FormClosingEventArgs)e).Cancel = true;
                }
            }
        }
        private void submnuListColaboradores_Click(object sender, EventArgs e)
        {
            frmColaboradoresList _frmColaboradoresList = new frmColaboradoresList();
            _frmColaboradoresList.ShowDialog();
        }

        private void submnuListMaterias_Click(object sender, EventArgs e)
        {
            frmMateriasList _frmMateriasList = new frmMateriasList();
            _frmMateriasList.ShowDialog();
        }

        private void submnuCadastrarColaboradores_Click(object sender, EventArgs e)
        {
            frmColaboradoresManut _frmColaboradoresManut = new frmColaboradoresManut();
            _frmColaboradoresManut.ShowDialog();
        }

        private void submnuCadastrarMaterias_Click(object sender, EventArgs e)
        {
            frmMateriasManut _frmMateriasManut = new frmMateriasManut();
            _frmMateriasManut.ShowDialog();
        }

        private void submnuCadastrarNotas_Click(object sender, EventArgs e)
        {
            frmReportAta _frmReportAta = new frmReportAta();
            _frmReportAta.ShowDialog();
        }

        private void submnuListTurmas_Click(object sender, EventArgs e)
        {
            frmTurmasList _frmTurmasList = new frmTurmasList();
            _frmTurmasList.ShowDialog();
        }

    }
}
