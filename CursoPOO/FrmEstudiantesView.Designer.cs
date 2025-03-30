namespace CursoPOO
{
    partial class FrmEstudiantesView
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
            components = new System.ComponentModel.Container();
            pnlContainer = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dtgListaEstudiante = new DataGridView();
            nombreCompletoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsData = new BindingSource(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListaEstudiante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsData).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(64, 64, 64);
            pnlContainer.Controls.Add(btnEliminar);
            pnlContainer.Controls.Add(btnEditar);
            pnlContainer.Controls.Add(btnAgregar);
            pnlContainer.Dock = DockStyle.Top;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1069, 71);
            pnlContainer.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Left;
            btnEliminar.FlatAppearance.BorderColor = Color.Brown;
            btnEliminar.FlatAppearance.BorderSize = 3;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(318, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(159, 71);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Left;
            btnEditar.FlatAppearance.BorderColor = Color.DarkOrange;
            btnEditar.FlatAppearance.BorderSize = 3;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(159, 0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(159, 71);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Dock = DockStyle.Left;
            btnAgregar.FlatAppearance.BorderColor = Color.White;
            btnAgregar.FlatAppearance.BorderSize = 3;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(0, 0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 71);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtgListaEstudiante
            // 
            dtgListaEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgListaEstudiante.AutoGenerateColumns = false;
            dtgListaEstudiante.BackgroundColor = Color.White;
            dtgListaEstudiante.BorderStyle = BorderStyle.None;
            dtgListaEstudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaEstudiante.Columns.AddRange(new DataGridViewColumn[] { nombreCompletoDataGridViewTextBoxColumn, edadDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn });
            dtgListaEstudiante.DataSource = bsData;
            dtgListaEstudiante.Location = new Point(143, 77);
            dtgListaEstudiante.Name = "dtgListaEstudiante";
            dtgListaEstudiante.RowHeadersWidth = 51;
            dtgListaEstudiante.Size = new Size(819, 317);
            dtgListaEstudiante.TabIndex = 1;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            nombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto";
            nombreCompletoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            nombreCompletoDataGridViewTextBoxColumn.Width = 125;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            edadDataGridViewTextBoxColumn.MinimumWidth = 6;
            edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            edadDataGridViewTextBoxColumn.ReadOnly = true;
            edadDataGridViewTextBoxColumn.Width = 125;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            dniDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsData
            // 
            bsData.DataSource = typeof(SysDataAccess.Entidades.Estudiante);
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FrmEstudiantesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1069, 469);
            Controls.Add(dtgListaEstudiante);
            Controls.Add(pnlContainer);
            Name = "FrmEstudiantesView";
            Text = "Datos de los estudiantes";
            Load += FrmEstudiantesView_Load;
            pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgListaEstudiante).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dtgListaEstudiante;
        private DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private BindingSource bsData;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}