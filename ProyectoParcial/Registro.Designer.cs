namespace ProyectoParcial
{
    partial class Registro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lista = new System.Windows.Forms.ListView();
            this.marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.placa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matriculado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.txtLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label2.Location = new System.Drawing.Point(52, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label3.Location = new System.Drawing.Point(52, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label4.Location = new System.Drawing.Point(243, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de placa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label5.Location = new System.Drawing.Point(243, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matriculado:";
            // 
            // Lista
            // 
            this.Lista.BackColor = System.Drawing.Color.White;
            this.Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.marca,
            this.modelo,
            this.color,
            this.placa,
            this.matriculado});
            this.Lista.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.Lista.HideSelection = false;
            this.Lista.Location = new System.Drawing.Point(129, 205);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(509, 158);
            this.Lista.TabIndex = 7;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.View = System.Windows.Forms.View.Details;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // marca
            // 
            this.marca.Text = "Marca";
            this.marca.Width = 70;
            // 
            // modelo
            // 
            this.modelo.Text = "Modelo";
            this.modelo.Width = 97;
            // 
            // color
            // 
            this.color.Text = "Color";
            this.color.Width = 79;
            // 
            // placa
            // 
            this.placa.Text = "Numero de placa";
            this.placa.Width = 139;
            // 
            // matriculado
            // 
            this.matriculado.Text = "Matriculado";
            this.matriculado.Width = 103;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(118, 65);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 8;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(118, 116);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 20);
            this.txtmodelo.TabIndex = 9;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(118, 166);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(100, 20);
            this.txtcolor.TabIndex = 10;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(378, 65);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(100, 20);
            this.txtplaca.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(378, 114);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 16;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(524, 58);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(87, 23);
            this.Agregar.TabIndex = 18;
            this.Agregar.Text = "Registrar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Location = new System.Drawing.Point(167, 189);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(0, 13);
            this.txtLabel.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(524, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProyectoParcial.Properties.Resources.istockphoto_1205276209_170667a;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CarOn;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 90;
            this.iconPictureBox1.Location = new System.Drawing.Point(15, 234);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(90, 94);
            this.iconPictureBox1.TabIndex = 24;
            this.iconPictureBox1.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 428);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.ColumnHeader marca;
        private System.Windows.Forms.ColumnHeader modelo;
        private System.Windows.Forms.ColumnHeader color;
        private System.Windows.Forms.ColumnHeader placa;
        private System.Windows.Forms.ColumnHeader matriculado;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}