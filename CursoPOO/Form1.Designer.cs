namespace CursoPOO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            label1 = new Label();
            txtDireccion = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtCedula = new TextBox();
            label4 = new Label();
            txtEdad = new TextBox();
            label5 = new Label();
            dtpFechaNac = new DateTimePicker();
            btnSalir = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtNombre.ForeColor = Color.RoyalBlue;
            txtNombre.Location = new Point(185, 9);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 30);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(162, 22);
            label1.TabIndex = 1;
            label1.Text = "Nombre Completo:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDireccion.AutoSize = true;
            txtDireccion.Font = new Font("Times New Roman", 12F);
            txtDireccion.Location = new Point(553, 13);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(95, 22);
            txtDireccion.TabIndex = 3;
            txtDireccion.Text = "Direccion:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.RoyalBlue;
            textBox1.Location = new Point(654, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 30);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(562, 55);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 7;
            label2.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTelefono.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtTelefono.ForeColor = Color.RoyalBlue;
            txtTelefono.Location = new Point(654, 52);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(236, 30);
            txtTelefono.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(-1, 60);
            label3.Name = "label3";
            label3.Size = new Size(175, 22);
            label3.TabIndex = 5;
            label3.Text = "Cedula de Identidad:";
            label3.Click += label3_Click;
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtCedula.ForeColor = Color.RoyalBlue;
            txtCedula.Location = new Point(185, 51);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(236, 30);
            txtCedula.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(591, 97);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 9;
            label4.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEdad.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtEdad.ForeColor = Color.RoyalBlue;
            txtEdad.Location = new Point(654, 94);
            txtEdad.Name = "txtEdad";
            txtEdad.ReadOnly = true;
            txtEdad.Size = new Size(236, 30);
            txtEdad.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(12, 94);
            label5.Name = "label5";
            label5.Size = new Size(153, 22);
            label5.TabIndex = 11;
            label5.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(185, 94);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(306, 27);
            dtpFechaNac.TabIndex = 12;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalir.BackColor = Color.OrangeRed;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(841, 509);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(646, 509);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 29);
            btnSave.TabIndex = 14;
            btnSave.Text = "Guardar Cambios";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 550);
            Controls.Add(btnSave);
            Controls.Add(btnSalir);
            Controls.Add(dtpFechaNac);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEdad);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtCedula);
            Controls.Add(txtDireccion);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label txtDireccion;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtCedula;
        private Label label4;
        private TextBox txtEdad;
        private Label label5;
        private DateTimePicker dtpFechaNac;
        private Button btnSalir;
        private Button btnSave;
    }
}
