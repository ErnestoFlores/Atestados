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

namespace Atesta2.Formularios
{
    public partial class Frm_Usuarios : Form
    {
        int usuario_Id = 0;
        UsuariosDAT obj_usuDAT = new UsuariosDAT();


        public Frm_Usuarios()
        {
            InitializeComponent();
            obj_usuDAT.MostrarDatosGrid(dgv);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                errorProvider.SetError(txt_Nombre, "Ingrese nombre del agente");
                txt_Nombre.Focus();
                return;
            }
            errorProvider.SetError(txt_Nombre, "");
            errorProvider.Clear();

            if (txt_Numero.Text == "")
            {
                errorProvider.SetError(txt_Numero, "Ingrese numero del agente");
                txt_Numero.Focus();
                return;
            }
            errorProvider.SetError(txt_Numero, "");
            errorProvider.Clear();


            if (txt_Contrasena.Text == "")
            {
                errorProvider.SetError(txt_Contrasena, "Ingrese contraseña");
                txt_Contrasena.Focus();
                return;
            }
            errorProvider.SetError(txt_Contrasena, "");
            errorProvider.Clear();



            if (txt_cmb_Tipo.Text == "")
            {
                errorProvider.SetError(txt_cmb_Tipo, "Ingrese tipo de Usuario");
                txt_cmb_Tipo.Focus();
                return;
            }
            errorProvider.SetError(txt_cmb_Tipo, "");
            errorProvider.Clear();

            Usuarios _usua = new Usuarios(usuario_Id, txt_Nombre.Text, txt_Numero.Text, txt_Contrasena.Text, txt_cmb_Tipo.Text);
            UsuariosDAT _usuDAT = new UsuariosDAT();

            _usuDAT.AgregarUsuario(_usua);

            LimpiarCampos();
            obj_usuDAT.MostrarDatosGrid(dgv);
            txt_cmb_Tipo.SelectedIndex = -1;

        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            txt_cmb_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // METODO LIMPIAR CAMPOS

        private void LimpiarCampos()
        {
            txt_Nombre.Text = txt_Numero.Text = txt_Contrasena.Text  = "";
            usuario_Id = 0;
            btn_Guardar.Text = "Guardar";
            btn_Eliminar.Enabled = false;
            txt_cmb_Tipo.SelectedIndex = -1;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este registro?", "¿ELIMINAR REGISTRO?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                obj_usuDAT.Eliminar_Seguro(usuario_Id);
                LimpiarCampos();
                obj_usuDAT.MostrarDatosGrid(dgv);
            }
            else
            {
                return;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            obj_usuDAT.MostrarDatosGrid(dgv);
        }


        // RECUPERAMOS LOS DATOS DE GRID HACIA LOS TEXTBOX
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow.Index != -1)
            {
                txt_Nombre.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txt_Numero.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txt_Contrasena.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                txt_cmb_Tipo.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                usuario_Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());

                btn_Guardar.Text = "Actualizar";
                btn_Eliminar.Enabled = Enabled;
            }
        }
    }
}
