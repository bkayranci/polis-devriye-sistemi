namespace PolisDevriyeSistemiFormApp
{
    partial class KonumAl
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
            this.konumX = new System.Windows.Forms.NumericUpDown();
            this.konumY = new System.Windows.Forms.NumericUpDown();
            this.btnKonumAl = new System.Windows.Forms.Button();
            this.lblKonumX = new System.Windows.Forms.Label();
            this.lblKonumY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.konumX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konumY)).BeginInit();
            this.SuspendLayout();
            // 
            // konumX
            // 
            this.konumX.Location = new System.Drawing.Point(103, 12);
            this.konumX.Name = "konumX";
            this.konumX.Size = new System.Drawing.Size(120, 20);
            this.konumX.TabIndex = 0;
            // 
            // konumY
            // 
            this.konumY.Location = new System.Drawing.Point(103, 38);
            this.konumY.Name = "konumY";
            this.konumY.Size = new System.Drawing.Size(120, 20);
            this.konumY.TabIndex = 1;
            // 
            // btnKonumAl
            // 
            this.btnKonumAl.Location = new System.Drawing.Point(44, 64);
            this.btnKonumAl.Name = "btnKonumAl";
            this.btnKonumAl.Size = new System.Drawing.Size(179, 54);
            this.btnKonumAl.TabIndex = 2;
            this.btnKonumAl.Text = "Konum Al";
            this.btnKonumAl.UseVisualStyleBackColor = true;
            this.btnKonumAl.Click += new System.EventHandler(this.btnKonumAl_Click);
            // 
            // lblKonumX
            // 
            this.lblKonumX.AutoSize = true;
            this.lblKonumX.Location = new System.Drawing.Point(41, 14);
            this.lblKonumX.Name = "lblKonumX";
            this.lblKonumX.Size = new System.Drawing.Size(56, 13);
            this.lblKonumX.TabIndex = 3;
            this.lblKonumX.Text = "Konum [X]";
            // 
            // lblKonumY
            // 
            this.lblKonumY.AutoSize = true;
            this.lblKonumY.Location = new System.Drawing.Point(41, 40);
            this.lblKonumY.Name = "lblKonumY";
            this.lblKonumY.Size = new System.Drawing.Size(56, 13);
            this.lblKonumY.TabIndex = 4;
            this.lblKonumY.Text = "Konum [Y]";
            // 
            // KonumAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 130);
            this.Controls.Add(this.lblKonumY);
            this.Controls.Add(this.lblKonumX);
            this.Controls.Add(this.btnKonumAl);
            this.Controls.Add(this.konumY);
            this.Controls.Add(this.konumX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KonumAl";
            this.Text = "KonumAl";
            ((System.ComponentModel.ISupportInitialize)(this.konumX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konumY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown konumX;
        private System.Windows.Forms.NumericUpDown konumY;
        private System.Windows.Forms.Button btnKonumAl;
        private System.Windows.Forms.Label lblKonumX;
        private System.Windows.Forms.Label lblKonumY;
    }
}