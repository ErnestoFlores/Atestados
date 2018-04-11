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
    public partial class Frm_Juzgados : Form
    {
        public Frm_Juzgados()
        {
            InitializeComponent();
        }

        private void dtp_Juzgados_ValueChanged(object sender, EventArgs e)
        {
            Validaciones.Validacion dato = new Validaciones.Validacion();
            lbl_Juzgado.Text = dato.calcularJuzgado(dtp_Juzgados);
        }


    }
}
