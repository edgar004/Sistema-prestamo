using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace Utilidades
{
    public class Utilidad
    {
        public static string con = "datasource=localhost;port=3000;username=root;password=;database=sistemaprestamos";
       public static MySqlConnection db = new MySqlConnection(con);

        public static DataSet ExecuteReader(string cmd, string mensaje)
        {
          DataSet ds = new DataSet();

            try
            {
                try
                {
                    db.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("La base de datos no está encendida, por favor comunicarse con soporte.");
                    return ds;
                }
                MySqlDataAdapter DL = new MySqlDataAdapter(cmd, db);
                DL.Fill(ds);

            }
            catch (MySqlException)
            {
                MessageBox.Show(mensaje);
            }
            db.Close();
            return ds;

        }
      
        public static int ExecuteNonQuery(string cmd,string mensaje)
        {
            int resp = 0;
            MySqlCommand DL = new MySqlCommand(cmd, db);

            try
            {
                try
                {
                    db.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("La base de datos no está encendida, por favor comunicarse con soporte");
                    return resp;
                }


             
                resp = DL.ExecuteNonQuery();

            }
            catch (MySqlException)
            {
                MessageBox.Show(mensaje);
            }
            db.Close();
            return resp;

        }

        public static string FormatoDinero(long numero)
        {

           return String.Format(CultureInfo.InvariantCulture,
                                 "{0:0,0}", numero);
        }

        public static bool validarFormulario(Control forms, ErrorProvider err)
        {
            bool ConErrores = false;

            foreach (Control obj in forms.Controls)
            {

                if (obj is TxtBoxError)
                {
                    TxtBoxError obj2 = (TxtBoxError)obj;
                    if (obj2.Validar)
                    {
                        err.SetError(obj2, (string.IsNullOrEmpty(obj2.Text.Trim()) ? "Campo obligatorio" : ""));
                        if (string.IsNullOrEmpty(obj2.Text.Trim())) ConErrores = true;
                    }


                }


                if (obj.Controls.Count > 0)
                {

                    ConErrores = validarFormulario(obj, err);
                }

            }
            return ConErrores;
        }
        public static void SoloNumeros (KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;

            }else
            {
                v.Handled = true;
            }
        }
        public static void limpiarCOntroles (Control forms)
        {
            foreach(Control obj in forms.Controls)
            {
                if(obj is TextBox || obj is TxtBoxError || obj is RichTextBox)
                {
                    obj.Text = "";
                }else if(obj is DataGridView)
                {
                    DataGridView dataGrid = (DataGridView)obj;
                    dataGrid.Rows.Clear();
                }
                if(obj.Controls.Count > 0)
                {
                    limpiarCOntroles(obj);
                }

            }
        }

    }
}
