using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atesta2.Formularios
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Item_Utilidades_CiasAseguradoras_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Frm_Seguros"] != null)
            {
                Application.OpenForms["Frm_Seguros"].Activate();
            }
            else
            {
                Frm_Seguros frm_Seguros = new Frm_Seguros();
                frm_Seguros.MdiParent = this;
                frm_Seguros.Show();
            }
        }

     

        private void ItemUsuarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Frm_Usuarios"] != null)
            {
                Application.OpenForms["Frm_Usuarios"].Activate();
            }
            else
            {
                Frm_Usuarios frm_Usuarios = new Frm_Usuarios();
                frm_Usuarios.MdiParent = this;
                frm_Usuarios.Show();
            }
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = dialog = MessageBox.Show("¿Desea salir de la aplicación?", "SALIR DE ATESTA-2", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.Exit();

            }

            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

      

        private void juzgadosDeGuardiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Frm_Juzgados"] != null)
            {
                Application.OpenForms["Frm_Juzgados"].Activate();
            }
            else
            {
                Frm_Juzgados frm_Juzgados = new Frm_Juzgados();
                frm_Juzgados.MdiParent = this;
                frm_Juzgados.Show();
            }
        }

        private void ItemReg_Accidentes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Frm_Accidentes"] != null)
            {
                Application.OpenForms["Frm_Accidentes"].Activate();
            }
            else
            {
                Frm_Accidentes frm_Accidentes = new Frm_Accidentes();
                frm_Accidentes.MdiParent = this;
                frm_Accidentes.Show();
            }
        }
    }
}
