namespace $safeprojectname$
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button_dA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_tA = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_dB = new System.Windows.Forms.Button();
            this.button_tB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(220, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(406, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Tag = "";
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puan:";
            // 
            // button_dA
            // 
            this.button_dA.BackColor = System.Drawing.Color.YellowGreen;
            this.button_dA.Enabled = false;
            this.button_dA.Location = new System.Drawing.Point(6, 19);
            this.button_dA.Name = "button_dA";
            this.button_dA.Size = new System.Drawing.Size(75, 23);
            this.button_dA.TabIndex = 4;
            this.button_dA.Text = "Doğru";
            this.button_dA.UseVisualStyleBackColor = false;
            this.button_dA.Click += new System.EventHandler(this.button_dA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_tA);
            this.groupBox1.Controls.Add(this.button_dA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(220, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRUP A";
            // 
            // button_tA
            // 
            this.button_tA.BackColor = System.Drawing.Color.Red;
            this.button_tA.Enabled = false;
            this.button_tA.ForeColor = System.Drawing.Color.White;
            this.button_tA.Location = new System.Drawing.Point(119, 19);
            this.button_tA.Name = "button_tA";
            this.button_tA.Size = new System.Drawing.Size(75, 23);
            this.button_tA.TabIndex = 6;
            this.button_tA.Text = "Tabu";
            this.button_tA.UseVisualStyleBackColor = false;
            this.button_tA.Click += new System.EventHandler(this.button_tA_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button_dB);
            this.groupBox2.Controls.Add(this.button_tB);
            this.groupBox2.Location = new System.Drawing.Point(426, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 88);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GRUP B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Puan:";
            // 
            // button_dB
            // 
            this.button_dB.BackColor = System.Drawing.Color.YellowGreen;
            this.button_dB.Enabled = false;
            this.button_dB.Location = new System.Drawing.Point(6, 19);
            this.button_dB.Name = "button_dB";
            this.button_dB.Size = new System.Drawing.Size(75, 23);
            this.button_dB.TabIndex = 8;
            this.button_dB.Text = "Doğru";
            this.button_dB.UseVisualStyleBackColor = false;
            this.button_dB.Click += new System.EventHandler(this.button_dB_Click);
            // 
            // button_tB
            // 
            this.button_tB.BackColor = System.Drawing.Color.Red;
            this.button_tB.Enabled = false;
            this.button_tB.ForeColor = System.Drawing.Color.White;
            this.button_tB.Location = new System.Drawing.Point(119, 19);
            this.button_tB.Name = "button_tB";
            this.button_tB.Size = new System.Drawing.Size(75, 23);
            this.button_tB.TabIndex = 9;
            this.button_tB.Text = "Tabu";
            this.button_tB.UseVisualStyleBackColor = false;
            this.button_tB.Click += new System.EventHandler(this.button_tB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Emre\\Tabu\\El Yapımı Kelimeler\\Mor\\başla.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kurallar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yazılımcı: Ali Emre KESKİN";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(440, 207);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(121, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "aliemrekskn@gmail.com";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkVisited = true;
            this.linkLabel2.Location = new System.Drawing.Point(440, 194);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(156, 13);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "facebook.com/aliemre.keskin.3";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(406, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "YENİDEN BAŞLA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(598, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "00";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(633, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(649, 263);
            this.MinimumSize = new System.Drawing.Size(649, 263);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_dA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_tA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_dB;
        private System.Windows.Forms.Button button_tB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

