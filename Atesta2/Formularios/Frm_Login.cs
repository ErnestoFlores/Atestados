using Comandos.Clases;
using Comandos.ClasesDAT;
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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txt_TipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //*********************
        //VALIDAMOS EL USUARIO
        //*********************
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            // Validamos el campo de usuario
            if (txt_Usuario.Text == "")
            {
                errorProvider.SetError(txt_Usuario, "Ingrese Nº de Agente");
                txt_Usuario.Focus();
                return;
            }
            errorProvider.SetError(txt_Usuario, "");
            errorProvider.Clear();

            // Validamos el campo contraseña
            if (txt_Contrasena.Text == "")
            {
                errorProvider.SetError(txt_Contrasena, "Ingrese contraseña");
                txt_Contrasena.Focus();
                return;
            }
            errorProvider.SetError(txt_Contrasena, "");
            errorProvider.Clear();

            if (txt_TipoUsuario.Text == "")
            {
                errorProvider.SetError(txt_TipoUsuario, "Ingrese un tipo de permiso");
                txt_TipoUsuario.Focus();
                return;
            }
            errorProvider.SetError(txt_TipoUsuario, "");
            errorProvider.Clear();

            UsuariosDAT _usuDAT = new UsuariosDAT();
            Usuarios _usu = new Usuarios(numero: txt_Usuario.Text.Trim(), passwor: txt_Contrasena.Text.Trim(), tipo: txt_TipoUsuario.Text.Trim());

            if (!_usuDAT.Validar_Entrada_Usuario(_usu))
            {
                MessageBox.Show("No valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Text = "";
                txt_Contrasena.Text = "";
                txt_TipoUsuario.SelectedIndex = -1;
                txt_Usuario.Focus();
                return;
            }

            // VALIDAMOS SI EL OPERADOR ES USUARIO O ADMINISTRADOR
            if (txt_TipoUsuario.Text == "Administrador")
            {
                Frm_Principal frm = new Frm_Principal();
                frm.Item_Administrador.Enabled = true;
                frm.tool_Num_Agente.Text = txt_Usuario.Text + "   ";
                frm.Show();
                this.Hide();
            }
            else
            {
                Frm_Principal frm = new Frm_Principal();
                frm.Item_Administrador.Enabled = false;
                frm.tool_Num_Agente.Text = txt_Usuario.Text + "   ";
                frm.Show();
                this.Hide();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
