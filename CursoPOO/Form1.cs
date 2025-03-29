using SysDataAccess.Entidades;

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
                MessageBox.Show(estudiante.MostrarInfo());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AsignarDatos()
        {
            estudiante.NombreCompleto = txtNombre.Text;
            estudiante.Direccion = txtDireccion.Text;
            estudiante.Dni = txtCedula.Text;
            estudiante.Telefono = txtTelefono.Text;
            estudiante.FechaNacimiento = dtpFechaNac.Value;

            txtEdad.Text = estudiante.Edad.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
