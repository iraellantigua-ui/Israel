using System;
using System.Globalization;
using System.Windows.Forms;
using WalkiriaPapeleria.Forms;

namespace WalkiriaPapeleria
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configurar cultura para República Dominicana
            CultureInfo culturaRD = new CultureInfo("es-DO");
            culturaRD.NumberFormat.CurrencySymbol = "RD$";
            culturaRD.NumberFormat.CurrencyDecimalSeparator = ".";
            culturaRD.NumberFormat.CurrencyGroupSeparator = ",";
            CultureInfo.DefaultThreadCurrentCulture = culturaRD;
            CultureInfo.DefaultThreadCurrentUICulture = culturaRD;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}