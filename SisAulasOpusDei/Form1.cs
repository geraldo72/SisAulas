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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializaGrids();
        }

        private void InicializaGrids()
        {
            try
            {
                this.sp_SelecionaMateriasCurriculoTableAdapter.Fill(this.sisAulasPiteDataSetProcs.sp_SelecionaMateriasCurriculo, "A", 2);
                this.sp_SelecionaMateriasCurriculoTableAdapter1.Fill(this.sisAulasPiteDataSetProcs1.sp_SelecionaMateriasCurriculo, "N", 2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
