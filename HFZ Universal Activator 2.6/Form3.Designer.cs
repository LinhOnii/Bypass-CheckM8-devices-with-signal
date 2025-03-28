using JaguarTools_2._1;

namespace jaguarTools
{
    partial class Form3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            SaaUI.Properties.Radius radius1 = new SaaUI.Properties.Radius();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.saaPanel2 = new SaaUI.SaaPanel();
            this.Downlabelsec = new SaaUI.SaaLabel();
            this.Powerlabelsec = new SaaUI.SaaLabel();
            this.Go = new SaaUI.SaaLabel();
            this.Set = new SaaUI.SaaLabel();
            this.Ready = new SaaUI.SaaLabel();
            this.saaButton1 = new SaaUI.SaaButton();
            this.saaLabel9 = new SaaUI.SaaLabel();
            this.Powerlabel = new SaaUI.SaaLabel();
            this.Downlabel = new SaaUI.SaaLabel();
            this.Homelabel = new SaaUI.SaaLabel();
            this.saaPictureBox3 = new SaaUI.SaaPictureBox();
            this.saaButton3 = new SaaUI.SaaButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.saaFormControlBox1 = new SaaUI.SaaFormControlBox();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saaLabel1 = new SaaUI.SaaLabel();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.saaToolTip1 = new SaaUI.SaaToolTip();
            this.saaLabel2 = new SaaUI.SaaLabel();
            this.saaPictureBox4 = new SaaUI.SaaPictureBox();
            this.saaFormControlBox2 = new SaaUI.SaaFormControlBox();
            this.saaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saaPictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saaPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // saaPanel2
            // 
            this.saaPanel2.BackColor = System.Drawing.Color.White;
            this.saaPanel2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.saaPanel2.BackColorAngle = 90F;
            this.saaPanel2.Border = 0;
            this.saaPanel2.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.saaPanel2.BorderColor2 = System.Drawing.Color.LightSkyBlue;
            this.saaPanel2.BorderColorAngle = 0;
            this.saaPanel2.ColorType = SaaUI.PanelColorType.Default;
            this.saaPanel2.Controls.Add(this.Downlabelsec);
            this.saaPanel2.Controls.Add(this.Powerlabelsec);
            this.saaPanel2.Controls.Add(this.Go);
            this.saaPanel2.Controls.Add(this.Set);
            this.saaPanel2.Controls.Add(this.Ready);
            this.saaPanel2.Controls.Add(this.saaButton1);
            this.saaPanel2.Controls.Add(this.saaLabel9);
            this.saaPanel2.Controls.Add(this.Powerlabel);
            this.saaPanel2.Controls.Add(this.Downlabel);
            this.saaPanel2.Controls.Add(this.Homelabel);
            this.saaPanel2.Controls.Add(this.saaPictureBox3);
            this.saaPanel2.Controls.Add(this.saaButton3);
            this.saaPanel2.EnableDoubleBuffering = true;
            this.saaPanel2.ForceDrawRegion = true;
            this.saaPanel2.Location = new System.Drawing.Point(1, 31);
            this.saaPanel2.Name = "saaPanel2";
            this.saaPanel2.Size = new System.Drawing.Size(483, 321);
            this.saaPanel2.TabIndex = 6;
            this.saaToolTip1.SetToolTip(this.saaPanel2, "");
            this.saaPanel2.Transparence = 100;
            // 
            // Downlabelsec
            // 
            this.Downlabelsec.AutoSize = true;
            this.Downlabelsec.BackColor = System.Drawing.Color.Transparent;
            this.Downlabelsec.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Downlabelsec.Location = new System.Drawing.Point(306, 224);
            this.Downlabelsec.Name = "Downlabelsec";
            this.Downlabelsec.Size = new System.Drawing.Size(21, 16);
            this.Downlabelsec.TabIndex = 12;
            this.Downlabelsec.Text = "(7)";
            this.saaToolTip1.SetToolTip(this.Downlabelsec, "");
            this.Downlabelsec.Visible = false;
            // 
            // Powerlabelsec
            // 
            this.Powerlabelsec.AutoSize = true;
            this.Powerlabelsec.BackColor = System.Drawing.Color.Transparent;
            this.Powerlabelsec.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Powerlabelsec.Location = new System.Drawing.Point(306, 160);
            this.Powerlabelsec.Name = "Powerlabelsec";
            this.Powerlabelsec.Size = new System.Drawing.Size(21, 16);
            this.Powerlabelsec.TabIndex = 11;
            this.Powerlabelsec.Text = "(5)";
            this.saaToolTip1.SetToolTip(this.Powerlabelsec, "");
            this.Powerlabelsec.Visible = false;
            // 
            // Go
            // 
            this.Go.AutoSize = true;
            this.Go.BackColor = System.Drawing.Color.Transparent;
            this.Go.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.Location = new System.Drawing.Point(329, 192);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(136, 48);
            this.Go.TabIndex = 10;
            this.Go.Text = "2. Press and hold the Side\r\nand Volume down buttons\r\ntogether";
            this.saaToolTip1.SetToolTip(this.Go, "");
            this.Go.Visible = false;
            // 
            // Set
            // 
            this.Set.AutoSize = true;
            this.Set.BackColor = System.Drawing.Color.Transparent;
            this.Set.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set.Location = new System.Drawing.Point(329, 128);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(136, 48);
            this.Set.TabIndex = 9;
            this.Set.Text = "2. Press and hold the Side\r\nand Volume down buttons\r\ntogether";
            this.saaToolTip1.SetToolTip(this.Set, "");
            this.Set.Visible = false;
            // 
            // Ready
            // 
            this.Ready.AutoSize = true;
            this.Ready.BackColor = System.Drawing.Color.Transparent;
            this.Ready.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ready.Location = new System.Drawing.Point(329, 92);
            this.Ready.Name = "Ready";
            this.Ready.Size = new System.Drawing.Size(66, 16);
            this.Ready.TabIndex = 8;
            this.Ready.Text = "1. Get ready";
            this.saaToolTip1.SetToolTip(this.Ready, "");
            this.Ready.Visible = false;
            // 
            // saaButton1
            // 
            this.saaButton1.BackColor = System.Drawing.Color.White;
            this.saaButton1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton1.BackColorAngle = 90F;
            this.saaButton1.Border = 1;
            this.saaButton1.BorderColor = System.Drawing.Color.Silver;
            this.saaButton1.BorderColor2 = System.Drawing.Color.Silver;
            this.saaButton1.BorderColorAngle = 0;
            this.saaButton1.ClickColor1 = System.Drawing.Color.SteelBlue;
            this.saaButton1.ClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.saaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saaButton1.EnableDoubleBuffering = true;
            this.saaButton1.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.saaButton1.HoverColor2 = System.Drawing.Color.SteelBlue;
            this.saaButton1.Icon = null;
            this.saaButton1.IconOffsetX = 5F;
            this.saaButton1.IconOffsetY = 5F;
            this.saaButton1.IconSize = new System.Drawing.Size(20, 20);
            this.saaButton1.Location = new System.Drawing.Point(361, 272);
            this.saaButton1.Name = "saaButton1";
            this.saaButton1.Radius.BottomLeft = 2;
            this.saaButton1.Radius.BottomRight = 2;
            this.saaButton1.Radius.TopLeft = 2;
            this.saaButton1.Radius.TopRight = 2;
            this.saaButton1.Size = new System.Drawing.Size(90, 28);
            this.saaButton1.TabIndex = 7;
            this.saaButton1.TextOffsetX = 0F;
            this.saaButton1.TextOffsetY = 0F;
            this.saaToolTip1.SetToolTip(this.saaButton1, "");
            this.saaButton1.Value = "Start";
            this.saaButton1.Click += new System.EventHandler(this.saaButton1_Click);
            // 
            // saaLabel9
            // 
            this.saaLabel9.AutoSize = true;
            this.saaLabel9.BackColor = System.Drawing.Color.Transparent;
            this.saaLabel9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaLabel9.Location = new System.Drawing.Point(24, 18);
            this.saaLabel9.Name = "saaLabel9";
            this.saaLabel9.Size = new System.Drawing.Size(0, 16);
            this.saaLabel9.TabIndex = 6;
            this.saaToolTip1.SetToolTip(this.saaLabel9, "");
            // 
            // Powerlabel
            // 
            this.Powerlabel.AutoSize = true;
            this.Powerlabel.BackColor = System.Drawing.Color.Transparent;
            this.Powerlabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Powerlabel.Location = new System.Drawing.Point(220, 110);
            this.Powerlabel.Name = "Powerlabel";
            this.Powerlabel.Size = new System.Drawing.Size(71, 14);
            this.Powerlabel.TabIndex = 5;
            this.Powerlabel.Text = "- Side Button";
            this.saaToolTip1.SetToolTip(this.Powerlabel, "");
            this.Powerlabel.Visible = false;
            // 
            // Downlabel
            // 
            this.Downlabel.AutoSize = true;
            this.Downlabel.BackColor = System.Drawing.Color.Transparent;
            this.Downlabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Downlabel.Location = new System.Drawing.Point(25, 129);
            this.Downlabel.Name = "Downlabel";
            this.Downlabel.Size = new System.Drawing.Size(80, 14);
            this.Downlabel.TabIndex = 4;
            this.Downlabel.Text = "Volume Down -";
            this.saaToolTip1.SetToolTip(this.Downlabel, "");
            this.Downlabel.Visible = false;
            // 
            // Homelabel
            // 
            this.Homelabel.AutoSize = true;
            this.Homelabel.BackColor = System.Drawing.Color.Transparent;
            this.Homelabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homelabel.Location = new System.Drawing.Point(30, 239);
            this.Homelabel.Name = "Homelabel";
            this.Homelabel.Size = new System.Drawing.Size(78, 14);
            this.Homelabel.TabIndex = 3;
            this.Homelabel.Text = "Home Button -";
            this.saaToolTip1.SetToolTip(this.Homelabel, "");
            this.Homelabel.Visible = false;
            // 
            // saaPictureBox3
            // 
            this.saaPictureBox3.Border = 0;
            this.saaPictureBox3.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.saaPictureBox3.BorderColor2 = System.Drawing.Color.LightSkyBlue;
            this.saaPictureBox3.BorderColorAngle = 0;
            this.saaPictureBox3.Image = global::jaguarTools.Properties.Resources._6s;
            this.saaPictureBox3.Location = new System.Drawing.Point(109, 60);
            this.saaPictureBox3.Name = "saaPictureBox3";
            this.saaPictureBox3.Size = new System.Drawing.Size(110, 214);
            this.saaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saaPictureBox3.TabIndex = 2;
            this.saaPictureBox3.TabStop = false;
            this.saaToolTip1.SetToolTip(this.saaPictureBox3, "");
            this.saaPictureBox3.Visible = false;
            // 
            // saaButton3
            // 
            this.saaButton3.BackColor = System.Drawing.Color.White;
            this.saaButton3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton3.BackColorAngle = 90F;
            this.saaButton3.Border = 1;
            this.saaButton3.BorderColor = System.Drawing.Color.Silver;
            this.saaButton3.BorderColor2 = System.Drawing.Color.Silver;
            this.saaButton3.BorderColorAngle = 0;
            this.saaButton3.ClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton3.ClickColor2 = System.Drawing.Color.DodgerBlue;
            this.saaButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saaButton3.EnableDoubleBuffering = true;
            this.saaButton3.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton3.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton3.Icon = null;
            this.saaButton3.IconOffsetX = 5F;
            this.saaButton3.IconOffsetY = 5F;
            this.saaButton3.IconSize = new System.Drawing.Size(20, 20);
            this.saaButton3.Location = new System.Drawing.Point(361, 272);
            this.saaButton3.Name = "saaButton3";
            this.saaButton3.Radius.BottomLeft = 2;
            this.saaButton3.Radius.BottomRight = 2;
            this.saaButton3.Radius.TopLeft = 2;
            this.saaButton3.Radius.TopRight = 2;
            this.saaButton3.Size = new System.Drawing.Size(90, 28);
            this.saaButton3.TabIndex = 13;
            this.saaButton3.TextOffsetX = 0F;
            this.saaButton3.TextOffsetY = 0F;
            this.saaToolTip1.SetToolTip(this.saaButton3, "");
            this.saaButton3.Value = "Start";
            this.saaButton3.Click += new System.EventHandler(this.saaButton3_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // saaFormControlBox1
            // 
            this.saaFormControlBox1.CloseActive = null;
            this.saaFormControlBox1.CloseInActive = null;
            this.saaFormControlBox1.CloseTip = "Close";
            this.saaFormControlBox1.DisableClose = false;
            this.saaFormControlBox1.DisableMaximize = false;
            this.saaFormControlBox1.DisableMinimize = false;
            this.saaFormControlBox1.Location = new System.Drawing.Point(3, 2);
            this.saaFormControlBox1.MaximizeActive = null;
            this.saaFormControlBox1.MaximizeInActive = null;
            this.saaFormControlBox1.MaximizeTip = "Maximize";
            this.saaFormControlBox1.MinimizeActive = null;
            this.saaFormControlBox1.MinimizeInActive = null;
            this.saaFormControlBox1.MinimizeTip = "Minimize";
            this.saaFormControlBox1.Name = "saaFormControlBox1";
            this.saaFormControlBox1.ShowClose = true;
            this.saaFormControlBox1.ShowMaximize = true;
            this.saaFormControlBox1.ShowMinimize = true;
            this.saaFormControlBox1.Size = new System.Drawing.Size(79, 25);
            this.saaFormControlBox1.TabIndex = 10;
            this.saaToolTip1.SetToolTip(this.saaFormControlBox1, "");
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.saaLabel1);
            this.panel2.Controls.Add(this.guna2CircleProgressBar1);
            this.panel2.Location = new System.Drawing.Point(1, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 321);
            this.panel2.TabIndex = 11;
            this.saaToolTip1.SetToolTip(this.panel2, "");
            this.panel2.Visible = false;
            // 
            // saaLabel1
            // 
            this.saaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.saaLabel1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.saaLabel1.Location = new System.Drawing.Point(80, 33);
            this.saaLabel1.Name = "saaLabel1";
            this.saaLabel1.Size = new System.Drawing.Size(321, 18);
            this.saaLabel1.TabIndex = 10;
            this.saaLabel1.Text = "Checking iDevice";
            this.saaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saaToolTip1.SetToolTip(this.saaLabel1, "");
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.InnerColor = System.Drawing.Color.DodgerBlue;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(151, 87);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CircleProgressBar1.ShadowDecoration.BorderRadius = 10;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.guna2CircleProgressBar1.ShowPercentage = true;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(179, 179);
            this.guna2CircleProgressBar1.TabIndex = 0;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            this.saaToolTip1.SetToolTip(this.guna2CircleProgressBar1, "");
            this.guna2CircleProgressBar1.Value = 50;
            // 
            // saaToolTip1
            // 
            this.saaToolTip1.Active = true;
            this.saaToolTip1.ArrowHeight = 10;
            this.saaToolTip1.ArrowStart = null;
            this.saaToolTip1.ArrowWidth = 20;
            this.saaToolTip1.BackgroundColor = System.Drawing.Color.White;
            this.saaToolTip1.Delay = 500;
            this.saaToolTip1.Duration = 15000;
            this.saaToolTip1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.saaToolTip1.OffsetX = 0;
            this.saaToolTip1.OffsetY = 0;
            this.saaToolTip1.OffSize = new System.Drawing.Size(0, 0);
            this.saaToolTip1.Position = SaaUI.SidePositions.Bottom;
            radius1.BottomLeft = 5;
            radius1.BottomRight = 5;
            radius1.TopLeft = 5;
            radius1.TopRight = 5;
            this.saaToolTip1.Radius = radius1;
            this.saaToolTip1.ShowAlways = false;
            this.saaToolTip1.ShowArrow = true;
            this.saaToolTip1.TextColor = System.Drawing.Color.DimGray;
            this.saaToolTip1.TextOffsetX = 0;
            this.saaToolTip1.TextOffsetY = 0;
            // 
            // saaLabel2
            // 
            this.saaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.saaLabel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saaLabel2.Location = new System.Drawing.Point(148, 7);
            this.saaLabel2.Name = "saaLabel2";
            this.saaLabel2.Size = new System.Drawing.Size(196, 17);
            this.saaLabel2.TabIndex = 13;
            this.saaLabel2.Text = "ZEUS Jailbreak";
            this.saaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saaToolTip1.SetToolTip(this.saaLabel2, "");
            this.saaLabel2.Click += new System.EventHandler(this.saaLabel2_Click);
            // 
            // saaPictureBox4
            // 
            this.saaPictureBox4.Border = 0;
            this.saaPictureBox4.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.saaPictureBox4.BorderColor2 = System.Drawing.Color.LightSkyBlue;
            this.saaPictureBox4.BorderColorAngle = 0;
            this.saaPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("saaPictureBox4.Image")));
            this.saaPictureBox4.Location = new System.Drawing.Point(450, 0);
            this.saaPictureBox4.Name = "saaPictureBox4";
            this.saaPictureBox4.Size = new System.Drawing.Size(33, 27);
            this.saaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saaPictureBox4.TabIndex = 12;
            this.saaPictureBox4.TabStop = false;
            this.saaToolTip1.SetToolTip(this.saaPictureBox4, "");
            // 
            // saaFormControlBox2
            // 
            this.saaFormControlBox2.CloseActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox2.CloseActive")));
            this.saaFormControlBox2.CloseInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox2.CloseInActive")));
            this.saaFormControlBox2.CloseTip = "Close";
            this.saaFormControlBox2.DisableClose = false;
            this.saaFormControlBox2.DisableMaximize = false;
            this.saaFormControlBox2.DisableMinimize = false;
            this.saaFormControlBox2.Location = new System.Drawing.Point(-15, 5);
            this.saaFormControlBox2.MaximizeActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox2.MaximizeActive")));
            this.saaFormControlBox2.MaximizeInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox2.MaximizeInActive")));
            this.saaFormControlBox2.MaximizeTip = "Maximize";
            this.saaFormControlBox2.MinimizeActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox2.MinimizeActive")));
            this.saaFormControlBox2.MinimizeInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox2.MinimizeInActive")));
            this.saaFormControlBox2.MinimizeTip = "Minimize";
            this.saaFormControlBox2.Name = "saaFormControlBox2";
            this.saaFormControlBox2.ShowClose = true;
            this.saaFormControlBox2.ShowMaximize = true;
            this.saaFormControlBox2.ShowMinimize = true;
            this.saaFormControlBox2.Size = new System.Drawing.Size(56, 20);
            this.saaFormControlBox2.TabIndex = 14;
            this.saaToolTip1.SetToolTip(this.saaFormControlBox2, "");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(487, 357);
            this.Controls.Add(this.saaFormControlBox2);
            this.Controls.Add(this.saaLabel2);
            this.Controls.Add(this.saaPictureBox4);
            this.Controls.Add(this.saaFormControlBox1);
            this.Controls.Add(this.saaPanel2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(487, 357);
            this.MinimumSize = new System.Drawing.Size(487, 357);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZEUS Jailbreak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.saaPanel2.ResumeLayout(false);
            this.saaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saaPictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saaPictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private SaaUI.SaaPanel saaPanel2;
        private SaaUI.SaaLabel Homelabel;
        private SaaUI.SaaPictureBox saaPictureBox3;
        private SaaUI.SaaLabel saaLabel9;
        private SaaUI.SaaLabel Powerlabel;
        private SaaUI.SaaLabel Downlabel;
        private SaaUI.SaaButton saaButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SaaUI.SaaLabel Downlabelsec;
        private SaaUI.SaaLabel Powerlabelsec;
        private SaaUI.SaaLabel Go;
        private SaaUI.SaaLabel Set;
        private SaaUI.SaaLabel Ready;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private SaaUI.SaaFormControlBox saaFormControlBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private SaaUI.SaaButton saaButton3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private SaaUI.SaaLabel saaLabel1;
        private SaaUI.SaaToolTip saaToolTip1;
        private SaaUI.SaaLabel saaLabel2;
        private SaaUI.SaaPictureBox saaPictureBox4;
        private SaaUI.SaaFormControlBox saaFormControlBox2;
    }
}

