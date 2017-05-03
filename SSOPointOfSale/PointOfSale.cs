#region Imports
using System;
using System.Windows.Forms;
#endregion
#region Program entry point and namespace initialization
namespace SSOPointOfSale
{
    static class PointOfSale
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPointOfSaleForm());
        }
    }
}
#endregion
