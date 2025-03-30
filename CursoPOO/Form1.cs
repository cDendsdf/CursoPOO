using Microsoft.Identity.Client;
using SysDataAccess.Entidades;
using SysServises;

namespace CursoPOO
{
    public partial class Form1 : Form
    {
        Estudiante estudiante = new Estudiante();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                AsignarDatos();
                SaveData(estudiante);
                //MessageBox.Show(estudiante.MostrarInfo());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AsignarDatos()
        {
            estudiante = new Estudiante();

            estudiante.NombreCompleto = txtNombre.Text;
            estudiante.Direccion = txtDirecc.Text;
            estudiante.Dni = txtCedula.Text;
            estudiante.Telefono = txtTelefono.Text;
            estudiante.FechaNacimiento = dtpFechaNac.Value;

            txtEdad.Text = estudiante.Edad.ToString();
        }


        private void SaveData(Estudiante estudiante)
        {
            EstuentServices estuentServices = new EstuentServices();

            estudiante.Direccion = txtDirecc.Text;
            if(estuentServices.InsertEstuent(estudiante) == true)
            {
                MessageBox.Show("se ha registrado el estudiante en la base de datos","Conectando con Sql",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
