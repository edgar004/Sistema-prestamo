using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class menuMantenimiento : Form
    {
        public menuMantenimiento()
        {
            InitializeComponent();
        }


        private void AbrirFormHijo(object formhijo)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }


        private void menuMantenimiento_Load(object sender, EventArgs e)
        {
            AbrirFormHijo(new Registrar_Cliente());
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Registrar_Cliente());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Registrar_Prestamos());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu ver = new Menu();
            this.Hide();
            ver.Show();
        }

        private void menuMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
