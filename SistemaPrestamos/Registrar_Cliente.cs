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
    public partial class Registrar_Cliente : Form
    {
        public Registrar_Cliente()
        {
            InitializeComponent();
        }

        private void Registrar_Cliente_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();

            if (txt_id_cliente.Text == "0")
            {
                int codigo = 1;
                string cmd = string.Format("select id_cliente from clientes order by id_cliente desc limit 1");
                DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al traer los clientes, por favor intentar de nuevo.");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    codigo = Convert.ToInt16(DS.Tables[0].Rows[0][0]) + 1;
                }
               
                txt_id_cliente.Text = codigo+"";
            }else
            {
                string cmd = string.Format("select * from clientes left join referentes on clientes.id_cliente = referentes.id_cliente where clientes.id_cliente={0}",txt_id_cliente.Text);
                DS = Utilidades.Utilidad.ExecuteReader(cmd, "Error al traer los clientes, por favor intentar de nuevo.");
                si.Enabled = false;
                no.Enabled = false;
                //Datos clientes
                if(DS.Tables.Count > 0)
                {
                    txt_nombre_cliente.Text = DS.Tables[0].Rows[0]["nombre_cliente"].ToString();
                    txt_telefono_cliente.Text = DS.Tables[0].Rows[0]["telefono_cliente"].ToString();
                    txt_celular_cliente.Text = DS.Tables[0].Rows[0]["celular_cliente"].ToString();
                    txt_otroTelefono_cliente.Text = DS.Tables[0].Rows[0]["otro_telefono_cliente"].ToString();
                    txt_cedula_cliente.Text = DS.Tables[0].Rows[0]["cedula_cliente"].ToString();
                    txt_email_cliente.Text = DS.Tables[0].Rows[0]["email_cliente"].ToString();
                    txt_direccion_cliente.Text = DS.Tables[0].Rows[0]["direccion_cliente"].ToString();

                    //Datos del referente
                    txt_nombre_referido.Text = DS.Tables[0].Rows[0]["nombre_referente"].ToString();
                    txt_telefono_referido.Text = DS.Tables[0].Rows[0]["telefono_referente"].ToString();
                    txt_celular_referido.Text = DS.Tables[0].Rows[0]["celular_referente"].ToString();
                    txt_otroTelefono_referido.Text = DS.Tables[0].Rows[0]["otro_telefono_referente"].ToString();
                    txt_cedula_referido.Text = DS.Tables[0].Rows[0]["cedula_referente"].ToString();
                    txt_email_referido.Text = DS.Tables[0].Rows[0]["email_referente"].ToString();
                    txt_direccion_referido.Text = DS.Tables[0].Rows[0]["direccion_referente"].ToString();

                    if(txt_nombre_referido.Text != "")
                    {
                        si.Checked = true;
                        no.Checked = false;
                    }




                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(txt_nombre_cliente.Text == "")
            {
                MessageBox.Show("El nombre del cliente es obligatorio");
                return;
            }

            if(si.Checked && txt_nombre_referido.Text == "")
            {
                MessageBox.Show("El nombre del referente es obligatorio");

                return;
            }





            string cmd = "";
            if(accionLabel.Text== "Registrar Cliente")
            {
                cmd = string.Format("insert into clientes  (nombre_cliente,telefono_cliente,celular_cliente,otro_telefono_cliente,cedula_cliente,email_cliente,direccion_cliente,estado_cliente) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7})", txt_nombre_cliente.Text
               , txt_telefono_cliente.Text, txt_celular_cliente.Text, txt_otroTelefono_cliente.Text, txt_cedula_cliente.Text, txt_email_cliente.Text, txt_direccion_cliente.Text, 1
               );

               

            }
            else
            {
                cmd = string.Format("update clientes  set nombre_cliente='{0}',telefono_cliente='{1}',celular_cliente='{2}',otro_telefono_cliente='{3}',cedula_cliente='{4}',email_cliente='{5}',direccion_cliente='{6}' where id_cliente={7}", txt_nombre_cliente.Text
               , txt_telefono_cliente.Text, txt_celular_cliente.Text, txt_otroTelefono_cliente.Text, txt_cedula_cliente.Text, txt_email_cliente.Text, txt_direccion_cliente.Text,txt_id_cliente.Text
               );
            }

          

           int filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd, "Error por favor intentar de nuevo.");
            if (filasAfectadas >= 1)
            {
                if(accionLabel.Text== "Registrar Cliente")
                {
                    if (si.Checked)
                    {
                       
                 cmd = string.Format("insert into referentes  (nombre_referente,telefono_referente,celular_referente,otro_telefono_referente,cedula_referente,email_referente,direccion_referente,id_cliente) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7})", txt_nombre_referido.Text
              , txt_telefono_referido.Text, txt_celular_referido.Text, txt_otroTelefono_referido.Text, txt_cedula_referido.Text, txt_email_referido.Text, txt_direccion_referido.Text, txt_id_cliente.Text
              );
                        filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd,"Error al registar el referente.");
                    }
                    MessageBox.Show("El cliente " + txt_nombre_cliente.Text + " se ha registrado correctamente");
                }else
                {
                    if (si.Checked)
                    {
                        cmd = string.Format("update referentes  set nombre_referente='{0}',telefono_referente='{1}',celular_referente='{2}',otro_telefono_referente='{3}',cedula_referente='{4}',email_referente='{5}',direccion_referente='{6}' where id_cliente={7}", txt_nombre_referido.Text
              , txt_telefono_referido.Text, txt_celular_referido.Text, txt_otroTelefono_referido.Text, txt_cedula_referido.Text, txt_email_referido.Text, txt_direccion_referido.Text, txt_id_cliente.Text
              );
                        filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd,"Error al modificar el referente.");
                    }

                    MessageBox.Show("El cliente " + txt_nombre_cliente.Text + " se ha modificado correctamente");


                }
            }
           
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultas_Clientes Pantalla_Cliente = new Consultas_Clientes();
            Pantalla_Cliente.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registrar_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
         //   Application.Exit();
        }

        private void no_Click(object sender, EventArgs e)
        {
            txt_nombre_referido.Enabled = false;
            txt_telefono_referido.Enabled = false;
            txt_celular_referido.Enabled = false;
            txt_otroTelefono_referido.Enabled = false;
            txt_cedula_referido.Enabled = false;
            txt_email_referido.Enabled = false;
            txt_direccion_referido.Enabled = false;
        }

        private void si_Click(object sender, EventArgs e)
        {
            txt_nombre_referido.Enabled = true;
            txt_telefono_referido.Enabled = true;
            txt_celular_referido.Enabled = true;
            txt_otroTelefono_referido.Enabled = true;
            txt_cedula_referido.Enabled = true;
            txt_email_referido.Enabled = true;
            txt_direccion_referido.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_nombre_cliente.Text = "";
            txt_telefono_cliente.Text = "";
            txt_celular_cliente.Text = "";
            txt_otroTelefono_cliente.Text = "";
            txt_cedula_cliente.Text = "";
            txt_email_cliente.Text = "";
            txt_direccion_cliente.Text = "";


            txt_nombre_referido.Text = "";
            txt_telefono_referido.Text = "";
            txt_celular_referido.Text = "";
            txt_otroTelefono_referido.Text = "";
            txt_cedula_referido.Text = "";
            txt_email_referido.Text = "";
            txt_direccion_referido.Text = "";
        }
    }
}
