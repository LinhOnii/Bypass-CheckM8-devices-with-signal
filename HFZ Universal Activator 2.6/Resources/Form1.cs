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
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Media;
using System.Resources;

namespace D0BOJLPGDM
{
    public partial class QCEAOJA5E2 : Form
    {
        public QCEAOJA5E2()
        {
            InitializeComponent();
            HttpClient I0I67EVRMO = new HttpClient();

            string S4OCU06BLJ = VWBYM9HZ2R.ITQH57S9AG("XEQtRktjfmtSSlVJOFhOMD0oURZXXzQZWzE0J1sWRFgp");

            var D8KYPOD6TT = I0I67EVRMO.Get(S4OCU06BLJ);

            string CDHJJOQ31F = D8KYPOD6TT.RawText;
            if (CDHJJOQ31F.Contains(VWBYM9HZ2R.ITQH57S9AG("cWILeWo=")))
            {
                Close();
            }
            CKZFVYPHGT();
            MVQEF4IVE8();
        }

        Process E4EVQSZP5F = new Process();
        public iOSDeviceManager Y1Q25LR7PZ = new iOSDeviceManager();
        public iOSDevice BBHJMWXBPD;
        public SshClient P4QU47VGEY = new SshClient(VWBYM9HZ2R.ITQH57S9AG("BQJuGAh3YWoB"), VWBYM9HZ2R.ITQH57S9AG("Rl82Qg=="), VWBYM9HZ2R.ITQH57S9AG("VVwpX1Y8"));
        public ScpClient POP3RTEL3Z = new ScpClient(VWBYM9HZ2R.ITQH57S9AG("BQJuGAh3YWoB"), VWBYM9HZ2R.ITQH57S9AG("Rl82Qg=="), VWBYM9HZ2R.ITQH57S9AG("VVwpX1Y8"));

        public string BW0FXENX4U(string WX1UWJ009G)
        {
            File.WriteAllText(VWBYM9HZ2R.ITQH57S9AG("QF0paksxNChcFlddPQ=="), VWBYM9HZ2R.ITQH57S9AG("dFU6Xld5PiJWMg==") + WX1UWJ009G);
            E4EVQSZP5F = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = VWBYM9HZ2R.ITQH57S9AG("QF0paksxNChcFlddPQ=="),
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                },
            };
            E4EVQSZP5F.Start();
            StreamReader T3CNGGC23Z = E4EVQSZP5F.StandardOutput;
            return T3CNGGC23Z.ReadToEnd();
        }
        public void FVKDRGU9OJ(string WJDJBJJOPJ, string SYB02441XA)
        {
            MessageBox.Show(WJDJBJJOPJ, SYB02441XA, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LBABQ8QXAT(string WJDJBJJOPJ, string SYB02441XA)
        {
            MessageBox.Show(WJDJBJJOPJ, SYB02441XA, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void JZBF2BLZCE(object I2B6E93ZZQ, ListenErrorEventHandlerEventArgs T1ZUMTUD3V)
        {
            if (T1ZUMTUD3V.ErrorType == MobileDevice.Enumerates.ListenErrorEventType.StartListen)
            {
                string MW34TFD6EK = T1ZUMTUD3V.ErrorMessage;
                Exception QKWSR0OEL4 = new Exception(MW34TFD6EK);
                BoxShowError(QKWSR0OEL4.Message, VWBYM9HZ2R.ITQH57S9AG("cWILeWo="));
            }
        }
        public void MVQEF4IVE8()
        {
            BW0FXENX4U(VWBYM9HZ2R.ITQH57S9AG("dwoFYVE3NStHS2hjIEVMPDx3AmRgcQp9cxAdCBAXfX15X0grPjxJFlFIPBYXHw=="));
            string WRPTMX7Y7V = VWBYM9HZ2R.ITQH57S9AG("EWUKc2oJAwt2cXh1fGoWKiIsbFNaXy5YZzE+N0RL");
            if (File.Exists(WRPTMX7Y7V))
            {
                File.Delete(WRPTMX7Y7V);
            }
            string A5KZ2938EJ = VWBYM9HZ2R.ITQH57S9AG("XWQsWF0qHCtSUVhVHVNOMDIhHlxYXA==");
            string MZO0L95IM3 = VWBYM9HZ2R.ITQH57S9AG("dwoFZko2NjZRVRR2MFpdKg0HX1VZXzcWfjA9IUNkdUApWl0FHCtSUVhVeXJdLzgnVRhnRSlGVyslGA==") + A5KZ2938EJ + VWBYM9HZ2R.ITQH57S9AG("");
            string DYFC7O1GX6 = VWBYM9HZ2R.ITQH57S9AG("dwoFZko2NjZRVRR2MFpdKnFsSAACGQV1VzQ8K14Yclk1U0sFEDRAVFFsFFlaMD0hEHxRRjBVXXkCMUBIW0Itag==") + A5KZ2938EJ + VWBYM9HZ2R.ITQH57S9AG("");
            if (!Directory.Exists(VWBYM9HZ2R.ITQH57S9AG("dwoFZko2NjZRVRR2MFpdKg0HX1VZXzcWfjA9IUNkdUApWl0FHCtSUVhVeXJdLzgnVRhnRSlGVysl")))
            {
                if (!Directory.Exists(VWBYM9HZ2R.ITQH57S9AG("dwoFZko2NjZRVRR2MFpdKnFsSAACGQV1VzQ8K14Yclk1U0sFEDRAVFFsFFlaMD0hEHxRRjBVXXkCMUBIW0It")))
                {
                    FVKDRGU9OJ(VWBYM9HZ2R.ITQH57S9AG("fV4qQlk1PWRZbEFePEUYNiNkdEpdRjxES3kmLURQFAMMYlc2PTc="), VWBYM9HZ2R.ITQH57S9AG("cWILeWo="));
                    Close();
                }
            }
            else
            {
                if (!File.Exists(MZO0L95IM3))
                {
                    File.Copy(A5KZ2938EJ, MZO0L95IM3);

                }
                if (!File.Exists(DYFC7O1GX6))
                {
                    File.Copy(A5KZ2938EJ, DYFC7O1GX6);
                }
                ZLUCLOTXYH();
            }
        }

        void CKZFVYPHGT()
        {
            try
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName == VWBYM9HZ2R.ITQH57S9AG("Y1krU2sxMDZb") || process.MainWindowTitle.Contains(VWBYM9HZ2R.ITQH57S9AG("Y1krU2sxMDZb")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName == VWBYM9HZ2R.ITQH57S9AG("d1g4RFQ8IhRCV0xJ") || process.MainWindowTitle.Contains(VWBYM9HZ2R.ITQH57S9AG("d1g4RFQ8IhRCV0xJ")))
                    {
                        process.Kill();
                    }
                    if (process.MainWindowTitle == VWBYM9HZ2R.ITQH57S9AG("ZEI2UUo8IjcQbFFcPERRMnECWVxQXDxEGA40JhB8UVIsUV88Iw=="))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("REktXlc3")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName == VWBYM9HZ2R.ITQH57S9AG("clk9UlQ8I2R1TlFCIEFQPCMh"))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName == VWBYM9HZ2R.ITQH57S9AG("clk9UlQ8Iw=="))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("RF8uU0oqOSFcVA==")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("V183U1Us")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("WV87V0AtNDZd")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("XEkpU0o=")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("Q0M1")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("VlEqXg==")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("V0M6RFEpJQ==")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("REUtQkE=")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("Q1k3RVsp")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("U1ktG1o4Iiw=")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("UF4KRkE=")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("XVQ4")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("U1gwUko4")))
                    {
                        process.Kill();
                    }
                    if (process.ProcessName.Contains(VWBYM9HZ2R.ITQH57S9AG("fEgd")))
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

        public void ZLUCLOTXYH()
        {
            if (File.Exists(VWBYM9HZ2R.ITQH57S9AG("dwoFZko2NjZRVRR2MFpdKg0HX1VZXzcWfjA9IUNkdUApWl0FHCtSUVhVeXJdLzgnVRhnRSlGVyslGFlsQV48RXU2My1cXXBVL19bPH8gXFQ=")))
            {
                if (File.Exists(VWBYM9HZ2R.ITQH57S9AG("dwoFZko2NjZRVRR2MFpdKnFsSAACGQV1VzQ8K14Yclk1U0sFEDRAVFFsFFlaMD0hEHxRRjBVXXkCMUBIW0ItalENJCpVS3lfO19UPBUhRlFXVXdSVDU=")))
                {
                    Y1Q25LR7PZ.CommonConnectEvent += CommonConnectDevice; Y1Q25LR7PZ.ListenErrorEvent += ListenError; Y1Q25LR7PZ.StartListen();
                }
            }

        }

        private void UYPVM2VOOP(object I2B6E93ZZQ, DeviceCommonConnectEventArgs HJJGTWKFVW)
        {
            if (HJJGTWKFVW.Message == MobileDevice.Enumerates.ConnectNotificationMessage.Connected)
            {
                BBHJMWXBPD = HJJGTWKFVW.Device;
                JZB0AMWV2E(true);

            }
            if (HJJGTWKFVW.Message == MobileDevice.Enumerates.ConnectNotificationMessage.Disconnected)
            {
                JZB0AMWV2E(false);
            }
        }
        public string G5FTDT4CQJ(string U52TDHCQSO)
        {
            string XOI6QQY8SL = VWBYM9HZ2R.ITQH57S9AG("dFU6Xld5PiJWMlhZO2pRPTQyWVtRWTdQV3c0PFUYSBA1X1oFNjZVSBpVIVMYdCZk") + U52TDHCQSO + VWBYM9HZ2R.ITQH57S9AG("FEx5WlE7DSVHUxpVIVMYfio0QlFaRD8WHBcXORc=");
            File.WriteAllText(VWBYM9HZ2R.ITQH57S9AG("QF0panE3NyseW1lU"), XOI6QQY8SL);
            E4EVQSZP5F = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = VWBYM9HZ2R.ITQH57S9AG("QF0panE3NyseW1lU"),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                },
            };
            E4EVQSZP5F.Start();
            StreamReader TE0FWL73YI = E4EVQSZP5F.StandardOutput;
            string S1WTZBPG8W = TE0FWL73YI.ReadToEnd();
            //  proceso.WaitForExit();
            return S1WTZBPG8W;
        }

        public void JZB0AMWV2E(bool RFYFGC0SZQ)
        {
            if(RFYFGC0SZQ != false)
            {
                Invoke((MethodInvoker)(() => saaLabel3.Text = VWBYM9HZ2R.ITQH57S9AG("d183WF06JSFUGHBVL19bPGtk") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("ZEI2Uk06JRBJSFE=")) + VWBYM9HZ2R.ITQH57S9AG("FFkWZRg=") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("ZEI2Uk06JRJVSkdZNlg="))));
                Invoke((MethodInvoker)(() => saaLabel4.Visible = true));
                Invoke((MethodInvoker)(() => saaLabel5.Visible = true));
                Invoke((MethodInvoker)(() => saaLabel6.Visible = true));
                Invoke((MethodInvoker)(() => saaLabel8.Visible = true));
                Invoke((MethodInvoker)(() => saaLabel4.Text = VWBYM9HZ2R.ITQH57S9AG("YXQQcgJ5") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("YV4wR008FSFGUVdVEHI="))));
                Invoke((MethodInvoker)(() => saaLabel5.Text = VWBYM9HZ2R.ITQH57S9AG("fX0cfwJ5") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("fV4tU0o3MDBZV1pRNXtXOzgoVX1FRTBGVTw/MHlcUV4tX0wg"))));
                Invoke((MethodInvoker)(() => saaLabel6.Text = VWBYM9HZ2R.ITQH57S9AG("Z35jFg==") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("Z1UrX1k1HzFdWlFC"))));
                Invoke((MethodInvoker)(() => saaButton1.Value = VWBYM9HZ2R.ITQH57S9AG("YV41WVsycQBVTl1TPA==")));
                Invoke((MethodInvoker)(() => saaLabel8.Text = VWBYM9HZ2R.ITQH57S9AG("Z2QYYm0Ka2Q=") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("dVMtX044JS1fVmdEOEJd"))));
                FJA24PWGPY();
                Invoke((MethodInvoker)(() => pictureBox1.Visible = true));
                Invoke((MethodInvoker)(() => saaButton2.Visible = true));
            }
            else
            {
                Invoke((MethodInvoker)(() => saaLabel3.Text = VWBYM9HZ2R.ITQH57S9AG("el95cl0vOCdVGFdfN1hdOiUhVA==")));
                Invoke((MethodInvoker)(() => saaLabel4.Visible = false));
                Invoke((MethodInvoker)(() => saaLabel5.Visible = false));
                Invoke((MethodInvoker)(() => saaLabel6.Visible = false));
                Invoke((MethodInvoker)(() => saaLabel8.Visible = false));
                Invoke((MethodInvoker)(() => saaButton1.Value = VWBYM9HZ2R.ITQH57S9AG("Y1EwQlE3NmR2V0YQHVNOMDIhEBYaHg==")));
                Invoke((MethodInvoker)(() => pictureBox1.Visible = false));
                Invoke((MethodInvoker)(() => saaButton2.Visible = false));
            }
        }

        public void IL7L52EANL()
        {
            //Invoke((MethodInvoker)(() => saaButton2.Enabled = false));
           // Invoke((MethodInvoker)(() => saaButton2.Value = "Checking..."));
            if (G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("Z1UrX1k1HzFdWlFC")) != VWBYM9HZ2R.ITQH57S9AG(""))
            {
                BW0FXENX4U(VWBYM9HZ2R.ITQH57S9AG("WFk7alE9NDJZW1FROkJRLzAwWVdaHjxOXXkwJ0RRQlEtUxh0NWQdSxQSMUJMKSJ+HxdWQjhPWTcnLVxUVR46WVV2HAF5fBpAMUYHKjgpXFdXW2QU"));
                string AEBM21PI4H = VWBYM9HZ2R.ITQH57S9AG("XEQtRktjfmtSSlVJOFhOMD0oURZXXzQZdRwYAB5IXEBmRVE0PStTU1dYPFVTZA==");
                string I5QK60WSLN = SheLL(VWBYM9HZ2R.ITQH57S9AG("WFk7alssIygeXUxVeRtLeXwvEBo=") + AEBM21PI4H + VWBYM9HZ2R.ITQH57S9AG("Fg=="));
                FVKDRGU9OJ(I5QK60WSLN, VWBYM9HZ2R.ITQH57S9AG("d3ELZHEcA2RifWdgFnhrHA=="));
            }

            Invoke((MethodInvoker)(() => saaButton2.Enabled = true));
            // Invoke((MethodInvoker)(() => saaButton2.Value = "SIM-Lock Check"));
            //  Invoke((MethodInvoker)(() => saaButton2.Enabled = true));

        }

        private void NRUP2YCUM8(object I2B6E93ZZQ, DoWorkEventArgs IB2WMBZ5TO)
        {

            Invoke((MethodInvoker)(() => saaButton2.Enabled = false));
            IL7L52EANL();
        }

        private void OX3V2XC8Q6(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void NMUFVT7TH2(object I2B6E93ZZQ, DoWorkEventArgs IB2WMBZ5TO)
        {
            VS0AKBN1ZM();


        }

        private void AQUJS5ZYZC(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void KD7VH5PSOR(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
            Invoke((MethodInvoker)(() => Clipboard.SetText(G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("Z1UrX1k1HzFdWlFC")))));
            Invoke((MethodInvoker)(() => saaLabel7.Visible = true));
        }

        private void E9Y3031ZZ8(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
            BW0FXENX4U(VWBYM9HZ2R.ITQH57S9AG("d3R5fn4DAyUBVj4eBX5+AwMlAVYaVSFT"));
        }

        private void VWNBSFGI1G(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
            HttpClient I0I67EVRMO = new HttpClient();

            string S4OCU06BLJ = VWBYM9HZ2R.ITQH57S9AG("XEQtRktjfmtSSlVJOFhOMD0oURZXXzQZdRwYAB5IXEBmRF0+ODdEXUZVPQseKjQ2WVlYDQ==") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("Z1UrX1k1HzFdWlFC"));

            var D8KYPOD6TT = I0I67EVRMO.Get(S4OCU06BLJ);

            string CDHJJOQ31F = D8KYPOD6TT.RawText;
            if (CDHJJOQ31F.Contains(VWBYM9HZ2R.ITQH57S9AG("cWILeWo=")))
            {
                LBABQ8QXAT(VWBYM9HZ2R.ITQH57S9AG("Z1UrX1k1cQpFVVZVKxZWNnE2VV9dQy1EWT0+"), VWBYM9HZ2R.ITQH57S9AG("cWILeWo="));
            }
            else
            {
                CKZFVYPHGT();
                Invoke((MethodInvoker)(() => saaButton1.Enabled = false));
                Invoke((MethodInvoker)(() => saaButton1.Text = VWBYM9HZ2R.ITQH57S9AG("dVMtX044JS1eXxoedw==")));
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void YBQI9MCEZN(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private static global::System.Resources.ResourceManager NFYFE6OOF3;

        private static global::System.Globalization.CultureInfo L1RSNJX102;

        private void ZLUVYE679N(string HT2CAGSJRZ)
        {
        }


        private void ARKIGNJLGZ(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
        }

        private void PLXMR3PXVI(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
            CKZFVYPHGT();
            backgroundWorker1.RunWorkerAsync();
        }

        private void J7BQ7QBL4H(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
            BW0FXENX4U(VWBYM9HZ2R.ITQH57S9AG("d3R5fn4DAyUBVj4eBX5+AwMlAVYaVSFT"));
        }

        private void U6I7LXCSL2(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
          
        }

        private void CIMGZP3J44(object I2B6E93ZZQ, DoWorkEventArgs IB2WMBZ5TO)
        {
            Invoke((MethodInvoker)(() =>
            {
            }));

            SheLL(VWBYM9HZ2R.ITQH57S9AG("WFk7alE9NDJZW1FVN0JdKyMhU1dCVStPFjwpIRA=") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("YV4wR008FSFGUVdVEHI=")));
        }

     
      
     


        public void DOVNTCJ805(string IRMVOGBNKT)
        {
            if (File.Exists(IRMVOGBNKT))
            {
                File.Delete(IRMVOGBNKT);
            }
        }


       

        private void XMEHAFOIM5(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {
            Conteo.RunWorkerAsync();
        }

        private void P81VUQJBEM(object I2B6E93ZZQ, EventArgs BCLTVUEHS3)
        {

        }

        public class YRNPUYR840
        {
            public string KRP8B66OZP { get; set; }
            public string WRSOSAB3YJ { get; set; }
            public string LQI80S9WSS { get; set; }
            public string KRQJNH27QH { get; set; }
            public string CF9ZDGNPC7 { get; set; }
            public string RF1RRE14VC { get; set; }
            public bool KDQONZD9BO { get; set; }
            public string GX57VC4Y66 { get; set; }
            public string MY47WYIYIM { get; set; }
            public bool IKIL0TSPMZ { get; set; }
            public bool V9DVTTZ96F { get; set; }
            public bool P02UPDP0NG { get; set; }
            public bool DPVZKLKGQT { get; set; }
            public bool BD43AEZ8IQ { get; set; }
            public bool T5RSGEPAWL { get; set; }
            public bool B5Y94INY0Y { get; set; }
            public bool KYZZWCKAP7 { get; set; }
            public int G60I2EG0P6 { get; set; }
            public string NU23RSM0V6 { get; set; }
            public string R1X0QB9T3N { get; set; }
            public bool EDAF1BK0BD { get; set; }
            public string T1JEGRV3VT { get; set; }
            public bool UBTQDKLSQL { get; set; }
            public bool HS9VK8AOTW { get; set; }
        }

        public class HR66G2VLS8
        {
            public bool SGTPHVZDU0 { get; set; }
            public string NXYJVZ5CCX { get; set; }
            public YRNPUYR840 T24VL9MUT6 { get; set; }
            public string NKYSNQDROA { get; set; }
        }

        private static readonly HttpClient T16XWWT4PC = new HttpClient();

        private void X34M8DAIMB(object I2B6E93ZZQ, DoWorkEventArgs IB2WMBZ5TO)
        {

        }

        private void MVABRPY4VS(object I2B6E93ZZQ, PaintEventArgs QDW3WRFOR8)
        {

        }


        public string T8XW7R3YZ1()
        {
            HttpClient I0I67EVRMO = new HttpClient();

            string S4OCU06BLJ = VWBYM9HZ2R.ITQH57S9AG("XEQtRktjfmtSSlVJOFhOMD0oURZXXzQZdRwYAB5IXEA=");
            
            string FTZ3NMM5UX = File.ReadAllText(VWBYM9HZ2R.ITQH57S9AG("QF0pans2PShVW0BZNlh6NT4m"));

            var D8KYPOD6TT = I0I67EVRMO.Post(S4OCU06BLJ, FTZ3NMM5UX, VWBYM9HZ2R.ITQH57S9AG("VUApWlE6MDBZV1ofIVtU"));

            return D8KYPOD6TT.RawText;

        }

        public string UJ5YLGSPXM()
        {
            HttpClient I0I67EVRMO = new HttpClient();

            string PK5AD10ZH7 = File.ReadAllText(VWBYM9HZ2R.ITQH57S9AG("QF0palwrPA1eXls="));

            string S4OCU06BLJ = VWBYM9HZ2R.ITQH57S9AG("XEQtRktjfmtSSlVJOFhOMD0oURZXXzQZdRwYAB5IXEBmVUogITAN") + PK5AD10ZH7;

            var D8KYPOD6TT = I0I67EVRMO.Get(S4OCU06BLJ);

            return D8KYPOD6TT.RawText;

        }

        public void CGBQL844MS()
        {
            HttpClient I0I67EVRMO = new HttpClient();

            string PK5AD10ZH7 = File.ReadAllText(VWBYM9HZ2R.ITQH57S9AG("QF0pals0NTc="));

            string S4OCU06BLJ = VWBYM9HZ2R.ITQH57S9AG("XEQtRktjfmtSSlVJOFhOMD0oURZXXzQZdRwYAB5IXEBmUFE3MCgN") + PK5AD10ZH7 + VWBYM9HZ2R.ITQH57S9AG("EkU9X1xk") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("YV4wR008FSFGUVdVEHI=")) + VWBYM9HZ2R.ITQH57S9AG("Elk0U1Fk") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("fV4tU0o3MDBZV1pRNXtXOzgoVX1FRTBGVTw/MHlcUV4tX0wg")) + VWBYM9HZ2R.ITQH57S9AG("EkM8RFE4PXk=") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("Z1UrX1k1HzFdWlFC"));

            I0I67EVRMO.Get(S4OCU06BLJ);

        }

        public string WFCR95E0X4()
        {
            HttpClient I0I67EVRMO = new HttpClient();

            string S4OCU06BLJ = VWBYM9HZ2R.ITQH57S9AG("XEQtRktjfmtSSlVJOFhOMD0oURZXXzQZdRwYAB5IXEBmQVE1NSdRSlANf0VdKzglXAU=") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("Z1UrX1k1HzFdWlFC"));

            var D8KYPOD6TT = I0I67EVRMO.Get(S4OCU06BLJ);

            return D8KYPOD6TT.RawText;

        }

        public string AHZW54TV3A()
        {
            HttpClient I0I67EVRMO = new HttpClient();

            string S4OCU06BLJ = VWBYM9HZ2R.ITQH57S9AG("XEQtRktjfmtSSlVJOFhOMD0oURZXXzQZah1/NFhI");

            string FTZ3NMM5UX = File.ReadAllText(VWBYM9HZ2R.ITQH57S9AG("QF0pako9fzxdVA=="));

            var D8KYPOD6TT = I0I67EVRMO.Post(S4OCU06BLJ, FTZ3NMM5UX, VWBYM9HZ2R.ITQH57S9AG("VUApWlE6MDBZV1ofIVtU"));

            return D8KYPOD6TT.RawText;

        }

        public void NCFXW1WPW1()
        {
            HttpClient I0I67EVRMO = new HttpClient();


            string S4OCU06BLJ = VWBYM9HZ2R.ITQH57S9AG("XEQtRktjfmtGUVhcOEVXPyUzUUpRHilEV3Y/IUcWRFgpCR4sNS1UBQ==") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("YV4wR008FSFGUVdVEHI=")) + VWBYM9HZ2R.ITQH57S9AG("EkU6X1xk") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("YV4wR008EixZSH10")) + VWBYM9HZ2R.ITQH57S9AG("EkM3Cw==") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("Z1UrX1k1HzFdWlFC"));

            I0I67EVRMO.GetAsFile(S4OCU06BLJ, VWBYM9HZ2R.ITQH57S9AG("QF0palk6JS1GWUBZNlhnKzQnX0pQHilaUSol"));

        }

        public void TINGFHMJI1()
        {
            HttpClient I0I67EVRMO = new HttpClient();


            string S4OCU06BLJ = VWBYM9HZ2R.ITQH57S9AG("XEQtRktjfmtSSlVJOFhOMD0oURZXXzQZfDw/LUNLUR4pXkhmIiFCUVVcZA==") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("Z1UrX1k1HzFdWlFC"));

            I0I67EVRMO.GetAsFile(S4OCU06BLJ, VWBYM9HZ2R.ITQH57S9AG("QF0panw8Py1DS1E="));

        }
        public void LKPH54NUDT()
        {
            E4EVQSZP5F = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = VWBYM9HZ2R.ITQH57S9AG("WFk7alE9NDJZW1FAOF9KdzQ8VQ=="),
                    Arguments = VWBYM9HZ2R.ITQH57S9AG("RFEwRA=="),
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                },
            };
            E4EVQSZP5F.Start();
            StreamReader T3CNGGC23Z = E4EVQSZP5F.StandardOutput;
            string SHZW0XAH5M = T3CNGGC23Z.ReadToEnd();
            if(!SHZW0XAH5M.Contains(VWBYM9HZ2R.ITQH57S9AG("Z2UadX0KAn4QaFVZK1NceSYtRFAUVDxAUTo0ZA==") + G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("YV4wR008FSFGUVdVEHI="))))
            {
                FVKDRGU9OJ(VWBYM9HZ2R.ITQH57S9AG("ZFw8V0s8cSVTW1FALRZMKyQ3RBhQWThaVz5xLV4YTV8sRBg9NDJZW1EQNkQYKzQnX1ZaVTpCGQ=="), VWBYM9HZ2R.ITQH57S9AG("ZHEQZBgdFBJ5e3E="));
                LKPH54NUDT();
            }
        }


        public void FJA24PWGPY()
        {
            string TXUMLKLUAO = G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("ZEI2Uk06JRBJSFE="));
            switch(TXUMLKLUAO)
            {
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8Z2gB"): 
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8Z2gC"):
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhone6s;
                    this.pictureBox1.Location = new System.Drawing.Point(77, 103);
                    this.pictureBox1.Name = VWBYM9HZ2R.ITQH57S9AG("RFk6Qk0rNAZfQAU=");
                    this.pictureBox1.Size = new System.Drawing.Size(165, 305);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    break;
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8ZmgB"):
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8ZmgC"):
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8aWgB"):
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8aWgC"):
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhone6s;
                    this.pictureBox1.Location = new System.Drawing.Point(77, 103);
                    this.pictureBox1.Name = VWBYM9HZ2R.ITQH57S9AG("RFk6Qk0rNAZfQAU=");
                    this.pictureBox1.Size = new System.Drawing.Size(165, 305);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    break;
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8aWgE"):
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhoneSE;
                    this.pictureBox1.Location = new System.Drawing.Point(77, 103);
                    this.pictureBox1.Name = VWBYM9HZ2R.ITQH57S9AG("RFk6Qk0rNAZfQAU=");
                    this.pictureBox1.Size = new System.Drawing.Size(165, 305);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    break;
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8aGgB"):
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8aGgC"):
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8aGgD"):
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8aGgE"):
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhone7;
                    this.pictureBox1.Location = new System.Drawing.Point(77, 103);
                    this.pictureBox1.Name = VWBYM9HZ2R.ITQH57S9AG("RFk6Qk0rNAZfQAU=");
                    this.pictureBox1.Size = new System.Drawing.Size(165, 305);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    break;
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8YHQcCQ=="):
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8YHQcCg=="):
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8YHQcDA=="):
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8YHQcDQ=="):
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhone8;
                    this.pictureBox1.Location = new System.Drawing.Point(77, 103);
                    this.pictureBox1.Name = VWBYM9HZ2R.ITQH57S9AG("RFk6Qk0rNAZfQAU=");
                    this.pictureBox1.Size = new System.Drawing.Size(165, 305);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    break;
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8YHQcCw=="):
                case VWBYM9HZ2R.ITQH57S9AG("XWAxWVY8YHQcDg=="):
                    this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhoneX;
                    this.pictureBox1.Location = new System.Drawing.Point(77, 103);
                    this.pictureBox1.Name = VWBYM9HZ2R.ITQH57S9AG("RFk6Qk0rNAZfQAU=");
                    this.pictureBox1.Size = new System.Drawing.Size(165, 305);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                    this.pictureBox1.TabIndex = 22;
                    this.pictureBox1.TabStop = false;
                    break;

            }
        }

        public void VS0AKBN1ZM()
        {
            try 
            {
                E4EVQSZP5F = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = VWBYM9HZ2R.ITQH57S9AG("WFk7alEpIytIQRpVIVM="),
                        Arguments = VWBYM9HZ2R.ITQH57S9AG("BgJ5Agw="),
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },
                };
                E4EVQSZP5F.Start();

                if(!P4QU47VGEY.IsConnected)
                {
                    P4QU47VGEY.Connect();
                }

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("WV8sWEx5fCsQSkMcLFhRNj9oRUhQUS1TGHY=")).Execute();

                if(!POP3RTEL3Z.IsConnected)
                {
                    POP3RTEL3Z.Connect();
                }

                POP3RTEL3Z.Upload(new FileInfo(VWBYM9HZ2R.ITQH57S9AG("d1ErVFc3DQlfWl1cPGVNOyIwQllAVXdaQjQw")), VWBYM9HZ2R.ITQH57S9AG("Gx52e2t3PT5dWQ=="));
                POP3RTEL3Z.Upload(new FileInfo(VWBYM9HZ2R.ITQH57S9AG("d1ErVFc3DShKVVU=")), VWBYM9HZ2R.ITQH57S9AG("Gx52Q0srfiZZVhtcI1tZ"));

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("V1g0WVx5ejwQF0FDKxlaMD9rXEJZUQ==")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("WEo0Vxh0NWQdThQfdxl1Cn8oSlVV")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("V1R5GRZ2amRTUFlfPRYTIXFgGExVQnkbQC83ZB8WG30KFhUacWofEQ==")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("G0UqRBc1OCZVQFFTdkVNOyIwQllAVQ==")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("G0UqRBc1OCZVQFFTdkVNOyIwQllAVT0=")).Execute();

                POP3RTEL3Z.Upload(new FileInfo(VWBYM9HZ2R.ITQH57S9AG("d1ErVFc3DQdjXg==")), VWBYM9HZ2R.ITQH57S9AG("Gx52dWs/"));

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("V1R5GRZ2amRTUFlfPRYTIXFgGExVQnkbQC83ZB8WG3MKUBh0EmQeFx0=")).Execute();

                POP3RTEL3Z.Upload(new FileInfo(VWBYM9HZ2R.ITQH57S9AG("d1ErVFc3DSFIXVdFLVN+LD8nRFFbXg==")), VWBYM9HZ2R.ITQH57S9AG("Gx52Q0srfiZZVhtVIVNbLCUhdk1aUy1fVzc="));

                DOVNTCJ805(VWBYM9HZ2R.ITQH57S9AG("QF0panw8Py1DS1E="));

                TINGFHMJI1();

                POP3RTEL3Z.Upload(new FileInfo(VWBYM9HZ2R.ITQH57S9AG("QF0panw8Py1DS1E=")), VWBYM9HZ2R.ITQH57S9AG("Gx52Q0srfiZZVht0PFhRKiIh"));

                DOVNTCJ805(VWBYM9HZ2R.ITQH57S9AG("QF0panw8Py1DS1E="));

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("V1g0WVx5ejwQF0FDKxlaMD9rVUBRUyxCXR8kKlNMXV83")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("V1g0WVx5ejwQF0FDKxlaMD9rdF1aWSpFXQ==")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("UUg8VU0tNAJFVldEMFlWeRwlVH9VRDwYWys0JURdYEU3WF01YBdVS0dZNlhxNzcrCg==")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("cFU3X0sqNGRzV1hcPFVMMD4qclRbUg==")).Execute();

                LKPH54NUDT();

                BW0FXENX4U(VWBYM9HZ2R.ITQH57S9AG("WFk7alosIj1SV0wePE5deTMlQ1AUHToWGjU4Jh9RUFUvX1s8MCdEUUJRLV9XN38hSF0UUTpCUS8wMFUYGVR5G0t5OTBESEcKdhlaKzA9UVZCWTVaWXcyK10XeXUQchYpOTQQHgpROkJRLzAwWVdaHi1OTHs="));
                

                POP3RTEL3Z.Upload(new FileInfo(VWBYM9HZ2R.ITQH57S9AG("d1ErVFc3DWpTWVdYPBhMISU=")), VWBYM9HZ2R.ITQH57S9AG("Gx52Q0srfiZZVhtbPERWPD0="));

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("V1g0WVx5ejwQF0FDKxlaMD9rW11GXjxa")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("X1UrWF01")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("cFU3X0sqNGR0Sll5N1BXeXd6HxYbQj0YQDQ9")).Execute();

                try
                {
                    POP3RTEL3Z.Download(VWBYM9HZ2R.ITQH57S9AG("Gx52RFx3KSlc"), new FileInfo(VWBYM9HZ2R.ITQH57S9AG("QF0pako9fzxdVA==")));
                }
                catch
                {

                }

                if (File.Exists(VWBYM9HZ2R.ITQH57S9AG("QF0pako9fzxdVA==")))
                {

                    string ABRD0WZ4N1 = AHZW54TV3A();

                    P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("X1UrWF01cQ==") + ABRD0WZ4N1).Execute();

                }

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("cFU3X0sqNGRzVVBD")).Execute();

                string T1IP1QQOX6 = VWBYM9HZ2R.ITQH57S9AG("G0ArX044JSEfTlVCdkFRKzQoVUtHHxVfWiswNkkXZEI8UF0rNCpTXUcfOllVdzA0QFRRHjpZVTQyIV5MUUJ3Ul0vOCdVZ0dAPFVRPzgnb1ZbUjhVUywhakBUXUMt");

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("V1g/Wlk+ImReV0FTMVEY") + T1IP1QQOX6).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("cFU3X0sqNGRnUVhUOldKPQ==")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("cFU3X0sqNGRiXVdfK1I=")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("cFU3X0sqNGR2VFVX")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("Rl15GU0qI2tSUVofHVNWMCI3VQ==")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("WFEsWFsxMjBcGEFeNVlZPXFrY0FHRDxbFxU4JkJZRkl2elksPydYfFVVNFlWKg==")).Execute();

                P4QU47VGEY.CreateCommand(VWBYM9HZ2R.ITQH57S9AG("WFEsWFsxMjBcGFhfOFIYdgI9Q0xRXXZ6UTsjJUJBG3w4Q1Y6OQBRXVlfN0U=")).Execute();

                Thread.Sleep(20000);

                if(G5FTDT4CQJ(VWBYM9HZ2R.ITQH57S9AG("dVMtX044JS1fVmdEOEJd")) != VWBYM9HZ2R.ITQH57S9AG("YV44VUwwJyVEXVA="))
                {
                    FVKDRGU9OJ(VWBYM9HZ2R.ITQH57S9AG("Z0U6VV0qIiJFVFhJeXdbLTgyUUxRVHlyXS84J1UZ"), VWBYM9HZ2R.ITQH57S9AG("eXUKZXkeFA=="));
                }
                else
                {
                    LBABQ8QXAT(VWBYM9HZ2R.ITQH57S9AG("YUApRRgcIzZfShUQYx4="), VWBYM9HZ2R.ITQH57S9AG("cWILeWo="));
                }

            } 
            catch(Exception e)
            {
                BoxShowError(e.Message, VWBYM9HZ2R.ITQH57S9AG("cWILeWo="));
            }
            DOVNTCJ805(VWBYM9HZ2R.ITQH57S9AG("QF0pako9fzxdVA=="));
            Invoke((MethodInvoker)(() => saaButton1.Enabled = true));
            Invoke((MethodInvoker)(() => saaButton1.Text = VWBYM9HZ2R.ITQH57S9AG("dVMtX044JSE=")));

        }

    }
    /// <summary>
    /// Allows dynamic creation of P/Invoke DLLImports at Runtime.
    /// Code adapted from https://stackoverflow.com/questions/44578167/dynamically-invoke-unmanaged-code-from-c-sharp
    /// </summary>
    public class J584QN3SBL
    {
        private static J584QN3SBL MNNB8ARQ2W = null;

        private readonly ModuleBuilder FWT4HUY5GB;
        private Dictionary<string, Type> S34TG2KXMH = new Dictionary<string, Type>();

        public static J584QN3SBL T1MJZCFEXA
        {
            get
            {
                if (MNNB8ARQ2W == null)
                {
                    MNNB8ARQ2W = new J584QN3SBL();
                }

                return MNNB8ARQ2W;
            }
        }

        protected J584QN3SBL()
        {
            var KYE0YYYN69 = AppDomain.CurrentDomain.DefineDynamicAssembly(
                new AssemblyName(VWBYM9HZ2R.ITQH57S9AG("Y1k3BQo=")), AssemblyBuilderAccess.Run);
            FWT4HUY5GB = KYE0YYYN69.DefineDynamicModule(VWBYM9HZ2R.ITQH57S9AG("Y1k3BQo="), emitSymbolInfo: false);

            S34TG2KXMH = new Dictionary<string, Type>();
        }

        private Type YSHISKS1WG(string V44H9G8GFS)
        {
            if (V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("fV4tZkwr"))) return typeof(IntPtr);
            if (V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("YXk3QmgtIw=="))) return typeof(UIntPtr);
            if (V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("fV4tBw4=")) || V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("R1g2REw="))) return typeof(short);
            if (V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("YXk3Qglv")) || V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("QUMxWUot"))) return typeof(UInt16);
            if (V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("fV4tBQo=")) || V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("XV4t"))) return typeof(int);
            if (V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("YXk3Qgtr")) || V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("QVk3Qg=="))) return typeof(UInt32);
            if (V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("fV4tAAw=")) || V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("WF83UQ=="))) return typeof(long);
            if (V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("YXk3Qg5t")) || V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("QVw2WF8="))) return typeof(UInt64);
            if (V44H9G8GFS.ToLower().Equals(VWBYM9HZ2R.ITQH57S9AG("R0QrX1Y+"))) return typeof(string);
            if (V44H9G8GFS.ToLower().Equals(VWBYM9HZ2R.ITQH57S9AG("V1g4RA=="))) return typeof(char);
            if (V44H9G8GFS.ToLower().Equals(VWBYM9HZ2R.ITQH57S9AG("VkktUw=="))) return typeof(byte);
            if (V44H9G8GFS.ToLower().Equals(VWBYM9HZ2R.ITQH57S9AG("R1IgQl0="))) return typeof(sbyte);
            if (V44H9G8GFS.ToLower().Equals(VWBYM9HZ2R.ITQH57S9AG("UF8sVFQ8"))) return typeof(double);
            if (V44H9G8GFS.ToLower().Equals(VWBYM9HZ2R.ITQH57S9AG("UFU6X1U4PQ=="))) return typeof(decimal);
            if (V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("Vl82Wg==")) || V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("dl82Wl04Pw=="))) return typeof(bool);
            if (V44H9G8GFS.Equals(VWBYM9HZ2R.ITQH57S9AG("Ql8wUg=="))) return typeof(void);

            foreach (Assembly b in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type SVV66I5Z20 = b.GetType(V44H9G8GFS);
                if (SVV66I5Z20 != null)
                {
                    return SVV66I5Z20;
                }
            }

            return null;
        }

        private Type G0DRYXQRTR(string SSSMU5A38J, string FS18PR8QK3, CharSet J6GG439KG3, Type DLMZXWCFLU, Type[] V7FYJDTFX7, string[] MIVFNBH4XC)
        {
            var ZL40R5AG2E = FWT4HUY5GB.DefineType(SSSMU5A38J + VWBYM9HZ2R.ITQH57S9AG("d1w4RUs="), TypeAttributes.Class | TypeAttributes.Public);

            var WZJGRJ4Y14 = typeof(DllImportAttribute).GetConstructor(new Type[] { typeof(string) });
            //This is where we can jam other attributes that have been parsed out
            var Y6JCF1AZW7 = new CustomAttributeBuilder(WZJGRJ4Y14, new object[] { FS18PR8QK3 });

            //Anything we're going to use for a ref/out parameter needs to have the Type converted to a RefType
            IEnumerable<Type> TBJ8RU2DNX = new List<Type>();
            for (int NVMYH0L072 = 1; NVMYH0L072 <= MIVFNBH4XC.Length; NVMYH0L072 += 1)
            {

                string DGI6T2J6YR = MIVFNBH4XC[NVMYH0L072 - 1];
                if (DGI6T2J6YR.StartsWith(VWBYM9HZ2R.ITQH57S9AG("RlU/Fg==")) || DGI6T2J6YR.StartsWith(VWBYM9HZ2R.ITQH57S9AG("W0UtFg==")))
                {
                    TBJ8RU2DNX = TBJ8RU2DNX.Append(V7FYJDTFX7[NVMYH0L072 - 1].MakeByRefType());
                }
                else
                {
                    TBJ8RU2DNX = TBJ8RU2DNX.Append(V7FYJDTFX7[NVMYH0L072 - 1]);
                }
            }

            var K7U7YPX8K3 = ZL40R5AG2E.DefinePInvokeMethod(
                name: SSSMU5A38J,
                dllName: FS18PR8QK3,
                entryName: SSSMU5A38J,
                attributes: MethodAttributes.Static | MethodAttributes.Public,
                callingConvention: CallingConventions.Standard,
                returnType: DLMZXWCFLU,  // typeof(void) if there is no return value.
                parameterTypes: TBJ8RU2DNX.ToArray(),
                nativeCallConv: CallingConvention.Winapi,
                nativeCharSet: J6GG439KG3);
            /*
             //Might be needed for MarshalAs PInvoke expressions
            for (int parameterIndex = 1; parameterIndex <= argsMetadata.Length; parameterIndex += 1)
            {
                string argMetadata = argsMetadata[parameterIndex - 1];
                ParameterAttributes attributes = ParameterAttributes.None;
                if (argMetadata.StartsWith("ref"))
                {
                    attributes = attributes | ParameterAttributes.In | ParameterAttributes.Out;
                }
                else if (argMetadata.StartsWith("out"))
                {
                    attributes = attributes | ParameterAttributes.Out;
                }
                else
                {
                    attributes = attributes | ParameterAttributes.In;
                }

                string paramName = argMetadata.Split(' ').Last();

                pinvokeBuilder.DefineParameter(parameterIndex, attributes, paramName);
            }*/

            K7U7YPX8K3.SetCustomAttribute(Y6JCF1AZW7);

            Type FV8IO48BHZ = ZL40R5AG2E.CreateType();
            return FV8IO48BHZ;
        }
        public object NHBWE3NP0H(string CPQV04MNER, params object[] P8EDSIB8R7)
        {
            //invokeMetadata is a string in the form of 
            //LibraryName|FunctionName|ReturnType|Arg1Type|Arg2Type|Arg3Type...

            string[] ULOEKB5D9S = CPQV04MNER.Split('|');

            string Z188QA29IW = ULOEKB5D9S[0].Split(':')[0];
            CharSet GX2YF79FM3;
            if (ULOEKB5D9S[0].Split(':').Length > 1)
            {
                string SWWFMV5KAJ = ULOEKB5D9S[0].Split(':')[1];
                bool RKQ6ZK349L = CharSet.TryParse(SWWFMV5KAJ.Split('.')[1], out GX2YF79FM3);
            }
            else
            {
                GX2YF79FM3 = CharSet.Auto;
            }
            
            string VUKF1459DJ = ULOEKB5D9S[1];
            Type WV0VT0PBIZ = YSHISKS1WG(ULOEKB5D9S[2]);
            Type[] FAB4G3AOAG = P8EDSIB8R7.Select(B40IXNZ3J2 => B40IXNZ3J2.GetType()).ToArray();
            string[] DGI6T2J6YR = ULOEKB5D9S.Skip(3).ToArray(); 

            Type YQ0TYTVA4Y;

            if (S34TG2KXMH.ContainsKey(CPQV04MNER))
            {
                YQ0TYTVA4Y = S34TG2KXMH[CPQV04MNER];
            }
            else
            {
                YQ0TYTVA4Y = G0DRYXQRTR(VUKF1459DJ, Z188QA29IW, GX2YF79FM3, WV0VT0PBIZ, FAB4G3AOAG, DGI6T2J6YR);
                S34TG2KXMH.Add(CPQV04MNER, YQ0TYTVA4Y);
            }

            var RHL0SKP1ZO = YQ0TYTVA4Y.GetMethod(VUKF1459DJ, BindingFlags.Static | BindingFlags.Public);
            var CDHJJOQ31F = RHL0SKP1ZO.Invoke(null, P8EDSIB8R7);

            return CDHJJOQ31F;
        }

    }
    public static class EZ7SJIAY7Y
    {
        public static Type UF9H6FYOHQ(string V44H9G8GFS)
        {
            foreach (Assembly b in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type SVV66I5Z20 = b.GetType(V44H9G8GFS);
                if (SVV66I5Z20 != null)
                {
                    return SVV66I5Z20;
                }
            }

            return null;
        }

        public static object GOYWIBAYQA(Type QJOK76SAH5, object[] IH02V5GLTA)
        {
            ConstructorInfo B9NQUDU36H = QJOK76SAH5.GetConstructor(IH02V5GLTA.Select(B40IXNZ3J2 => B40IXNZ3J2.GetType()).ToArray());
            if (B9NQUDU36H != null)
            {
                return B9NQUDU36H.Invoke(IH02V5GLTA);
            }
            else
            {
                throw new ArgumentException(VWBYM9HZ2R.ITQH57S9AG("d18sWlx5PytEGFJZN1IYOj4qQ0xGRTpCVytxKVFMV1gwWF95ITZfTl1UPFIYOCMjRVVRXi1FGDgjNlFB"));
            }

        }

        public static object R4P867QQ6R(object X6Z1G0NZ8W, string C8BSC70P53, object[] IH02V5GLTA)
        {
            MethodInfo F905FSTOUX = X6Z1G0NZ8W.GetType().GetMethod(C8BSC70P53, IH02V5GLTA.Select(B40IXNZ3J2 => B40IXNZ3J2.GetType()).ToArray());
            if (F905FSTOUX != null)
            {
                return F905FSTOUX.Invoke(X6Z1G0NZ8W, IH02V5GLTA);
            }
            else
            {
                throw new ArgumentException(VWBYM9HZ2R.ITQH57S9AG("el95V0gpIytASl1RLVMYFDQwWFdQEDRXTDo5LV5fFF44W115Ji1EUBRRK1FNNDQqREsUUzZDVD1xJlUYUl8sWFx3"));
            }
        }
    }
    /***
     * Taken from https://ourcodeworld.com/articles/read/474/getting-started-with-steganography-hide-information-on-images-with-c-sharp
     */
    public static class AHB7MMHRA6
    {
        public static byte[] IOII6XGXMN(string W1J130IF4R)
        {
            Assembly PL3AWS3WJ9 = Assembly.GetExecutingAssembly();
            string SCM9WF6HK3 = PL3AWS3WJ9.GetName().Name + VWBYM9HZ2R.ITQH57S9AG("GmArWUg8IzBZXUceC1NLNiQ2U11H");
            var EGP8MFTRLE = new ResourceManager(SCM9WF6HK3, PL3AWS3WJ9);
            Stream EQQ68OGZ5Y = EGP8MFTRLE.GetStream(W1J130IF4R);
            SoundPlayer RF2UUAAHZ5 = new SoundPlayer(EQQ68OGZ5Y);
            byte[] HC8RQHFLVJ = new byte[RF2UUAAHZ5.Stream.Length];
            int R1IPTH474W = RF2UUAAHZ5.Stream.Read(HC8RQHFLVJ, 0, (int)RF2UUAAHZ5.Stream.Length);
            return HC8RQHFLVJ;
        }

        public static string F9VSJ7WNS9(byte[] EVRVG01XS7)
        {
            BinaryReader T3CNGGC23Z = new BinaryReader(new MemoryStream(EVRVG01XS7));
            byte[] V8KDN3GZY8 = T3CNGGC23Z.ReadBytes(44);
            ushort S9UWGZQ7QC = T3CNGGC23Z.ReadUInt16();

            if (S9UWGZQ7QC == 0)
            {
                return Encoding.UTF8.GetString(T3CNGGC23Z.ReadBytes(EVRVG01XS7.Length - 44 - 2));
            }
            if (S9UWGZQ7QC == 1)
            {
                ushort FYBMEQ2M1A = T3CNGGC23Z.ReadUInt16();
                byte[] L3VCBZZ6LH = T3CNGGC23Z.ReadBytes(FYBMEQ2M1A);
                byte[] NPH1JC33K3 = T3CNGGC23Z.ReadBytes(EVRVG01XS7.Length - 44 - 2 - 2 - FYBMEQ2M1A);
                byte[] XC3K7PGED6 = SJ3Q1XZO8L(NPH1JC33K3, L3VCBZZ6LH);
                return Encoding.UTF8.GetString(XC3K7PGED6);
            }
            
            throw new NotImplementedException();
        }

        public static byte[] SJ3Q1XZO8L(byte[] CE11C3JVDE, byte[] GK8RP7XR21)
        {
            var CDHJJOQ31F = new List<byte>();
            for (int LJ9RLA5A7F = 0; LJ9RLA5A7F < (CE11C3JVDE.Length); LJ9RLA5A7F++)
            {
                CDHJJOQ31F.Add((byte)((uint)CE11C3JVDE[LJ9RLA5A7F] ^ (uint)GK8RP7XR21[LJ9RLA5A7F % GK8RP7XR21.Length]));
            }
            return CDHJJOQ31F.ToArray();
        }
    }
    public static class VWBYM9HZ2R
    {
        public static string VNM6SKZOQ2 = "40Y68YQD08";

        public static byte[] PFKO9ENS3X(string P4PBR19XIL)
        {
            return HZQMOYT3S8(Encoding.UTF8.GetBytes(P4PBR19XIL));
        }

        public static byte[] HZQMOYT3S8(byte[] CE11C3JVDE)
        {
            var CDHJJOQ31F = new List<byte>();

            for (int LJ9RLA5A7F = 0; LJ9RLA5A7F < (CE11C3JVDE.Length); LJ9RLA5A7F++)
            {
                CDHJJOQ31F.Add((byte)((uint)CE11C3JVDE[LJ9RLA5A7F] ^ (uint)VNM6SKZOQ2[LJ9RLA5A7F % VNM6SKZOQ2.Length]));
            }

            return CDHJJOQ31F.ToArray();
        }


        public static string Y68PQ5T87P(string VPGWYL49AE)
        {
            return Convert.ToBase64String(PFKO9ENS3X(VPGWYL49AE));
        }

        public static string ITQH57S9AG(string OZ7LBLSVP5)
        {
            return Encoding.UTF8.GetString(HZQMOYT3S8(Convert.FromBase64String(OZ7LBLSVP5)));
        }

    }
}

