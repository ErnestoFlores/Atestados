using Comandos.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandos.ClasesDAT
{
    public class UsuariosDAT
    {
        ConexionBD Conect;

        public UsuariosDAT()
        {
            Conect = new ConexionBD();
        }

        //***********************************************
        // VALIDAR USUARIO 
        //***********************************************
        public bool Validar_Entrada_Usuario(Usuarios _usu)
        {
            
           
            try
            {
                Conect.conx.Open();

                MySqlCommand cmd = new MySqlCommand("Usuarios_Acceso_Sistema", Conect.conx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_numero", _usu.Numero);
                cmd.Parameters.AddWithValue("@_passwor", _usu.Passwor);
                cmd.Parameters.AddWithValue("@_tipo", _usu.Tipo);

                MySqlDataReader myReader;
                myReader = cmd.ExecuteReader();

                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    Conect.conx.Close();
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);
                Conect.conx.Close();
                return false;

            }
            

        }


        //***********************************************
        // Método para agregar un usuario con parámetros
        //***********************************************
        public void AgregarUsuario(Usuarios _usu)
        {

            Conect.conx.Open();
            

            try
            {
                MySqlCommand cmd = new MySqlCommand("Usuarios_Guardar_o_Actualizar", Conect.conx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_id_Usu", _usu.Id_Usuario);
                cmd.Parameters.AddWithValue("@_nombre", _usu.Nombre);
                cmd.Parameters.AddWithValue("@_numero", _usu.Numero);
                cmd.Parameters.AddWithValue("@_contrasena", _usu.Passwor);
                cmd.Parameters.AddWithValue("@_tipo", _usu.Tipo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Se agregó correctamente");
                
                Conect.conx.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);
                
                Conect.conx.Close();
            }

        }



        //******************************************
        // METODO MOSTRAR DATOS DENTRO DEL DATAGRID
        //******************************************
        public void MostrarDatosGrid(DataGridView data)
        {
            Conect.conx.Open();
            try
            {
                

                MySqlDataAdapter da = new MySqlDataAdapter("Usuarios_Ver_Registros", Conect.conx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();

                da.Fill(dt);

                data.DataSource = dt;

                data.Columns[1].HeaderText = "NOMBRE";
                data.Columns[2].HeaderText = "NÚMERO";
                data.Columns[3].HeaderText = "CONTRASEÑA";
                data.Columns[4].HeaderText = "TIPO";
                
                data.Columns[0].Visible = false;
            }
            catch (MySqlException)
            {

                throw;
            }

            Conect.conx.Close();
        }


        //*******************************************************
        // METODO ELIMINAR ASEGURADORA A TRAVES DEL ID
        //*******************************************************
        public void Eliminar_Seguro(int usu_Id)
        {
            Conect.conx.Open();
            try
            {
                
                MySqlCommand mySqlComd = new MySqlCommand("Usuario_BorrarPor_Id", Conect.conx);
                mySqlComd.CommandType = CommandType.StoredProcedure;
                mySqlComd.Parameters.AddWithValue("_Id_Usu", usu_Id);
                mySqlComd.ExecuteNonQuery();


            }
            catch (MySqlException)
            {

                throw;
            }

            Conect.conx.Close();

        }
    }
}
