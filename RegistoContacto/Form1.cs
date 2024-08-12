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
            // Verifica que todos los campos estén llenos
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

            // Validar que el teléfono solo contenga números y tenga un máximo de 8 dígitos
            if (!Regex.IsMatch(txtTelefono.Text, @"^\d{1,8}$"))
            {
                lblMensaje.Text = "El número de teléfono debe contener solo números y no más de 8 dígitos.";
                lblMensaje.ForeColor = Color.Red;
                return;
            }

            // Verifica que el correo tenga un formato válido
            if (!Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblMensaje.Text = "Por favor, ingrese un correo electrónico válido.";
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

            // Mensaje de éxito
            lblMensaje.Text = "Datos agregados correctamente.";
            lblMensaje.ForeColor = Color.Green; // Mensaje de éxito en verde
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
