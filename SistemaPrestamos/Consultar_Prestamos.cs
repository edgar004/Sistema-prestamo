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
    public partial class Consultar_Prestamos : Form
    {
        public Consultar_Prestamos()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            codigo_prestamo.DataPropertyName = "id_prestamo";
            cliente.DataPropertyName = "nombre_cliente";
            Fecha.DataPropertyName = "fecha_prestamo";
            prestamo.DataPropertyName = "monto_prestamo";
            totalInteres.DataPropertyName = "total_interes_prestamo";
            TotalPrestamo.DataPropertyName = "total_prestamo";
            Abonos.DataPropertyName = "abonos_prestamo";
            Deuda.DataPropertyName = "deuda_prestamo";
            Estado.DataPropertyName = "estado_prestamo";
            calcularMora();
            string cmd = "select SUM(total_prestamo - abonos_prestamo) as dinero from prestamos where estado_prestamo = 'Pendiente'";
            DataSet DS = new DataSet();
            DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al mostrar la suma de las deudas.");


            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                if (DS.Tables[0].Rows[0][0].ToString().Equals(""))
                {
                    dinero.Text = "RD 0";
                

                }
                else
                {
                    dinero.Text = "RD "+DS.Tables[0].Rows[0][0].ToString();

                }
            }

            llenarDataGrid("no");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count==0)
            {
                MessageBox.Show("Debe selecionar un préstamo.");
                return;
            }

            Abonos_Prestamos Pantalla_Abonos = new Abonos_Prestamos();
            Pantalla_Abonos.txt_codigo_prestamo.Text = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            this.Hide();
            Pantalla_Abonos.Show();
        }

        private void Consultar_Prestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Consultar_Prestamos_Load(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
           


        }

        public void calcularMora()
        {
            DateTime fecha = Convert.ToDateTime(DateTime.Now, new CultureInfo("es-ES"));

            DataSet DS = new DataSet();
            string cmd = "select fecha from fecha_mora";
            DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al verificar si hay cuotas retrasadas");
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                DateTime fechaBD = DateTime.Parse(DS.Tables[0].Rows[0][0].ToString());

                if (fechaBD.ToString("yyyy-dd-MM") == fecha.ToString("yyyy-dd-MM"))
                {
                    return;
                }

                cmd = string.Format("SELECT * from detalles_prestamos INNER JOIN prestamos on prestamos.id_prestamo = detalles_prestamos.id_prestamo WHERE fecha_cuota  < '{0}'  and estado_cuota = 'Pendiente'", fecha.ToString("yyyy-MM-dd"));
                DS = Utilidades.Utilidad.ExecuteReader(cmd, "Error al verificar si hay cuotas retrasadas");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    int totalDetalles = DS.Tables[0].Rows.Count;
                    for (int i = 0; i < totalDetalles; i++)
                    {
                        DateTime FechaCuota = DateTime.Parse(DS.Tables[0].Rows[i][2].ToString());
                        int diasPasados = 0;
                        while (FechaCuota.ToString("yyyy-dd-MM") != fecha.ToString("yyyy-dd-MM"))
                        {
                            FechaCuota = FechaCuota.AddDays(1);
                            diasPasados++;
                        }
                        double porcientoMora = Convert.ToDouble(DS.Tables[0].Rows[i][14].ToString()) / 100;
                        int mora = Convert.ToInt32((porcientoMora * Convert.ToInt32(DS.Tables[0].Rows[i][18].ToString())));
                        mora *= diasPasados;

                        cmd = string.Format("update  detalles_prestamos set mora_cuota = ( mora_cuota + {0}), deuda_cuota = ( deuda_cuota + {0} ) where id_prestamo = {1} and numero_cuota={2} ", mora, DS.Tables[0].Rows[i][0].ToString(), DS.Tables[0].Rows[i][1].ToString());
                        int filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd,"Error al aplicar mora a las cuotas retrasadas, por favor salir de la aplicación e informe a soporte.");
                        if (filasAfectadas == 0) return;
                        cmd = string.Format("update  prestamos set total_prestamo = ( total_prestamo + {0})  where id_prestamo = {1}", mora, DS.Tables[0].Rows[i][0].ToString());
                        filasAfectadas = Utilidades.Utilidad.ExecuteNonQuery(cmd, "Error al aplicar mora a las cuotas retrasadas, por favor salir de la aplicación e informe a soporte.");
                        if (filasAfectadas == 0) return;



                    }
                    cmd =string.Format("update fecha_mora set fecha ='{0}' ", fecha.ToString("yyyy-MM-dd"));
                    Utilidades.Utilidad.ExecuteNonQuery(cmd,"Error aplicar moras a las cuotas retrasadas, por favor salir de la aplicación e informe a soporte.");
                }

            }

        }

        public void llenarDataGrid(string condicion)
        {
            string cmd = "SELECT clientes.nombre_cliente,prestamos.*,(total_prestamo - abonos_prestamo) as deuda_prestamo FROM prestamos inner JOIN clientes on prestamos.id_cliente = clientes.id_cliente ORDER BY prestamos.id_prestamo desc";
            if (condicion != "no")
            {
                cmd += condicion;
            }
            DataSet DS = new DataSet();
            DS = Utilidades.Utilidad.ExecuteReader(cmd,"Error al traer los prèstamo, por favor intente de nuevo.");
            if (DS.Tables.Count > 0)
            {
                dataGridView.DataSource = DS.Tables[0];

            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu ver = new Menu();
            this.Hide();
            ver.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar_Prestamos Pantalla_registrarPrestamos = new Registrar_Prestamos();
            this.Hide();
            Pantalla_registrarPrestamos.Show();
        }
    }
}
