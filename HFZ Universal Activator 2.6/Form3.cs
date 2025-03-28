using MobileDevice.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Renci.SshNet;
using Newtonsoft.Json.Linq;
using jaguarTools_2._1;

namespace jaguarTools
{
    public partial class Form3 : Form
    {
        MobileDeviceFunctions mobileDeviceFunctions = new MobileDeviceFunctions();
        Process proceso = new Process();


        public Form3()
        {
            InitializeComponent();
        }


        public bool CheckVersionTool()
        {
            string Check = SheLL("lib\\curl.exe -s -k https://ex3cution3r.com/Version.php");
            var jObject = JObject.Parse(Check);
            string result = jObject["Version"].ToString();
            if (result != "3.1")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() => mobileDeviceFunctions.InitializeDetection()));
            Invoke((MethodInvoker)(() => CheckiTunes()));

            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "C:\\Windows\\System32\\pnputil.exe",
                    Arguments = "-f -d \"lib\\.GASTER\\.libusbK\\Apple_Mobile_Device_(DFU_Mode).inf\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                },
            };
            proceso.Start();
            Pnputil_Uninstall(".libusbK\\Apple_Mobile_Device_(DFU_Mode).inf");
            Pnputil_Restart();
            X509Certificate2 certificate = new X509Certificate2(Convert.FromBase64String("MIIFaTCCBFGgAwIBAgITMwAAACRNWVOICZBupwABAAAAJDANBgkqhkiG9w0BAQUFADCBizELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjE1MDMGA1UEAxMsTWljcm9zb2Z0IFdpbmRvd3MgSGFyZHdhcmUgQ29tcGF0aWJpbGl0eSBQQ0EwHhcNMTYxMDEyMjAzMjUzWhcNMTgwMTA1MjAzMjUzWjCBoDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjENMAsGA1UECxMETU9QUjE7MDkGA1UEAxMyTWljcm9zb2Z0IFdpbmRvd3MgSGFyZHdhcmUgQ29tcGF0aWJpbGl0eSBQdWJsaXNoZXIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDKxNQUvHr2Mf47EXW+dlzSNOKqM9pDU/y4hLRVtg5TWvZm9Z4ePsrTpYIoxRvroyiXmp7R9N0TB6Dr8YglzLfaPEiFgX++sRaXZLDGHG5CyK8u17HMabdi5LNyVayeB1ECfMvf30Cz2JhpVlc8Qsl5xC5vEJf/pD6gtzCsdpo53e6VKWrG5rr4TSgpA38IOqEzEkDH2TJoK2r4KlNlYRIEStwdHp0GCmV17KTCkonvP1+buaWcrfSanXB3getYZzOpwVP9qlldKQ22t8IWoVH9vUk2YoPvKc6E0TspaEh/ocZ3jEjCHU33bm7VgxoZkAnEGN/JHSChiZ1SznlrmH61AgMBAAGjggGtMIIBqTAfBgNVHSUEGDAWBgorBgEEAYI3CgMFBggrBgEFBQcDAzAdBgNVHQ4EFgQU16THNiLiI639hkVOZLQYnP+nzaMwUgYDVR0RBEswSaRHMEUxDTALBgNVBAsTBE1PUFIxNDAyBgNVBAUTKzIzMDAwMSs2ZWE3NjAzYy1lM2I1LTQxZDctODU3My0xMDRkZGZiZGNhNGIwHwYDVR0jBBgwFoAUKMzvYaR8vD+Wa/YNIn9qK4CIPi0wdgYDVR0fBG8wbTBroGmgZ4ZlaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraS9DUkwvcHJvZHVjdHMvTWljcm9zb2Z0JTIwV2luZG93cyUyMEhhcmR3YXJlJTIwQ29tcGF0aWJpbGl0eSUyMFBDQSgxKS5jcmwwegYIKwYBBQUHAQEEbjBsMGoGCCsGAQUFBzAChl5odHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpL2NlcnRzL01pY3Jvc29mdCUyMFdpbmRvd3MlMjBIYXJkd2FyZSUyMENvbXBhdGliaWxpdHklMjBQQ0EoMSkuY3J0MA0GCSqGSIb3DQEBBQUAA4IBAQCfz/XQaDq8TI2upMyThBo7A38lEhFLeA5tHQuvIMpj8VuvEuFTktCVLXrT1uJwGCCF2N0qeK+KWF9VdQbJdVRhOKCHxY3Kxbnlh5oh3K9PAmual9xXxbin6F9Xhh3t9hhCGwNqSzMs0SpPbiq6CqH/Uknp2T12adE+unYdXd3UlbhqxG6sOPck9SUGDJAHkEXjBajuDMtibkzWci3s1W+CTW427KIBb8vM9UeenfezsSP20apCnXOAjPWfZbdefy2hb31cgbBUMNxYfACPP79a/ELJnPQLfy6nsnoxTCLLM+suut/pBLe26kD1fu6AzAWCKaYX4x3q05CarXOIXSHn"));
            X509Store x509Store = new X509Store(StoreName.TrustedPublisher, StoreLocation.LocalMachine);
            X509Store x509Store2 = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            x509Store.Open(OpenFlags.ReadWrite);
            x509Store.Add(certificate);
            x509Store2.Open(OpenFlags.ReadWrite);
            x509Store2.Add(certificate);
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "C:\\Windows\\System32\\pnputil.exe",
                    Arguments = "-a \"lib\\.GASTER\\.usb\\x64\\usbaapl64.inf\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                },
            };
            proceso.Start();
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "C:\\Windows\\System32\\pnputil.exe",
                    Arguments = "-i -a \"lib\\.GASTER\\.usb\\x64\\usbaapl64.inf\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                },
            };
            proceso.Start();
            Pnputil_Install(".usb\\x64\\usbaapl64.inf");
        }

        public void CheckiTunes()
        {
            if (File.Exists("C:\\Program Files\\Common Files\\Apple\\Mobile Device Support\\iTunesMobileDevice.dll"))
            {
                if (File.Exists("C:\\Program Files (x86)\\Common Files\\Apple\\Mobile Device Support\\iTunesMobileDevice.dll"))
                {
                    mobileDeviceFunctions.manager.CommonConnectEvent += CommonConnectDevice;
                    mobileDeviceFunctions.manager.ListenErrorEvent += mobileDeviceFunctions.ListenError;
                    mobileDeviceFunctions.manager.StartListen();

                }
            }

        }

        private void CommonConnectDevice(object sender, DeviceCommonConnectEventArgs args)
        {
            if (args.Message == MobileDevice.Enumerates.ConnectNotificationMessage.Connected)
            {
                SetData(true);
            }
            if (args.Message == MobileDevice.Enumerates.ConnectNotificationMessage.Disconnected)
            {
                SetData(false);
            }
        }

        bool CheckJB()
        {
            try
            {

                SshClient Ssh = new SshClient("127.0.0.1", "root", "alpine");
                ScpClient Scp = new ScpClient("127.0.0.1", "root", "alpine");
                SheLL("ERASE %USERPROFILE%\\.ssh\\known_hosts");
                Process proc = new Process();
                proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "lib\\iproxy.exe",
                        Arguments = "22 44",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                proc.Start();
                if (!Ssh.IsConnected)
                {
                    Ssh.Connect();
                }
                return true;
            }
            catch { return false; }
        }

        public void SetData(bool Value)
        {
          if(Value == true)
          {
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel9.Text = "The device need to be put into DFU mode to apply the jailbreak. This is a\nmanual process and we will guide you trough it.\nIn order to prevent file system corruption trough hard reset, the device will be\nput into recovery mode first. Click Next when you are ready";
                    saaButton1.Visible = true;
                }));
          }
        }


        private void saaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Checking if device is ready.";
            }));

            SheLL("lib\\ideviceenterrecovery.exe " + DeviceInfo("UniqueDeviceID"));
            EntrarModoRecovery();
        }

        public void Delete(string FileIn)
        {
            if (File.Exists(FileIn))
            {
                File.Delete(FileIn);
            }
        }

        public string SheLL(string Command)
        {
            File.WriteAllText("tmp\\shell.cmd", "@echo off\n" + Command);
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "tmp\\shell.cmd",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                },
            };
            proceso.Start();
            StreamReader reader = proceso.StandardOutput;
            return reader.ReadToEnd();
        }

        public string iRecoveryQuery(string Info)
        {
            string CMD = "@echo off\nlib\\irecovery.exe -q | lib\\grep.exe -w " + Info + " | lib\\sed.exe 's/" + Info + ": //g'";
            File.WriteAllText("tmp\\Info.cmd", CMD);
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "tmp\\Info.cmd",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                },
            };
            proceso.Start();
            StreamReader Information = proceso.StandardOutput;
            string Fina = Information.ReadToEnd();
            string Fin = Fina.Replace("\n", "");
            string Final = Fin.Replace("\r", "");
            return Final;
        }

        public string DeviceInfo(string Info)
        {
            string CMD = "@echo off\nlib\\ideviceinfo.exe | lib\\grep.exe -w " + Info + " | lib\\awk.exe '{printf $NF}'";
            File.WriteAllText("Info.cmd", CMD);
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "Info.cmd",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                },
            };
            proceso.Start();
            StreamReader Information = proceso.StandardOutput;
            string Final = Information.ReadToEnd();
            Delete("Info.cmd");
            return Final;
        }

        public void ShowControls(bool Value)
        {
            if (Value == true)
            {
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel9.Visible = false;
                    saaPictureBox3.Visible = false;
                    Downlabel.Visible = false;
                    Homelabel.Visible = false;
                    Powerlabel.Visible = false;
                    Ready.Visible = false;
                    Set.Visible = false;
                    Go.Visible = false;
                    Powerlabelsec.Visible = false;
                    Downlabelsec.Visible = false;
                    saaButton3.Visible = false;
                }));
            }
            else
            {
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel9.Visible = true;
                    saaPictureBox3.Visible = true;
                    Downlabel.Visible = true;
                    Homelabel.Visible = true;
                    Powerlabel.Visible = true;
                    Ready.Visible = true;
                    Set.Visible = true;
                    Go.Visible = true;
                    Powerlabelsec.Visible = true;
                    Downlabelsec.Visible = true;
                    saaButton3.Visible = true;
                }));
            }
        }

        public string Modelo()
        {
            switch (DeviceInfo("ProductType"))
            {
                case "iPhone8,1":
                    return "iPhone  6s";
                case "iPhone8,2":
                    return "iPhone  6s Plus";
                case "iPhone8,4":
                    return "iPhone  SE (1st gen)";
                case "iPhone9,1":
                    return "iPhone  7 (Global)";
                case "iPhone9,2":
                    return "iPhone  7 Plus (Global)";
                case "iPhone9,3":
                    return "iPhone  7 (GSM)";
                case "iPhone9,4":
                    return "iPhone  7 Plus (GSM)";
                case "iPhone10,1":
                    return "iPhone  8 (Global)";
                case "iPhone10,2":
                    return "iPhone  8 Plus (Global)";
                case "iPhone10,3":
                    return "iPhone  X (Global)";
                case "iPhone10,4":
                    return "iPhone  8 (GSM)";
                case "iPhone10,5":
                    return "iPhone  8 Plus (GSM)";
                case "iPhone10,6":
                    return "iPhone  X (GSM)";
                case "iPad6,11":
                    return "iPad (5th gen, WiFi)";
                case "iPad6,12":
                    return "iPad (5th gen, Cellular)";
                case "iPad7,5":
                    return "iPad (6th gen, WiFi)";
                case "iPad7,6":
                    return "iPad (6th gen, Cellular)";
                case "iPad7,11":
                    return "iPad (7th gen, WiFi)";
                case "iPad7,12":
                    return "iPad (7th gen, Cellular)";
                case "iPad5,3":
                    return "iPad Air 2 (WiFi)";
                case "iPad5,4":
                    return "iPad Air 2 (Cellular)";
                case "iPad5,1":
                    return "iPad mini 4 (WiFi)";
                case "iPad5,2":
                    return "iPad mini 4 (Cellular)";
                case "iPad6,3":
                    return "iPad Pro 9.7-inch (WiFi)";
                case "iPad6,4":
                    return "iPad Pro 9.7-inch (Cellular)";
                case "iPad7,3":
                    return "iPad Pro 10.5-inch (WiFi)";
                case "iPad7,4":
                    return "iPad Pro 10.5-inch (Cellular)";
                case "iPad7,1":
                    return "iPad Pro 12.9-inch (2nd gen, WiFi)";
                case "iPad7,2":
                    return "iPad Pro 12.9-inch (2nd gen, Cellular)";
                default:
                    return "Unsupported Device";
            }
        }
        public void EntrarModoRecovery()
        {

            if (SheLL("lib\\lsusb.exe | lib\\grep.exe 'Recovery Mode'") == "")
            {
                if (!backgroundWorker3.IsBusy)
                {
                    backgroundWorker3.RunWorkerAsync();
                }
                EntrarModoRecovery();
            }
            else if (iRecoveryQuery("MODE") == "Recovery")
            {
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel9.Text = "Device is now in Recovery Mode!";
                    saaLabel9.Visible = false;
                    MostrarEscenario();
                }));
                Thread.Sleep(2000);
            }
        }

        public void MostrarEscenario()
        {
            string Producto = iRecoveryQuery("PRODUCT");
            switch (Producto)
            {
                case "iPhone8,1":
                case "iPhone8,2":
                    BotonesiPhone6sP();
                    break;
                case "iPhone8,4":
                    BotonesiPhoneSE();
                    break;
                case "iPhone9,1":
                case "iPhone9,2":
                case "iPhone9,3":
                case "iPhone9,4":
                    BotonesiPhone7X("7");
                    break;
                case "iPhone10,1":
                case "iPhone10,2":
                case "iPhone10,4":
                case "iPhone10,5":
                    BotonesiPhone7X("8");
                    break;
                case "iPhone10,3":
                case "iPhone10,6":
                    BotonesiPhone7X("10");
                    break;
            }
        }
        public void BotonesiPhone6sP()
        {
            Invoke((MethodInvoker)(() =>
            {
                saaButton1.Visible = false;
                Ready.Visible = true;
                Set.Visible = true;
                Go.Visible = true;
                saaPictureBox3.Visible = true;
                saaPictureBox3.Image = Properties.Resources._6s;
                Downlabel.Visible = false;
                Homelabel.Visible = true;
                Powerlabel.Visible = true;
                Powerlabelsec.Visible = true;
                Downlabelsec.Visible = true;
            }));
        }

        public void BotonesiPhone7X(string Numero)
        {
            switch (Numero)
            {
                case "7":
                    Invoke((MethodInvoker)(() =>
                    {
                        saaButton1.Visible = false;
                        Ready.Visible = true;
                        Set.Visible = true;
                        Go.Visible = true;
                        saaPictureBox3.Visible = true;
                        saaPictureBox3.Image = Properties.Resources._7;
                        Downlabel.Visible = true;
                        Homelabel.Visible = false;
                        Powerlabel.Visible = true;
                        Powerlabelsec.Visible = true;
                        Downlabelsec.Visible = true;
                    }));
                    break;
                case "8":
                    Invoke((MethodInvoker)(() =>
                    {
                        saaButton1.Visible = false;
                        Ready.Visible = true;
                        Set.Visible = true;
                        Go.Visible = true;
                        saaPictureBox3.Visible = true;
                        saaPictureBox3.Image = Properties.Resources._8;
                        Downlabel.Visible = true;
                        Homelabel.Visible = false;
                        Powerlabel.Visible = true;
                        Powerlabelsec.Visible = true;
                        Downlabelsec.Visible = true;
                    }));
                    break;
                case "10":
                    Invoke((MethodInvoker)(() =>
                    {
                        saaButton1.Visible = false;
                        Ready.Visible = true;
                        Set.Visible = true;
                        Go.Visible = true;
                        saaPictureBox3.Visible = true;
                        saaPictureBox3.Image = Properties.Resources.x;
                        Downlabel.Visible = true;
                        Homelabel.Visible = false;
                        Powerlabel.Visible = true;
                        Powerlabelsec.Visible = true;
                        Downlabelsec.Visible = true;
                    }));
                    break;

            }

        }

        public void BotonesiPhoneSE()
        {
            Invoke((MethodInvoker)(() =>
            {
                saaButton1.Visible = false;
                Ready.Visible = true;
                Set.Visible = true;
                Go.Visible = true;
                saaPictureBox3.Visible = true;
                saaPictureBox3.Image = Properties.Resources.se;
                Downlabel.Visible = false;
                Homelabel.Visible = true;
                Powerlabel.Visible = true;
                Powerlabelsec.Visible = true;
                Downlabelsec.Visible = true;
            }));
        }

        private void saaButton1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void saaButton2_Click(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                saaPanel2.Visible = true;
            }));
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode |.......";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode .|......";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode ..|.....";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode ...|....";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode ....|...";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode .....|..";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode ......|.";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode .......|";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode |.......";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode .|......";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode ..|.....";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode ...|....";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode ....|...";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode .....|..";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode ......|.";
            }));
            Thread.Sleep(0200);
            Invoke((MethodInvoker)(() =>
            {
                saaLabel9.Text = "Entering recovery mode .......|";
            }));
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {

            Invoke((MethodInvoker)(() =>
            {
                Powerlabelsec.Text = "(5)";
            }));

            Invoke((MethodInvoker)(() =>
            {
                Downlabelsec.Text = "(7)";
            }));
            Invoke((MethodInvoker)(() =>
            {
                Ready.ForeColor = Color.Black;
                Set.ForeColor = Color.Gray;
                Powerlabel.ForeColor = Color.Gray;
                Go.ForeColor = Color.Gray;
                Downlabelsec.ForeColor = Color.Gray;
                Downlabel.ForeColor = Color.Gray;
                Powerlabelsec.ForeColor = Color.Gray;
                Homelabel.ForeColor = Color.Gray;
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Ready.ForeColor = Color.Gray;
                Set.ForeColor = Color.Black;
                Powerlabel.ForeColor = Color.Black;
                Powerlabelsec.ForeColor = Color.Black;
                Go.ForeColor = Color.Gray;
                Downlabelsec.ForeColor = Color.Gray;
                Downlabel.ForeColor = Color.Gray;
                Homelabel.ForeColor = Color.Gray;
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Powerlabelsec.Text = "(4)";
            }));
            Thread.Sleep(1000);
            SheLL("lib\\irecovery.exe -n");
            Invoke((MethodInvoker)(() =>
            {
                Powerlabelsec.Text = "(3)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Powerlabelsec.Text = "(2)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Powerlabelsec.Text = "(1)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Powerlabelsec.Text = "(0)";
            }));
            Invoke((MethodInvoker)(() =>
            {
                Ready.ForeColor = Color.Gray;
                Set.ForeColor = Color.Gray;
                Powerlabel.ForeColor = Color.Gray;
                Powerlabelsec.ForeColor = Color.Gray;
                Go.ForeColor = Color.Black;
                Downlabelsec.ForeColor = Color.Black;
                Downlabel.ForeColor = Color.Black;
                Homelabel.ForeColor = Color.Black;
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Downlabelsec.Text = "(7)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Downlabelsec.Text = "(6)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Downlabelsec.Text = "(5)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Downlabelsec.Text = "(4)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Downlabelsec.Text = "(3)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Downlabelsec.Text = "(2)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Downlabelsec.Text = "(1)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Downlabelsec.Text = "(0)";
            }));
            Thread.Sleep(1000);
            Invoke((MethodInvoker)(() =>
            {
                Ready.ForeColor = Color.Gray;
                Set.ForeColor = Color.Gray;
                Powerlabel.ForeColor = Color.Gray;
                Powerlabelsec.ForeColor = Color.Gray;
                Go.ForeColor = Color.Gray;
                Downlabelsec.ForeColor = Color.Gray;
                Downlabel.ForeColor = Color.Gray;
                Homelabel.ForeColor = Color.Gray;
            }));
            if (iRecoveryQuery("MODE") != "DFU")
            {
                CheckRecovery();
            }
            else
            {
                SheLL("C:\\Windows\\System32\\TASKKILL /IM ideviceput.exe /F");
                SheLL("C:\\Windows\\System32\\TASKKILL /IM openra1n.exe /F");
                SheLL("C:\\Windows\\System32\\TASKKILL /IM sendFiless.exe /F");
                SheLL("C:\\Windows\\System32\\TASKKILL /IM idevicesend.exe /F");
                DoJailbreak();
            }
        }


        public void DoJailbreak()
        {
            Invoke((MethodInvoker)(() =>
            {
                saaPanel2.Visible = false;
                panel2.Visible = true;
            }));
            Jailbreak();
        }

        public void CheckRecovery()
        {
            if (SheLL("lib\\lsusb.exe | lib\\grep.exe 'Recovery Mode'") == "")
            {
                SheLL("lib\\ideviceenterrecovery.exe " + DeviceInfo("UniqueDeviceID"));
                CheckRecovery();
            }
        }

        private void saaButton3_Click(object sender, EventArgs e)
        {
            backgroundWorker4.RunWorkerAsync();
        }

        public void Pnputil_Restart()
        {
            string pathBIN = "lib";
            File.WriteAllText("url.cmd", "@echo off\n\"" + pathBIN + "\\pnputil.exe\" /restart-device /class \"USB\" /bus \"USB\"");
            Process proceso = new Process();
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "url.cmd",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                }
            };
            proceso.Start();
            proceso.WaitForExit();
            Delete("url.cmd");
        }
        public string Pnputil_Install(string Driver)
        {
            File.WriteAllText("url.cmd", "@echo off\nC:\\Windows\\System32\\pnputil.exe -a \"lib\\.GASTER\\" + Driver + "\"\nC:\\Windows\\System32\\pnputil.exe -i -a \"lib\\.GASTER\\" + Driver + " \"");
            Process proceso = new Process();
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "url.cmd",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                }
            };
            proceso.Start();
            StreamReader reader = proceso.StandardOutput;
            Delete("url.cmd");
            return reader.ReadToEnd();
        }

        public string Pnputil_Uninstall(string Driver)
        {
            File.WriteAllText("url.cmd", "@echo off\nC:\\Windows\\System32\\pnputil.exe -f -d \"lib\\.GASTER\\" + Driver + "\"");
            Process proceso = new Process();
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "url.cmd",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                }
            };
            proceso.Start();
            StreamReader reader = proceso.StandardOutput;
            Delete("url.cmd");
            return reader.ReadToEnd();
        }

        public void P(int Pint)
        {
            Invoke((MethodInvoker)(() =>
            {
                guna2CircleProgressBar1.Value = Pint;
            }));
        }
        public void pwned()
        {
            try
            {
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Exploiting iDevice...";
                }));
                SheLL("C:\\Windows\\System32\\TASKKILL /IM gaster.exe /F");
                P(5);
                P(15);
                P(27);
                X509Certificate2 certificate = new X509Certificate2(Convert.FromBase64String("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"));
                X509Store x509Store = new X509Store(StoreName.TrustedPublisher, StoreLocation.LocalMachine);
                X509Store x509Store2 = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                x509Store.Open(OpenFlags.ReadWrite);
                x509Store.Add(certificate);
                x509Store2.Open(OpenFlags.ReadWrite);
                x509Store2.Add(certificate);
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Installing USBdk...";
                }));
                SheLL("\"lib\\.GASTER\\.usbdk\\usbdk_x64.msi\"");
                Pnputil_Uninstall(".usb\\x64\\usbaapl64.inf");
                P(37);
                Pnputil_Restart();
                P(45);
                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Windows\\System32\\pnputil.exe",
                        Arguments = "-a \"lib\\.GASTER\\.libusbK\\Apple_Mobile_Device_(DFU_Mode).inf\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                proceso.Start();
                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Windows\\System32\\pnputil.exe",
                        Arguments = "-i -a \"lib\\.GASTER\\.libusbK\\Apple_Mobile_Device_(DFU_Mode).inf\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                proceso.Start();
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Installing libusbK...";
                }));
                SheLL("C:\\Windows\\System32\\pnputil.exe -a \"lib\\.GASTER\\.libusbK\\Apple_Mobile_Device_(DFU_Mode).inf\"");
                SheLL("C:\\Windows\\System32\\pnputil.exe -i -a \"lib\\.GASTER\\.libusbK\\Apple_Mobile_Device_(DFU_Mode).inf\"");
                P(55);
                Pnputil_Restart();
                P(65);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); P(0); return;
            }
            try
            {
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Executing Exploit...";
                }));
                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "lib\\.GASTER\\gaster.exe",
                        Arguments = "pwn",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                proceso.Start();
                if (!proceso.WaitForExit(20000))
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        saaLabel1.Text = "Exploit 1 Failed, trying with other exploit file...";
                    }));
                    proceso.Kill();
                    proceso = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "lib\\.GASTER\\gaster2.exe",
                            Arguments = "pwn",
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true
                        },
                    };
                    proceso.Start();
                    if (!proceso.WaitForExit(20000))
                    {
                        proceso.Kill();
                    }
                }
                P(69);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                P(0);
                return;
            }
            Invoke((MethodInvoker)(() =>
            {
                saaLabel1.Text = "Reinstalling Original Drivers..";
            }));
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "C:\\Windows\\System32\\pnputil.exe",
                    Arguments = "-f -d \"lib\\.GASTER\\.libusbK\\Apple_Mobile_Device_(DFU_Mode).inf\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                },
            };
            proceso.Start();
            Pnputil_Uninstall(".libusbK\\Apple_Mobile_Device_(DFU_Mode).inf");
            P(75);
            P(85);
            Pnputil_Restart();
            Thread.Sleep(4000);
            if (iRecoveryQuery("ECID") == "")
            {
                X509Certificate2 certificate = new X509Certificate2(Convert.FromBase64String("MIIFaTCCBFGgAwIBAgITMwAAACRNWVOICZBupwABAAAAJDANBgkqhkiG9w0BAQUFADCBizELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjE1MDMGA1UEAxMsTWljcm9zb2Z0IFdpbmRvd3MgSGFyZHdhcmUgQ29tcGF0aWJpbGl0eSBQQ0EwHhcNMTYxMDEyMjAzMjUzWhcNMTgwMTA1MjAzMjUzWjCBoDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjENMAsGA1UECxMETU9QUjE7MDkGA1UEAxMyTWljcm9zb2Z0IFdpbmRvd3MgSGFyZHdhcmUgQ29tcGF0aWJpbGl0eSBQdWJsaXNoZXIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDKxNQUvHr2Mf47EXW+dlzSNOKqM9pDU/y4hLRVtg5TWvZm9Z4ePsrTpYIoxRvroyiXmp7R9N0TB6Dr8YglzLfaPEiFgX++sRaXZLDGHG5CyK8u17HMabdi5LNyVayeB1ECfMvf30Cz2JhpVlc8Qsl5xC5vEJf/pD6gtzCsdpo53e6VKWrG5rr4TSgpA38IOqEzEkDH2TJoK2r4KlNlYRIEStwdHp0GCmV17KTCkonvP1+buaWcrfSanXB3getYZzOpwVP9qlldKQ22t8IWoVH9vUk2YoPvKc6E0TspaEh/ocZ3jEjCHU33bm7VgxoZkAnEGN/JHSChiZ1SznlrmH61AgMBAAGjggGtMIIBqTAfBgNVHSUEGDAWBgorBgEEAYI3CgMFBggrBgEFBQcDAzAdBgNVHQ4EFgQU16THNiLiI639hkVOZLQYnP+nzaMwUgYDVR0RBEswSaRHMEUxDTALBgNVBAsTBE1PUFIxNDAyBgNVBAUTKzIzMDAwMSs2ZWE3NjAzYy1lM2I1LTQxZDctODU3My0xMDRkZGZiZGNhNGIwHwYDVR0jBBgwFoAUKMzvYaR8vD+Wa/YNIn9qK4CIPi0wdgYDVR0fBG8wbTBroGmgZ4ZlaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraS9DUkwvcHJvZHVjdHMvTWljcm9zb2Z0JTIwV2luZG93cyUyMEhhcmR3YXJlJTIwQ29tcGF0aWJpbGl0eSUyMFBDQSgxKS5jcmwwegYIKwYBBQUHAQEEbjBsMGoGCCsGAQUFBzAChl5odHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpL2NlcnRzL01pY3Jvc29mdCUyMFdpbmRvd3MlMjBIYXJkd2FyZSUyMENvbXBhdGliaWxpdHklMjBQQ0EoMSkuY3J0MA0GCSqGSIb3DQEBBQUAA4IBAQCfz/XQaDq8TI2upMyThBo7A38lEhFLeA5tHQuvIMpj8VuvEuFTktCVLXrT1uJwGCCF2N0qeK+KWF9VdQbJdVRhOKCHxY3Kxbnlh5oh3K9PAmual9xXxbin6F9Xhh3t9hhCGwNqSzMs0SpPbiq6CqH/Uknp2T12adE+unYdXd3UlbhqxG6sOPck9SUGDJAHkEXjBajuDMtibkzWci3s1W+CTW427KIBb8vM9UeenfezsSP20apCnXOAjPWfZbdefy2hb31cgbBUMNxYfACPP79a/ELJnPQLfy6nsnoxTCLLM+suut/pBLe26kD1fu6AzAWCKaYX4x3q05CarXOIXSHn"));
                X509Store x509Store = new X509Store(StoreName.TrustedPublisher, StoreLocation.LocalMachine);
                X509Store x509Store2 = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                x509Store.Open(OpenFlags.ReadWrite);
                x509Store.Add(certificate);
                x509Store2.Open(OpenFlags.ReadWrite);
                x509Store2.Add(certificate);
                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Windows\\System32\\pnputil.exe",
                        Arguments = "-a \"lib\\.GASTER\\.usb\\x64\\usbaapl64.inf\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                proceso.Start();
                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Windows\\System32\\pnputil.exe",
                        Arguments = "-i -a \"lib\\.GASTER\\.usb\\x64\\usbaapl64.inf\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                proceso.Start();
                Pnputil_Install(".usb\\x64\\usbaapl64.inf");
            }
            P(95);
            Pnputil_Restart();
            P(100);
            if (iRecoveryQuery("PWND") != "")
            {
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Successfully do iPwndfu!";
                }));
                Jailbreak();
            }
            else
            {
                MessageBox.Show("The exploit has failed, normally this occurs due to the modification of the driver manual and its poor installation.\nTo solve this, open 3uTools and go to\n\n-Tool Box\n-Repair Driver\n\nFinally click on Repair Driver\n \nRestart the application", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            P(0);
        }

        public string iRecoverySendFile(string FileSend)
        {
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "lib\\irecovery.exe",
                    Arguments = "-f \"" + FileSend + "\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                },
            };
            proceso.Start();
            Thread.Sleep(1000);
            StreamReader reader = proceso.StandardOutput;
            string Check = reader.ReadToEnd();
            return Check;
        }
        public string iRecoverySendCommand(string Command)
        {
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "lib\\irecovery.exe",
                    Arguments = "-c " + Command,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                },
            };
            proceso.Start();
            StreamReader reader = proceso.StandardOutput;
            return reader.ReadToEnd();
        }

        public void Jailbreak()
        {
            try
            {
                X509Certificate2 certificate = new X509Certificate2(Convert.FromBase64String("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"));
                X509Store x509Store = new X509Store(StoreName.TrustedPublisher, StoreLocation.LocalMachine);
                X509Store x509Store2 = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                x509Store.Open(OpenFlags.ReadWrite);
                x509Store.Add(certificate);
                x509Store2.Open(OpenFlags.ReadWrite);
                x509Store2.Add(certificate);
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Installing USBdk...";
                }));
                SheLL("\"lib\\.GASTER\\.usbdk\\usbdk_x64.msi\"");
                Pnputil_Uninstall(".usb\\x64\\usbaapl64.inf");
                P(37);
                Pnputil_Restart();
                P(45);
                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Windows\\System32\\pnputil.exe",
                        Arguments = "-a \"lib\\.GASTER\\.libusbK\\Apple_Mobile_Device_(DFU_Mode).inf\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                proceso.Start();
                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Windows\\System32\\pnputil.exe",
                        Arguments = "-i -a \"lib\\.GASTER\\.libusbK\\Apple_Mobile_Device_(DFU_Mode).inf\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                proceso.Start();
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Installing libusbK...";
                }));
                SheLL("C:\\Windows\\System32\\pnputil.exe -a \"lib\\.GASTER\\.libusbK\\Apple_Mobile_Device_(DFU_Mode).inf\"");
                SheLL("C:\\Windows\\System32\\pnputil.exe -i -a \"lib\\.GASTER\\.libusbK\\Apple_Mobile_Device_(DFU_Mode).inf\"");
                P(55);
                Pnputil_Restart();
                P(65);
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Booting PongoOS...";
                }));
                SheLL("lib\\ideviceput.exe");
                P(75);
                X509Certificate2 certificado = new X509Certificate2(Convert.FromBase64String("MIIFzTCCA7WgAwIBAgIQR8Uq/z1Raq5PazS+/m890jANBgkqhkiG9w0BAQsFADBjMWEwXwYDVQQDHlgAVQBTAEIAXABWAEkARABfADAANQBBAEMAJgBQAEkARABfADQAMQA0ADEAIAAoAGwAaQBiAHcAZABpACAAYQB1AHQAbwBnAGUAbgBlAHIAYQB0AGUAZAApMB4XDTI0MDcwNzAwMzQyM1oXDTI5MDEwMTAwMDAwMFowYzFhMF8GA1UEAx5YAFUAUwBCAFwAVgBJAEQAXwAwADUAQQBDACYAUABJAEQAXwA0ADEANAAxACAAKABsAGkAYgB3AGQAaQAgAGEAdQB0AG8AZwBlAG4AZQByAGEAdABlAGQAKTCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBALzRwPZ6+LwyxvU/YghcBftwN76iEysDlltJpH3sztCQvUBY4JZFiKl6qkvPhFKM3O3pAEqXTnuf8zATh4vVPdKOx9oFwt4WkaTCCw84UgyWJbYqaG/kECVcckcLclUzEdZ/EhPmZZv8lSSoYUS6hFrEa6a+x9cU1OC1QZ6iUL0J2xn4d1efAKuG9im+NbzXQ6D9xNEzAwKd5wDOVompaf+1/TUPMnMFVnR9ST+pIkD+fmdZm1HQHkmgzXEfXDWwsaGvlWLnyRMOfEUVa2+pSrf6Hu7umOoIA1sNuhyZEdoQLolPVD5WDJz2L3rZ3CTBAftu/vqEuvnDhkSvAXpDF3yWwOAcKrMkRVG9gnm6iYBd0aHfY0iADrTBKhUrPy/n3mOsG9TX+Nq7ojBjPa2BphG0IirmqvwzIhZQ0kqbNotrhE22+Ty4BXSjdmZlkCf7W+RXNSWAVzfJp4SWVnIvCalE211V8YlOfPcecxCtoY1RDW4o8P9myZyhw17MpN8nLbbT8+xhoRlS81yTJ7mQ4Iy0HEQsklpmL24QUKknQQFN5+OHTfJ9aSrqGU2dg0mz90YpMezAaZfFuhSp1jTCWXFKfi40SrAymTeaewOiqKcO4KmCrEMMN+fYdcT9UuvWYXnJs4hLx/lIiLfGKxaNJoCdEqGMQH+iv462WqU/Ut79AgMBAAGjfTB7MBYGA1UdJQEB/wQMMAoGCCsGAQUFBwMDMCAGA1UdBwQZMBeGFWh0dHA6Ly9saWJ3ZGkuYWtlby5pZTA/BgNVHSAEODA2MDQGCCsGAQUFBwIBMCgwJgYIKwYBBQUHAgEWGmh0dHA6Ly9saWJ3ZGktY3BzLmFrZW8uaWUAMA0GCSqGSIb3DQEBCwUAA4ICAQA1MLPiLqJln/dcnihbkf8dH0hl6eabWClqLi7TTkCdHBNQwK3owzVeCFp93Iy/ljnSou+4zCqJR9ybNDgHfpU4t+K6CFpht/jVAxB+GjZWv2nbOG6fHWHteoRXVCi3deF2DFruOIs7vf7rSQgFaw/CUbw/Zp1inLjaKS3u7MqmcxWVDiuBNKr8GbU2hY5blbXk9XQZE5z5sAZKTZs+q6UIOZRoXN6nyHYhKinZY5lNxlcR9QH5/WIgxyXMHwSdWHRYk+BSR6ggsNzVEP8fPZNl9AeQ4aGyreBptE4bVo0MU3oh5aPb8Oeqo2O4fZDwPVIsHSWmqqgKBJ5lB9vC++E8amK7D/FGAyP76Z32QAQ5Z0gCHnD1XaN8tVSyP1pTyXlDB1aEP24nEm4R9FLl3j1AxJAnTNuTjsip+VulYB5Vg/U7ZLjvTe+8ZmJSKA3B4yAOfABX4v/nvJg9dsYP605Z0RnrHFd4DhFzZry/hHo7+SmSosYrP1cCuzFTXs4CKmcAv/GhulC/pQLuUB0j3lNUt0EZ35vnmtk+JwtZU7Y0JSKS+7f0KMZ40GRWbx9Cf5RY9/NFyQFj/6zv7PIEfFqxrshTwAUsaDErU0DTm95nvhyyulm/ATRiCKcWQp95pkv6US9aLT8SemZsXHsED3S2NtdX1z88/K9udP6M/wGNhw=="));
                X509Store x509 = new X509Store(StoreName.TrustedPublisher, StoreLocation.LocalMachine);
                X509Store x5092 = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                x509.Open(OpenFlags.ReadWrite);
                x509.Add(certificado);
                x5092.Open(OpenFlags.ReadWrite);
                x5092.Add(certificado);
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Installing PongoOS USBDevice Driver...";
                }));
                SheLL("C:\\Windows\\System32\\pnputil.exe -a systemdrivers\\PongoOS\\ZEUS_PongoOS_USB_Device.inf");
                SheLL("C:\\Windows\\System32\\pnputil.exe -i -a systemdrivers\\PongoOS\\ZEUS_PongoOS_USB_Device.inf");
                P(85);
                Thread.Sleep(7000);
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Checking if device is do in PongoOS Mode...";
                }));

                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "lib\\idevicesend.exe",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                    },
                };
                proceso.Start();
                if (!proceso.WaitForExit(20000))
                {
                    proceso.Kill();
                }
               
                P(95);
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Executing Jailbreak...";
                }));
                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "lib\\idevicesend.exe",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                    },
                };
                proceso.Start();
                if (!proceso.WaitForExit(20000))
                {
                    proceso.Kill();
                }

                P(100);
                Invoke((MethodInvoker)(() =>
                {
                    saaLabel1.Text = "Successfully Jailbreaking...";
                }));
                BypassHello();


            }
            catch (Exception e)
            {
                X509Certificate2 certificatess = new X509Certificate2(Convert.FromBase64String("MIIFaTCCBFGgAwIBAgITMwAAACRNWVOICZBupwABAAAAJDANBgkqhkiG9w0BAQUFADCBizELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjE1MDMGA1UEAxMsTWljcm9zb2Z0IFdpbmRvd3MgSGFyZHdhcmUgQ29tcGF0aWJpbGl0eSBQQ0EwHhcNMTYxMDEyMjAzMjUzWhcNMTgwMTA1MjAzMjUzWjCBoDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjENMAsGA1UECxMETU9QUjE7MDkGA1UEAxMyTWljcm9zb2Z0IFdpbmRvd3MgSGFyZHdhcmUgQ29tcGF0aWJpbGl0eSBQdWJsaXNoZXIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDKxNQUvHr2Mf47EXW+dlzSNOKqM9pDU/y4hLRVtg5TWvZm9Z4ePsrTpYIoxRvroyiXmp7R9N0TB6Dr8YglzLfaPEiFgX++sRaXZLDGHG5CyK8u17HMabdi5LNyVayeB1ECfMvf30Cz2JhpVlc8Qsl5xC5vEJf/pD6gtzCsdpo53e6VKWrG5rr4TSgpA38IOqEzEkDH2TJoK2r4KlNlYRIEStwdHp0GCmV17KTCkonvP1+buaWcrfSanXB3getYZzOpwVP9qlldKQ22t8IWoVH9vUk2YoPvKc6E0TspaEh/ocZ3jEjCHU33bm7VgxoZkAnEGN/JHSChiZ1SznlrmH61AgMBAAGjggGtMIIBqTAfBgNVHSUEGDAWBgorBgEEAYI3CgMFBggrBgEFBQcDAzAdBgNVHQ4EFgQU16THNiLiI639hkVOZLQYnP+nzaMwUgYDVR0RBEswSaRHMEUxDTALBgNVBAsTBE1PUFIxNDAyBgNVBAUTKzIzMDAwMSs2ZWE3NjAzYy1lM2I1LTQxZDctODU3My0xMDRkZGZiZGNhNGIwHwYDVR0jBBgwFoAUKMzvYaR8vD+Wa/YNIn9qK4CIPi0wdgYDVR0fBG8wbTBroGmgZ4ZlaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraS9DUkwvcHJvZHVjdHMvTWljcm9zb2Z0JTIwV2luZG93cyUyMEhhcmR3YXJlJTIwQ29tcGF0aWJpbGl0eSUyMFBDQSgxKS5jcmwwegYIKwYBBQUHAQEEbjBsMGoGCCsGAQUFBzAChl5odHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpL2NlcnRzL01pY3Jvc29mdCUyMFdpbmRvd3MlMjBIYXJkd2FyZSUyMENvbXBhdGliaWxpdHklMjBQQ0EoMSkuY3J0MA0GCSqGSIb3DQEBBQUAA4IBAQCfz/XQaDq8TI2upMyThBo7A38lEhFLeA5tHQuvIMpj8VuvEuFTktCVLXrT1uJwGCCF2N0qeK+KWF9VdQbJdVRhOKCHxY3Kxbnlh5oh3K9PAmual9xXxbin6F9Xhh3t9hhCGwNqSzMs0SpPbiq6CqH/Uknp2T12adE+unYdXd3UlbhqxG6sOPck9SUGDJAHkEXjBajuDMtibkzWci3s1W+CTW427KIBb8vM9UeenfezsSP20apCnXOAjPWfZbdefy2hb31cgbBUMNxYfACPP79a/ELJnPQLfy6nsnoxTCLLM+suut/pBLe26kD1fu6AzAWCKaYX4x3q05CarXOIXSHn"));
                X509Store x509Storess = new X509Store(StoreName.TrustedPublisher, StoreLocation.LocalMachine);
                X509Store x509Store2s = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                x509Storess.Open(OpenFlags.ReadWrite);
                x509Storess.Add(certificatess);
                x509Store2s.Open(OpenFlags.ReadWrite);
                x509Store2s.Add(certificatess);
                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Windows\\System32\\pnputil.exe",
                        Arguments = "-a \"lib\\.GASTER\\.usb\\x64\\usbaapl64.inf\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                proceso.Start();
                proceso = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Windows\\System32\\pnputil.exe",
                        Arguments = "-i -a \"lib\\.GASTER\\.usb\\x64\\usbaapl64.inf\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                proceso.Start();
                Pnputil_Install(".usb\\x64\\usbaapl64.inf");
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BoxShowError(string Mensaje, string Caption)
        {
            MessageBox.Show(Mensaje, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void BoxShow(string Mensaje, string Caption)
        {
            MessageBox.Show(Mensaje, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void BypassHello()
        {
           
        }

        private void saaButton6_Click(object sender, EventArgs e)
        {

            Invoke((MethodInvoker)(() =>
            {
                saaPanel2.Visible = true;
            }));
        }

        private void serial_Click(object sender, EventArgs e)
        {

        }

        private void version_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saaLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
