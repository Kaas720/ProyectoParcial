namespace ProyectoParcial
{
    partial class Reserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaViaje = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroMa = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DataGridReservas = new System.Windows.Forms.DataGridView();
            this.idReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaTaxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroMaletas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textPuntoOrigen = new System.Windows.Forms.TextBox();
            this.textPuntoDestino = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textCedula = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBoxTaxi = new System.Windows.Forms.ComboBox();
            this.bb = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rango de viaje:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fechaViaje
            // 
            this.fechaViaje.CustomFormat = "";
            this.fechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaViaje.Location = new System.Drawing.Point(406, 147);
            this.fechaViaje.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.fechaViaje.Name = "fechaViaje";
            this.fechaViaje.Size = new System.Drawing.Size(98, 20);
            this.fechaViaje.TabIndex = 12;
            this.fechaViaje.Value = new System.DateTime(2022, 9, 13, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(368, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reservar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProyectoParcial.Properties.Resources.istockphoto_1205276209_170667a;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 583);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // TextNombre
            // 
            this.TextNombre.AutoSize = true;
            this.TextNombre.BackColor = System.Drawing.Color.Transparent;
            this.TextNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombre.Location = new System.Drawing.Point(128, 96);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(117, 17);
            this.TextNombre.TabIndex = 18;
            this.TextNombre.Text = "KEVIN AREVALO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha de viaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Número maletas:";
            // 
            // numeroMa
            // 
            this.numeroMa.Location = new System.Drawing.Point(671, 147);
            this.numeroMa.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numeroMa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroMa.Name = "numeroMa";
            this.numeroMa.Size = new System.Drawing.Size(88, 20);
            this.numeroMa.TabIndex = 22;
            this.numeroMa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Número cédula:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Punto origen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(519, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Punto destino:";
            // 
            // DataGridReservas
            // 
            this.DataGridReservas.AllowUserToAddRows = false;
            this.DataGridReservas.AllowUserToDeleteRows = false;
            this.DataGridReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReserva,
            this.PlacaTaxi,
            this.puntoDestino,
            this.llegada,
            this.Fecha,
            this.NumeroMaletas,
            this.Eliminar,
            this.Editar});
            this.DataGridReservas.Location = new System.Drawing.Point(47, 322);
            this.DataGridReservas.Name = "DataGridReservas";
            this.DataGridReservas.ReadOnly = true;
            this.DataGridReservas.Size = new System.Drawing.Size(712, 174);
            this.DataGridReservas.TabIndex = 31;
            this.DataGridReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridReservas_CellContentClick);
            // 
            // idReserva
            // 
            this.idReserva.HeaderText = "Id Reserva";
            this.idReserva.Name = "idReserva";
            this.idReserva.ReadOnly = true;
            // 
            // PlacaTaxi
            // 
            this.PlacaTaxi.HeaderText = "Placa del Taxi";
            this.PlacaTaxi.Name = "PlacaTaxi";
            this.PlacaTaxi.ReadOnly = true;
            // 
            // puntoDestino
            // 
            this.puntoDestino.HeaderText = "Punto destino";
            this.puntoDestino.Name = "puntoDestino";
            this.puntoDestino.ReadOnly = true;
            // 
            // llegada
            // 
            this.llegada.HeaderText = "Punto Origen";
            this.llegada.Name = "llegada";
            this.llegada.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de viaje";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // NumeroMaletas
            // 
            this.NumeroMaletas.HeaderText = "Número de maletas";
            this.NumeroMaletas.Name = "NumeroMaletas";
            this.NumeroMaletas.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar Reserva";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar Reserva";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // textPuntoOrigen
            // 
            this.textPuntoOrigen.Location = new System.Drawing.Point(401, 194);
            this.textPuntoOrigen.Name = "textPuntoOrigen";
            this.textPuntoOrigen.Size = new System.Drawing.Size(103, 20);
            this.textPuntoOrigen.TabIndex = 32;
            // 
            // textPuntoDestino
            // 
            this.textPuntoDestino.Location = new System.Drawing.Point(648, 195);
            this.textPuntoDestino.Name = "textPuntoDestino";
            this.textPuntoDestino.Size = new System.Drawing.Size(111, 20);
            this.textPuntoDestino.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Listado de reserva";
            // 
            // textCedula
            // 
            this.textCedula.AutoSize = true;
            this.textCedula.BackColor = System.Drawing.Color.Transparent;
            this.textCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCedula.Location = new System.Drawing.Point(668, 98);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(88, 17);
            this.textCedula.TabIndex = 35;
            this.textCedula.Text = "0302522202";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Apellido:";
            // 
            // textApellido
            // 
            this.textApellido.AutoSize = true;
            this.textApellido.BackColor = System.Drawing.Color.Transparent;
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(365, 98);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(117, 17);
            this.textApellido.TabIndex = 37;
            this.textApellido.Text = "KEVIN AREVALO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "Placa del taxi: ";
            // 
            // ComboBoxTaxi
            // 
            this.ComboBoxTaxi.FormattingEnabled = true;
            this.ComboBoxTaxi.Location = new System.Drawing.Point(173, 191);
            this.ComboBoxTaxi.Name = "ComboBoxTaxi";
            this.ComboBoxTaxi.Size = new System.Drawing.Size(88, 21);
            this.ComboBoxTaxi.TabIndex = 40;
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(173, 144);
            this.bb.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.bb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(88, 20);
            this.bb.TabIndex = 41;
            this.bb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 583);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.ComboBoxTaxi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textPuntoDestino);
            this.Controls.Add(this.textPuntoOrigen);
            this.Controls.Add(this.DataGridReservas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeroMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fechaViaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaViaje;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TextNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeroMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DataGridReservas;
        private System.Windows.Forms.TextBox textPuntoOrigen;
        private System.Windows.Forms.TextBox textPuntoDestino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaTaxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroMaletas;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Label textCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label textApellido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBoxTaxi;
        private System.Windows.Forms.NumericUpDown bb;
    }
}