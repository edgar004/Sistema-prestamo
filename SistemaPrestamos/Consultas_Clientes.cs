using MySql.Data.MySqlClient;
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
    public partial class Consultas_Clientes : Form
    {
       public bool cerrarVentana = true;
        public Consultas_Clientes()
        {
            InitializeComponent();

            dataGridViewCliente.AutoGenerateColumns = false;
            codigo.DataPropertyName = "id_cliente";
            nombre.DataPropertyName = "nombre_cliente";
            telefono.DataPropertyName = "telefono_cliente";
            cedula.DataPropertyName = "cedula_cliente";
            direccion.DataPropertyName = "direccion_cliente";
            referente.DataPropertyName = "nombre_referente";
            deuda.DataPropertyName = "deuda";
            llenarDataGrid("no");


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consultas_Clientes_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void llenarDataGrid(string condicion)
        {
            string cmd = "SELECT clientes.*,referentes.nombre_referente, FORMAT (sum(prestamos.total_prestamo - prestamos.abonos_prestamo ), 'd', 'en-US' ) as deuda, referentes.nombre_referente from clientes LEFT JOIN prestamos on prestamos.id_cliente=clientes.id_cliente LEFT JOIN referentes on referentes.id_cliente=clientes.id_cliente WHERE clientes.estado_cliente = 1 GROUP BY clientes.id_cliente";
            if (condicion != "no")
            {
                cmd += condicion;
            }
            DataSet DS = new DataSet();
           DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al traer los clientes, por favor intente de nuevo.");
            if (DS.Tables.Count > 0)
            {
                dataGridViewCliente.DataSource = DS.Tables[0];

            }



        }

        public void abrirVentana (String ventana)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Registrar_Cliente))
                {
                    frm.Close();
                    break;
                }
            }

            Registrar_Cliente Pantalla_registrarCliemte = new Registrar_Cliente();
            Pantalla_registrarCliemte.accionLabel.Text = ventana;
            int codigo = 0;
            DataSet DS = new DataSet();
            if (ventana== "Modificar Cliente" || ventana== "Consultar Cliente")
            {
             codigo = Convert.ToInt16(dataGridViewCliente.Rows[dataGridViewCliente.CurrentCell.RowIndex].Cells[0].Value.ToString());
             Pantalla_registrarCliemte.button2.Visible = false;

            }
            cerrarVentana = false;
            this.Hide();
            Pantalla_registrarCliemte.txt_id_cliente.Text = codigo.ToString();
            Pantalla_registrarCliemte.Show();

        }

      
        private void button2_Click(object sender, EventArgs e)
        {

            abrirVentana("Registrar Cliente");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe selecionar un cliente");
                return;
            }
            abrirVentana("Modificar Cliente");



        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDataGrid("no");
            textBox1.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu ver = new Menu();
            this.Hide();
            ver.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("¿Seguro que quieres eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;

                if (dataGridViewCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe selecionar un cliente");
                return;
            }

            string codigo = dataGridViewCliente.Rows[dataGridViewCliente.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string cmd = string.Format("select * from prestamos where id_cliente= {0} and estado_prestamo = 'Pendiente'",codigo);
            DataSet DS = new  DataSet();
            DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al eliminar el cliente.");
            if (DS.Tables.Count == 0) return;
            if (DS.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("El cliente tiene un préstamo pendiente, no se podra eliminar hasta que se concluya.");
                return;
            }

            cmd = string.Format("update clientes set estado_cliente={0} where id_cliente= {1}", 0,codigo);
            Utilidades.Utilidad.ExecuteNonQuery(cmd,"Error al eliminar el cliente, por favor intente de nuevo.");
            llenarDataGrid("no");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "")
            {
                llenarDataGrid("no");
                return;
            }
            string condicion = " and ";
            if (comboBox1.SelectedIndex == 0)
            {
                condicion+= "nombre_cliente";
            }else if (comboBox1.SelectedIndex == 1)
            {
                condicion+= "cedula_cliente";
            }else
            {
                condicion+= "clientes.id_cliente";
            }
            condicion += string.Format(" like '%{0}%'",textBox1.Text);
            llenarDataGrid(condicion);
        }

        private void Consultas_Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
           if(cerrarVentana) System.Environment.Exit(-1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.Rows.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
