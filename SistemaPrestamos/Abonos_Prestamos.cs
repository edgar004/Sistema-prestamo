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
    public partial class Abonos_Prestamos : Form
    {
        bool cambioCombox = false;
        public Abonos_Prestamos()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            NumCuotas.DataPropertyName = "numero_cuota";
            Fecha.DataPropertyName = "fecha_cuota";
            MontoCuotas.DataPropertyName = "monto_cuota";
            Abonos.DataPropertyName = "abonos_cuota";
            interes.DataPropertyName = "interes_cuota";
            Moras.DataPropertyName = "mora_cuota";
            Deuda.DataPropertyName = "deuda_cuota";
            Estado.DataPropertyName = "estado_cuota";



        }

        public void llenarDataGrid()
        {
           
            string cmd = "Select * from detalles_prestamos where id_prestamo = " + txt_codigo_prestamo.Text;
         
            DataSet DS = new DataSet();
            DS = Utilidades.Utilidad.ExecuteReader(cmd, "Error al traer los datos del préstamo, por favor intente de nuevo.");
            if (DS.Tables.Count > 0)
            {
                dataGridView.DataSource = null;
                dataGridView.DataSource = DS.Tables[0];

            }



        }

        private void Abonos_Prestamos_Resize(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Abonos_Prestamos_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            string cmd = string.Format("select * from clientes left join referentes on clientes.id_cliente = referentes.id_cliente inner join prestamos on prestamos.id_cliente = clientes.id_cliente where prestamos.id_prestamo={0}", txt_codigo_prestamo.Text);
            DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al traer los datos del préstamo, por favor intente de nuevo.");
            //Datos clientes
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                txt_nombre_cliente.Text = DS.Tables[0].Rows[0]["nombre_cliente"].ToString();
                txt_telefono_cliente.Text = DS.Tables[0].Rows[0]["telefono_cliente"].ToString();
                txt_cedula_cliente.Text = DS.Tables[0].Rows[0]["cedula_cliente"].ToString();
                txt_direccion_cliente.Text = DS.Tables[0].Rows[0]["direccion_cliente"].ToString();

                //Datos del referente
                txt_nombre_referido.Text = DS.Tables[0].Rows[0]["nombre_referente"].ToString();
                txt_telefono_referido.Text = DS.Tables[0].Rows[0]["telefono_referente"].ToString();
                txt_cedula_referido.Text = DS.Tables[0].Rows[0]["cedula_referente"].ToString();
                txt_direccion_referido.Text = DS.Tables[0].Rows[0]["direccion_referente"].ToString();

                //Datos del préstamo
                txt_monto_prestamo.Text = DS.Tables[0].Rows[0]["monto_prestamo"].ToString();
                txt_monto_prestamo.Text = Utilidades.Utilidad.FormatoDinero(long.Parse(txt_monto_prestamo.Text));
                txt_interes_prestamo.Text = DS.Tables[0].Rows[0]["interes_prestamo"].ToString();
                txt_interes_prestamo.Text = Utilidades.Utilidad.FormatoDinero(long.Parse(txt_interes_prestamo.Text));
                txt_cuota_prestamo.Text = DS.Tables[0].Rows[0]["cuotas_prestamo"].ToString();
                txt_cuota_prestamo.Text = Utilidades.Utilidad.FormatoDinero(long.Parse(txt_cuota_prestamo.Text));
                txt_mora_prestamo.Text = DS.Tables[0].Rows[0]["mora_prestamo"].ToString();
                txt_mora_prestamo.Text = Utilidades.Utilidad.FormatoDinero(long.Parse(txt_mora_prestamo.Text));
                txt_plazo_prestamo.Text = DS.Tables[0].Rows[0]["plazo_prestamo"].ToString();
                DateTime fecha = DateTime.Parse(DS.Tables[0].Rows[0]["fecha_inicio_prestamo"].ToString());
                calendario.Value = fecha;
                txt_total_prestamo.Text = DS.Tables[0].Rows[0]["total_prestamo"].ToString();
                txt_total_prestamo.Text = Utilidades.Utilidad.FormatoDinero(long.Parse(txt_total_prestamo.Text));
                txt_interesTotal_prestamo.Text = DS.Tables[0].Rows[0]["total_interes_prestamo"].ToString();
                txt_interesTotal_prestamo.Text = Utilidades.Utilidad.FormatoDinero(long.Parse(txt_interesTotal_prestamo.Text));
                txt_cuotasPagar_prestamo.Text = DS.Tables[0].Rows[0]["monto_cuota_prestamo"].ToString();
                txt_cuotasPagar_prestamo.Text = Utilidades.Utilidad.FormatoDinero(long.Parse(txt_cuotasPagar_prestamo.Text));
                fechaPrestamo.Text = DS.Tables[0].Rows[0]["fecha_prestamo"].ToString();
                comboBox1.DisplayMember = "numero_cuota";
                comboBox1.ValueMember = "numero_cuota";
                llenarCombox();

                llenarDataGrid();


            }

        }

        public void llenarCombox() {
            DataSet DS = new DataSet();
           string cmd = string.Format("select numero_cuota from detalles_prestamos where id_prestamo ={0} and deuda_cuota > {1} ", txt_codigo_prestamo.Text, 0);
            DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al traer las cuotas pendientes, salga de la ventana e intente de nuevo.");
            if (DS.Tables.Count > 0)
            {
                if(DS.Tables[0].Rows.Count > 0)
                {
                    comboBox1.DataSource = DS.Tables[0];
                    cambioCombox = true;
                    comboBox1.SelectedIndex = -1;
                }else
                {
                    comboBox1.DataSource = null;
                    buttonPagar.Enabled = false;
                    cmd = string.Format("update prestamos set estado_prestamo='{0}' where (monto_prestamo-abonos_prestamo) <=0 ", "Pagado");
                    Utilidades.Utilidad.ExecuteNonQuery(cmd, "Error al traer el préstamo, por favor intente de nuevo");

                }
               
            }


        }


        private void radioButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
        }

        private void txt_cedula_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_referido_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_direccion_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu ver = new Menu();
            this.Hide();
            ver.Show();
        }

        private void Abonos_Prestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(-1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

            
           


        }
     
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cambioCombox)
            {
                calculoCombox();

            }
        }


        public void calculoCombox()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                txt_montoPagar.Text = "0";
                return;
            }
            int total = 0;
            for (int i =0; i <= Convert.ToInt16(comboBox1.SelectedValue) - 1; i++)
            {
                total += Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value.ToString());

            }
            txt_montoPagar.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox1, (comboBox1.SelectedIndex == -1 ? "Campo obligatorio" : ""));
            if (Utilidades.Utilidad.validarFormulario(this, errorProvider1) == true)
            {
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {

                return;
            }
            if(txt_abono.Text.Replace(" ", "").Trim().Length > 9)
            {
                MessageBox.Show("Solo puede digitar una cantidad menor a 9 digitos. ");
                return;

            }
            


            int montoPagar = Convert.ToInt32(txt_montoPagar.Text.Replace(" ", "").Trim());
            int abono = Convert.ToInt32(txt_abono.Text.Replace(" ", "").Trim());
            if (abono == 0)
            {
                MessageBox.Show("El abono debe ser mayor que cero.");
                return;
            }
            if(abono> montoPagar)
            {
                MessageBox.Show("El monto ingresado supera el monto a pagar");
                return;
            }

            
            DataSet DS = new DataSet();
            string cmd = "";

            for (int i = 0; i <= Convert.ToInt16(comboBox1.SelectedValue) - 1; i++)
            {
                if (Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value.ToString()) > 0){

                    if (abono>= Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value.ToString()))
                    {
                        abono -= Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value.ToString());
                        cmd = string.Format("update detalles_prestamos set estado_cuota='{0}', deuda_cuota={1}, abonos_cuota =( abonos_cuota + {2}) where id_prestamo={3} and numero_cuota = {4}", "Pagado", 0, dataGridView.Rows[i].Cells[6].Value.ToString(), txt_codigo_prestamo.Text,(i+1));
                        int filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd,"Error al realizar el pago, por favor intente de nuevo.");
                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show("Error al pagar la cuota" + (i + 1));
                            break;
                        }

                        cmd = string.Format("update prestamos set abonos_prestamo = ( abonos_prestamo + {0}) where id_prestamo ={1}", dataGridView.Rows[i].Cells[6].Value.ToString(),txt_codigo_prestamo.Text);
                       filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd,"Error al realizar el pago, por favor salir de la aplicación e informe a soporte.");
                        if (filasAfectadas == 0)
                        {
                            break;
                        }

                    }
                    else
                    {
                        cmd = string.Format("update detalles_prestamos set deuda_cuota = (deuda_cuota- {0}), abonos_cuota = ( abonos_cuota + {0} ) where id_prestamo={1} and numero_cuota = {2} ", abono,txt_codigo_prestamo.Text,(i+1));
                        int filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd, "Error al realizar el pago, por favor intente de nuevo.");
                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show("Error al pagar la cuota" + (i + 1));
                        }
                        cmd = string.Format("update prestamos set abonos_prestamo = ( abonos_prestamo + {0}) where id_prestamo = {1}", abono,txt_codigo_prestamo.Text);
                        filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd, "Error al realizar el pago, por favor salir de la aplicación e informe a soporte.");
                        break;
                    }
                    
                    if (abono == 0)
                    {
                        break;
                    }
                }
                
            }
            llenarCombox();
            comboBox1.SelectedIndex = -1;
            txt_abono.Text = "";
            txt_montoPagar.Text = "";
            llenarDataGrid();


        }

        private void txt_abono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidad.SoloNumeros(e);

        }

        private void txt_montoPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidad.SoloNumeros(e);

        }
    }
}
