using Microsoft.Win32;
using System;
using System.Collections;

namespace ProductKeyWindowsProyectoA
{
    // Para versiones de Windows 7 o inferiores o Windows 8 o superiores
    public enum VersionDigitalProductID
    {
        // Versiones Windows 7 o inferiores
        hastaWindows7,
        // Versiones Windows 8 o superiores
        Windows8EnAdelante
    }

    public static class Decodificar
    {
        public static string ObtenerProductKeyRegistro(bool DigitalProductId4, bool obtenerSoloValorHex)
        {            
            var claveRegistroLM =
                RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem
                    ? RegistryView.Registry64
                    : RegistryView.Registry32);
            var valorRegistro = claveRegistroLM.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion")?.GetValue("DigitalProductId");
            if (DigitalProductId4)
                valorRegistro = claveRegistroLM.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion")?.GetValue("DigitalProductId4");
            if (valorRegistro == null)
                if (DigitalProductId4)
                    return "Error al obtener la clave de registro DigitalProductId4";
                else       
                    return "Error al obtener la clave de registro DigitalProductId";
            
            var valorClaveDigitalProductID = (byte[])valorRegistro;

            if (!obtenerSoloValorHex)
            {
                
                claveRegistroLM.Close();
                // Obtenemos la versión de Windows del equipo para aplicar un método u otro de decodificación
                var esWindows8OSuperior =
                    Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor >= 2
                    ||
                    Environment.OSVersion.Version.Major > 6;
                return GetWindowsProductKeyFromDigitalProductId(valorClaveDigitalProductID,
                    esWindows8OSuperior ? VersionDigitalProductID.Windows8EnAdelante : VersionDigitalProductID.hastaWindows7);
            }
            else
                return BitConverter.ToString(valorClaveDigitalProductID);
        }

        public static string GetWindowsProductKeyFromDigitalProductId(byte[] digitalProductId, VersionDigitalProductID digitalProductIdVersion)
        {

            var productKey = digitalProductIdVersion == VersionDigitalProductID.Windows8EnAdelante
                ? DecodificarProductKeyWindows8EnAdelante(digitalProductId) 
                : DecodificarProductKeyHastaWindows7(digitalProductId);
            return productKey;
        }

        private static string DecodificarProductKeyHastaWindows7(byte[] digitalProductId)
        {
            const int inicioKey = 52;
            const int finKey = inicioKey + 15;
            var digits = new[]
            {
                'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'M', 'P', 'Q', 'R',
                'T', 'V', 'W', 'X', 'Y', '2', '3', '4', '6', '7', '8', '9',
            };
            const int longitudDecodificar = 29;
            const int longitudCadenaDecodificar = 15;
            var caracteresDecodificados = new char[longitudDecodificar];
            var hexPid = new ArrayList();
            for (var i = inicioKey; i <= finKey; i++)
            {
                hexPid.Add(digitalProductId[i]);
            }
            for (var i = longitudDecodificar - 1; i >= 0; i--)
            {
                // Cada sexto carácter es un separador
                if ((i + 1) % 6 == 0)
                {
                    caracteresDecodificados[i] = '-';
                }
                else
                {
                    // Decodificamos
                    var digitMapIndex = 0;
                    for (var j = longitudCadenaDecodificar - 1; j >= 0; j--)
                    {
                        var byteValue = (digitMapIndex << 8) | (byte)hexPid[j];
                        hexPid[j] = (byte)(byteValue / 24);
                        digitMapIndex = byteValue % 24;
                        caracteresDecodificados[i] = digits[digitMapIndex];
                    }
                }
            }
            return new string(caracteresDecodificados);
        }

        public static string DecodificarProductKeyWindows8EnAdelante(byte[] digitalProductId)
        {
            var key = String.Empty;
            const int desplazaKey = 52;
            var esWindows8 = (byte)((digitalProductId[66] / 6) & 1);
            digitalProductId[66] = (byte)((digitalProductId[66] & 0xf7) | (esWindows8 & 2) * 4);

            const string digitos = "BCDFGHJKMPQRTVWXY2346789";
            var ultimo = 0;
            for (var i = 24; i >= 0; i--)
            {
                var actual = 0;
                for (var j = 14; j >= 0; j--)
                {
                    actual = actual*256;
                    actual = digitalProductId[j + desplazaKey] + actual;
                    digitalProductId[j + desplazaKey] = (byte)(actual/24);
                    actual = actual%24;
                    ultimo = actual;
                }
                key = digitos[actual] + key;
            }

            var key1 = key.Substring(1, ultimo);
            var key2 = key.Substring(ultimo + 1, key.Length - (ultimo + 1));
            key = key1 + "N" + key2;

            for (var i = 5; i < key.Length; i += 6)
            {
                key = key.Insert(i, "-");
            }

            return key;
        }
    }
}
