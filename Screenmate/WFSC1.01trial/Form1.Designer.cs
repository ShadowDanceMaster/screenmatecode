namespace WFSC101trial
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moveImList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.idleImList = new System.Windows.Forms.ImageList(this.components);
            this.climbImList = new System.Windows.Forms.ImageList(this.components);
            this.smImageCont = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.smImageCont)).BeginInit();
            this.SuspendLayout();
            // 
            // moveImList
            // 
            this.moveImList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moveImList.ImageStream")));
            this.moveImList.TransparentColor = System.Drawing.Color.Transparent;
            this.moveImList.Images.SetKeyName(0, "1.png");
            this.moveImList.Images.SetKeyName(1, "2.png");
            this.moveImList.Images.SetKeyName(2, "3.png");
            this.moveImList.Images.SetKeyName(3, "4.png");
            this.moveImList.Images.SetKeyName(4, "5.png");
            this.moveImList.Images.SetKeyName(5, "6.png");
            this.moveImList.Images.SetKeyName(6, "7.png");
            this.moveImList.Images.SetKeyName(7, "8.png");
            this.moveImList.Images.SetKeyName(8, "9.png");
            this.moveImList.Images.SetKeyName(9, "10.png");
            this.moveImList.Images.SetKeyName(10, "11.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // idleImList
            // 
            this.idleImList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("idleImList.ImageStream")));
            this.idleImList.TransparentColor = System.Drawing.Color.Transparent;
            this.idleImList.Images.SetKeyName(0, "1.png");
            this.idleImList.Images.SetKeyName(1, "2.png");
            this.idleImList.Images.SetKeyName(2, "3.png");
            this.idleImList.Images.SetKeyName(3, "4.png");
            this.idleImList.Images.SetKeyName(4, "5.png");
            this.idleImList.Images.SetKeyName(5, "6.png");
            this.idleImList.Images.SetKeyName(6, "7.png");
            this.idleImList.Images.SetKeyName(7, "8.png");
            this.idleImList.Images.SetKeyName(8, "9.png");
            this.idleImList.Images.SetKeyName(9, "10.png");
            this.idleImList.Images.SetKeyName(10, "11.png");
            // 
            // climbImList
            // 
            this.climbImList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("climbImList.ImageStream")));
            this.climbImList.TransparentColor = System.Drawing.Color.Transparent;
            this.climbImList.Images.SetKeyName(0, "1.png");
            this.climbImList.Images.SetKeyName(1, "2.png");
            this.climbImList.Images.SetKeyName(2, "3.png");
            // 
            // smImageCont
            // 
            this.smImageCont.BackColor = System.Drawing.Color.Transparent;
            this.smImageCont.ErrorImage = ((System.Drawing.Image)(resources.GetObject("smImageCont.ErrorImage")));
            this.smImageCont.InitialImage = ((System.Drawing.Image)(resources.GetObject("smImageCont.InitialImage")));
            this.smImageCont.Location = new System.Drawing.Point(-1, -1);
            this.smImageCont.Name = "smImageCont";
            this.smImageCont.Size = new System.Drawing.Size(64, 72);
            this.smImageCont.TabIndex = 0;
            this.smImageCont.TabStop = false;
            this.smImageCont.Click += new System.EventHandler(this.smImageCont_Click);
            this.smImageCont.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.smImageCont.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.smImageCont.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1268, 901);
            this.Controls.Add(this.smImageCont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.smImageCont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox smImageCont;
        private System.Windows.Forms.ImageList moveImList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ImageList idleImList;
        private System.Windows.Forms.ImageList climbImList;
    }
}

