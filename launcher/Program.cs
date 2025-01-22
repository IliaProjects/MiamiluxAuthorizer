
using System.Drawing.Text;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace launcher
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);



            /*PrivateFontCollection pfcMedium = new PrivateFontCollection();
            int fontLength = Properties.Resources.Jost_Medium.Length;
            byte[] fontData = Properties.Resources.Jost_Medium;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);
            pfcMedium.AddMemoryFont(data, fontLength);
            Application.SetDefaultFont(new Font(pfcMedium.Families[0], 10));*/

            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm()/*Form1()*/);
        }
    }
}