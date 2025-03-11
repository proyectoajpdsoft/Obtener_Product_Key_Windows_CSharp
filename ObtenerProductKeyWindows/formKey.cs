using System;
using System.Windows.Forms;

namespace ProductKeyWindowsProyectoA
{
    public partial class formKey : Form
    {
        public formKey()
        {
            InitializeComponent();
        }

        private void btnFromProductKey_Click(object sender, EventArgs e)
        {
            var form = new formDecodificar();
            form.ShowDialog();
        }

        private void btCopiarDigitalProductID_Click(object sender, EventArgs e)
        {
            // Seleccionamos la clave obtenida
            txtKeyDigitalProductId.SelectionStart = 0;
            txtKeyDigitalProductId.SelectionLength = txtKeyDigitalProductId.Text.Length;
            // Copiamos al portapapeles
            txtKeyDigitalProductId.Copy();
        }

        private void btObtenerKeyDigitalProductId_Click(object sender, EventArgs e)
        {
            // Obtenemos el valor de la clave de registro
            // Equipo\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\DigitalProductId
            // Lo decodificamos para mostrarlo en caracteres legibles
            txtKeyDigitalProductId.Text = Decodificar.ObtenerProductKeyRegistro(false, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtenemos el valor de la clave de registro
            // Equipo\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\DigitalProductId4
            // Lo decodificamos para mostrarlo en caracteres legibles
            txtKeyDigitalProductId4.Text = Decodificar.ObtenerProductKeyRegistro(true, false);
        }

        private void btCopiarDigitalProduct4_Click(object sender, EventArgs e)
        {
            // Seleccionamos la clave obtenida
            txtKeyDigitalProductId4.SelectionStart = 0;
            txtKeyDigitalProductId4.SelectionLength = txtKeyDigitalProductId4.Text.Length;
            // Copiamos al portapapeles
            txtKeyDigitalProductId4.Copy();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
