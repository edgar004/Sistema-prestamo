
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           

        }



        private void Hora_Tick(object sender, EventArgs e)
        {

            labelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(nick, (nick.Text.Replace(" ","").Trim() =="" ? "Campo obligatorio" : ""));
            errorProvider1.SetError(clave, (clave.Text.Replace(" ", "").Trim() == "" ? "Campo obligatorio" : ""));
            if (clave.Text.Replace(" ", "").Trim() == "" || nick.Text.Replace(" ", "").Trim() == "") return;
            string cmd = string.Format("select * from usuario where nick_usuario = '{0}' and clave_usuario = '{1}' ", nick.Text.Replace(" ", "").Trim(), clave.Text.Replace(" ", "").Trim());
            DataSet DS = new DataSet();
            DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al verificar el usuario, por favor intente de nuevo.");
            if(DS.Tables.Count > 0)
            {
                if (DS.Tables[0].Rows.Count > 0)
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Nick y/o contraseña incorrecta.");
                }
               
            }
            

            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
