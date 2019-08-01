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
            calcularPrestamo();


        }

        public bool calcularPrestamo()
        {
            try
            {
                if (txt_interes_prestamo.Text.Replace(" ", "").Trim() != "")
                {
                    txt_cuotasPagar_prestamo.Validar = false;
                }
                else if (txt_cuotasPagar_prestamo.Text.Replace(" ", "").Trim() != "")
                {
                    txt_interes_prestamo.Validar = false;
                }

                if (txt_interes_prestamo.Text.Replace(" ", "").Trim() == "" && txt_cuotasPagar_prestamo.Text.Replace(" ", "").Trim() == "")
                {
                    MessageBox.Show("Debe llenar el monto cuotas a pagar o el interes %");
                    return false;
                }

                errorProvider1.SetError(comboPlazo, (comboPlazo.SelectedIndex == -1 ? "Campo obligatorio" : ""));



                if (Utilidades.Utilidad.validarFormulario(this, errorProvider1) == true)
                {
                    buttonRegistraPrestamo.Enabled = false;
                    return false;
                }

                if (comboPlazo.SelectedIndex == -1)
                {
                    buttonRegistraPrestamo.Enabled = false;

                    return false;
                }

                if (txt_monto_prestamo.Text.Replace(" ", "").Trim().Length > 9)
                {
                    MessageBox.Show("El monto préstamo no puede superar una cantidad mayor a 9 digitos. ");
                    return false;

                }

                if (txt_cuotasPagar_prestamo.Text.Replace(" ", "").Trim().Length > 9)
                {
                    MessageBox.Show("El monto cuotas a pagar no puede superar una cantidad mayor a 9 digitos. ");
                    return false;

                }



                if (txt_interes_prestamo.Text.Replace(" ", "").Trim() != "" && Convert.ToDouble(txt_interes_prestamo.Text.Replace(" ", "").Trim()) > 100)
                {
                    MessageBox.Show("El interes préstamo no puede ser una cantidad mayor a 100.");
                    return false;

                }

                if (txt_cuota_prestamo.Text.Replace(" ", "").Trim().Length > 9)
                {
                    MessageBox.Show("La cantidad cuota préstamo no puede superar una cantidad mayor a 9 digitos. ");
                    return false;

                }

                if (Convert.ToDouble(txt_mora_prestamo.Text.Replace(" ", "").Trim()) > 100)
                {
                    MessageBox.Show("La mora préstamo no puede ser una cantidad mayor a 100.");
                    return false;

                }








                if (Convert.ToInt32(txt_monto_prestamo.Text.Replace(" ", "").Trim()) == 0)
                {
                    MessageBox.Show("El monto préstamo debe ser mayor que cero.");
                    return false;
                }

                if (Convert.ToInt32(txt_cuota_prestamo.Text.Replace(" ", "").Trim()) == 0)
                {
                    MessageBox.Show("La cantidad de cuota debe ser mayor que cero.");
                    return false;
                }
                dataGridView.DataSource = null;
                buttonRegistraPrestamo.Enabled = true;
                dataGridView.Rows.Clear();


                int cuota = Convert.ToInt32(txt_cuota_prestamo.Text.Replace(" ", "").Trim());
                int monto = Convert.ToInt32(txt_monto_prestamo.Text.Replace(" ", "").Trim());
                double totalInteres = 0;
                if (txt_interes_prestamo.Text.Replace(" ", "").Trim() == "")
                {
                    totalInteres = Convert.ToInt32(txt_cuota_prestamo.Text) * Convert.ToInt32(txt_cuotasPagar_prestamo.Text);
                    totalInteres = totalInteres - monto;
                    double resultado = Convert.ToDouble((totalInteres / ((monto * cuota) / 100)));
                    if ((resultado % 1) < 0.5)
                    {
                        txt_interes_prestamo.Text = Math.Round(resultado).ToString();
                    }
                    else
                    {
                        txt_interes_prestamo.Text = Math.Ceiling(resultado).ToString();

                    }

                    if (txt_interes_prestamo.Text.Replace(" ", "").Trim() != "" && Convert.ToDouble(txt_interes_prestamo.Text.Replace(" ", "").Trim()) > 100)
                    {
                        MessageBox.Show("Monto cuota a pagar supera el 100% de interes.");
                        txt_interes_prestamo.Text = "";
                        return false;

                    }

                    if (txt_interes_prestamo.Text.Replace(" ", "").Trim() != "" && Convert.ToDouble(txt_interes_prestamo.Text.Replace(" ", "").Trim()) < 0)
                    {
                        MessageBox.Show("Monto cuota a pagar es muy bajo, se esta aplicando un interes de " + txt_interes_prestamo.Text + "%.");
                        txt_interes_prestamo.Text = "";
                        return false;

                    }

                }

                totalInteres = Convert.ToInt32((Convert.ToDouble(txt_interes_prestamo.Text.Replace(" ", "").Trim()) / 100) * monto * cuota);
                int interes = Convert.ToInt32((Convert.ToDouble(txt_interes_prestamo.Text.Replace(" ", "").Trim()) / 100) * monto);
                int totalPrestamo = monto + Convert.ToInt32(totalInteres);
                txt_total_prestamo.Text = totalPrestamo.ToString();
                txt_interesTotal_prestamo.Text = totalInteres.ToString();
                int montoCuota = totalPrestamo / cuota;
                txt_cuotasPagar_prestamo.Text = montoCuota.ToString();
                int mora = Convert.ToInt32((Convert.ToDouble(txt_mora_prestamo.Text.Replace(" ", "").Trim()) / 100) * montoCuota);
                DateTime fecha = Convert.ToDateTime(calendario.Text, new CultureInfo("es-ES"));
                for (int i = 1; i <= cuota; i++)
                {
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
                    }
                    else
                    {
                        fecha = fecha.AddYears(1);
                    }
                    dataGridView.Rows.Add(i, fecha.ToString("d/M/yyyy"), montoCuota, 0, interes, mora, montoCuota, "Pendiente");

                }


                dataGridView.ClearSelection();
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al intetar crear el préstamo, por favor verifique que los datos ingresado tiene un formato correcto.");
                return false;
            }
            

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

        private void NAR(object o)
        {
            try
            {
                while (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0) ;
            }
            catch { }
            finally
            {
                o = null;
            }
        }

        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName ="prestamo";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    aplicacion.DisplayAlerts = false;
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Range chartRange;
                    
                    hoja_trabajo.Cells[1, "E"] = "Información del Cliente";
                    hoja_trabajo.Cells[1, "E"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DeepSkyBlue);
                    hoja_trabajo.Cells[1, "E"].Font.Bold = true;

                    hoja_trabajo.Cells[2, "E"] = "Cliente";
                    hoja_trabajo.Cells[2, "E"].Font.Bold = true;
                    hoja_trabajo.Cells[3, "E"] = txt_nombre_cliente.Text;
                    hoja_trabajo.Cells[3, "E"].ColumnWidth = 18;


                    hoja_trabajo.Cells[2, "F"] = "Teléfono";
                    hoja_trabajo.Cells[2, "F"].Font.Bold = true;
                    hoja_trabajo.Cells[3, "F"] = txt_telefono_cliente.Text;



                    hoja_trabajo.Cells[6, "E"] = "Información del Referente";
                    hoja_trabajo.Cells[6, "E"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DeepSkyBlue);
                    hoja_trabajo.Cells[6, "E"].Font.Bold = true;

                    hoja_trabajo.Cells[7, "E"] = "Referente";
                    hoja_trabajo.Cells[7, "E"].Font.Bold = true;
                    hoja_trabajo.Cells[8, "E"] = txt_nombre_referido.Text;
                    hoja_trabajo.Cells[8, "E"].ColumnWidth = 18;

                    hoja_trabajo.Cells[7, "F"] = "Teléfono";
                    hoja_trabajo.Cells[7, "F"].Font.Bold = true;
                    hoja_trabajo.Cells[8, "F"] = txt_telefono_referido.Text;

                    chartRange = hoja_trabajo.get_Range("E1", "F8");
                    foreach (Microsoft.Office.Interop.Excel.Range cell in chartRange.Cells)
                    {
                        cell.BorderAround2();
                        cell.ColumnWidth = 18;
                        cell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    }

                    chartRange = hoja_trabajo.get_Range("E1", "F1");
                    chartRange.Merge(true);

                    chartRange = hoja_trabajo.get_Range("E6", "F6");
                    chartRange.Merge(true);


                    hoja_trabajo.Cells[11, "D"] = "Monto préstamo";
                    hoja_trabajo.Cells[12, "D"] = txt_monto_prestamo.Text;
                   

                    hoja_trabajo.Cells[11, "E"] = "Cuota";
                    hoja_trabajo.Cells[12, "E"] = txt_cuota_prestamo.Text;


                    hoja_trabajo.Cells[11, "F"] = "Monto cuotas a pagar";
                    hoja_trabajo.Cells[12, "F"] = txt_cuotasPagar_prestamo.Text;
                   
                    hoja_trabajo.Cells[11, "G"] = "Interes %";
                    hoja_trabajo.Cells[12, "G"] = txt_interes_prestamo.Text;
                    
                    hoja_trabajo.Cells[13, "D"] = "Frecuencia pago";
                    hoja_trabajo.Cells[14, "D"] =comboPlazo.SelectedItem;

                    hoja_trabajo.Cells[13, "E"] = "Total préstamo";
                    hoja_trabajo.Cells[14, "E"] = txt_total_prestamo.Text;
                   

                    hoja_trabajo.Cells[13, "F"] = "Total interes";
                    hoja_trabajo.Cells[14, "F"] = txt_interesTotal_prestamo.Text;
                   

                    hoja_trabajo.Cells[13, "G"] = "Mora %";
                    hoja_trabajo.Cells[14, "G"] = txt_mora_prestamo.Text;
                   
                    chartRange = hoja_trabajo.get_Range("D11", "G11");
                    //ENCABEZADOS
                    foreach (Microsoft.Office.Interop.Excel.Range cell in chartRange.Cells)
                    {
                        cell.Font.Bold = true;
                        cell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DeepSkyBlue);
                    }

                    chartRange = hoja_trabajo.get_Range("D13", "G13");
                    //ENCABEZADOS
                    foreach (Microsoft.Office.Interop.Excel.Range cell in chartRange.Cells)
                    {
                        cell.Font.Bold = true;
                        cell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DeepSkyBlue);
                    }

                    //TODO encabezado y valores
                    chartRange = hoja_trabajo.get_Range("D11", "G14");
                    foreach (Microsoft.Office.Interop.Excel.Range cell in chartRange.Cells)
                    {
                        cell.BorderAround2();
                        cell.ColumnWidth = 18;
                        cell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        
                    }

                    //Datagrind view
                    hoja_trabajo.Cells[17, "B"] = "Cuota";
                    hoja_trabajo.Cells[17, "C"] = "Fecha";
                    hoja_trabajo.Cells[17, "D"] = "Monto cuota";
                    hoja_trabajo.Cells[17, "E"] = "Abonos";
                    hoja_trabajo.Cells[17, "F"] = "Interes";
                    hoja_trabajo.Cells[17, "G"] = "Moras";
                    hoja_trabajo.Cells[17, "H"] = "Deuda";
                    hoja_trabajo.Cells[17, "I"] = "Estado";

                    chartRange = hoja_trabajo.get_Range("B17", "I17");
                    foreach (Microsoft.Office.Interop.Excel.Range cell in chartRange.Cells)
                    {
                        cell.BorderAround2();
                        cell.Font.Bold = true;
                        cell.ColumnWidth = 18;
                        cell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DeepSkyBlue);
                        cell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }


                    

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    int fila = 18;
                    int columna = 2;
                    for (int i = 0; i < grd.Rows.Count; i++)
                    {
                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            if ((grd.Rows[i].Cells[j].Value == null) == false)
                            {
                                hoja_trabajo.Cells[fila, columna] = grd.Rows[i].Cells[j].Value.ToString();
                                //Bordes
                                /* hoja_trabajo.Cells[fila, columna].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;
                                 hoja_trabajo.Cells[fila, columna].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;
                                 hoja_trabajo.Cells[fila, columna].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;
                                 hoja_trabajo.Cells[fila, columna].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                 hoja_trabajo.Cells[fila, columna].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                 hoja_trabajo.Cells[fila, columna].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                 */
                                columna++;
                            }
                        }
                        columna = 2;
                        fila++;
                    }

                    chartRange = hoja_trabajo.get_Range("B17", "I"+(Convert.ToInt16(txt_cuota_prestamo.Text) + 17 ));
                    foreach (Microsoft.Office.Interop.Excel.Range cell in chartRange.Cells)
                    {
                        cell.BorderAround2();
                        cell.ColumnWidth = 18;
                        cell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    }

                    hoja_trabajo.Cells[(Convert.ToInt16(txt_cuota_prestamo.Text) + 17) + 5, "B"] = "Firma del cliente:";
                    hoja_trabajo.Cells[(Convert.ToInt16(txt_cuota_prestamo.Text) + 17) + 5, "B"].Font.Bold = true;



                    hoja_trabajo.Cells[(Convert.ToInt16(txt_cuota_prestamo.Text) + 17) + 5, "C"] = "_________________________________________________________";
                    hoja_trabajo.Cells[(Convert.ToInt16(txt_cuota_prestamo.Text) + 17) + 5, "C"].Font.Bold = true;
                    hoja_trabajo.Cells[(Convert.ToInt16(txt_cuota_prestamo.Text) + 17) + 5, "C"].ColumnWidth = 18;

                    chartRange = hoja_trabajo.get_Range("C"+ (  (Convert.ToInt16(txt_cuota_prestamo.Text) + 17 + 5) ), "E"+ ((Convert.ToInt16(txt_cuota_prestamo.Text) + 17 + 5) ));
                    chartRange.Merge(true);

                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(false);
                    aplicacion.Quit();

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(aplicacion);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(libros_trabajo);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(hoja_trabajo);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(chartRange);



                    /*  System.Diagnostics.Process[] objProcess = System.Diagnostics.Process.GetProcessesByName("EXCEL");

                       if (objProcess.Length > 0)
                       {
                           System.Collections.Hashtable objHashtable = new System.Collections.Hashtable();

                           // check to kill the right process
                           foreach (System.Diagnostics.Process processInExcel in objProcess)
                           {
                               if (objHashtable.ContainsKey(processInExcel.Id) == false)
                               {
                                   processInExcel.Kill();
                               }
                           }
                           objProcess = null;
                       }

       */
                    MessageBox.Show("El archivo de Excel se ha creado correctamente.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear el archivo Excel, pero el préstamo fue creado correctamente.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calcularPrestamo() == false) return;
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
                    ExportarDataGridViewExcel(dataGridView);
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
            System.Environment.Exit(-1);

        }

        private void txt_monto_prestamo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidad.SoloNumeros(e);
        }

        private void txt_cuota_prestamo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidad.SoloNumeros(e);
        }

        private void txt_cuotasPagar_prestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidad.SoloNumeros(e);
        }

        private void calendario_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
