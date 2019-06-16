namespace SistemaPrestamos
{
    partial class Registrar_Prestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar_Prestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buscador = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_cedula_referido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_direccion_referido = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_telefono_referido = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_nombre_referido = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonRegistraPrestamo = new System.Windows.Forms.Button();
            this.txt_cuotasPagar_prestamo = new Utilidades.TxtBoxError();
            this.txt_interesTotal_prestamo = new Utilidades.TxtBoxError();
            this.txt_total_prestamo = new Utilidades.TxtBoxError();
            this.txt_mora_prestamo = new Utilidades.TxtBoxError();
            this.txt_cuota_prestamo = new Utilidades.TxtBoxError();
            this.txt_interes_prestamo = new Utilidades.TxtBoxError();
            this.txt_monto_prestamo = new Utilidades.TxtBoxError();
            this.comboPlazo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_codigo_cliente = new Utilidades.TxtBoxError();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new Utilidades.TxtBoxError();
            this.txt_cedula_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_direccion_cliente = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefono_cliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.fechaActual = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(61, 49);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(186, 22);
            this.buscador.TabIndex = 2;
            this.buscador.Enter += new System.EventHandler(this.buscador_Enter);
            this.buscador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buscador_KeyUp);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label34.Location = new System.Drawing.Point(341, -2);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(364, 33);
            this.label34.TabIndex = 37;
            this.label34.Text = "REGISTRAR PRÉSTAMOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(36, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 19);
            this.label9.TabIndex = 41;
            this.label9.Text = "Ingresar la cédula del cliente";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_cedula_referido);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txt_direccion_referido);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txt_telefono_referido);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txt_nombre_referido);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(529, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 152);
            this.panel3.TabIndex = 57;
            // 
            // txt_cedula_referido
            // 
            this.txt_cedula_referido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_cedula_referido.Enabled = false;
            this.txt_cedula_referido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula_referido.Location = new System.Drawing.Point(269, 22);
            this.txt_cedula_referido.Name = "txt_cedula_referido";
            this.txt_cedula_referido.Size = new System.Drawing.Size(177, 25);
            this.txt_cedula_referido.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(327, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Cédula";
            // 
            // txt_direccion_referido
            // 
            this.txt_direccion_referido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_direccion_referido.Enabled = false;
            this.txt_direccion_referido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_referido.Location = new System.Drawing.Point(5, 75);
            this.txt_direccion_referido.Name = "txt_direccion_referido";
            this.txt_direccion_referido.Size = new System.Drawing.Size(201, 75);
            this.txt_direccion_referido.TabIndex = 11;
            this.txt_direccion_referido.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "Dirección";
            // 
            // txt_telefono_referido
            // 
            this.txt_telefono_referido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_telefono_referido.Enabled = false;
            this.txt_telefono_referido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_referido.Location = new System.Drawing.Point(269, 122);
            this.txt_telefono_referido.Name = "txt_telefono_referido";
            this.txt_telefono_referido.Size = new System.Drawing.Size(177, 25);
            this.txt_telefono_referido.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(315, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "Teléfono";
            // 
            // txt_nombre_referido
            // 
            this.txt_nombre_referido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_nombre_referido.Enabled = false;
            this.txt_nombre_referido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_referido.Location = new System.Drawing.Point(5, 21);
            this.txt_nombre_referido.Name = "txt_nombre_referido";
            this.txt_nombre_referido.Size = new System.Drawing.Size(185, 25);
            this.txt_nombre_referido.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(56, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(664, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 19);
            this.label8.TabIndex = 55;
            this.label8.Text = "Información del referente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(127, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Información del cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(329, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 33);
            this.label5.TabIndex = 54;
            this.label5.Text = "Información del préstamos";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.buttonRegistraPrestamo);
            this.panel5.Controls.Add(this.txt_cuotasPagar_prestamo);
            this.panel5.Controls.Add(this.txt_interesTotal_prestamo);
            this.panel5.Controls.Add(this.txt_total_prestamo);
            this.panel5.Controls.Add(this.txt_mora_prestamo);
            this.panel5.Controls.Add(this.txt_cuota_prestamo);
            this.panel5.Controls.Add(this.txt_interes_prestamo);
            this.panel5.Controls.Add(this.txt_monto_prestamo);
            this.panel5.Controls.Add(this.comboPlazo);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.calendario);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.label32);
            this.panel5.Location = new System.Drawing.Point(10, 299);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(980, 174);
            this.panel5.TabIndex = 53;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // buttonRegistraPrestamo
            // 
            this.buttonRegistraPrestamo.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonRegistraPrestamo.Enabled = false;
            this.buttonRegistraPrestamo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistraPrestamo.Location = new System.Drawing.Point(352, 135);
            this.buttonRegistraPrestamo.Name = "buttonRegistraPrestamo";
            this.buttonRegistraPrestamo.Size = new System.Drawing.Size(202, 37);
            this.buttonRegistraPrestamo.TabIndex = 73;
            this.buttonRegistraPrestamo.Text = "Registrar préstamo";
            this.buttonRegistraPrestamo.UseVisualStyleBackColor = false;
            this.buttonRegistraPrestamo.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_cuotasPagar_prestamo
            // 
            this.txt_cuotasPagar_prestamo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_cuotasPagar_prestamo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txt_cuotasPagar_prestamo.Location = new System.Drawing.Point(359, 34);
            this.txt_cuotasPagar_prestamo.Name = "txt_cuotasPagar_prestamo";
            this.txt_cuotasPagar_prestamo.Size = new System.Drawing.Size(167, 25);
            this.txt_cuotasPagar_prestamo.TabIndex = 72;
            this.txt_cuotasPagar_prestamo.Validar = false;
            // 
            // txt_interesTotal_prestamo
            // 
            this.txt_interesTotal_prestamo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_interesTotal_prestamo.Enabled = false;
            this.txt_interesTotal_prestamo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txt_interesTotal_prestamo.Location = new System.Drawing.Point(387, 107);
            this.txt_interesTotal_prestamo.Name = "txt_interesTotal_prestamo";
            this.txt_interesTotal_prestamo.Size = new System.Drawing.Size(139, 25);
            this.txt_interesTotal_prestamo.TabIndex = 71;
            this.txt_interesTotal_prestamo.Validar = false;
            // 
            // txt_total_prestamo
            // 
            this.txt_total_prestamo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_total_prestamo.Enabled = false;
            this.txt_total_prestamo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txt_total_prestamo.Location = new System.Drawing.Point(190, 106);
            this.txt_total_prestamo.Name = "txt_total_prestamo";
            this.txt_total_prestamo.Size = new System.Drawing.Size(139, 25);
            this.txt_total_prestamo.TabIndex = 70;
            this.txt_total_prestamo.Validar = false;
            // 
            // txt_mora_prestamo
            // 
            this.txt_mora_prestamo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_mora_prestamo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txt_mora_prestamo.Location = new System.Drawing.Point(579, 107);
            this.txt_mora_prestamo.Name = "txt_mora_prestamo";
            this.txt_mora_prestamo.Size = new System.Drawing.Size(139, 25);
            this.txt_mora_prestamo.TabIndex = 66;
            this.txt_mora_prestamo.Validar = true;
            // 
            // txt_cuota_prestamo
            // 
            this.txt_cuota_prestamo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_cuota_prestamo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txt_cuota_prestamo.Location = new System.Drawing.Point(190, 33);
            this.txt_cuota_prestamo.Name = "txt_cuota_prestamo";
            this.txt_cuota_prestamo.Size = new System.Drawing.Size(139, 25);
            this.txt_cuota_prestamo.TabIndex = 65;
            this.txt_cuota_prestamo.Validar = true;
            // 
            // txt_interes_prestamo
            // 
            this.txt_interes_prestamo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_interes_prestamo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txt_interes_prestamo.Location = new System.Drawing.Point(579, 33);
            this.txt_interes_prestamo.Name = "txt_interes_prestamo";
            this.txt_interes_prestamo.Size = new System.Drawing.Size(139, 25);
            this.txt_interes_prestamo.TabIndex = 64;
            this.txt_interes_prestamo.Validar = false;
            // 
            // txt_monto_prestamo
            // 
            this.txt_monto_prestamo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_monto_prestamo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txt_monto_prestamo.Location = new System.Drawing.Point(13, 33);
            this.txt_monto_prestamo.Name = "txt_monto_prestamo";
            this.txt_monto_prestamo.Size = new System.Drawing.Size(139, 25);
            this.txt_monto_prestamo.TabIndex = 63;
            this.txt_monto_prestamo.Validar = true;
            // 
            // comboPlazo
            // 
            this.comboPlazo.FormattingEnabled = true;
            this.comboPlazo.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Quicenal",
            "Mensual",
            "Anual"});
            this.comboPlazo.Location = new System.Drawing.Point(18, 107);
            this.comboPlazo.Name = "comboPlazo";
            this.comboPlazo.Size = new System.Drawing.Size(134, 24);
            this.comboPlazo.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(618, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Mora %";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::SistemaPrestamos.Properties.Resources.cancelar_icono;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(806, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 37);
            this.button3.TabIndex = 25;
            this.button3.Text = "Limpiar todo";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // calendario
            // 
            this.calendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendario.Location = new System.Drawing.Point(788, 33);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(187, 22);
            this.calendario.TabIndex = 38;
            this.calendario.Value = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(403, 77);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 19);
            this.label25.TabIndex = 22;
            this.label25.Text = "Total interes";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(806, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 37);
            this.button2.TabIndex = 24;
            this.button2.Text = "Realizar cálculo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(770, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(209, 19);
            this.label26.TabIndex = 20;
            this.label26.Text = "Fecha inicio del préstamo";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(603, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 19);
            this.label29.TabIndex = 12;
            this.label29.Text = "Interes %";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(14, 74);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(139, 19);
            this.label27.TabIndex = 16;
            this.label27.Text = "Frecuencia pago";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(222, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 19);
            this.label28.TabIndex = 14;
            this.label28.Text = "Cuotas";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(186, 74);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(126, 19);
            this.label30.TabIndex = 10;
            this.label30.Text = "Total préstamo";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(355, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(180, 19);
            this.label31.TabIndex = 8;
            this.label31.Text = "Monto cuotas a pagar";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(9, 9);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(137, 19);
            this.label32.TabIndex = 6;
            this.label32.Text = "Monto préstamo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SistemaPrestamos.Properties.Resources.lupa_icono;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(331, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(943, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_codigo_cliente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_nombre_cliente);
            this.panel2.Controls.Add(this.txt_cedula_cliente);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_direccion_cliente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_telefono_cliente);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(12, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 152);
            this.panel2.TabIndex = 49;
            // 
            // txt_codigo_cliente
            // 
            this.txt_codigo_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_codigo_cliente.Enabled = false;
            this.txt_codigo_cliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txt_codigo_cliente.Location = new System.Drawing.Point(11, 24);
            this.txt_codigo_cliente.Name = "txt_codigo_cliente";
            this.txt_codigo_cliente.Size = new System.Drawing.Size(185, 25);
            this.txt_codigo_cliente.TabIndex = 75;
            this.txt_codigo_cliente.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Código";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_nombre_cliente.Enabled = false;
            this.txt_nombre_cliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txt_nombre_cliente.Location = new System.Drawing.Point(268, 19);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(185, 25);
            this.txt_nombre_cliente.TabIndex = 73;
            this.txt_nombre_cliente.Validar = true;
            // 
            // txt_cedula_cliente
            // 
            this.txt_cedula_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_cedula_cliente.Enabled = false;
            this.txt_cedula_cliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula_cliente.Location = new System.Drawing.Point(276, 69);
            this.txt_cedula_cliente.Name = "txt_cedula_cliente";
            this.txt_cedula_cliente.Size = new System.Drawing.Size(177, 25);
            this.txt_cedula_cliente.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cédula";
            // 
            // txt_direccion_cliente
            // 
            this.txt_direccion_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_direccion_cliente.Enabled = false;
            this.txt_direccion_cliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_cliente.Location = new System.Drawing.Point(11, 70);
            this.txt_direccion_cliente.Name = "txt_direccion_cliente";
            this.txt_direccion_cliente.Size = new System.Drawing.Size(185, 81);
            this.txt_direccion_cliente.TabIndex = 11;
            this.txt_direccion_cliente.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dirección";
            // 
            // txt_telefono_cliente
            // 
            this.txt_telefono_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_telefono_cliente.Enabled = false;
            this.txt_telefono_cliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_cliente.Location = new System.Drawing.Point(276, 121);
            this.txt_telefono_cliente.Name = "txt_telefono_cliente";
            this.txt_telefono_cliente.Size = new System.Drawing.Size(177, 25);
            this.txt_telefono_cliente.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(318, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Teléfono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(315, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nombre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::SistemaPrestamos.Properties.Resources.lupa_icono;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(510, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 37);
            this.button4.TabIndex = 63;
            this.button4.Text = "Ver clientes";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fechaActual
            // 
            this.fechaActual.Enabled = false;
            this.fechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaActual.Location = new System.Drawing.Point(733, 47);
            this.fechaActual.Name = "fechaActual";
            this.fechaActual.Size = new System.Drawing.Size(187, 22);
            this.fechaActual.TabIndex = 65;
            this.fechaActual.Value = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 64;
            this.label4.Text = "Fecha actual";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 41;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuota,
            this.fecha,
            this.monto,
            this.abonos,
            this.interes,
            this.moras,
            this.deuda,
            this.estado});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(10, 475);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(980, 167);
            this.dataGridView.TabIndex = 68;
            // 
            // cuota
            // 
            this.cuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cuota.HeaderText = "Cuota";
            this.cuota.Name = "cuota";
            this.cuota.Width = 92;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 90;
            // 
            // monto
            // 
            this.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.monto.HeaderText = "Monto Cuota";
            this.monto.Name = "monto";
            this.monto.Width = 153;
            // 
            // abonos
            // 
            this.abonos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.abonos.HeaderText = "Abonos";
            this.abonos.Name = "abonos";
            this.abonos.Width = 102;
            // 
            // interes
            // 
            this.interes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.interes.HeaderText = "Interes";
            this.interes.Name = "interes";
            this.interes.Width = 94;
            // 
            // moras
            // 
            this.moras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.moras.HeaderText = "Moras";
            this.moras.Name = "moras";
            this.moras.Width = 90;
            // 
            // deuda
            // 
            this.deuda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deuda.HeaderText = "Deuda";
            this.deuda.Name = "deuda";
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // Registrar_Prestamos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 645);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.fechaActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registrar_Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Registrar_Prestamos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_cedula_referido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txt_direccion_referido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_telefono_referido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_nombre_referido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox comboPlazo;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_cedula_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txt_direccion_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefono_cliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Utilidades.TxtBoxError txt_interes_prestamo;
        private Utilidades.TxtBoxError txt_monto_prestamo;
        private Utilidades.TxtBoxError txt_cuota_prestamo;
        private Utilidades.TxtBoxError txt_mora_prestamo;
        private Utilidades.TxtBoxError txt_total_prestamo;
        private Utilidades.TxtBoxError txt_interesTotal_prestamo;
        private Utilidades.TxtBoxError txt_cuotasPagar_prestamo;
        private Utilidades.TxtBoxError txt_nombre_cliente;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button buttonRegistraPrestamo;
        private Utilidades.TxtBoxError txt_codigo_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaActual;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn moras;
        private System.Windows.Forms.DataGridViewTextBoxColumn deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}