using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileDevice;
using MobileDevice.Event;

namespace jaguarTools_2._1
{
    internal class MobileDeviceFunctions
    {
        public iOSDeviceManager manager = new iOSDeviceManager();
        public iOSDevice currentiOSDevice;

        public void BoxShow(string Arg, string Caption)
        {
            MessageBox.Show(Arg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void BoxShowError(string Arg, string Caption)
        {
            MessageBox.Show(Arg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ListenError(object sender, ListenErrorEventHandlerEventArgs args)
        {
            if (args.ErrorType == MobileDevice.Enumerates.ListenErrorEventType.StartListen)
            {
                string ERROR = args.ErrorMessage;
                Exception e = new Exception(ERROR);
                BoxShowError(e.Message, "ERROR");
            }
        }

        public void InitializeDetection()
        {
            string Known = "%USERPROFILE%\\.ssh\\known_hosts";
            if (File.Exists(Known))
            {
                File.Delete(Known);
            }
            string iTunes = "iTunesMobileDevice.dll";
            string X86 = "C:\\Program Files\\Common Files\\Apple\\Mobile Device Support\\" + iTunes + "";
            string X64 = "C:\\Program Files (x86)\\Common Files\\Apple\\Mobile Device Support\\" + iTunes + "";
            if (!Directory.Exists("C:\\Program Files\\Common Files\\Apple\\Mobile Device Support"))
            {
                if (!Directory.Exists("C:\\Program Files (x86)\\Common Files\\Apple\\Mobile Device Support"))
                {
                    BoxShow("Install iTunes or Drivers with 3UTools", "ERROR");
                }
            }
            else
            {
                if (!File.Exists(X86))
                {
                    File.Copy(iTunes, X86);

                }
                if (!File.Exists(X64))
                {
                    File.Copy(iTunes, X64);
                }
            }
        }

  

        

    }
}
