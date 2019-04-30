using AppManager.Repository;
using AppManager.Util;
using AppManager.View;
using AppManager.View.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Identify.Device = DeviceRepository.Instance.GetMasterDevice();

            Application.Run(new HomeMain());
        }
    }
}
