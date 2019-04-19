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
    public partial class menuConsulta : Form
    {
        public menuConsulta()
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

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormHijo(new Consultas_Clientes());
        }

        private void menuConsulta_Load(object sender, EventArgs e)
        {
            AbrirFormHijo(new Consultas_Clientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Consultar_Prestamos());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu ver = new Menu();
            this.Hide();
            ver.Show();
        }

        private void menuConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
