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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void FechHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuMantenimiento Pantalla_Mantenimiento = new menuMantenimiento();
            Pantalla_Mantenimiento.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Consultas_Clientes Pantalla_Cliente = new Consultas_Clientes();
            Pantalla_Cliente.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Consultar_Prestamos Pantalla_Prestamo = new Consultar_Prestamos();
            Pantalla_Prestamo.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Consultar_Prestamos Pantalla_Prestamo = new Consultar_Prestamos();
            Pantalla_Prestamo.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Consultas_Clientes Pantalla_Cliente = new Consultas_Clientes();
            Pantalla_Cliente.Show();
            this.Hide();
        }
    }
}
