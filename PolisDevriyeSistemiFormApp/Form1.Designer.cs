namespace PolisDevriyeSistemiFormApp
{
    partial class Form1
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
            this.vatandaslarListBox = new System.Windows.Forms.ListBox();
            this.vatandaslarGroup = new System.Windows.Forms.GroupBox();
            this.polislerGroup = new System.Windows.Forms.GroupBox();
            this.polislerListBox = new System.Windows.Forms.ListBox();
            this.vatandasEkleGroup = new System.Windows.Forms.GroupBox();
            this.vatandasKonumY = new System.Windows.Forms.NumericUpDown();
            this.vatandasKonumX = new System.Windows.Forms.NumericUpDown();
            this.btnVatandasEkle = new System.Windows.Forms.Button();
            this.lblVatandasKonumY = new System.Windows.Forms.Label();
            this.lblVatandasKonumX = new System.Windows.Forms.Label();
            this.lblVatandasSoyadi = new System.Windows.Forms.Label();
            this.tboxVatandasSoyadi = new System.Windows.Forms.TextBox();
            this.lblVatandasAdi = new System.Windows.Forms.Label();
            this.tboxVatandasAdi = new System.Windows.Forms.TextBox();
            this.polisEkleGroup = new System.Windows.Forms.GroupBox();
            this.polisKonumY = new System.Windows.Forms.NumericUpDown();
            this.polisKonumX = new System.Windows.Forms.NumericUpDown();
            this.btnPolisEkle = new System.Windows.Forms.Button();
            this.lblPolisKonumY = new System.Windows.Forms.Label();
            this.lblPolisKonumX = new System.Windows.Forms.Label();
            this.lblPolisSoyadi = new System.Windows.Forms.Label();
            this.tboxPolisSoyadi = new System.Windows.Forms.TextBox();
            this.lblPolisAdi = new System.Windows.Forms.Label();
            this.tboxPolisAdi = new System.Windows.Forms.TextBox();
            this.sikayetlerGroup = new System.Windows.Forms.GroupBox();
            this.btnKazaBildir = new System.Windows.Forms.Button();
            this.sikayetKuyruguGroup = new System.Windows.Forms.GroupBox();
            this.sikayetKuyruguListBox = new System.Windows.Forms.ListBox();
            this.hayat = new System.Windows.Forms.Timer(this.components);
            this.raporGroup = new System.Windows.Forms.GroupBox();
            raporListBox = new System.Windows.Forms.ListBox();
            this.btnYaralamaBildir = new System.Windows.Forms.Button();
            this.vatandaslarGroup.SuspendLayout();
            this.polislerGroup.SuspendLayout();
            this.vatandasEkleGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vatandasKonumY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatandasKonumX)).BeginInit();
            this.polisEkleGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polisKonumY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polisKonumX)).BeginInit();
            this.sikayetlerGroup.SuspendLayout();
            this.sikayetKuyruguGroup.SuspendLayout();
            this.raporGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // vatandaslarListBox
            // 
            this.vatandaslarListBox.FormattingEnabled = true;
            this.vatandaslarListBox.Location = new System.Drawing.Point(6, 19);
            this.vatandaslarListBox.Name = "vatandaslarListBox";
            this.vatandaslarListBox.Size = new System.Drawing.Size(197, 186);
            this.vatandaslarListBox.TabIndex = 0;
            this.vatandaslarListBox.SelectedIndexChanged += new System.EventHandler(this.vatandaslarListBox_SelectedIndexChanged);
            // 
            // vatandaslarGroup
            // 
            this.vatandaslarGroup.Controls.Add(this.vatandaslarListBox);
            this.vatandaslarGroup.Location = new System.Drawing.Point(12, 12);
            this.vatandaslarGroup.Name = "vatandaslarGroup";
            this.vatandaslarGroup.Size = new System.Drawing.Size(209, 214);
            this.vatandaslarGroup.TabIndex = 1;
            this.vatandaslarGroup.TabStop = false;
            this.vatandaslarGroup.Text = "Vatandaslar";
            // 
            // polislerGroup
            // 
            this.polislerGroup.Controls.Add(this.polislerListBox);
            this.polislerGroup.Location = new System.Drawing.Point(694, 12);
            this.polislerGroup.Name = "polislerGroup";
            this.polislerGroup.Size = new System.Drawing.Size(220, 214);
            this.polislerGroup.TabIndex = 2;
            this.polislerGroup.TabStop = false;
            this.polislerGroup.Text = "Polisler";
            // 
            // polislerListBox
            // 
            this.polislerListBox.Enabled = false;
            this.polislerListBox.FormattingEnabled = true;
            this.polislerListBox.Location = new System.Drawing.Point(6, 19);
            this.polislerListBox.Name = "polislerListBox";
            this.polislerListBox.Size = new System.Drawing.Size(208, 186);
            this.polislerListBox.TabIndex = 0;
            // 
            // vatandasEkleGroup
            // 
            this.vatandasEkleGroup.Controls.Add(this.vatandasKonumY);
            this.vatandasEkleGroup.Controls.Add(this.vatandasKonumX);
            this.vatandasEkleGroup.Controls.Add(this.btnVatandasEkle);
            this.vatandasEkleGroup.Controls.Add(this.lblVatandasKonumY);
            this.vatandasEkleGroup.Controls.Add(this.lblVatandasKonumX);
            this.vatandasEkleGroup.Controls.Add(this.lblVatandasSoyadi);
            this.vatandasEkleGroup.Controls.Add(this.tboxVatandasSoyadi);
            this.vatandasEkleGroup.Controls.Add(this.lblVatandasAdi);
            this.vatandasEkleGroup.Controls.Add(this.tboxVatandasAdi);
            this.vatandasEkleGroup.Location = new System.Drawing.Point(12, 232);
            this.vatandasEkleGroup.Name = "vatandasEkleGroup";
            this.vatandasEkleGroup.Size = new System.Drawing.Size(209, 207);
            this.vatandasEkleGroup.TabIndex = 3;
            this.vatandasEkleGroup.TabStop = false;
            this.vatandasEkleGroup.Text = "Vatandas Ekle";
            // 
            // vatandasKonumY
            // 
            this.vatandasKonumY.Location = new System.Drawing.Point(103, 98);
            this.vatandasKonumY.Name = "vatandasKonumY";
            this.vatandasKonumY.Size = new System.Drawing.Size(100, 20);
            this.vatandasKonumY.TabIndex = 10;
            // 
            // vatandasKonumX
            // 
            this.vatandasKonumX.Location = new System.Drawing.Point(103, 72);
            this.vatandasKonumX.Name = "vatandasKonumX";
            this.vatandasKonumX.Size = new System.Drawing.Size(100, 20);
            this.vatandasKonumX.TabIndex = 9;
            // 
            // btnVatandasEkle
            // 
            this.btnVatandasEkle.Location = new System.Drawing.Point(6, 178);
            this.btnVatandasEkle.Name = "btnVatandasEkle";
            this.btnVatandasEkle.Size = new System.Drawing.Size(197, 23);
            this.btnVatandasEkle.TabIndex = 8;
            this.btnVatandasEkle.Text = "Vatandas Ekle";
            this.btnVatandasEkle.UseVisualStyleBackColor = true;
            this.btnVatandasEkle.Click += new System.EventHandler(this.btnVatandasEkle_Click);
            // 
            // lblVatandasKonumY
            // 
            this.lblVatandasKonumY.AutoSize = true;
            this.lblVatandasKonumY.Location = new System.Drawing.Point(41, 100);
            this.lblVatandasKonumY.Name = "lblVatandasKonumY";
            this.lblVatandasKonumY.Size = new System.Drawing.Size(56, 13);
            this.lblVatandasKonumY.TabIndex = 7;
            this.lblVatandasKonumY.Text = "Konum [Y]";
            // 
            // lblVatandasKonumX
            // 
            this.lblVatandasKonumX.AutoSize = true;
            this.lblVatandasKonumX.Location = new System.Drawing.Point(41, 74);
            this.lblVatandasKonumX.Name = "lblVatandasKonumX";
            this.lblVatandasKonumX.Size = new System.Drawing.Size(56, 13);
            this.lblVatandasKonumX.TabIndex = 5;
            this.lblVatandasKonumX.Text = "Konum [X]";
            // 
            // lblVatandasSoyadi
            // 
            this.lblVatandasSoyadi.AutoSize = true;
            this.lblVatandasSoyadi.Location = new System.Drawing.Point(10, 48);
            this.lblVatandasSoyadi.Name = "lblVatandasSoyadi";
            this.lblVatandasSoyadi.Size = new System.Drawing.Size(87, 13);
            this.lblVatandasSoyadi.TabIndex = 3;
            this.lblVatandasSoyadi.Text = "Vatandas Soyadi";
            // 
            // tboxVatandasSoyadi
            // 
            this.tboxVatandasSoyadi.Location = new System.Drawing.Point(103, 45);
            this.tboxVatandasSoyadi.Name = "tboxVatandasSoyadi";
            this.tboxVatandasSoyadi.Size = new System.Drawing.Size(100, 20);
            this.tboxVatandasSoyadi.TabIndex = 2;
            // 
            // lblVatandasAdi
            // 
            this.lblVatandasAdi.AutoSize = true;
            this.lblVatandasAdi.Location = new System.Drawing.Point(27, 22);
            this.lblVatandasAdi.Name = "lblVatandasAdi";
            this.lblVatandasAdi.Size = new System.Drawing.Size(70, 13);
            this.lblVatandasAdi.TabIndex = 1;
            this.lblVatandasAdi.Text = "Vatandas Adi";
            // 
            // tboxVatandasAdi
            // 
            this.tboxVatandasAdi.Location = new System.Drawing.Point(103, 19);
            this.tboxVatandasAdi.Name = "tboxVatandasAdi";
            this.tboxVatandasAdi.Size = new System.Drawing.Size(100, 20);
            this.tboxVatandasAdi.TabIndex = 0;
            // 
            // polisEkleGroup
            // 
            this.polisEkleGroup.Controls.Add(this.polisKonumY);
            this.polisEkleGroup.Controls.Add(this.polisKonumX);
            this.polisEkleGroup.Controls.Add(this.btnPolisEkle);
            this.polisEkleGroup.Controls.Add(this.lblPolisKonumY);
            this.polisEkleGroup.Controls.Add(this.lblPolisKonumX);
            this.polisEkleGroup.Controls.Add(this.lblPolisSoyadi);
            this.polisEkleGroup.Controls.Add(this.tboxPolisSoyadi);
            this.polisEkleGroup.Controls.Add(this.lblPolisAdi);
            this.polisEkleGroup.Controls.Add(this.tboxPolisAdi);
            this.polisEkleGroup.Location = new System.Drawing.Point(694, 232);
            this.polisEkleGroup.Name = "polisEkleGroup";
            this.polisEkleGroup.Size = new System.Drawing.Size(220, 207);
            this.polisEkleGroup.TabIndex = 4;
            this.polisEkleGroup.TabStop = false;
            this.polisEkleGroup.Text = "Polis Ekle";
            // 
            // polisKonumY
            // 
            this.polisKonumY.Location = new System.Drawing.Point(120, 97);
            this.polisKonumY.Name = "polisKonumY";
            this.polisKonumY.Size = new System.Drawing.Size(100, 20);
            this.polisKonumY.TabIndex = 18;
            // 
            // polisKonumX
            // 
            this.polisKonumX.Location = new System.Drawing.Point(120, 71);
            this.polisKonumX.Name = "polisKonumX";
            this.polisKonumX.Size = new System.Drawing.Size(100, 20);
            this.polisKonumX.TabIndex = 17;
            // 
            // btnPolisEkle
            // 
            this.btnPolisEkle.Location = new System.Drawing.Point(17, 178);
            this.btnPolisEkle.Name = "btnPolisEkle";
            this.btnPolisEkle.Size = new System.Drawing.Size(197, 23);
            this.btnPolisEkle.TabIndex = 16;
            this.btnPolisEkle.Text = "Polis Ekle";
            this.btnPolisEkle.UseVisualStyleBackColor = true;
            this.btnPolisEkle.Click += new System.EventHandler(this.btnPolisEkle_Click);
            // 
            // lblPolisKonumY
            // 
            this.lblPolisKonumY.AutoSize = true;
            this.lblPolisKonumY.Location = new System.Drawing.Point(58, 100);
            this.lblPolisKonumY.Name = "lblPolisKonumY";
            this.lblPolisKonumY.Size = new System.Drawing.Size(56, 13);
            this.lblPolisKonumY.TabIndex = 15;
            this.lblPolisKonumY.Text = "Konum [Y]";
            // 
            // lblPolisKonumX
            // 
            this.lblPolisKonumX.AutoSize = true;
            this.lblPolisKonumX.Location = new System.Drawing.Point(58, 74);
            this.lblPolisKonumX.Name = "lblPolisKonumX";
            this.lblPolisKonumX.Size = new System.Drawing.Size(56, 13);
            this.lblPolisKonumX.TabIndex = 13;
            this.lblPolisKonumX.Text = "Konum [X]";
            // 
            // lblPolisSoyadi
            // 
            this.lblPolisSoyadi.AutoSize = true;
            this.lblPolisSoyadi.Location = new System.Drawing.Point(50, 48);
            this.lblPolisSoyadi.Name = "lblPolisSoyadi";
            this.lblPolisSoyadi.Size = new System.Drawing.Size(64, 13);
            this.lblPolisSoyadi.TabIndex = 11;
            this.lblPolisSoyadi.Text = "Polis Soyadi";
            // 
            // tboxPolisSoyadi
            // 
            this.tboxPolisSoyadi.Location = new System.Drawing.Point(120, 45);
            this.tboxPolisSoyadi.Name = "tboxPolisSoyadi";
            this.tboxPolisSoyadi.Size = new System.Drawing.Size(100, 20);
            this.tboxPolisSoyadi.TabIndex = 10;
            // 
            // lblPolisAdi
            // 
            this.lblPolisAdi.AutoSize = true;
            this.lblPolisAdi.Location = new System.Drawing.Point(67, 22);
            this.lblPolisAdi.Name = "lblPolisAdi";
            this.lblPolisAdi.Size = new System.Drawing.Size(47, 13);
            this.lblPolisAdi.TabIndex = 9;
            this.lblPolisAdi.Text = "Polis Adi";
            // 
            // tboxPolisAdi
            // 
            this.tboxPolisAdi.Location = new System.Drawing.Point(120, 19);
            this.tboxPolisAdi.Name = "tboxPolisAdi";
            this.tboxPolisAdi.Size = new System.Drawing.Size(100, 20);
            this.tboxPolisAdi.TabIndex = 8;
            // 
            // sikayetlerGroup
            // 
            this.sikayetlerGroup.Controls.Add(this.btnYaralamaBildir);
            this.sikayetlerGroup.Controls.Add(this.btnKazaBildir);
            this.sikayetlerGroup.Location = new System.Drawing.Point(227, 12);
            this.sikayetlerGroup.Name = "sikayetlerGroup";
            this.sikayetlerGroup.Size = new System.Drawing.Size(200, 80);
            this.sikayetlerGroup.TabIndex = 5;
            this.sikayetlerGroup.TabStop = false;
            this.sikayetlerGroup.Text = "Sikayetler";
            this.sikayetlerGroup.Visible = false;
            // 
            // btnKazaBildir
            // 
            this.btnKazaBildir.Location = new System.Drawing.Point(6, 19);
            this.btnKazaBildir.Name = "btnKazaBildir";
            this.btnKazaBildir.Size = new System.Drawing.Size(188, 23);
            this.btnKazaBildir.TabIndex = 0;
            this.btnKazaBildir.Text = "kaza bildir";
            this.btnKazaBildir.UseVisualStyleBackColor = true;
            this.btnKazaBildir.Click += new System.EventHandler(this.btnKazaBildir_Click);
            // 
            // sikayetKuyruguGroup
            // 
            this.sikayetKuyruguGroup.Controls.Add(this.sikayetKuyruguListBox);
            this.sikayetKuyruguGroup.Location = new System.Drawing.Point(488, 12);
            this.sikayetKuyruguGroup.Name = "sikayetKuyruguGroup";
            this.sikayetKuyruguGroup.Size = new System.Drawing.Size(200, 214);
            this.sikayetKuyruguGroup.TabIndex = 6;
            this.sikayetKuyruguGroup.TabStop = false;
            this.sikayetKuyruguGroup.Text = "Sikayet Kuyrugu";
            // 
            // sikayetKuyruguListBox
            // 
            this.sikayetKuyruguListBox.Enabled = false;
            this.sikayetKuyruguListBox.FormattingEnabled = true;
            this.sikayetKuyruguListBox.Location = new System.Drawing.Point(6, 19);
            this.sikayetKuyruguListBox.Name = "sikayetKuyruguListBox";
            this.sikayetKuyruguListBox.Size = new System.Drawing.Size(188, 186);
            this.sikayetKuyruguListBox.TabIndex = 0;
            // 
            // hayat
            // 
            this.hayat.Interval = 1000;
            this.hayat.Tick += new System.EventHandler(this.hayat_Tick);
            // 
            // raporGroup
            // 
            this.raporGroup.Controls.Add(raporListBox);
            this.raporGroup.Location = new System.Drawing.Point(227, 232);
            this.raporGroup.Name = "raporGroup";
            this.raporGroup.Size = new System.Drawing.Size(461, 207);
            this.raporGroup.TabIndex = 7;
            this.raporGroup.TabStop = false;
            this.raporGroup.Text = "Rapor";
            // 
            // raporListBox
            // 
            raporListBox.FormattingEnabled = true;
            raporListBox.Location = new System.Drawing.Point(6, 19);
            raporListBox.Name = "raporListBox";
            raporListBox.Size = new System.Drawing.Size(449, 173);
            raporListBox.TabIndex = 0;
            // 
            // btnYaralamaBildir
            // 
            this.btnYaralamaBildir.Location = new System.Drawing.Point(6, 51);
            this.btnYaralamaBildir.Name = "btnYaralamaBildir";
            this.btnYaralamaBildir.Size = new System.Drawing.Size(188, 23);
            this.btnYaralamaBildir.TabIndex = 1;
            this.btnYaralamaBildir.Text = "yaralama bildir";
            this.btnYaralamaBildir.UseVisualStyleBackColor = true;
            this.btnYaralamaBildir.Click += new System.EventHandler(this.btnYaralamaBildir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 451);
            this.Controls.Add(this.raporGroup);
            this.Controls.Add(this.sikayetKuyruguGroup);
            this.Controls.Add(this.sikayetlerGroup);
            this.Controls.Add(this.polisEkleGroup);
            this.Controls.Add(this.vatandasEkleGroup);
            this.Controls.Add(this.polislerGroup);
            this.Controls.Add(this.vatandaslarGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.vatandaslarGroup.ResumeLayout(false);
            this.polislerGroup.ResumeLayout(false);
            this.vatandasEkleGroup.ResumeLayout(false);
            this.vatandasEkleGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vatandasKonumY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatandasKonumX)).EndInit();
            this.polisEkleGroup.ResumeLayout(false);
            this.polisEkleGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polisKonumY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polisKonumX)).EndInit();
            this.sikayetlerGroup.ResumeLayout(false);
            this.sikayetKuyruguGroup.ResumeLayout(false);
            this.raporGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox vatandaslarListBox;
        private System.Windows.Forms.GroupBox vatandaslarGroup;
        private System.Windows.Forms.GroupBox polislerGroup;
        private System.Windows.Forms.ListBox polislerListBox;
        private System.Windows.Forms.GroupBox vatandasEkleGroup;
        private System.Windows.Forms.Button btnVatandasEkle;
        private System.Windows.Forms.Label lblVatandasKonumY;
        private System.Windows.Forms.Label lblVatandasKonumX;
        private System.Windows.Forms.Label lblVatandasSoyadi;
        private System.Windows.Forms.TextBox tboxVatandasSoyadi;
        private System.Windows.Forms.Label lblVatandasAdi;
        private System.Windows.Forms.TextBox tboxVatandasAdi;
        private System.Windows.Forms.GroupBox polisEkleGroup;
        private System.Windows.Forms.Button btnPolisEkle;
        private System.Windows.Forms.Label lblPolisKonumY;
        private System.Windows.Forms.Label lblPolisKonumX;
        private System.Windows.Forms.Label lblPolisSoyadi;
        private System.Windows.Forms.TextBox tboxPolisSoyadi;
        private System.Windows.Forms.Label lblPolisAdi;
        private System.Windows.Forms.TextBox tboxPolisAdi;
        private System.Windows.Forms.NumericUpDown vatandasKonumY;
        private System.Windows.Forms.NumericUpDown vatandasKonumX;
        private System.Windows.Forms.NumericUpDown polisKonumY;
        private System.Windows.Forms.NumericUpDown polisKonumX;
        private System.Windows.Forms.GroupBox sikayetlerGroup;
        private System.Windows.Forms.Button btnKazaBildir;
        private System.Windows.Forms.GroupBox sikayetKuyruguGroup;
        private System.Windows.Forms.ListBox sikayetKuyruguListBox;
        private System.Windows.Forms.Timer hayat;
        private System.Windows.Forms.GroupBox raporGroup;
        private System.Windows.Forms.Button btnYaralamaBildir;
        private static System.Windows.Forms.ListBox raporListBox;
    }
}

