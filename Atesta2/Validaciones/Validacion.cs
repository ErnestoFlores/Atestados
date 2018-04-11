using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atesta2.Validaciones
{
    class Validacion
    {
        public void Solo_Letras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Solo_Numeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                //else if (Char.IsSeparator(e.KeyChar))
                //{
                //    e.Handled = false;
                //}
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string  calcularJuzgado(DateTimePicker date)
        {

            string[] todosJuzgados = { "Instrucción Nº 1", "Instrucción Nº 2", "Instrucción Nº 3", "Instrucción Nº 4", "Instrucción Nº 5", "Instrucción Nº 6", "Instrucción Nº 7", "Instrucción Nº 8" };
            DateTime fechaInicial = DateTime.Parse("05/09/2016");
            DateTime fechaFinal = date.Value.Date;

            TimeSpan semanass = fechaFinal.Subtract(fechaInicial);
            int numero = semanass.Days;
            int contador = Convert.ToInt16(numero % 8);

            string resultado = "";

            switch (contador)
            {
                case 0:
                    resultado = todosJuzgados[contador].ToString();
                    break;

                case 1:
                    resultado = todosJuzgados[contador].ToString();
                    break;
                case 2:
                    resultado = todosJuzgados[contador].ToString();
                    break;
                case 3:
                    resultado = todosJuzgados[contador].ToString();
                    break;
                case 4:
                    resultado = todosJuzgados[contador].ToString();
                    break;
                case 5:
                    resultado = todosJuzgados[contador].ToString();
                    break;
                case 6:
                    resultado = todosJuzgados[contador].ToString();
                    break;
                case 7:
                    resultado = todosJuzgados[contador].ToString();
                    break;

                default:
                    break;
            }
            return resultado;


        }

    }
}
