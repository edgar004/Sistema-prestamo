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
    public partial class Registrar_Prestamos : Form
    {
        public Registrar_Prestamos()
        {
            InitializeComponent();
            calendario.Text = DateTime.Now.ToString();
            fechaActual.Text = DateTime.Now.ToString();
           
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrar_Prestamos_Load(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu ver = new Menu();
            this.Hide();
            ver.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarClieteCedula();
        }

        public void buscarClieteCedula()
        {
            if (buscador.Text == "")
            {
                return;
            }
            DataSet DS = new DataSet();
            string cmd = string.Format("select * from clientes left join referentes on clientes.id_cliente = referentes.id_cliente where cedula_cliente='{0}'", buscador.Text);
            DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al buscar el cliente, por favor intente de nuevo.");
            if (DS.Tables.Count > 0)
            {
                if (DS.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No existe un cliente con dicha cédula");
                    return;

                }
                txt_codigo_cliente.Text = DS.Tables[0].Rows[0]["id_cliente"].ToString();
                txt_nombre_cliente.Text = DS.Tables[0].Rows[0]["nombre_cliente"].ToString();
                txt_telefono_cliente.Text = DS.Tables[0].Rows[0]["telefono_cliente"].ToString();
                txt_cedula_cliente.Text = DS.Tables[0].Rows[0]["cedula_cliente"].ToString();
                txt_direccion_cliente.Text = DS.Tables[0].Rows[0]["direccion_cliente"].ToString();

                //Datos del referente
                txt_nombre_referido.Text = DS.Tables[0].Rows[0]["nombre_referente"].ToString();
                txt_telefono_referido.Text = DS.Tables[0].Rows[0]["telefono_referente"].ToString();
                txt_cedula_referido.Text = DS.Tables[0].Rows[0]["cedula_referente"].ToString();
                txt_direccion_referido.Text = DS.Tables[0].Rows[0]["direccion_referente"].ToString();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboPlazo, (comboPlazo.SelectedIndex == -1 ? "Campo obligatorio" : ""));
            if (Utilidades.Utilidad.validarFormulario(this, errorProvider1) == true)
            {
                buttonRegistraPrestamo.Enabled = false;
                return;
            }

            if (comboPlazo.SelectedIndex == -1)
            {
                buttonRegistraPrestamo.Enabled = false;

                return;
            }

            if (txt_monto_prestamo.Text.Replace(" ", "").Trim().Length > 9)
            {
                MessageBox.Show("El monto préstamo no puede superar una cantidad mayor a 9 digitos. ");
                return;

            }

            if (txt_interes_prestamo.Text.Replace(" ", "").Trim().Length > 4)
            {
                MessageBox.Show("El interes préstamo no puede ser una cantidad mayor a 100. ");
                return;

            }

            if (txt_cuota_prestamo.Text.Replace(" ", "").Trim().Length > 9)
            {
                MessageBox.Show("La cantidad cuota préstamo no puede superar una cantidad mayor a 9 digitos. ");
                return;

            }

            if (txt_mora_prestamo.Text.Replace(" ", "").Trim().Length > 4)
            {
                MessageBox.Show("La mora préstamo no puede ser una cantidad mayor a 100. ");
                return;

            }






            if (Convert.ToInt32(txt_monto_prestamo.Text.Replace(" ", "").Trim()) == 0)
            {
                MessageBox.Show("El monto préstamo debe ser mayor que cero.");
                return;
            }

            if (Convert.ToInt32(txt_cuota_prestamo.Text.Replace(" ", "").Trim()) == 0)
            {
                MessageBox.Show("La cantidad de cuota debe ser mayor que cero.");
                return;
            }
            dataGridView.DataSource = null;
            buttonRegistraPrestamo.Enabled = true;
            dataGridView.Rows.Clear();

                int cuota = Convert.ToInt32(txt_cuota_prestamo.Text.Replace(" ", "").Trim());
                int monto = Convert.ToInt32(txt_monto_prestamo.Text.Replace(" ", "").Trim());
                int totalInteres = Convert.ToInt32((Convert.ToDouble(txt_interes_prestamo.Text.Replace(" ", "").Trim()) /100) * monto * cuota);
                int interes =Convert.ToInt32( (Convert.ToDouble(txt_interes_prestamo.Text.Replace(" ", "").Trim()) / 100) * monto);
                int totalPrestamo = monto + totalInteres;
                txt_total_prestamo.Text = totalPrestamo.ToString();
                txt_interesTotal_prestamo.Text = totalInteres.ToString();
                int montoCuota = totalPrestamo / cuota;
                txt_cuotasPagar_prestamo.Text = montoCuota.ToString();
               int mora = Convert.ToInt32 ( ( Convert.ToDouble(txt_mora_prestamo.Text.Replace(" ", "").Trim()) / 100) * montoCuota);
               DateTime fecha = Convert.ToDateTime(calendario.Text, new CultureInfo("es-ES"));
               for (int i = 1; i <= cuota; i++) {
                    if (comboPlazo.SelectedIndex == 0)
                    {
                        fecha = fecha.AddDays(1);

                    }
                    else if (comboPlazo.SelectedIndex == 1)
                    {
                        fecha = fecha.AddDays(7);

                    }
                    else if (comboPlazo.SelectedIndex == 2)
                    {
                        fecha = fecha.AddDays(15);

                    }
                    else if (comboPlazo.SelectedIndex == 3)
                    {
                        fecha = fecha.AddMonths(1);
                    }else
                    {
                        fecha = fecha.AddYears(1);
                    }
                dataGridView.Rows.Add(i, fecha.ToString("d/M/yyyy"), montoCuota, 0, interes, mora, montoCuota, "Pendiente");

            }
          

            dataGridView.ClearSelection();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Utilidades.Utilidad.limpiarCOntroles(this);
        }

        private void buscador_Enter(object sender, EventArgs e)
        {

        }

        private void buscador_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consultas_Clientes obj = new Consultas_Clientes();
            obj.button4.Visible = true;
            obj.button2.Visible = false;
            obj.button6.Visible = false;
            obj.button3.Visible = false;
            obj.cerrarVentana = false;
            if (obj.ShowDialog() == DialogResult.OK)
            {
                buscador.Text = obj.dataGridViewCliente.Rows[obj.dataGridViewCliente.CurrentCell.RowIndex].Cells[3].Value.ToString();
                buscarClieteCedula();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboPlazo, (comboPlazo.SelectedIndex == -1 ? "Campo obligatorio" : ""));
            if (Utilidades.Utilidad.validarFormulario(this, errorProvider1) == true)
            {
                buttonRegistraPrestamo.Enabled = false;
                return;
            }

            if (comboPlazo.SelectedIndex == -1)
            {
                buttonRegistraPrestamo.Enabled = false;

                return;
            }
            buttonRegistraPrestamo.Enabled = true;
            string codigoPrestamo = "";
            try
            {

                if (dataGridView.Rows.Count > 0)
                {
                    // Crear prestamo.
                    DateTime fecha_inicio = Convert.ToDateTime(calendario.Text, new CultureInfo("es-ES"));
                    DateTime fecha_actual = Convert.ToDateTime(fechaActual.Text, new CultureInfo("es-ES"));

                    string cmd = string.Format("insert into prestamos (id_cliente,monto_prestamo,interes_prestamo,cuotas_prestamo,mora_prestamo,plazo_prestamo,total_prestamo,total_interes_prestamo,monto_cuota_prestamo,fecha_prestamo,fecha_inicio_prestamo) values ({0},{1},{2},{3},{4},'{5}',{6},{7},{8},'{9}','{10}')", txt_codigo_cliente.Text, txt_monto_prestamo.Text.Replace(" ", "").Trim(), txt_interes_prestamo.Text.Replace(" ", "").Trim(), txt_cuota_prestamo.Text.Replace(" ", "").Trim(), txt_mora_prestamo.Text.Replace(" ", "").Trim(), comboPlazo.SelectedItem, txt_total_prestamo.Text.Replace(" ", "").Trim(), txt_interesTotal_prestamo.Text.Replace(" ", "").Trim(), txt_cuotasPagar_prestamo.Text.Replace(" ", "").Trim(), fecha_actual.ToString("yyyy-MM-dd"), fecha_inicio.ToString("yyyy-MM-dd"));

                    int filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd, "Error al crear el préstamo, intento de nuevo.");
                    if (filasAfectadas == 0)
                    {
                        return;
                    }
                    DataSet DS = new DataSet();
                    cmd = "select id_prestamo from prestamos ORDER BY id_prestamo desc limit 1";
                    DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al crear las cuotas.");
                    if(DS.Tables.Count == 0)
                    {
                        return;
                    }
                     codigoPrestamo = DS.Tables[0].Rows[0]["id_prestamo"].ToString();
                    int monto = Convert.ToInt32(txt_monto_prestamo.Text.Replace(" ", "").Trim());
                    double interes = (Convert.ToDouble(txt_interes_prestamo.Text.Replace(" ", "").Trim()) / 100) * monto;
                    foreach (DataGridViewRow prestamo in dataGridView.Rows)
                    {
                        DateTime fecha_pago = Convert.ToDateTime(prestamo.Cells[1].Value.ToString(), new CultureInfo("es-ES"));
                        cmd = string.Format("insert into detalles_prestamos (id_prestamo,numero_cuota,fecha_cuota,monto_cuota,abonos_cuota,mora_cuota,deuda_cuota,interes_cuota) values({0},{1},'{2}',{3},{4},{5},{6},{7})", codigoPrestamo, prestamo.Cells[0].Value, fecha_pago.ToString("yyyy-MM-dd"), prestamo.Cells[2].Value, prestamo.Cells[3].Value, 0, prestamo.Cells[6].Value, interes);

                        filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd, "Error al crear el préstamo, intento de nuevo.");
                        // Si un detalle falla en la creacion, borrar el prestamo con todos sus detalles.

                        if (filasAfectadas == 0)
                        {
                            cmd = "delete from prestamos where id_prestamo = " + codigoPrestamo;
                            Utilidades.Utilidad.ExecuteNonQuery(cmd,"Error por favor salir de la aplicación e informe a soporte.");
                            cmd = "delete from detalles_prestamos where id_prestamo = " + codigoPrestamo;
                            Utilidades.Utilidad.ExecuteNonQuery(cmd, "Error por favor salir de la aplicación e informe a soporte.");

                            return;
                        }


                    }
                    MessageBox.Show("El préstamo se ha realizado correctamente");
                    Utilidades.Utilidad.limpiarCOntroles(this);
                    comboPlazo.SelectedIndex = -1;
                    buttonRegistraPrestamo.Enabled = false;

                }

            }
            catch (Exception )
            {
                MessageBox.Show("Error al crear el préstamo, intento de nuevo.");
                if (codigoPrestamo != "")
                {

                string  cmd = "delete from prestamos where id_prestamo = " + codigoPrestamo;
                Utilidades.Utilidad.ExecuteNonQuery(cmd, "Error al crear el préstamo, intento de nuevo.");  
                cmd = "delete from detalles_prestamos where id_prestamo = " + codigoPrestamo;
                Utilidades.Utilidad.ExecuteNonQuery(cmd, "Error al crear el préstamo, intento de nuevo.");
                }

                return;
            }
            

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_monto_prestamo_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txt_monto_prestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidad.SoloNumeros(e);

        }

        private void txt_interes_prestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidad.SoloNumeros(e);

        }

        private void txt_cuota_prestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidad.SoloNumeros(e);

        }

        private void txt_mora_prestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mora_prestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidad.SoloNumeros(e);

        }

        private void fechaActual_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_Prestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
