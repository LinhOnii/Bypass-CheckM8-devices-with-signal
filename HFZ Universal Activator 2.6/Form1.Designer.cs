namespace JaguarTools_2._1
{
    partial class Form1
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.saaLabel8 = new SaaUI.SaaLabel();
            this.saaLabel7 = new SaaUI.SaaLabel();
            this.saaLabel6 = new SaaUI.SaaLabel();
            this.saaLabel5 = new SaaUI.SaaLabel();
            this.saaLabel4 = new SaaUI.SaaLabel();
            this.saaLabel3 = new SaaUI.SaaLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.carga = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.EnterModeRecovery = new System.ComponentModel.BackgroundWorker();
            this.Conteo = new System.ComponentModel.BackgroundWorker();
            this.saaFormControlBox1 = new SaaUI.SaaFormControlBox();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saaLabel1 = new SaaUI.SaaLabel();
            this.saaButton3 = new SaaUI.SaaButton();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.saaButton4 = new SaaUI.SaaButton();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.ResizeForm = false;
            // 
            // saaLabel8
            // 
            this.saaLabel8.BackColor = System.Drawing.Color.Transparent;
            this.saaLabel8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaLabel8.ForeColor = System.Drawing.Color.White;
            this.saaLabel8.Location = new System.Drawing.Point(119, 204);
            this.saaLabel8.Name = "saaLabel8";
            this.saaLabel8.Size = new System.Drawing.Size(156, 18);
            this.saaLabel8.TabIndex = 13;
            this.saaLabel8.Text = "STATUS:";
            this.saaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saaLabel8.Visible = false;
            // 
            // saaLabel7
            // 
            this.saaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.saaLabel7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaLabel7.ForeColor = System.Drawing.Color.White;
            this.saaLabel7.Location = new System.Drawing.Point(76, 281);
            this.saaLabel7.Name = "saaLabel7";
            this.saaLabel7.Size = new System.Drawing.Size(242, 18);
            this.saaLabel7.TabIndex = 12;
            this.saaLabel7.Text = "[SerialNumber is copied to Pasteboard]";
            this.saaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saaLabel7.Visible = false;
            // 
            // saaLabel6
            // 
            this.saaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.saaLabel6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaLabel6.ForeColor = System.Drawing.Color.White;
            this.saaLabel6.Location = new System.Drawing.Point(213, 171);
            this.saaLabel6.Name = "saaLabel6";
            this.saaLabel6.Size = new System.Drawing.Size(118, 18);
            this.saaLabel6.TabIndex = 7;
            this.saaLabel6.Text = "SN:";
            this.saaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saaLabel6.Visible = false;
            this.saaLabel6.Click += new System.EventHandler(this.saaLabel6_Click);
            // 
            // saaLabel5
            // 
            this.saaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.saaLabel5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaLabel5.ForeColor = System.Drawing.Color.White;
            this.saaLabel5.Location = new System.Drawing.Point(65, 171);
            this.saaLabel5.Name = "saaLabel5";
            this.saaLabel5.Size = new System.Drawing.Size(131, 18);
            this.saaLabel5.TabIndex = 6;
            this.saaLabel5.Text = "IMEI:";
            this.saaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saaLabel5.Visible = false;
            // 
            // saaLabel4
            // 
            this.saaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.saaLabel4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaLabel4.ForeColor = System.Drawing.Color.White;
            this.saaLabel4.Location = new System.Drawing.Point(62, 139);
            this.saaLabel4.Name = "saaLabel4";
            this.saaLabel4.Size = new System.Drawing.Size(271, 18);
            this.saaLabel4.TabIndex = 5;
            this.saaLabel4.Text = "UDID:";
            this.saaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saaLabel4.Visible = false;
            // 
            // saaLabel3
            // 
            this.saaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.saaLabel3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaLabel3.ForeColor = System.Drawing.Color.White;
            this.saaLabel3.Location = new System.Drawing.Point(34, 111);
            this.saaLabel3.Name = "saaLabel3";
            this.saaLabel3.Size = new System.Drawing.Size(326, 18);
            this.saaLabel3.TabIndex = 4;
            this.saaLabel3.Text = "No Device connected";
            this.saaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork_1);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // saaFormControlBox1
            // 
            this.saaFormControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.saaFormControlBox1.CloseActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.CloseActive")));
            this.saaFormControlBox1.CloseInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.CloseInActive")));
            this.saaFormControlBox1.CloseTip = "Close";
            this.saaFormControlBox1.DisableClose = false;
            this.saaFormControlBox1.DisableMaximize = false;
            this.saaFormControlBox1.DisableMinimize = false;
            this.saaFormControlBox1.Location = new System.Drawing.Point(914, 1);
            this.saaFormControlBox1.MaximizeActive = null;
            this.saaFormControlBox1.MaximizeInActive = null;
            this.saaFormControlBox1.MaximizeTip = "Maximize";
            this.saaFormControlBox1.MinimizeActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MinimizeActive")));
            this.saaFormControlBox1.MinimizeInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MinimizeInActive")));
            this.saaFormControlBox1.MinimizeTip = "Minimize";
            this.saaFormControlBox1.Name = "saaFormControlBox1";
            this.saaFormControlBox1.ShowClose = true;
            this.saaFormControlBox1.ShowMaximize = true;
            this.saaFormControlBox1.ShowMinimize = true;
            this.saaFormControlBox1.Size = new System.Drawing.Size(77, 24);
            this.saaFormControlBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::jaguarTools.Properties.Resources.iPhoneX;
            this.pictureBox1.Location = new System.Drawing.Point(370, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // saaLabel1
            // 
            this.saaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.saaLabel1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaLabel1.ForeColor = System.Drawing.Color.White;
            this.saaLabel1.Location = new System.Drawing.Point(342, 9);
            this.saaLabel1.Name = "saaLabel1";
            this.saaLabel1.Size = new System.Drawing.Size(326, 18);
            this.saaLabel1.TabIndex = 23;
            this.saaLabel1.Text = "ZEUS Activator MEID/GSM Full Signal";
            this.saaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saaButton3
            // 
            this.saaButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.saaButton3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.saaButton3.BackColorAngle = 90F;
            this.saaButton3.Border = 1;
            this.saaButton3.BorderColor = System.Drawing.Color.SteelBlue;
            this.saaButton3.BorderColor2 = System.Drawing.Color.LightSkyBlue;
            this.saaButton3.BorderColorAngle = 0;
            this.saaButton3.ClickColor1 = System.Drawing.Color.DeepSkyBlue;
            this.saaButton3.ClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.saaButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saaButton3.EnableDoubleBuffering = true;
            this.saaButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaButton3.ForeColor = System.Drawing.Color.White;
            this.saaButton3.HoverColor1 = System.Drawing.Color.RoyalBlue;
            this.saaButton3.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.saaButton3.Icon = ((System.Drawing.Image)(resources.GetObject("saaButton3.Icon")));
            this.saaButton3.IconOffsetX = 5F;
            this.saaButton3.IconOffsetY = 5F;
            this.saaButton3.IconSize = new System.Drawing.Size(20, 20);
            this.saaButton3.Location = new System.Drawing.Point(368, 424);
            this.saaButton3.Name = "saaButton3";
            this.saaButton3.Radius.BottomLeft = 2;
            this.saaButton3.Radius.BottomRight = 2;
            this.saaButton3.Radius.TopLeft = 2;
            this.saaButton3.Radius.TopRight = 2;
            this.saaButton3.Size = new System.Drawing.Size(244, 37);
            this.saaButton3.TabIndex = 24;
            this.saaButton3.TextOffsetX = 0F;
            this.saaButton3.TextOffsetY = 0F;
            this.saaButton3.Value = "Waiting For Device ...";
            this.saaButton3.Click += new System.EventHandler(this.saaButton3_Click_1);
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            // 
            // saaButton4
            // 
            this.saaButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.saaButton4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.saaButton4.BackColorAngle = 90F;
            this.saaButton4.Border = 1;
            this.saaButton4.BorderColor = System.Drawing.Color.SteelBlue;
            this.saaButton4.BorderColor2 = System.Drawing.Color.LightSkyBlue;
            this.saaButton4.BorderColorAngle = 0;
            this.saaButton4.ClickColor1 = System.Drawing.Color.DeepSkyBlue;
            this.saaButton4.ClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.saaButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saaButton4.EnableDoubleBuffering = true;
            this.saaButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaButton4.ForeColor = System.Drawing.Color.White;
            this.saaButton4.HoverColor1 = System.Drawing.Color.RoyalBlue;
            this.saaButton4.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.saaButton4.Icon = ((System.Drawing.Image)(resources.GetObject("saaButton4.Icon")));
            this.saaButton4.IconOffsetX = 0F;
            this.saaButton4.IconOffsetY = -3F;
            this.saaButton4.IconSize = new System.Drawing.Size(40, 40);
            this.saaButton4.Location = new System.Drawing.Point(68, 343);
            this.saaButton4.Name = "saaButton4";
            this.saaButton4.Radius.BottomLeft = 2;
            this.saaButton4.Radius.BottomRight = 2;
            this.saaButton4.Radius.TopLeft = 2;
            this.saaButton4.Radius.TopRight = 2;
            this.saaButton4.Size = new System.Drawing.Size(244, 37);
            this.saaButton4.TabIndex = 25;
            this.saaButton4.TextOffsetX = 0F;
            this.saaButton4.TextOffsetY = 0F;
            this.saaButton4.Value = "Jailbreak iOS 15 - 17";
            this.saaButton4.Click += new System.EventHandler(this.saaButton4_Click_1);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Location = new System.Drawing.Point(341, 482);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(95)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.SteelBlue;
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(300, 11);
            this.guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.guna2ProgressBar1.TabIndex = 26;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 518);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.saaButton4);
            this.Controls.Add(this.saaButton3);
            this.Controls.Add(this.saaLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saaFormControlBox1);
            this.Controls.Add(this.saaLabel8);
            this.Controls.Add(this.saaLabel7);
            this.Controls.Add(this.saaLabel6);
            this.Controls.Add(this.saaLabel3);
            this.Controls.Add(this.saaLabel5);
            this.Controls.Add(this.saaLabel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZEUS Activator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private SaaUI.SaaFormControlBox saaFormControlBox1;
        private SaaUI.SaaLabel saaLabel3;
        private SaaUI.SaaLabel saaLabel6;
        private SaaUI.SaaLabel saaLabel5;
        private SaaUI.SaaLabel saaLabel4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private SaaUI.SaaLabel saaLabel7;
        private SaaUI.SaaLabel saaLabel8;
        private System.ComponentModel.BackgroundWorker carga;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker EnterModeRecovery;
        private System.ComponentModel.BackgroundWorker Conteo;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SaaUI.SaaLabel saaLabel1;
        private SaaUI.SaaButton saaButton3;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private SaaUI.SaaButton saaButton4;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
    }
}

