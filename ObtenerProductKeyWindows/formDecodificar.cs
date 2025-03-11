using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductKeyWindowsProyectoA
{
    public partial class formDecodificar : Form
    {
        public formDecodificar()
        {
            InitializeComponent();
        }

        private void btnClearDigitalProductId_Click(object sender, EventArgs e)
        {
            txtValorHex.Clear();
            txtProductKey.Clear();
            txtHexadecimalFormateado.Clear();
        }

        private void tbDigitalProductId_TextChanged(object sender, EventArgs e)
        {
            txtProductKey.Clear();
            txtHexadecimalFormateado.Clear();
        }

        private void DigitalProductIdForm_Load(object sender, EventArgs e)
        {
            lsSO.SelectedIndex = 1;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            // Seleccionamos la clave obtenida
            txtProductKey.SelectionStart = 0;
            txtProductKey.SelectionLength = txtProductKey.Text.Length;
            // Copiamos al portapapeles
            txtProductKey.Copy();
        }

        private void btnParseDigitalProductId_Click(object sender, EventArgs e)
        {
            if (txtValorHex.Text == "")
            {
                MessageBox.Show("Introduzca el valor hexadecimal obtenido de la clave de registro para decodificar.", 
                    "Faltan datos para decodificar...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorHex.Focus();
            }
            else
            {
                try
                {
                    string valorFormatear = txtValorHex.Text.ToLower();

                    // Si se ha introducido "DigitalProductId4"= lo quitamos
                    valorFormatear = valorFormatear.Replace("digitalproductid4", "").Replace("\"", "").Replace("=", "");
                    // Si se ha introducido "DigitalProductId"= lo quitamos
                    valorFormatear = valorFormatear.Replace("digitalproductid", "").Replace("\"", "").Replace("=", "");

                    // Elimininamos posibles saltos de línea, espacios y guiones
                    valorFormatear = valorFormatear.Replace("\\\r\n", "").Replace(" ", "").Replace("-", ",").Trim();

                    // Añadimos "hex:" delante si no se ha añadido
                    if (!valorFormatear.StartsWith("hex:", StringComparison.InvariantCultureIgnoreCase))
                        valorFormatear = "hex:" + valorFormatear;

                    // Convertimos los valores hexadecimales de cadenas delimitadas por comas en una matriz de bytes
                    var valorHexadecimal = valorFormatear.Remove(0, 4).Split(',');

                    txtHexadecimalFormateado.Text = valorFormatear;

                    // Creamos una matriz de bytes a partir de valores hexadecimales
                    var valoresByte = valorHexadecimal.Select(s => Convert.ToByte(s.ToUpper(), 16)).ToArray();
                    txtProductKey.Text = Decodificar.GetWindowsProductKeyFromDigitalProductId(
                        valoresByte,
                        lsSO.SelectedIndex == 0
                            ? VersionDigitalProductID.hastaWindows7
                            : VersionDigitalProductID.Windows8EnAdelante);
                }
                catch (Exception)
                {
                    string mensaje = "Error al decodificar la cadena. Recuerde que debe ser una cadena hexadecimal, " +
                        "obtenida de la exportación de la clave de registro: " + Environment.NewLine +
                        "Equipo\\HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\DigitalProductId";
                    MessageBox.Show(mensaje, "Error al decodificar...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btObtenerDPId_Click(object sender, EventArgs e)
        {
            // Obtenemos el valor de la clave de registro
            // Equipo\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\DigitalProductId
            // Lo decodificamos para mostrarlo en caracteres legibles
            txtValorHex.Text = Decodificar.ObtenerProductKeyRegistro(false, true);
        }

        private void btObtenerDPId4_Click(object sender, EventArgs e)
        {
            // Obtenemos el valor de la clave de registro
            // Equipo\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\DigitalProductId4
            // Lo decodificamos para mostrarlo en caracteres legibles
            txtValorHex.Text = Decodificar.ObtenerProductKeyRegistro(true, true);
        }

        private void btCopiarHex_Click(object sender, EventArgs e)
        {
            // Seleccionamos el hexadecimal obtenido
            txtHexadecimalFormateado.SelectionStart = 0;
            txtHexadecimalFormateado.SelectionLength = txtHexadecimalFormateado.Text.Length;
            // Copiamos al portapapeles
            txtHexadecimalFormateado.Copy();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
