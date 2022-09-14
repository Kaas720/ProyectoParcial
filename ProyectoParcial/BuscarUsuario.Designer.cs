namespace ProyectoParcial
{
    partial class BuscarUsuario
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
            this.dataCliente = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txCedula = new System.Windows.Forms.TextBox();
            this.textCedula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ckCedula = new System.Windows.Forms.RadioButton();
            this.ckNombre = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCAR USUARIO";
            // 
            // dataCliente
            // 
            this.dataCliente.AllowUserToAddRows = false;
            this.dataCliente.AllowUserToDeleteRows = false;
            this.dataCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.nombre,
            this.apellido});
            this.dataCliente.Location = new System.Drawing.Point(12, 144);
            this.dataCliente.Name = "dataCliente";
            this.dataCliente.ReadOnly = true;
            this.dataCliente.Size = new System.Drawing.Size(571, 294);
            this.dataCliente.TabIndex = 1;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cedula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // txCedula
            // 
            this.txCedula.Location = new System.Drawing.Point(84, 100);
            this.txCedula.Name = "txCedula";
            this.txCedula.Size = new System.Drawing.Size(153, 20);
            this.txCedula.TabIndex = 2;
            // 
            // textCedula
            // 
            this.textCedula.AutoSize = true;
            this.textCedula.Location = new System.Drawing.Point(22, 103);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(56, 13);
            this.textCedula.TabIndex = 3;
            this.textCedula.Text = "CEDULA: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(312, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(476, 100);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ckCedula
            // 
            this.ckCedula.AutoSize = true;
            this.ckCedula.Checked = true;
            this.ckCedula.Location = new System.Drawing.Point(205, 67);
            this.ckCedula.Name = "ckCedula";
            this.ckCedula.Size = new System.Drawing.Size(77, 17);
            this.ckCedula.TabIndex = 7;
            this.ckCedula.TabStop = true;
            this.ckCedula.Text = "Por Cedula";
            this.ckCedula.UseVisualStyleBackColor = true;
            this.ckCedula.CheckedChanged += new System.EventHandler(this.ckCedula_CheckedChanged);
            // 
            // ckNombre
            // 
            this.ckNombre.AutoSize = true;
            this.ckNombre.Location = new System.Drawing.Point(288, 67);
            this.ckNombre.Name = "ckNombre";
            this.ckNombre.Size = new System.Drawing.Size(81, 17);
            this.ckNombre.TabIndex = 8;
            this.ckNombre.Text = "Por Nombre";
            this.ckNombre.UseVisualStyleBackColor = true;
            this.ckNombre.CheckedChanged += new System.EventHandler(this.ckNombre_CheckedChanged);
            // 
            // BuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.ckNombre);
            this.Controls.Add(this.ckCedula);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.txCedula);
            this.Controls.Add(this.dataCliente);
            this.Controls.Add(this.label1);
            this.Name = "BuscarUsuario";
            this.Text = "BuscarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataCliente;
        private System.Windows.Forms.TextBox txCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.Label textCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton ckCedula;
        private System.Windows.Forms.RadioButton ckNombre;
    }
}