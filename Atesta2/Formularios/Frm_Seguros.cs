using System;
using Comandos.Clases;
using Comandos.ClasesDAT;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atesta2.Validaciones;

namespace Atesta2
{
    public partial class Frm_Seguros : Form
    {
        int segur_Id = 0;
        

        SegurosDAT _obj_segDAT = new SegurosDAT();
        Validacion valida = new Validacion();

        public Frm_Seguros()
        {
            
            InitializeComponent();
            _obj_segDAT.MostrarDatosGrid(dgv);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            

            // Validamos el campo de usuario
            if (txt_NombreAseguradora.Text == "")
            {
                errorProvider.SetError(txt_NombreAseguradora, "Ingrese nombre de la compañia");
                txt_NombreAseguradora.Focus();
                return;
            }
            errorProvider.SetError(txt_NombreAseguradora, "");
            errorProvider.Clear();

            if (txt_Email.Text.Trim() == "")
            {
                goto Found;
            }
            


            if ( valida.ComprobarFormatoEmail(txt_Email.Text) == false)
            {
                errorProvider.SetError(txt_Email, "Dirección no valida");
                txt_Email.Focus();
                return;
            
            }
            errorProvider.SetError(txt_Email, "");
            errorProvider.Clear();


            Found:

            Seguros _seguros = new Seguros(segur_Id, txt_NombreAseguradora.Text, txt_Domicilio.Text, txt_Telefono1.Text,
                                           txt_Telefono2.Text, txt_Fax.Text, txt_Email.Text, txt_Notas.Text);

            SegurosDAT _segurosDAT = new SegurosDAT();
            _segurosDAT.Agregar_Aseguradoras(_seguros);

            MessageBox.Show("Ingresado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            LimpiarCampos();
            _obj_segDAT.MostrarDatosGrid(dgv);


            errorProvider.SetError(txt_NombreAseguradora, "");
            errorProvider.SetError(txt_Email, "");
            errorProvider.Clear();

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            _obj_segDAT.Buscar_Aseguradora(dgv, txt_Buscar.Text);
        }


        // METODO LIMPIAR CAMPOS

        private void LimpiarCampos()
        {
            txt_NombreAseguradora.Text = txt_Domicilio.Text = txt_Telefono1.Text = txt_Telefono2.Text = txt_Fax.Text = txt_Notas.Text = txt_Buscar.Text = txt_Email.Text = "";
            segur_Id = 0;
            btn_Guardar.Text = "Guardar";
            btn_Eliminar.Enabled = false;
        }



        // ELIMINAR REGISTRO 
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este registro?", "¿ELIMINAR REGISTRO?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _obj_segDAT.Eliminar_Seguro(segur_Id);
                LimpiarCampos();
                _obj_segDAT.MostrarDatosGrid(dgv);
            }
            else
            {
                return;
            }


            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            _obj_segDAT.MostrarDatosGrid(dgv);
        }

        // RECUPERAMOS LOS DATOS DE GRID HACIA LOS TEXTBOX
        private void dgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow.Index != -1)
            {
                txt_NombreAseguradora.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txt_Domicilio.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txt_Telefono1.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                txt_Telefono2.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                txt_Fax.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                txt_Email.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                txt_Notas.Text = dgv.CurrentRow.Cells[7].Value.ToString();
                segur_Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());

                btn_Guardar.Text = "Actualizar";
                btn_Eliminar.Enabled = Enabled;
            }
        }

        private void txt_Telefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.Solo_Numeros(e);
        }

    
    }
}
