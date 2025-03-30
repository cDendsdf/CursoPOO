using SysDataAccess.Entidades;
using SysServises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoPOO
{
    public partial class FrmEstudiantesView : Form
    {

        EstuentServices estuentServices = new EstuentServices();
        public FrmEstudiantesView()
        {
            InitializeComponent();
        }

        private void FrmEstudiantesView_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        public void LoadData()
        {
            EstuentServices estuentServices = new EstuentServices();
            bsData.DataSource = estuentServices.GetEstudiantes();
            dtgListaEstudiante.DataSource = bsData;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            using (Form1 frmdatos = new Form1())
            {
                frmdatos.ShowDialog();
                if (frmdatos.DialogResult == DialogResult.OK)  LoadData();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Estudiante itemSeleccionado = bsData.Current as Estudiante;
            if (MessageBox.Show($"Desea eliminar al estudiante {itemSeleccionado.NombreCompleto}","Esta seguro de elimanar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {                
                if (estuentServices.DeleteItem(itemSeleccionado))
                {
                    MessageBox.Show("Estudiante eliminado correctamente","Conexion con sql exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadData();
                }
                else  MessageBox.Show("Lo sentimos no se pudo eliminar el registro contacte con informatica");                
            }
        }
    }
}
