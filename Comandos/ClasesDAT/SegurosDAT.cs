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
    public class SegurosDAT
    {
        ConexionBD conex;

        public SegurosDAT()
        {
            conex = new ConexionBD();
        }

        //********************************
        // METODO PARA AGREGAR ASEGURADORAS
        //**********************************
        public void Agregar_Aseguradoras(Seguros _segur)
        {


            try
            {
                conex.conx.Open(); 

                MySqlCommand mySqlComd = new MySqlCommand("Seguros_Guardar_o_Actualizar", conex.conx);
                mySqlComd.CommandType = CommandType.StoredProcedure;

                mySqlComd.Parameters.AddWithValue("_segur_id", _segur.Id_Aseguradora);
                mySqlComd.Parameters.AddWithValue("_segur_nombre", _segur.Nombre);
                mySqlComd.Parameters.AddWithValue("_segur_domicilio", _segur.Domicilio);
                mySqlComd.Parameters.AddWithValue("_segur_telefono1", _segur.Telefono_1);
                mySqlComd.Parameters.AddWithValue("_segur_telefono2", _segur.Telefono_2);
                mySqlComd.Parameters.AddWithValue("_segur_fax", _segur.Fax);
                mySqlComd.Parameters.AddWithValue("_segur_email", _segur.Email);
                mySqlComd.Parameters.AddWithValue("_segur_notas", _segur.Notas);

                mySqlComd.ExecuteNonQuery();

            }
            catch (MySqlException)
            {

                throw;
            }

            conex.conx.Close();
        }

        //******************************************
        // METODO MOSTRAR DATOS DENTRO DEL DATAGRID
        //******************************************
        public void MostrarDatosGrid( DataGridView data)
        {

            try
            {
                conex.conx.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("Seguros_Ver_Registros", conex.conx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();

                da.Fill(dt);

                data.DataSource = dt;

                data.Columns[1].HeaderText = "NOMBRE";
                data.Columns[2].HeaderText = "DOMICILIO";
                data.Columns[3].HeaderText = "TELEFONO 1";
                data.Columns[4].HeaderText = "TELEFONO 2";
                data.Columns[5].HeaderText = "FAX";
                data.Columns[6].HeaderText = "EMAIL";
                data.Columns[7].HeaderText = "NOTAS";
                data.Columns[0].Visible = false;
            }
            catch (MySqlException)
            {

                throw;
            }

            conex.conx.Close();
        }

        //*******************************************************
        // METODO BUSCAR ASEGURADORA A TRAVES DEL CAMPO DE TEXTO
        //*******************************************************
        public void Buscar_Aseguradora(DataGridView data, string palabra)
        {

            try
            {
                conex.conx.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("Seguros_Buscar", conex.conx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_BuscarValor", palabra);
                DataTable dt = new DataTable();

                da.Fill(dt);
                data.DataSource = dt;
                data.Columns[0].Visible = false;

                
            }
            catch (MySqlException)
            {

                throw;
            }

            conex.conx.Close();


        }

        //*******************************************************
        // METODO ELIMINAR ASEGURADORA A TRAVES DEL ID
        //*******************************************************
        public void Eliminar_Seguro(int segur_Id)
        {

            try
            {
                conex.conx.Open();
                MySqlCommand mySqlComd = new MySqlCommand("Seguros_BorrarPor_Id", conex.conx);
                mySqlComd.CommandType = CommandType.StoredProcedure;
                mySqlComd.Parameters.AddWithValue("_segur_id", segur_Id);
                mySqlComd.ExecuteNonQuery();


            }
            catch (MySqlException)
            {

                throw;
            }

            conex.conx.Close();

        }


    }
}
