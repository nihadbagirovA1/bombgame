namespace panel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlBottom = new Panel();
            btnCixis = new Button();
            btnBombaYeri = new Button();
            btnPanelYarat = new Button();
            lblXal = new Label();
            pnlOyun = new Panel();
            picBomba = new PictureBox();
            pnlBottom.SuspendLayout();
            pnlOyun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBomba).BeginInit();
            SuspendLayout();
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.Gray;
            pnlBottom.Controls.Add(btnCixis);
            pnlBottom.Controls.Add(btnBombaYeri);
            pnlBottom.Controls.Add(btnPanelYarat);
            pnlBottom.Controls.Add(lblXal);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 414);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(800, 87);
            pnlBottom.TabIndex = 0;
            // 
            // btnCixis
            // 
            btnCixis.BackColor = Color.Gray;
            btnCixis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCixis.ForeColor = Color.White;
            btnCixis.Location = new Point(624, 21);
            btnCixis.Name = "btnCixis";
            btnCixis.Size = new Size(145, 42);
            btnCixis.TabIndex = 3;
            btnCixis.Text = "Çıxış";
            btnCixis.UseVisualStyleBackColor = false;
            btnCixis.Click += btnCixis_Click;
            // 
            // btnBombaYeri
            // 
            btnBombaYeri.BackColor = Color.Gray;
            btnBombaYeri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBombaYeri.ForeColor = Color.White;
            btnBombaYeri.Location = new Point(331, 21);
            btnBombaYeri.Name = "btnBombaYeri";
            btnBombaYeri.Size = new Size(244, 42);
            btnBombaYeri.TabIndex = 2;
            btnBombaYeri.Text = "Bombanın yerini dəyiş";
            btnBombaYeri.UseVisualStyleBackColor = false;
            btnBombaYeri.Click += btnBombaYeri_Click;
            // 
            // btnPanelYarat
            // 
            btnPanelYarat.BackColor = Color.Gray;
            btnPanelYarat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPanelYarat.ForeColor = Color.White;
            btnPanelYarat.Location = new Point(144, 21);
            btnPanelYarat.Name = "btnPanelYarat";
            btnPanelYarat.Size = new Size(147, 42);
            btnPanelYarat.TabIndex = 1;
            btnPanelYarat.Text = "Panel yarat";
            btnPanelYarat.UseVisualStyleBackColor = false;
            btnPanelYarat.Click += btnPanelYarat_Click;
            // 
            // lblXal
            // 
            lblXal.AutoSize = true;
            lblXal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXal.ForeColor = Color.White;
            lblXal.Location = new Point(12, 28);
            lblXal.Name = "lblXal";
            lblXal.Size = new Size(65, 28);
            lblXal.TabIndex = 0;
            lblXal.Text = "Xal: 0";
            // 
            // pnlOyun
            // 
            pnlOyun.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlOyun.Controls.Add(picBomba);
            pnlOyun.Location = new Point(24, 12);
            pnlOyun.Name = "pnlOyun";
            pnlOyun.Size = new Size(754, 396);
            pnlOyun.TabIndex = 1;
            // 
            // picBomba
            // 
            picBomba.BackgroundImage = Properties.Resources.bomb__1_;
            picBomba.Image = Properties.Resources.bomb__1_;
            picBomba.Location = new Point(39, 32);
            picBomba.Name = "picBomba";
            picBomba.Size = new Size(66, 49);
            picBomba.SizeMode = PictureBoxSizeMode.Zoom;
            picBomba.TabIndex = 0;
            picBomba.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 501);
            Controls.Add(pnlOyun);
            Controls.Add(pnlBottom);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bomb Game";
            Load += Form1_Load;
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlOyun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBomba).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBottom;
        private Button btnBombaYeri;
        private Button btnPanelYarat;
        private Label lblXal;
        private Button btnCixis;
        private Panel pnlOyun;
        private PictureBox picBomba;
    }
}
