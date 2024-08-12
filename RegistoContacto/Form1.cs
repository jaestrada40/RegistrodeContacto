using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegistoContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos est�n llenos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                lblMensaje.Text = "Por favor, complete todos los campos.";
                lblMensaje.ForeColor = Color.Red; 
                return;
            }

            // Verifica que el nombre solo contenga letras
            if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z\s]+$"))
            {
                lblMensaje.Text = "El nombre solo debe contener letras.";
                lblMensaje.ForeColor = Color.Red;
                return;
            }

            // Validar que el tel�fono solo contenga n�meros y tenga un m�ximo de 8 d�gitos
            if (!Regex.IsMatch(txtTelefono.Text, @"^\d{1,8}$"))
            {
                lblMensaje.Text = "El n�mero de tel�fono debe contener solo n�meros y no m�s de 8 d�gitos.";
                lblMensaje.ForeColor = Color.Red;
                return;
            }

            // Verifica que el correo tenga un formato v�lido
            if (!Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblMensaje.Text = "Por favor, ingrese un correo electr�nico v�lido.";
                lblMensaje.ForeColor = Color.Red;
                return;
            }

            // Agrega los datos al ListBox
            string item = $"{txtNombre.Text} - {txtTelefono.Text} - {txtCorreo.Text}";
            lbListar.Items.Add(item);

            // Limpia los campos
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;

            // Mensaje de �xito
            lblMensaje.Text = "Datos agregados correctamente.";
            lblMensaje.ForeColor = Color.Green; // Mensaje de �xito en verde
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia el ListBox
            lbListar.Items.Clear();

            // Mensaje indicando que el ListBox ha sido limpiado
            lblMensaje.Text = "Listado limpiado correctamente.";
            lblMensaje.ForeColor = Color.Green;
        }
    }
}
